using Microsoft.AspNetCore.Mvc;
using WebCv.Repository;

namespace WebCv.Controllers
{
    public class ExperienciaLaboralController : Controller
    {
        private IExperienciaLaboralRespository ELRInyectada;

        public ExperienciaLaboralController(IExperienciaLaboralRespository eLRInyectada)
        {
            ELRInyectada = eLRInyectada;
        }

        public IActionResult Index()
        {
            //TODO: llamo a una clase que llama a la base de datos (clase de repositorio) RepositorioExperienciaLaboral
            //y llamo a un metodo de esa clase que ese metodo llama a la base de datos y me trae los datos
            //se la mando al viewbag viewdata en formato lista. Creación de base SQL server. Crear la carpeta repository
            this.ViewBag.Experiencia = "pingapoy";
            this.ViewBag.ListadoExperiencias = LlamarBaseTraerTrabajos();



            //experiencialaboralrepository experiencialaboralrepository = new experiencialaboralrepository();
            //this.ViewBag.ListaDeTrabajos = experiencialaboralrepository.GetExperienciasLaborales();
            this.ViewBag.ListaDeTrabajos = ELRInyectada.GetExperienciasLaborales();

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
