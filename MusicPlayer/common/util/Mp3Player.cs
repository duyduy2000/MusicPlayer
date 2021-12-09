﻿using AxWMPLib;
using WMPLib;

namespace MusicPlayer.common.util
{
    public class Mp3Player
    {
        private static readonly string songFileLocation = @"C:\Users\Speedyservice\Music\MusicPlayer\";
        private readonly WindowsMediaPlayer player = new WindowsMediaPlayer();
        //private static IWMPMedia media;


        public string SongUrl { get => player.URL; set => player.URL = GetSongLocation(value); }
        public bool MuteVolume { get => player.settings.mute; set => player.settings.mute = value; }


        public static string GetSongLocation(string mp3File)
        {
            return songFileLocation + mp3File;
        }


        public void PlaySong()
        {
            player.controls.play();
        }


        public void PauseSong()
        {
            player.controls.pause();
        }


        public void ClosePlayer()
        {
            player.close();
        }


        public void SetVolume(int volume)
        {
            player.settings.volume = volume;
        }


        //public static int GetSongDurationInSecond(string mp3File)
        //{
        //    media = player.newMedia(GetSongLocation(mp3File));
        //    int duration = (int)media.duration;

        //    // Stop the music and return result
        //    player.controls.stop();
        //    return duration;
        //}


    }
}
