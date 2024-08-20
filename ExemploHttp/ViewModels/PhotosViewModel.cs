using CommunityToolkit.Mvvm.ComponentModel;
using ExemploHttp.Models;
using ExemploHttp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExemploHttp.ViewModels
{
    public partial class PhotosViewModel : ObservableObject
    {

        [ObservableProperty]
        ObservableCollection <Photo> photos;


        public ICommand getPhotosCommmand { get; }

        public PhotosViewModel()
        {
            getPhotosCommmand = new Command(getPhoto);

        }

        public async void getPhoto()
        {
            RestService photosService = new RestService();
            photos = await photosService.getPhotosAsync();
        }

    }

}
