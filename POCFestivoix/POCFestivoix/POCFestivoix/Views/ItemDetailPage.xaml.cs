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

            this.map.Pins.Add(new Pin { Position = new Position(46.342946, -72.536535), Label = "Festivoix" });
            this.map.Pins.Add(new Pin { Position = new Position(46.342014, -72.537777), Label = "Poivre noir" });
            this.map.Pins.Add(new Pin { Position = new Position(46.341954, -72.539401), Label = "Resto-Bar Faste-Fou" });
            this.map.Pins.Add(new Pin { Position = new Position(46.342435, -72.537277), Label = "Sea Shack La Gamba" });
            this.map.Pins.Add(new Pin { Position = new Position(46.344181, -72.537642), Label = "Le Buck : Pub Gastronomique" });
        }

        /// <summary>
        /// MapMapClicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MapMapClicked(object sender, MapClickedEventArgs e)
        {
        }
    }
}