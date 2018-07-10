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
    public partial class AddArtist_Admin : Form
    {
        DbConnect connect = new DbConnect();
        public AddArtist_Admin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Artists_admin newForm = new Artists_admin();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                MessageBox.Show("All fields must be filled");
            else
            {

                string s1 = Convert.ToString(textBox1.Text);
                bool ok = true;

                for (int i = 0; i < s1.Length && ok; i++)
                {
                    if (s1[i] == '\'')
                        ok = false;

                }

                if (ok)
                {
                    connect.AddArtist(textBox1.Text, textBox2.Text, textBox3.Text);
                    Artists_admin newForm = new Artists_admin();
                    newForm.FormClosed += new FormClosedEventHandler(closeForm);
                    this.Hide();
                    newForm.Show();
                    newForm.Left = this.Left;
                    newForm.Top = this.Top;
                }
                else
                    MessageBox.Show("You cannot use the character \'");
            }

        }
    }
}
