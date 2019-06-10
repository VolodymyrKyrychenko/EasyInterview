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
    // Start the connection.
    var connection = new signalR.HubConnectionBuilder()
        .withUrl('/inter')
        .build();
    // Create a function that the hub can call to broadcast messages.
    connection.on('broadcastMessage', function (content) {
        if (edit) {
            $('#code').remove();

            $('#forCode').append('<div id="code"></div>');

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
            $('#forCode').on('keyup', '#code', function (event) {
                edit = false;

                var content = "";

                 $('.ace_line').each(function (index, elem) {
                    var span = $(elem).find('span');

                    $(span).each(function (index, elem) {
                        content += elem.innerText + " ";
                    });

                    content += '\n';
                 });

                 content.trim();

                connection.invoke('send', content);
                // Clear text box and reset focus for next comment.
                event.preventDefault();
            });
        })
        .catch(error => {
            console.error(error.message);
        });
});