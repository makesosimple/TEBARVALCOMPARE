/* Modal Scripts */

async function modalScript(requestedItem) {

    const detailsModal = $("#GeneralModal");
    const url = $(requestedItem).data("url");
    const response = await fetch(url, {
        method: 'GET'
    })
        .then(response => response.text())
        .catch(function (error) {
            alert("Sayfa bulunamadı.");
            console.warn("Error: ", error);
        });
    detailsModal.html(response);
    detailsModal.find(".modal").modal("show");
}