using MvcTurbine.Blades;
using MvcTurbine.ComponentModel;
using MvcTurbine.Diagnostic.Models;
using MvcTurbine.Diagnostic.ViewModelBuilders.Diagnostic;

namespace MvcTurbine.Diagnostic
{
	public class DiagnosticBlade : Blade, ISupportAutoRegistration
	{
		public virtual void AddRegistrations(AutoRegistrationList registrationList)
		{
			registrationList
				.Add(Registration.Simple<IDiagnostic>())
				.Add(Registration.Simple<IIndexViewModelBuilder>());
		}

		public override void Spin(IRotorContext context)
		{
		}
	}
}