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
    public partial class Artists_user : Form
    {
        DbConnect connect = new DbConnect();
        string loggedArtist;

        public Artists_user(string loggedArtist)
        {
            this.loggedArtist = loggedArtist;
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
                Albums_user newForm = new Albums_user(numeArtist, this.loggedArtist);
                newForm.FormClosed += new FormClosedEventHandler(closeForm);
                this.Hide();
                newForm.Show();
                newForm.Left = this.Left;
                newForm.Top = this.Top;
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
        void closeForm(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
