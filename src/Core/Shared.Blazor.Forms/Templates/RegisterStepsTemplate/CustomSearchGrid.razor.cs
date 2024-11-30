using System.Reflection;

namespace Niu.Nutri.Shared.Blazor.Components.GenericComponents;
public partial class CustomSearchGrid
{

}



public static class AppDomainExtensions
{
    public static Assembly GetAssemblyByName(this AppDomain domain, string assemblyName)
    {
        return domain.GetAssemblies().FirstOrDefault(a => a.GetName().Name == assemblyName);
    }
}