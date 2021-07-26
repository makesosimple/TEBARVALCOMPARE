/* Modal Scripts */

function modalScript(requestedItem) {

    let detailsModal = $("#GeneralModal");
    let url = $(requestedItem).data("url");
    $.get(url).done(function (data) {
        detailsModal.html(data);
        detailsModal.find(".modal").modal("show");
    });
}