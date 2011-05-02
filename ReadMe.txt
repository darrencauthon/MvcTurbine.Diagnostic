 ___             _ __  __
| _ \___ __ _ __| |  \/  |___
|   / -_) _` / _` | |\/| / -_)
|_|_\___\__,_\__,_|_|  |_\___|

USAGE
1. Reference the assembly.
2. Create a Diagnostics folder in your project.
3. Create diagnostic classes the inpliment the IDiagnostic interface.
4. Register your diagnostic classes.

REQUIREMENTS
* MVC3
* MvcTurbine

NOTES
I have only tested this with Unity. Do to the way that unity performs
ResolveAll() for constructor injection, you need to make sure that your
diagnostic classes are regesterd with a name. I suggest using the type
name like this:
	locator.Register<IDiagnostic, MyDiagnostic>("MyDiagnostic");