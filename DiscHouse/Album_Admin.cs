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
    public partial class Album_Admin : Form
    {
        DbConnect connect = new DbConnect();
        string numeArtist;
        string numeAlbum;

        public Album_Admin(string numeArtist, string numeAlbum)
        {
            this.numeArtist = numeArtist;
            this.numeAlbum = numeAlbum;

            InitializeComponent();


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
            // string awards = connect.ReadNameFromArtist("Select Name from awards where [Album.id]=" + Convert.ToString(index));


            //  label6.Text = awards;
        }

        private void Album_Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void button5_Click(object sender, EventArgs e)
        {
            MainForm newForm = new MainForm();
            newForm.FormClosed += new FormClosedEventHandler(closeForm);
            this.Hide();
            newForm.Show();
            newForm.Left = this.Left;
            newForm.Top = this.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Song newForm = new Add_Song(this.numeArtist, this.numeAlbum);
            newForm.FormClosed += new FormClosedEventHandler(closeForm);
            this.Hide();
            newForm.Show();
            newForm.Left = this.Left;
            newForm.Top = this.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ArrayList list = new ArrayList();
                int id = connect.GetAlbumId(numeArtist, numeAlbum);
                list = connect.ReadSongsForAlbum(Convert.ToString(id));
                foreach (string slist in list)
                {
                    string s1 = Convert.ToString(slist);
                    int ok1 = 1;
                    string s2 = "";
                    for (int i = 0; i < s1.Length && ok1 == 1; i++)
                    {
                        if (s1[i + 1] == '.')
                            ok1 = 0;

                        s2 = s2 + s1[i];
                    }
                    int songIndex = connect.GetSongId(s2);
                    bool ok = connect.DeleteSong(songIndex);
                    if (!ok)
                        MessageBox.Show("Error at deleting songs");
                }

                bool ok3 = connect.DeleteAlbum(this.numeAlbum);
                if (ok3)
                    MessageBox.Show("Album Deleted");
                else
                    MessageBox.Show("Delete Error");

                Albums_admin newForm = new Albums_admin(this.numeArtist);
                newForm.FormClosed += new FormClosedEventHandler(closeForm);
                this.Hide();
                newForm.Show();
                newForm.Left = this.Left;
                newForm.Top = this.Top;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                int songIndex = connect.GetSongId(s2);
                bool ok = connect.DeleteSong(songIndex);
                if (ok)
                    MessageBox.Show("Song Deleted");
                else
                    MessageBox.Show("Delete Error");

                listBox1.Items.Clear();


                ArrayList list = new ArrayList();
                int id = connect.GetAlbumId(this.numeArtist, this.numeAlbum);
                list = connect.ReadSongsForAlbum(Convert.ToString(id));
                listBox1.DataSource = null;
                listBox1.Items.Clear();
                foreach (string slist in list)
                {
                    listBox1.Items.Add(slist);
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            Update_Admin newForm = new Update_Admin(this.numeAlbum, label4.Text, label5.Text,this.numeArtist);
            newForm.FormClosed += new FormClosedEventHandler(closeForm);
            this.Hide();
            newForm.Show();
            newForm.Left = this.Left;
            newForm.Top = this.Top;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
