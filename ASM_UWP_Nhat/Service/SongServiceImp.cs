using ASM_UWP_Nhat.Entity;
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
using System.Threading.Tasks;

namespace ASM_UWP_Nhat.Service
{
    class SongServiceImp: SongService
    {

        private string Send_Song_URL = "https://2-dot-backup-server-003.appspot.com/_api/v2/songs/post-free";
        private string Infor_URL = "https://2-dot-backup-server-003.appspot.com/_api/v2/songs/get-free-songs";
        public List<ListSong1> GetInfor()
        {
            //HttpClient client = new HttpClient();
            //client.DefaultRequestHeaders.Add("Authorization", "Basic ");
            //var responseContent = client.GetAsync(Infor_URL).Result.Content.ReadAsStringAsync().Result;

            //JObject jsonJObject = JObject.Parse(responseContent);
            //Debug.WriteLine(jsonJObject["name"]);
            //ListSong1 listsong1 = new ListSong1 {
            //    name = jsonJObject["name"].ToString(),
            //    singer = jsonJObject["singer"].ToString(),
            //    author = jsonJObject["author"].ToString(),
            //    thumbnail = jsonJObject["thumbnail"].ToString()
            //};

            HttpClient httpClient = new HttpClient();
            var responseContent = httpClient.GetAsync(Infor_URL).Result.Content.ReadAsStringAsync().Result;
            List<ListSong1> listSong = JsonConvert.DeserializeObject<List<ListSong1>>(responseContent);
           
            return listSong;
        }



        public ListSong1 SendInfor(ListSong1 listsong1)
        {
            Debug.WriteLine(JsonConvert.SerializeObject(listsong1));
            var httpClient = new HttpClient();
            HttpContent content = new StringContent(JsonConvert.SerializeObject(listsong1), Encoding.UTF8,
                "application/json");

            Task<HttpResponseMessage> httpRequestMessage = httpClient.PostAsync(Send_Song_URL, content);
            String responseContent = httpRequestMessage.Result.Content.ReadAsStringAsync().Result;
            Debug.WriteLine("Response: " + responseContent);

            JObject resObject = JObject.Parse(responseContent);

            // SAVE
            Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile sampleFile = storageFolder.CreateFileAsync("sample.txt",
                Windows.Storage.CreationCollisionOption.ReplaceExisting).GetAwaiter().GetResult();

            Windows.Storage.FileIO.WriteTextAsync(sampleFile, responseContent).GetAwaiter().GetResult();
            Debug.WriteLine("URL link save: "+ sampleFile.Path);

            return listsong1;
        }
    }
}
