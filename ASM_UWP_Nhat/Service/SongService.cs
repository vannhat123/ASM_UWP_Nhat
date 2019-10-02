using ASM_UWP_Nhat.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_UWP_Nhat.Service
{
    interface SongService
    {
        ListSong1 SendInfor(ListSong1 listsong1);

        ListSong1 GetInfor();
    }
}
