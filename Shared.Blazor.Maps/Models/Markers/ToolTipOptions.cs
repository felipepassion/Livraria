using Microsoft.JSInterop;
using System.Text.Json.Serialization;

namespace FisSst.BlazorMaps
{
    /// <summary>
    /// Determines Marker's properties.
    /// </summary>
    public class ToolTipOptions : InteractiveLayerOptions
    {
        public ToolTipOptions()
        {
            Sticky = false;
            Permament = true;
            Pane = DefaultPane;
            BubblingMouseEvents = false;
            Interactive = false;
            Opacity = 1;
        }

        private const int DefaultZIndexOffset = 0;
        private const double DefaultOpacity = 1;
        private const int DefaultRiseOffset = 250;
        private const string DefaultPane = "tooltipPane";
        private const string DefaultShadowPane = "shadowPane";
        
        public bool Permament { get; init; }
        public bool Sticky { get; init; }
        public double Opacity { get; init; }
    }
}
