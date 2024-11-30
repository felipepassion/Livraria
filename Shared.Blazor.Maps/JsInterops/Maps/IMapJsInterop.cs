using FisSst.BlazorMaps.JsInterops.Base;
using Microsoft.JSInterop;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace FisSst.BlazorMaps.JsInterops.Maps
{
    internal interface IMapJsInterop : IBaseJsInterop
    {
        ValueTask<IJSObjectReference> Initialize(MapOptions mapOptions);
    }
}
