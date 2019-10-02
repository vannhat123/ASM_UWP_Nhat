using ASM_UWP_Nhat.Entity;
using ASM_UWP_Nhat.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Imaging;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Newtonsoft.Json.Linq;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ASM_UWP_Nhat.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GetInfor : Page
    {
        ObservableCollection<ListSong1> listSongs { get; set; }
        public GetInfor()
        {


            this.InitializeComponent();
            this.listSongs = new ObservableCollection<ListSong1>();
            this.listSongs.Add(new ListSong1()
            {
                name = "123",
                singer = "123",
                thumbnail = "123",
                link = "123"
            });

            List<ListSong1> listSong = new SongServiceImp().GetInfor();
            foreach (ListSong1 item in listSong)
            {
                this.listSongs.Add(new ListSong1()
                {
                    name = item.name,
                    singer = item.singer,
                    thumbnail = item.thumbnail,
                    link = item.link
                });
            }

        }
    }
}
