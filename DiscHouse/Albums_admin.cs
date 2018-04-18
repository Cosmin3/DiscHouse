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
    public partial class Albums_admin : Form
    {
        DbConnect connect = new DbConnect();
        string numeArtist;
        public Albums_admin(string numeArtist)
        {
            this.numeArtist = numeArtist;
            InitializeComponent();
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

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm newForm = new MainForm();
            newForm.FormClosed += new FormClosedEventHandler(closeForm);
            this.Hide();
            newForm.Show();
            newForm.Left = this.Left;
            newForm.Top = this.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Album newForm = new Add_Album(this.numeArtist);
            newForm.FormClosed += new FormClosedEventHandler(closeForm);
            this.Hide();
            newForm.Show();
            newForm.Left = this.Left;
            newForm.Top = this.Top;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex + 1;
            string numeAlbum = Convert.ToString(listBox1.SelectedItem);
            // numeAlbum = connect.ReadNameFromAlbum("Select name from artists where id=" + Convert.ToString(index));


            Album_Admin newForm = new Album_Admin(this.numeArtist, numeAlbum);
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
            Artists_admin newForm = new Artists_admin();
            newForm.FormClosed += new FormClosedEventHandler(closeForm);
            this.Hide();
            newForm.Show();
            newForm.Left = this.Left;
            newForm.Top = this.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Remove_Album newForm = new Remove_Album();
            newForm.FormClosed += new FormClosedEventHandler(closeForm);
            this.Hide();
            newForm.Show();
            newForm.Left = this.Left;
            newForm.Top = this.Top;
        }

        private void Albums_admin_Load(object sender, EventArgs e)
        {

        }
    }
}
