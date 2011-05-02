using System.Collections.Generic;
using System.Linq;
using MvcTurbine.Diagnostic.Models;
using MvcTurbine.Diagnostic.ViewModels.Diagnostic;

namespace MvcTurbine.Diagnostic.ViewModelBuilders.Diagnostic
{
	public interface IIndexViewModelBuilder
	{
		IndexViewModel Build();
	}

	public class IndexViewModelBuilder : IIndexViewModelBuilder
	{
		private readonly IEnumerable<IDiagnostic> diagnostics;

		public IndexViewModelBuilder(IEnumerable<IDiagnostic> diagnostics)
		{
			this.diagnostics = diagnostics;
		}

		public IndexViewModel Build()
		{
			return new IndexViewModel
			{
				DiagnosticResults = diagnostics.Select(diagnostic => diagnostic.Run())
			};
		}
	}
}