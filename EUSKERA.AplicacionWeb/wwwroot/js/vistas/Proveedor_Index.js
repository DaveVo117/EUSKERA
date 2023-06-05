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
    $("#cboCategoria").val(modelo.idGiro == 0 ? $("#cboGiro option:first").val() : modelo.idGiro)
    $("#txtMarca").val(modelo.razonSocial)
    $("#txtDescripcion").val(modelo.rfc)
    $("#txtCodigoBarra").val(modelo.calle)
    $("#txtStock").val(modelo.numExt)
    $("#txtPrecio").val(modelo.colonia)
    $("#txtPrecio").val(modelo.municipio)
    $("#txtPrecio").val(modelo.estado)
    $("#txtPrecio").val(modelo.cp)
    $("#txtPrecio").val(modelo.tel)
    $("#txtPrecio").val(modelo.eMail)
    $("#txtPrecio").val(modelo.fecRegistro)
    $("#cboEstado").val(modelo.snActivo)

    $("#modalData").modal("show")
}





$("#btnNuevo").click(function () {
    /*    debugger;*/
    mostrarModal()
})