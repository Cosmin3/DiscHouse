using System;
using System.Collections;
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
    public partial class Update_Admin : Form
    {
        DbConnect connect = new DbConnect();
        string numeArtist;
        string numeAlbumVechi;
        public Update_Admin(String numeAlbum, String genre, string year,string numeArtist)
        {

            this.numeArtist = numeArtist;
            this.numeAlbumVechi = numeAlbum;
            InitializeComponent();
            textBox1.Text = numeAlbum;
            textBox4.Text = genre;
            textBox3.Text = year;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList list = connect.ReadAlbums();
            connect.UpdateAlbum(textBox1.Text, textBox4.Text, textBox3.Text,list,numeAlbumVechi);
            Albums_admin newForm = new Albums_admin(this.numeArtist);
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
    }
}
