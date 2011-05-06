using MvcTurbine.Diagnostic.Models;

namespace MvcTurbine.Diagnostic
{
	public interface IDiagnostic
	{
		DiagnosticResult Run();
	}
}