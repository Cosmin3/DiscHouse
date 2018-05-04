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
    public partial class Albums_user : Form
    {
        DbConnect connect = new DbConnect();
        string numeArtist;
        string loggedArtist;
        public Albums_user(string numeArtist,string loggedArtist)
        {
            this.loggedArtist = loggedArtist;
            this.numeArtist = numeArtist;
            InitializeComponent();

            if (numeArtist != loggedArtist)
                button1.Hide();
            ArrayList list = new ArrayList();

            int id = connect.GetArtistId(numeArtist);


            list = connect.ReadAlbumsForArtist("Select Name from Albums where [Artist.Id]=" + Convert.ToString(id));
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            foreach (string slist in list)
            {
                listBox1.Items.Add(slist);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Albums_user_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Artists_user newForm = new Artists_user(this.loggedArtist);
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
            int index = listBox1.SelectedIndex + 1;
            string numeAlbum = Convert.ToString(listBox1.SelectedItem);
            // numeAlbum = connect.ReadNameFromAlbum("Select name from artists where id=" + Convert.ToString(index));

            if (numeAlbum != "")
            {
                Album newForm = new Album(this.numeArtist, numeAlbum, this.loggedArtist);
                newForm.FormClosed += new FormClosedEventHandler(closeForm);
                this.Hide();
                newForm.Show();
                newForm.Left = this.Left;
                newForm.Top = this.Top;
            }
        }
    }
}
