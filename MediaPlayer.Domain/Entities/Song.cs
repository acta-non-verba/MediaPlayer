using System;

namespace MediaPlayer.Domain.Entity
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public TimeSpan Length { get; set; }
        public Lyrics Lyrics { get; set; }
    }
}