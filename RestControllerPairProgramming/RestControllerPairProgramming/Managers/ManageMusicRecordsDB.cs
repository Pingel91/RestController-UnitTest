using ModelLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestControllerPairProgramming.Managers
{
    public class ManageMusicRecordsDB : IManageMusicRecords
    {
        private readonly MusicRecordsContext _context;

        public ManageMusicRecordsDB(MusicRecordsContext context)
        {
            _context = context;

        }


        public IEnumerable<MusicRecords> Get()
        {
            return _context.MusicRecords;
        }

        public MusicRecords Get(int id)
        {
            return _context.MusicRecords.Find(id);
        }

        public bool Create(MusicRecords value)
        {
            _context.MusicRecords.Add(value);
            _context.SaveChanges();
            return true;
        }

        public bool Update(int id, MusicRecords value)
        {
            MusicRecords musicRecords = Get(id);
            if (musicRecords != null)
            {
                musicRecords.Id = value.Id;
                musicRecords.Title = value.Title;
                musicRecords.Artist = value.Artist;
                musicRecords.Genre = value.Genre;
                musicRecords.Duration = value.Duration;
                musicRecords.PublicationYear = value.PublicationYear;

                return true;
            }

            return false;
        }

        public MusicRecords Delete(int id)
        {
            MusicRecords musicRecords = Get(id);
            _context.MusicRecords.Remove(musicRecords);
            return musicRecords;
        }
    }
}
