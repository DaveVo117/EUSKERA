using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.Json;

namespace EUSKERA.AplicacionWeb.Controllers
{
    public class ProveedorController : Controller
    {

        private static IConfiguration _configuration;

        public ProveedorController(IConfiguration configuration)
        {
            _configuration = configuration;
        }



        [HttpGet]
        public IActionResult Proveedores(string opc, int id, int Giro, string razonSocial, string rfc, string calle, int numExt, string colonia, string municipio, string estado, int cp, string tel, string eMail, string fecRegistro, int snActivo)
        {
            string connectionString = _configuration.GetConnectionString("CadenaSQL");
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SP_Mto_Proveedores", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@opc", opc);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@idGiro", Giro);
                command.Parameters.AddWithValue("@razonSocial", razonSocial ?? ""); // Asignar cadena vacía si es nulo
                command.Parameters.AddWithValue("@rfc", rfc ?? ""); // Asignar cadena vacía si es nulo
                command.Parameters.AddWithValue("@calle", calle ?? ""); // Asignar cadena vacía si es nulo
                command.Parameters.AddWithValue("@numExt", numExt);
                command.Parameters.AddWithValue("@colonia", colonia ?? ""); // Asignar cadena vacía si es nulo
                command.Parameters.AddWithValue("@municipio", municipio ?? ""); // Asignar cadena vacía si es nulo
                command.Parameters.AddWithValue("@estado", estado ?? ""); // Asignar cadena vacía si es nulo
                command.Parameters.AddWithValue("@cp", cp);
                command.Parameters.AddWithValue("@tel", tel ?? ""); // Asignar cadena vacía si es nulo
                command.Parameters.AddWithValue("@eMail", eMail ?? ""); // Asignar cadena vacía si es nulo
                command.Parameters.AddWithValue("@fecRegistro", fecRegistro ?? ""); // Asignar cadena vacía si es nulo
                command.Parameters.AddWithValue("@snActivo", snActivo);

                SqlDataReader reader = command.ExecuteReader();
                dataTable.Load(reader);
            }

            //Serializar DatatTable
            var dataList = new List<Dictionary<string, object>>();
            foreach (DataRow row in dataTable.Rows)
            {
                var dataRow = new Dictionary<string, object>();
                foreach (DataColumn col in dataTable.Columns)
                {
                    dataRow [col.ColumnName] = row [col];
                }
                dataList.Add(dataRow);
            }

            var respuesta = new JsonResult(new { data = dataList });
            return respuesta;

        }



        public IActionResult Index()
        {
            return View();
        }
    }
}
