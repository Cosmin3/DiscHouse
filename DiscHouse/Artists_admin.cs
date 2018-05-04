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
    
    public partial class Artists_admin : Form
    {
        DbConnect connect = new DbConnect();
        public Artists_admin()
        {
            InitializeComponent();
            ArrayList list = new ArrayList();

            list = connect.ReadArtists();



            listBox1.DataSource = null;
            listBox1.Items.Clear();
            foreach (string slist in list)
            {
                listBox1.Items.Add(slist);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string numeArtist = Convert.ToString(listBox1.SelectedItem);
            if (numeArtist != "")
            {
                Albums_admin newForm = new Albums_admin(numeArtist);
                newForm.FormClosed += new FormClosedEventHandler(closeForm);
                this.Hide();
                newForm.Show();
                newForm.Left = this.Left;
                newForm.Top = this.Top;
            }
        }
        void closeForm(object sender, FormClosedEventArgs e)
        {
            this.Close();
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

        private void Artists_admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diskHouseDataSet.artists' table. You can move, or remove it, as needed.
            this.artistsTableAdapter.Fill(this.diskHouseDataSet.artists);
            // TODO: This line of code loads data into the 'diskHouseDataSet.Albums' table. You can move, or remove it, as needed.
            this.albumsTableAdapter.Fill(this.diskHouseDataSet.Albums);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddArtist_Admin newForm = new AddArtist_Admin();
            newForm.FormClosed += new FormClosedEventHandler(closeForm);
            this.Hide();
            newForm.Show();
            newForm.Left = this.Left;
            newForm.Top = this.Top;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
