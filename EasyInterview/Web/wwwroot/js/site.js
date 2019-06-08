function GetProblem(id) {
    $('.problem').load("/Problem/Get" + "?id=" + id);
};
