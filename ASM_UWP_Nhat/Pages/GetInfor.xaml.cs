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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ASM_UWP_Nhat.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GetInfor : Page
    {
        public GetInfor()
        {
            this.InitializeComponent();

            //SongServiceImp songServiceImp = new SongServiceImp();
            //ListSong1 listsong = songServiceImp.GetInfor();
            //this.Name.Text = listsong.name;
            //this.Singer.Text = listsong.singer;
            //this.Author.Text = listsong.author;
            //  this.ImageControl.Source = listsong.thumbnail;
        }


    }
}
