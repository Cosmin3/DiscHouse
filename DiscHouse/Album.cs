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
    public partial class Album : Form
    {
        DbConnect connect = new DbConnect();
        string numeArtist;
        string numeAlbum;
        string loggedArtist;

        public Album(string numeArtist,string numeAlbum, string loggedArtist)
        {
            this.loggedArtist = loggedArtist;
            this.numeAlbum = numeAlbum;
            this.numeArtist = numeArtist;
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            MainForm newForm = new MainForm();
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
           Albums_user newForm = new Albums_user(this.numeArtist,this.loggedArtist);
            newForm.FormClosed += new FormClosedEventHandler(closeForm);
            this.Hide();
            newForm.Show();
            newForm.Left = this.Left;
            newForm.Top = this.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Update_User newForm = new Update_User(this.numeAlbum, label4.Text, label5.Text, this.numeArtist,this.loggedArtist);
            newForm.FormClosed += new FormClosedEventHandler(closeForm);
            this.Hide();
            newForm.Show();
            newForm.Left = this.Left;
            newForm.Top = this.Top;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
