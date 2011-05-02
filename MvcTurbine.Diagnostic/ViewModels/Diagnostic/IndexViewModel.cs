using System.Collections.Generic;
using MvcTurbine.Diagnostic.Models;

namespace MvcTurbine.Diagnostic.ViewModels.Diagnostic
{
	public class IndexViewModel
	{
		public IEnumerable<DiagnosticResult> DiagnosticResults { get; set; }
	}
}