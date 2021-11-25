using System;
using MediaPlayer.Domain.Entity;

namespace MediaPlayer.Application.MediaPlayer
{
    
    public class MP3Player 
    {
        public void Start()
        {
            //Mp3 player started.
        }
        public void Play(Song song)
        {
            //Mp3 player plays the song;
        }
        public void Pause(Song song)
        {
            //Mp3 player paused            
        }
        public void Resume(Song song)
        {
            //Mp3 player resumed the song;
        }
        public void Stop(Song song)
        {
            //Mp3 player stops the song;
        }
        public void Next(Song song)
        {
            //Mp3 player plays the next song;
        }
        public void Previous(Song song)
        {
            //Mp3 player plays the previous song;
        }
        public void Seek(TimeSpan timeSpan)
        {
            //Mp3 player plays from the seek position;
        }
        public void ShowLyrics(Song song)
        {
            //Mp3 player displays the lyrics if available;
        }
        public void HideLyrics(Song song)
        {
            //Mp3 player hides the lyrics if shown;
        }

    }
}