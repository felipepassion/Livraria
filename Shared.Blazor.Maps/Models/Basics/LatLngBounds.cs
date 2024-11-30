using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FisSst.BlazorMaps
{
    /// <summary>
    /// Represents coordinates - latitude and longitude.
    /// </summary>
    public class LatLngBounds
    {
        public LatLngBounds()
        {
        }

        public LatLngBounds(LatLng corner1, LatLng corner2)
        {
            NorthEast = corner1;
            SouthWest = corner2;
        }

        public LatLngBounds(LatLng[] latlngs)
        {
            NorthEast = latlngs[0];
            SouthWest = latlngs[1];
        }

        [JsonPropertyName("_northEast")]
        public LatLng NorthEast { get; set; }

        [JsonPropertyName("_southWest")]
        public LatLng SouthWest { get; set; }
    }
}
