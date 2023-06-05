const MODELO_BASE = {
    id: 0,
    idGiro: 0,
    razonSocial: "",
    rfc: "",
    calle: "",
    numExt: 0,
    colonia: "",
    municipio: "",
    estado: "",
    cp: 0,
    tel: "",
    eMail: "",
    fecRegistro: "",
    snActivo: 1
}//Utilizar inicial minuscula

let tablaData

$(document).ready(function () {
    LLenarTabla();
});

// FUNCIONES

function LLenarTabla() {
    const opc = 'CONSULTAR';
    // Inicializar la tabla DataTable
    tablaData = $('#tbdata').DataTable({
        responsive: true,
        "ajax": {
            "url": `/Proveedor/Proveedores?opc=${opc}`,
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "id", "visible": false },
            { "data": "Giro" },
            { "data": "razonSocial" },
            { "data": "RFC" },
            { "data": "Calle", "visible": false },
            { "data": "NumExterior", "visible": false },
            { "data": "Colonia", "visible": false },
            { "data": "Municipio", "visible": false },
            { "data": "Estado", "visible": false },
            { "data": "Domicilio"},
            { "data": "CP" },
            { "data": "Telefono" },
            { "data": "Email" },
            {
                "data": "Fecha_Registro",
                "render": function (data) {
                    // Dar formato "dd/mm/yyyy" a la fecha
                    var fecha = new Date(data);
                    var dia = fecha.getDate().toString().padStart(2, '0');
                    var mes = (fecha.getMonth() + 1).toString().padStart(2, '0');
                    var anio = fecha.getFullYear();
                    return dia + '/' + mes + '/' + anio;
                }
            },
            {
                "data": "SN_Activo", render: function (data) {
                    if (data == 1)
                        return '<pan class="badge badge-info">Activo </span>';
                    else
                        return '<pan class="badge badge-danger">No Activo </span>';
                }
            },
            {
                "defaultContent": '<button class="btn btn-primary btn-editar btn-sm mr-2"><i class="fas fa-pencil-alt"></i></button>' +
                    '<button class="btn btn-danger btn-eliminar btn-sm"><i class="fas fa-trash-alt"></i></button>',
                "orderable": false,
                "searchable": false,
                "width": "80px"
            }
        ],
        order: [[0, "desc"]],
        dom: "Bfrtip",
        buttons: [
            {
                text: 'Exportar Excel',
                extend: 'excelHtml5',
                title: '',
                filename: 'Reporte Productos',
                exportOptions: {
                    columns: [2, 3, 4, 5, 6] //especificar columnas que se descargarán inicia en 0 para el reporte en excel
                }
            }, 'pageLength'
        ],
        language: {
            url: "https://cdn.datatables.net/plug-ins/1.11.5/i18n/es-ES.json"
        }
    });
}


function mostrarModal(modelo = MODELO_BASE) {
    $("#txtId").val(modelo.id)
    $("#cboGiro").val(modelo.Giro == 0 ? $("#cboGiro option:first").val() : modelo.Giro)
    $("#txtRazonSocial").val(modelo.razonSocial)
    $("#txtRFC").val(modelo.RFC)
    $("#txtCalle").val(modelo.Calle)
    $("#txtNumExt").val(modelo.NumExterior)
    $("#txtColonia").val(modelo.Colonia)
    $("#txtMunicipio").val(modelo.Municipio)
    $("#txtEstado").val(modelo.Estado)
    $("#txtCP").val(modelo.CP)
    $("#txtTelefono").val(modelo.Telefono)
    $("#txtEmail").val(modelo.Email)
    $("#cboEstado").val(modelo.SN_Activo)

    $("#modalData").modal("show")
}





$("#btnNuevo").click(function () {
    /*    debugger;*/
    mostrarModal()
})



let filaSeleccionada;
$("#tbdata tbody").on("click", ".btn-editar", function () {             //Pasa la informacion de la fila seleciconada para llenar modal

    if ($(this).closest("tr").hasClass("child")) {
        filaSeleccionada = $(this).closest("tr").prev();
    } else {
        filaSeleccionada = $(this).closest("tr");
    }

    const data = tablaData.row(filaSeleccionada).data();
    //console.log(data)
    mostrarModal(data);
})

$("#tbdata tbody").on("click", ".btn-eliminar", function () {

    let fila;

    if ($(this).closest("tr").hasClass("child")) {
        fila = $(this).closest("tr").prev();
    } else {
        fila = $(this).closest("tr");
    }

    const data = tablaData.row(fila).data();

    swal({
        title: "¿Estas seguro?",
        text: `Eliminar el producto: "${data.txtDescripcion}"`,
        type: "warning",
        showCancelButton: true,
        confirmButtonClass: "btn-danger",
        confirmButtonText: "Si, eliminar",
        cancelButtonText: "No, cancelar",
        closeOnConfirm: false,
        closeOnCancel: true
    },
        function (respuesta) {

            if (respuesta) {

                $(".showSweetAlert").LoadingOverlay("show");
                //debugger;
                fetch(`/Producto/Eliminar?IdProducto=${data.idProducto}`, {
                    method: "DELETE"
                })
                    .then(response => {
                        $(".showSweetAlert").LoadingOverlay("hide");
                        return response.ok ? response.json() : Promise.reject(response);
                    })
                    .then(responseJson => {

                        if (responseJson.estado) {

                            tablaData.row(fila).remove().draw();

                            swal("Listo!", "El producto fue eliminado", "success")
                        } else {
                            swal("Lo sentimos", responseJson.mensaje, "error")
                        }
                    })


            }

        }
    )

})