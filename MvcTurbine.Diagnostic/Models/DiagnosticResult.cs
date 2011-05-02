namespace MvcTurbine.Diagnostic.Models
{
	public class DiagnosticResult
	{
		public DiagnosticResult()
		{
			Passed = false;
		}

		public string Name { get; set; }
		public bool Passed { get; set; }
		public string Info { get; set; }
	}
}