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
using System.IO;

namespace DiscHouse
{

    public partial class Add_Song : Form
    {
        string numeArtist;
        string numeAlbum;
        DbConnect connect = new DbConnect();

        public Add_Song(string numeArtist,string numeAlbum)
        {
            this.numeAlbum = numeAlbum;
            this.numeArtist = numeArtist;
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                MessageBox.Show("All fields must be filled");
            else
            {
                string s1 = Convert.ToString(textBox1.Text);
                bool ok = true;

                for (int i = 0; i < s1.Length && ok; i++)
                {
                    if (s1[i] == '\'' || s1[i] == '.')
                        ok = false;

                }

                if (ok)
                {
                    bool existentSong = false;
                    ArrayList list = new ArrayList();
                    int id = connect.GetAlbumId(numeArtist, numeAlbum);
                    list = connect.ReadSongs(Convert.ToString(id));


                    foreach (string slist in list)
                    {

                        if (slist == textBox1.Text)
                            existentSong = true;
                    }

                    if (existentSong)
                        MessageBox.Show("The song already exists in the database for this album.");
                    else
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
                else
                    MessageBox.Show("You cannot use the characters \' or .");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect.DeleteSong(connect.GetSongId(textBox1.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            var FD = new System.Windows.Forms.OpenFileDialog();
            DialogResult result = FD.ShowDialog();
            textBox1.Text = Path.GetFileNameWithoutExtension(FD.ToString());
            string source=FD.FileName;
            string path= @"D:\Scoala\An 3\Sem 2\II\Project\DiscHouse\DiscHouse\bin\Debug\Music\" + numeArtist+@"\"+numeAlbum+@"\";
            Directory.CreateDirectory(path);
            File.Copy(source, path + Path.GetFileName(FD.ToString()), true);

        }
    }
}
