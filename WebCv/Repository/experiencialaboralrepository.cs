using Microsoft.Data.SqlClient;
using WebCv.Models;

namespace WebCv.Repository
{
    public class experiencialaboralrepository : IExperienciaLaboralRespository
    {
        //private readonly string connectionString = "Data Source=localhost;Initial Catalog=PersonalWebCV;User ID=sa;Password=primitivo7;TrustServerCertificate=True;";
        private readonly string connectionString = "";

        public experiencialaboralrepository(IConfiguration configuration)
        {
            this.connectionString = configuration["ConnectionStrings"];
        }

        public List<ExperienciaLaboral> GetExperienciasLaborales()
        {
            List<ExperienciaLaboral> listaDeExperiencias = new List<ExperienciaLaboral>();

            using (SqlConnection connection = new SqlConnection(connectionString)) //Paso 1
            {
                string query = "SELECT * FROM ExperienciasLaborales;";

                SqlCommand cmd = new SqlCommand(query, connection);    //Paso 2
                connection.Open();  //Paso 3

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ExperienciaLaboral experienciaLaboral = new ExperienciaLaboral();
                        experienciaLaboral.Id = (int)reader["id"];
                        experienciaLaboral.Nombre = reader["nombre"].ToString();
                        experienciaLaboral.Descripcion = reader["descripcion"].ToString();

                        listaDeExperiencias.Add(experienciaLaboral);
                    }   
                }   
            }
            return listaDeExperiencias; 
        }

    }
}
