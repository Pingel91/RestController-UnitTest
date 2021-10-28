using ModelLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestControllerPairProgramming.Managers
{
    public class ManageMusicRecordsDB : IManageMusicRecords
    {
        public IEnumerable<MusicRecords> GetGenreFromSubstring(string substring)
        {
            throw new NotImplementedException();
        }

        public bool Create(MusicRecords value)
        {
            throw new NotImplementedException();
        }

        public MusicRecords Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MusicRecords> Get()
        {
            throw new NotImplementedException();
        }

        public MusicRecords Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MusicRecords> GetTitleFromSubstring(string substring)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MusicRecords> GetArtistFromSubstring(string substring)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, MusicRecords value)
        {
            throw new NotImplementedException();
        }
    }
}
