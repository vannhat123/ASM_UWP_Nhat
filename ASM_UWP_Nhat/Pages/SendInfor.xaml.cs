using ASM_UWP_Nhat.Entity;
using ASM_UWP_Nhat.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ASM_UWP_Nhat.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SendInfor : Page
    {
        public SendInfor()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListSong1 listSong1 = new ListSong1
            {
                name ="Nhat",
                description = "bai hat hay nhat thang 10",
                singer ="Duy manh",
                author="Manh Duy",
                thumbnail= "https://image.thanhnien.vn/660/uploaded/thienminh/2017_05_21/anh1_ewnl.jpg",
                link = "https://zingmp3.vn/bai-hat/Co-Tat-Ca-Nhung-Thieu-Anh-ERIK/ZWAEOBCW.mp3"
            };

            SongServiceImp songServiceImp = new SongServiceImp();
            songServiceImp.SendInfor(listSong1);

            
        }
    }
}
