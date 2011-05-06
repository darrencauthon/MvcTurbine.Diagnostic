using System.Collections.Generic;

namespace MvcTurbine.Diagnostic
{
	public class DiagnosticsPage
	{
		public IEnumerable<DiagnosticResult> DiagnosticResults { get; set; }
	}
}