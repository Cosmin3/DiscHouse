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
    public partial class Add_Album_User : Form
    {
        DbConnect connect = new DbConnect();
        string artistName;
        string loggedArtist;

        public Add_Album_User(string nume, string loggedArtist)
        {
            this.artistName = nume;
            this.loggedArtist = loggedArtist;

            InitializeComponent();
        }
        void closeForm(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox4.Text == "" || textBox3.Text == "")
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
                    bool existentAlbum = false;
                    ArrayList list = new ArrayList();
                    int id = connect.GetArtistId(this.artistName);
                    list = connect.ReadAlbumsForArtist("Select Name from Albums where [Artist.Id]=" + Convert.ToString(id));

                    foreach (string slist in list)
                    {

                        if (slist == textBox1.Text)
                            existentAlbum = true;
                    }

                    if (existentAlbum)
                        MessageBox.Show("The album already exists in the database.");
                    else
                    {
                        int artistId = connect.GetArtistId(this.artistName);

                        connect.AddAlbum(textBox1.Text, Convert.ToDateTime(textBox3.Text), textBox4.Text, artistId);

                        Add_Song newForm = new Add_Song(this.artistName, textBox1.Text, this.loggedArtist);
                        newForm.FormClosed += new FormClosedEventHandler(closeForm);
                        this.Hide();
                        newForm.Show();
                        newForm.Left = this.Left;
                        newForm.Top = this.Top;
                    }
                }
                else
                    MessageBox.Show("You cannot use the characters \' or .");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Albums_user newForm = new Albums_user(this.artistName,this.loggedArtist);
            newForm.FormClosed += new FormClosedEventHandler(closeForm);
            this.Hide();
            newForm.Show();
            newForm.Left = this.Left;
            newForm.Top = this.Top;
        }
    }
}
