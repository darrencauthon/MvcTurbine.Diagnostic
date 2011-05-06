using System.Linq;
using MvcTurbine.ComponentModel;

namespace MvcTurbine.Diagnostic.Helpers
{
    public class DiagnosticsPageBuilder : IDiagnosticsPageBuilder
	{
		private readonly IServiceLocator serviceLocator;

		public DiagnosticsPageBuilder(IServiceLocator serviceLocator)
		{
			this.serviceLocator = serviceLocator;
		}

		public DiagnosticsPage Build()
		{
			var diagnostics = serviceLocator.ResolveServices<IDiagnostic>();
			var results = diagnostics.Select(diagnostic => diagnostic.Run());
			return new DiagnosticsPage { DiagnosticResults = results };
		}
	}
}