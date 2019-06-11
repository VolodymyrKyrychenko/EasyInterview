$(function () {
    ace.require("ace/ext/language_tools");
    code = ace.edit("code");                      // создаем редактор из элемента с id="code"
    code.setTheme("ace/theme/textmate");          // выбираем тему оформления для подсветки синтаксиса
    code.getSession().setMode("ace/mode/c_cpp");  // говорим что код надо подсвечивать как C++ код
    code.setShowPrintMargin(false);               // опционально: убираем вертикальную границу в 80 сиволов
    code.setOptions({
        maxLines: Infinity,                       // опционально: масштабировать редактор вертикально по размеру кода
        fontSize: "12pt",                         // опционально: размер шрифта ставим побольше
        enableBasicAutocompletion: true
    });
    code.$blockScrolling = Infinity;              // отключаем устаревшие, не поддерживаемые фишки редактора
    code.selection.selectAll();
    code.removeLines();
    code.insert("#include <iostream>\n\nusing namespace std;\n\nint main() {\n\tcout << \"HELLO WORLD\";\n}");
});

document.addEventListener('DOMContentLoaded', function () {

    edit = true;

    $('#forCode').on('keydown', '#code', function (event) {
        edit = false;
    });

    var connection = new signalR.HubConnectionBuilder()
        .withUrl('/inter')
        .build();
    // Create a function that the hub can call to broadcast messages.
    connection.on('broadcastMessage', function (content) {
        if (edit) {


            ace.require("ace/ext/language_tools");
            code = ace.edit("code");                      // создаем редактор из элемента с id="code"
            code.setTheme("ace/theme/textmate");          // выбираем тему оформления для подсветки синтаксиса
            code.getSession().setMode("ace/mode/c_cpp");  // говорим что код надо подсвечивать как C++ код
            code.setShowPrintMargin(false);               // опционально: убираем вертикальную границу в 80 сиволов
            code.setOptions({
                maxLines: Infinity,                       // опционально: масштабировать редактор вертикально по размеру кода
                fontSize: "12pt",                         // опционально: размер шрифта ставим побольше
                enableBasicAutocompletion: true
            });
            code.$blockScrolling = Infinity;              // отключаем устаревшие, не поддерживаемые фишки редактора
            code.selection.selectAll();
            code.removeLines();
            code.insert(content);


            // выбираем тему оформления для подсветки синтаксиса
        }
    });
    // Transport fallback functionality is now built into start.
    connection.start()
        .then(function () {
            console.log('connection started');


            $('#forCode').on('keyup',
                '#code',
                function (event) {
                    edit = true;

                    setTimeout(() => {
                        if (edit) {
                            var content = "";

                            $('.ace_line').each(function (index, el) {

                                content += el.innerText;


                                if (content.charAt(content.length - 2) !== '\n') {
                                    content += '\n';
                                }
                            });

                            connection.invoke('send', content);
                        }
                    }, 2000);
                });
        })
        .catch(error => {
            console.error(error.message);
        });
});

function run() {
    var http = new XMLHttpRequest();
    http.open("POST", "https://coliru.stacked-crooked.com/compile", false);
    var initialCommand = "g++ -std=c++17 -O2 -Wall -pedantic -pthread main.cpp && ./a.out";
    var input = document.getElementById("input").value;
    if (input.length > 0) {
        input = input.replace(/ /g, "\n");
        initialCommand += " << EOF\n" + input + "\nEOF";
    }
    http.send(JSON.stringify({ "cmd": initialCommand, "src": code.getValue() }));
    var output = $("#output");
    output.text('');
    output.text(http.response);
}