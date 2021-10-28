using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ModelLib.Model;


namespace RestControllerPairProgramming.Managers
{
    interface IManageMusicRecords
    {
        IEnumerable<MusicRecords> Get();
        MusicRecords Get(int id);
        IEnumerable<MusicRecords> GetTitleFromSubstring(string substring);
        IEnumerable<MusicRecords> GetArtistFromSubstring(string substring);

        IEnumerable<MusicRecords> GetGenreFromSubstring(string substring);

        bool Create(MusicRecords value);
        bool Update(int id, MusicRecords value);
        MusicRecords Delete(int id);

    }
}
