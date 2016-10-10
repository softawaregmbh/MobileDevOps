using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using HelloXamarin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HelloXamarin.ViewModels
{
    public class AlbumViewModel : ViewModelBase
    {
        private IEnumerable<Album> albums;

        public IEnumerable<Album> Albums
        {
            get { return albums; }
            set { this.Set(ref albums, value); }
        }

        public ICommand LoadAlbumsCommand { get; set; }

        public AlbumViewModel()
        {
            this.Albums = new List<Album>();

            this.LoadAlbumsCommand = new RelayCommand(async () => await LoadAlbums());
        }

        public async Task LoadAlbums()
        {
            // Use System.Net.Http.HttpClient (NuGet) instead of Windows.Web.Http!
            using (var client = new HttpClient())
            {
                var json = await client.GetStringAsync("http://jsonplaceholder.typicode.com/albums");
                this.Albums = JsonConvert.DeserializeObject<IEnumerable<Album>>(json);
            }
        }
    }
}
