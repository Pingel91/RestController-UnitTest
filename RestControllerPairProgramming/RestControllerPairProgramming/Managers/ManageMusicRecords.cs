using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelLib.Model;

namespace RestControllerPairProgramming.Managers
{
    public class ManageMusicRecords : IManageMusicRecords
    {
        private static List<MusicRecords> musicRecordsList = new List<MusicRecords>()
        {
            new MusicRecords(1, "Crying In The Sun", "Faustix", "Dance", 196, 2018),
            new MusicRecords(2, "Starfields", "Hallman", "Rock", 162, 2018),
            new MusicRecords(3, "Happy Now", "Kygo", "Dance", 211, 2018),
            new MusicRecords(4, "Breaking Me", "Topic", "Rock", 167, 2019)
        };
        public IEnumerable<MusicRecords> Get()
        {
            return new List<MusicRecords>(musicRecordsList);
        }

        public MusicRecords Get(int id)
        {
            if (musicRecordsList.Exists(i => i.Id == id))
            {
                return musicRecordsList.Find(i => i.Id == id);
            }
            throw new KeyNotFoundException();
        }

        public bool Create(MusicRecords value)
        {
            musicRecordsList.Add(value);
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
            musicRecordsList.Remove(musicRecords);
            return musicRecords;
        }
    }
}
