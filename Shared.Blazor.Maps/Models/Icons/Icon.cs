using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Niu.Nutri.WebApp.Tests")]
namespace FisSst.BlazorMaps
{
    /// <summary>
    /// Can be a graphical representation of an object on a Map.
    /// </summary>
    public class Icon : JsReferenceBase
    {
        internal Icon(IJSObjectReference jsReference)
        {
            JsReference = jsReference;
        }
    }
}
