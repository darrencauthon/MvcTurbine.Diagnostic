using System.Linq;
using MvcTurbine.ComponentModel;
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
		private readonly IServiceLocator serviceLocator;

		public IndexViewModelBuilder(IServiceLocator serviceLocator)
		{
			this.serviceLocator = serviceLocator;
		}

		public IndexViewModel Build()
		{
			var diagnostics = serviceLocator.ResolveServices<IDiagnostic>();
			var results = diagnostics.Select(diagnostic => diagnostic.Run());
			return new IndexViewModel { DiagnosticResults = results };
		}
	}
}