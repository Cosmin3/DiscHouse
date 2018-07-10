using System;
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
    public partial class AddAward : Form
    {
        DbConnect connect = new DbConnect();
        string numeArtist;

        public AddAward(string numeArtist)
        {
            InitializeComponent();
            this.numeArtist = numeArtist;
        }
        void closeForm(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Albums_admin newForm = new Albums_admin(this.numeArtist);
            newForm.FormClosed += new FormClosedEventHandler(closeForm);
            this.Hide();
            newForm.Show();
            newForm.Left = this.Left;
            newForm.Top = this.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox4.Text == "" || textBox3.Text == "")
                MessageBox.Show("All fields must be filled");
            else
            {
                int albumId = connect.GetAlbumId(this.numeArtist, textBox4.Text);
                bool ok = connect.AddAward(textBox1.Text, Convert.ToDateTime(textBox3.Text), albumId);

                if (ok)
                {
                    MessageBox.Show("Award Added");
                    Albums_admin newForm = new Albums_admin(this.numeArtist);
                    newForm.FormClosed += new FormClosedEventHandler(closeForm);
                    this.Hide();
                    newForm.Show();
                    newForm.Left = this.Left;
                    newForm.Top = this.Top;
                }
                else
                    MessageBox.Show("Award could not be added");
            }
            
        }
    }
}
