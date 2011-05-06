using System.Web.Mvc;
using MvcTurbine.Diagnostic.Helpers;

namespace MvcTurbine.Diagnostic.Controllers
{
    public class DiagnosticController : Controller
    {
    	private readonly IDiagnosticsPageBuilder diagnosticsPageBuilder;

    	public DiagnosticController(IDiagnosticsPageBuilder diagnosticsPageBuilder)
		{
			this.diagnosticsPageBuilder = diagnosticsPageBuilder;
		}

    	public ActionResult Index()
    	{
    		var model = diagnosticsPageBuilder.Build();
			return View("Index", model);
        }
    }
}