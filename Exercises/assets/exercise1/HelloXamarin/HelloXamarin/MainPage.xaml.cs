using HelloXamarin.Models;
using HelloXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new AlbumViewModel();
        }

        private void OnAlbumTapped(object sender, ItemTappedEventArgs e)
        {
            var album = e.Item as Album;
            this.Navigation.PushAsync(new PhotoPage(album.Id));
        }
    }
}
