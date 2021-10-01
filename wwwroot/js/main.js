function addToShortCuts(ProjectID) {
    $.get('/Shortcuts/Add/?id=' + ProjectID, function (data, status) {
        console.log("data", data);
        console.log("status", status);
    });
}

function toggleShortCuts(ProjectID) {
    $.get('/Shortcuts/Add/?id=' + ProjectID, function (data, status) {
        console.log("data", data);
        console.log("status", status);
    });
}

/* Select2 Validation */
$('select').on('change', function () {
    $(this).removeClass("is-invalid");
    $(this).addClass("is-valid");
    $(this).valid();
});