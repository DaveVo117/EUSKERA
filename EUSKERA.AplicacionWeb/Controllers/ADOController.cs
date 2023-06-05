using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace EUSKERA.AplicacionWeb.Controllers
{
    public class ADOController : Controller
    {
        private static  IConfiguration _configuration;

        public ADOController(IConfiguration configuration)
        {
            _configuration = configuration;
        }



        [HttpGet]
        public IActionResult Proveedores(string opc, int id, int idGiro, string razonSocial, string rfc, string calle, int numExt, string colonia, string municipio, string estado,int cp , string tel, string eMail, string fecRegistro, int snActivo)
        {
        string connectionString = _configuration.GetConnectionString("CadenaSQL");
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SP_Mto_Proveedores", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@opc", opc);
                command.Parameters.AddWithValue("@id,", id);
                command.Parameters.AddWithValue("@idGiro", idGiro);
                command.Parameters.AddWithValue("@razonSocial", razonSocial);
                command.Parameters.AddWithValue("@rfc", rfc);
                command.Parameters.AddWithValue("@calle", calle);
                command.Parameters.AddWithValue("@numExt", numExt);
                command.Parameters.AddWithValue("@colonia", colonia);
                command.Parameters.AddWithValue("@municipio", municipio);
                command.Parameters.AddWithValue("@estado", estado);
                command.Parameters.AddWithValue("@cp,", cp);
                command.Parameters.AddWithValue("@tel", tel);
                command.Parameters.AddWithValue("@eMail", eMail);
                command.Parameters.AddWithValue("@fecRegistro", fecRegistro);
                command.Parameters.AddWithValue("@snActivo", snActivo);

                SqlDataReader reader = command.ExecuteReader();
                dataTable.Load(reader);
            }

            // Devolver los datos en formato JSON
            return Json(dataTable);
        }



    }
}
