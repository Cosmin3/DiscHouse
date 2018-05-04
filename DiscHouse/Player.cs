using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace DiscHouse
{
    public partial class Player : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        string artistName, albumName, songName;



        public Player(string artistName, string albumName, string songName)
        {
            this.artistName = artistName;
            this.albumName = albumName;
            this.songName = songName;
            
            InitializeComponent();
            player.URL = @"Music\" + this.artistName + @"\" + this.albumName + @"\" + this.songName + ".mp3";
            label4.Text = songName;
            
            this.FormClosing += Player_FormClosing;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.controls.play();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.controls.stop();
          
        }

        private void Player_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.controls.stop();
        }
    }
}
