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
        string numeArtist;
        string numeAlbum;
        public Album_guest(string numeArtist, string numeAlbum)
        {
            this.numeArtist = numeArtist;
            this.numeAlbum = numeAlbum;
            InitializeComponent();

            ArrayList awardList = new ArrayList();
            ArrayList list = new ArrayList();
            int id = connect.GetAlbumId(numeArtist, numeAlbum);
            list = connect.ReadSongsForAlbum(Convert.ToString(id));
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            foreach (string slist in list)
            {
                listBox1.Items.Add(slist);
            }
            
            label5.Text = connect.ReadYearFromArtist("Select year from albums where id=" + Convert.ToString(id));
            label4.Text = connect.ReadGenreFromArtist("Select genre from albums where id=" + Convert.ToString(id));

            awardList = connect.ReadAwardsForAlbum(id);
            string awards = "";

            foreach (string award in awardList)
            {
                awards = awards + award + System.Environment.NewLine;
            }
            if (awards == "")
            {
                label6.Text = "No awards yet";
            }
            else
            {
                label6.Text = awards;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Albums_guest newForm = new Albums_guest(this.numeArtist);           
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

        void listBox1_MouseDoubleClick(object sender, EventArgs e)
        {
            string s1 = Convert.ToString(listBox1.SelectedItem);
            int ok1 = 1;
            string s2 = "";
            for (int i = 0; i < s1.Length && ok1 == 1; i++)
            {
                if (s1[i + 1] == '.')
                    ok1 = 0;

                s2 = s2 + s1[i];
            }
            if (s2 != "")
            {
                Player player = new Player(this.numeArtist, this.numeAlbum, s2);
                player.Show();
            }


        }

        private void Album_guest_Load(object sender, EventArgs e)
        {

        }
    }
}
