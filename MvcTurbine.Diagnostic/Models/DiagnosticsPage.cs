using System.Collections.Generic;

namespace MvcTurbine.Diagnostic.Models
{
	public class DiagnosticsPage
	{
		public IEnumerable<DiagnosticResult> DiagnosticResults { get; set; }
	}
}