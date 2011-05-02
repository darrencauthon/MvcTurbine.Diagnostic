using System.Web.Mvc;
using MvcTurbine.Diagnostic.ViewModelBuilders.Diagnostic;

namespace MvcTurbine.Diagnostic.Controllers
{
    public class DiagnosticController : Controller
    {
    	private readonly IIndexViewModelBuilder indexViewModelBuilder;

    	public DiagnosticController(IIndexViewModelBuilder indexViewModelBuilder)
		{
			this.indexViewModelBuilder = indexViewModelBuilder;
		}

    	public ActionResult Index()
    	{
    		var model = indexViewModelBuilder.Build();
			return View("Index", model);
        }
    }
}