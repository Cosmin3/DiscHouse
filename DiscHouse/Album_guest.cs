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
        public Album_guest(string numeArtist, string numeAlbum)
        {
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
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Albums_guest newForm = new Albums_guest("");           
            newForm.FormClosed += new FormClosedEventHandler(closeForm);
            this.Close();
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
