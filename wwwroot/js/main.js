l
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