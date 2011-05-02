using MvcTurbine.Diagnostic.Models;

namespace MvcTurbine.Diagnostic.Diagnostics
{
	public class ControlPassDiagnostic : IDiagnostic
	{
		public DiagnosticResult Run()
		{
			return new DiagnosticResult { Name = "Control Pass", Passed = true, Info = "This is a controlled test diagnostic." };
		}
	}
}