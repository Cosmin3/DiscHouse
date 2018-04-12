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
    public partial class Album_guest : Form
    {
        DbConnect connect = new DbConnect();
        string nume;
        public Album_guest(string numeArtist, string numeAlbum)
        {
            this.nume = numeArtist;
            InitializeComponent();
            ArrayList list = new ArrayList();
            int id = connect.GetAlbumId(numeArtist, numeAlbum);
            list = connect.ReadSongsForAlbum("Select Name from Songs where [Album.Id]=" + Convert.ToString(id));
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            foreach (string slist in list)
            {
                listBox1.Items.Add(slist);
            }
            
            label4.Text = connect.ReadYearFromArtist("Select year from albums where id=" + Convert.ToString(id));
            label5.Text = connect.ReadGenreFromArtist("Select genre from albums where id=" + Convert.ToString(id));
           // string awards = connect.ReadNameFromArtist("Select Name from awards where [Album.id]=" + Convert.ToString(index));

            
          //  label6.Text = awards;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Albums_guest newForm = new Albums_guest(this.nume);           
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void Album_guest_Load(object sender, EventArgs e)
        {

        }
    }
}
