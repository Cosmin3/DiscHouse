using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscHouse
{
    public partial class Artists_guest : Form
    {
        DbConnect connect = new DbConnect();
        public Artists_guest()
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

        private void Artists_guest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diskHouseDataSet.artists' table. You can move, or remove it, as needed.
            this.artistsTableAdapter.Fill(this.diskHouseDataSet.artists);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string numeArtist = Convert.ToString(listBox1.SelectedItem);

            Albums_guest newForm = new Albums_guest(numeArtist);
            newForm.FormClosed += new FormClosedEventHandler(closeForm);
            this.Hide();
            newForm.Show();
            newForm.Left = this.Left;
            newForm.Top = this.Top;
        }
    }
}
