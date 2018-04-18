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

            label4.Text = connect.ReadYearFromArtist("Select year from albums where id=" + Convert.ToString(id));
            label5.Text = connect.ReadGenreFromArtist("Select genre from albums where id=" + Convert.ToString(id));
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
    }
}
