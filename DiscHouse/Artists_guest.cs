using System;
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
            int index =listBox1.SelectedIndex+1;
            string sr;
            sr= connect.ReadNameFromArtist("Select name from artists where id=" + Convert.ToString(index));

            Albums_guest newForm = new Albums_guest(sr);
            newForm.FormClosed += new FormClosedEventHandler(closeForm);
            this.Hide();
            newForm.Show();
            newForm.Left = this.Left;
            newForm.Top = this.Top;
        }
    }
}
