using Plugin.Geolocator;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace POCFestivoix.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();

            this.AddPins(this.map);

            Polyline polyLine = new Polyline
            {
                StrokeColor = Color.Blue,
                StrokeWidth = 12,
                Geopath = {
                    new Position(46.342946, -72.536535),
                    new Position(46.342014, -72.537777),
                    new Position(46.341954, -72.539401),
                }
            };

            this.map.MapElements.Add(polyLine);
        }

        /// <summary>
        /// AddPins
        /// </summary>
        /// <param name="map"></param>
        private void AddPins(Map map)
        {
            map.Pins.Add(new Pin { Position = new Position(46.342946, -72.536535), Label = "Festivoix" });
            map.Pins.Add(new Pin { Position = new Position(46.342014, -72.537777), Label = "Poivre noir" });
            map.Pins.Add(new Pin { Position = new Position(46.341954, -72.539401), Label = "Resto-Bar Faste-Fou" });
            map.Pins.Add(new Pin { Position = new Position(46.342435, -72.537277), Label = "Sea Shack La Gamba" });
            map.Pins.Add(new Pin { Position = new Position(46.344181, -72.537642), Label = "Le Buck : Pub Gastronomique" });
        }

        private async void ButtonClicked(object sender, EventArgs e)
        {
            Plugin.Geolocator.Abstractions.IGeolocator locator = CrossGeolocator.Current;

            Plugin.Geolocator.Abstractions.Position userPosition = await locator.GetPositionAsync();

            this.map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(userPosition.Latitude, userPosition.Longitude), Distance.FromMiles(1)));

        }
    }
}