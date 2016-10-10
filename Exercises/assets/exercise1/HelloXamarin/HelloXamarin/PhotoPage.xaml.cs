using HelloXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class PhotoPage : ContentPage
    {
        private PhotoViewModel viewModel;

        public PhotoPage(int albumId)
        {
            InitializeComponent();

            this.viewModel = new PhotoViewModel(albumId);
            this.BindingContext = this.viewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await this.viewModel.LoadPhotos();
        }
    }
}
