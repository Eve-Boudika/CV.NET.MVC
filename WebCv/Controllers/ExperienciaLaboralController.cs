using Microsoft.AspNetCore.Mvc;

namespace WebCv.Controllers
{
    public class ExperienciaLaboralController : Controller
    {
        public IActionResult Index()
        {
            //TODO: llamo a una clase que llama a la base de datos (clase de repositorio) RepositorioExperienciaLaboral
            //y llamo a un metodo de esa clase que ese metodo llama a la base de datos y me trae los datos
            //se la mando al viewbag viewdata en formato lista 
            this.ViewBag.Experiencia = "pingapoy";


            this.ViewBag.ListadoExperiencias = LlamarBaseTraerTrabajos();

            return View();
        }

        private List<string> LlamarBaseTraerTrabajos()
        {
            List<string> ListaExperienciaLaboral = new List<string>();
            ListaExperienciaLaboral.Add("experiencia 1");
            ListaExperienciaLaboral.Add("experiencia 2");
            ListaExperienciaLaboral.Add("experiencia 3");
            return ListaExperienciaLaboral;
        }
     }
}
