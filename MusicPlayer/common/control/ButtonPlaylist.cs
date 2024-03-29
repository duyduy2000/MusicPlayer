﻿using MusicPlayer.common.util;
using System;
using System.Windows.Forms;

namespace MusicPlayer.common.control
{
    public partial class ButtonPlaylist : UserControl
    {
        private string playlistName;


        public string PlaylistName { 
            get => playlistName; 
            set
            {
                playlistName = value;
                SetPlaylistName();
            }
        }


        public ButtonPlaylist()
        {
            InitializeComponent();
            btn.Click += OnClick;
        }


        private void OnLoad(object sender, EventArgs e)
        {

        }



        public void OnClick(object sender, EventArgs e)
        {
            InvokeOnClick(this, e);
        }


        public void SetPlaylistName()
        {
            btn.Text = TextUtil.GetTextWithLimitedLength(playlistName, 15);
        }

    }
}
