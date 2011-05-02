using System.Collections.Generic;
using MvcTurbine.ComponentModel;
using MvcTurbine.Diagnostic.Diagnostics;
using MvcTurbine.Diagnostic.Models;
using MvcTurbine.Diagnostic.ViewModelBuilders.Diagnostic;

namespace MvcTurbine.Diagnostic.Registration
{
	public class ServiceRegistrator : IServiceRegistration
	{
		public void Register(IServiceLocator locator)
		{
			locator.Register<IEnumerable<IDiagnostic>, IDiagnostic[]>();
			locator.Register<IDiagnostic, ControlPassDiagnostic>("ControlPassDiagnostic");
			locator.Register<IDiagnostic, ControlFailDiagnostic>("ControlFailDiagnostic");
			locator.Register<IIndexViewModelBuilder, IndexViewModelBuilder>();
		}
	}
}