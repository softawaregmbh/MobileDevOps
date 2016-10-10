using GalaSoft.MvvmLight;
using HelloXamarin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HelloXamarin.ViewModels
{
    public class PhotoViewModel : ViewModelBase
    {
        private int albumId;

        private IEnumerable<Photo> photos;

        public IEnumerable<Photo> Photos
        {
            get { return photos; }
            set { this.Set(ref photos, value); }
        }


        public PhotoViewModel(int albumId)
        {
            this.albumId = albumId;
            this.Photos = new List<Photo>();
        }

        public async Task LoadPhotos()
        {
            using (var client = new HttpClient())
            {
                var json = await client.GetStringAsync($"http://jsonplaceholder.typicode.com/albums/{albumId}/photos");
                this.Photos = JsonConvert.DeserializeObject<IEnumerable<Photo>>(json);
            }
        }
    }
}
