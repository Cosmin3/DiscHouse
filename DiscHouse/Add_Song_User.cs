using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscHouse
{
    public partial class Add_Song_User : Form
    {
        string numeArtist;
        string numeAlbum;
        string loggedArtist;
        DbConnect connect = new DbConnect();

        public Add_Song_User(string numeArtist, string numeAlbum, string loggedArtist)
        {
            this.numeAlbum = numeAlbum;
            this.numeArtist = numeArtist;
            this.loggedArtist = loggedArtist;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Albums_user newForm = new Albums_user(this.numeArtist,this.loggedArtist);
            newForm.FormClosed += new FormClosedEventHandler(closeForm);
            this.Hide();
            newForm.Show();
            newForm.Left = this.Left;
            newForm.Top = this.Top;
        }
        void closeForm(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int albumId = connect.GetAlbumId(this.numeArtist, this.numeAlbum);
            TimeSpan time;
            int t = 60 * Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text);
            time = TimeSpan.FromSeconds(t);
            connect.AddSong(textBox1.Text, time, albumId);
            MessageBox.Show("Song Added");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
