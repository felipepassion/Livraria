using Microsoft.JSInterop;
using System.Text.Json.Serialization;

namespace FisSst.BlazorMaps
{
    /// <summary>
    /// Determines Marker's properties.
    /// </summary>
    public class PopupOptions : InteractiveLayerOptions
    {
        public PopupOptions()
        {
            KeepInView = true;
            AutoClose = false;
            CloseOnClick = false;
            CloseOnEscapeKey = false;
            Pane = DefaultPane;
            BubblingMouseEvents = false;
            Interactive = true;
            Opacity = 1;
        }

        private const int DefaultZIndexOffset = 0;
        private const double DefaultOpacity = 1;
        private const int DefaultRiseOffset = 250;
        private const string DefaultPane = "popupPane";
        private const string DefaultShadowPane = "shadowPane";
        
        public bool KeepInView { get; init; }
        public bool AutoClose { get; init; }
        public bool CloseOnClick { get; init; }
        public bool CloseOnEscapeKey { get; init; }
        
        public double Opacity { get; init; }
    }
}
