document.addEventListener('DOMContentLoaded', function () {
    var collapseCatalogos = document.getElementById('collapseCatalogos');
    var collapseLineaNegocio = document.getElementById('collapseLineaNegocio');
    var collapseInventario = document.getElementById('collapseInventario');

    collapseCatalogos.addEventListener('click', function () {
        if (collapseLineaNegocio.classList.contains('show')) {
            collapseLineaNegocio.classList.remove('show');
        }
        if (collapseInventario.classList.contains('show')) {
            collapseInventario.classList.remove('show');
        }
    });

    document.getElementById("Inventario").addEventListener("click", function (event) {
        event.preventDefault();
        var collapseInventario = document.getElementById("collapseInventario");
        if (collapseInventario.classList.contains("show")) {
            collapseInventario.classList.remove("show");
        } else {
            collapseInventario.classList.add("show");
        }
    });
    document.getElementById("LineaNegocio").addEventListener("click", function (event) {
        event.preventDefault();
        var collapseInventario = document.getElementById("collapseLineaNegocio");
        if (collapseInventario.classList.contains("show")) {
            collapseInventario.classList.remove("show");
        } else {
            collapseInventario.classList.add("show");
        }
    });



});
