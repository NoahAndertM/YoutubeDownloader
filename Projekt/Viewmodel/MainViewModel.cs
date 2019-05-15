using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary;

namespace Projekt.Viewmodel
{
    class MainViewModel : BaseViewModel
    {

        public List<YouTubeVideo> _videos;

        public YouTube youTube = YouTube.Default;

        public ICollection<YouTubeVideo> Videos {
            get
            {
                return _videos;
            }
        }
        

        public YouTubeVideo _selectedVideo;
        public YouTubeVideo SelectedVideo
        {
            get
            {
                return _selectedVideo;
            }
            set
            {
                _selectedVideo = value;
                OnNotifyPropertyChanged(nameof(_selectedVideo));
                OnNotifyPropertyChanged(nameof(SelectedVideo));
            }
        }

        public MainViewModel()
        {
            _videos = new List<YouTubeVideo>();
        }
    
        public void addVideo(string url)
        {
            YouTubeVideo video = youTube.GetVideo(url);
            Videos.Add(video);
            OnNotifyPropertyChanged(nameof(Videos));
        }

    }
}
