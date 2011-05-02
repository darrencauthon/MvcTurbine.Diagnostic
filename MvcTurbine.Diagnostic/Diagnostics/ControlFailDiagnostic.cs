using MvcTurbine.Diagnostic.Models;

namespace MvcTurbine.Diagnostic.Diagnostics
{
	public class ControlFailDiagnostic : IDiagnostic
	{
		public DiagnosticResult Run()
		{
			return new DiagnosticResult { Name = "Control Fail", Passed = false, Info = "This is a controlled test diagnostic." };
		}
	}
}