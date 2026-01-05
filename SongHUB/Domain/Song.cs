using System;

namespace SongHUB.Domain
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Singer { get; set; }
        public string SongType { get; set; }
        public DateTime CreatedDate { get; set; }

        public Song()
        {
            CreatedDate = DateTime.Now;
        }

        public Song(int id, string title, string singer, string songType)
        {
            Id = id;
            Title = title;
            Singer = singer;
            SongType = songType;
            CreatedDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Title} - {Singer} ({SongType})";
        }
    }
}