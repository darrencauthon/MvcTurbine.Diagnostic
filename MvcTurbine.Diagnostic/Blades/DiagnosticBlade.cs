using MvcTurbine.Blades;
using MvcTurbine.ComponentModel;
using MvcTurbine.Diagnostic.Helpers;

namespace MvcTurbine.Diagnostic.Blades
{
	public class DiagnosticBlade : Blade, ISupportAutoRegistration
	{
		public virtual void AddRegistrations(AutoRegistrationList registrationList)
		{
			registrationList
				.Add(Registration.Simple<IDiagnostic>())
				.Add(Registration.Simple<IDiagnosticsPageBuilder>());
		}

		public override void Spin(IRotorContext context)
		{
		}
	}
}