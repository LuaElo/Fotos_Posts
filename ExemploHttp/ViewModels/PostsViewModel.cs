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
    public partial class PostsViewModel : ObservableObject
    {
        
        [ObservableProperty]
        ObservableCollection<Post> posts;

        
        public ICommand getPostsCommmand { get; }
        
        public PostsViewModel() 
        {
            getPostsCommmand = new Command(getPosts);

        }

        public async void getPosts()
        {
            RestService postService = new RestService();
            Posts = await postService.getPostAsync();
        }

    }
}
