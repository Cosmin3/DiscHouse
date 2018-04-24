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
    public partial class Login : Form
    {
        DbConnect connect = new DbConnect();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int log;
            log = connect.CheckLogIn(textBox1.Text, textBox2.Text);

            if (log == -1)
            {
                Artists_admin newForm = new Artists_admin();
                newForm.FormClosed += new FormClosedEventHandler(closeForm);
                this.Hide();
                newForm.Show();
                newForm.Left = this.Left;
                newForm.Top = this.Top;
            }
            else if (log == 1)
            {
                Artists_user newForm = new Artists_user();
                newForm.FormClosed += new FormClosedEventHandler(closeForm);
                this.Hide();
                newForm.Show();
                newForm.Left = this.Left;
                newForm.Top = this.Top;
            }
            else
                MessageBox.Show("User/Password incorrect");
            
        }
        void closeForm(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

            private void button2_Click(object sender, EventArgs e)
        {
            MainForm newForm = new MainForm();
            newForm.FormClosed += new FormClosedEventHandler(closeForm);
            this.Hide();
            newForm.Show();
            newForm.Left = this.Left;
            newForm.Top = this.Top;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
