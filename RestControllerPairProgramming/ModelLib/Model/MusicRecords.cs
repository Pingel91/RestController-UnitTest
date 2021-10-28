using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Model
{
    public class MusicRecords
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public int PublicationYear { get; set; }

        public MusicRecords()
        {
            
        }

        public MusicRecords(int id, string title, string artist, string genre, int duration, int publicationYear)
        {
            Id = id;
            Title = title;
            Artist = artist;
            Genre = genre;
            Duration = duration;
            PublicationYear = publicationYear;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Title)}: {Title}, {nameof(Artist)}: {Artist}, {nameof(Genre)}: {Genre}, {nameof(Duration)}: {Duration}, {nameof(PublicationYear)}: {PublicationYear}";
        }
    }
}
