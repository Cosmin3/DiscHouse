using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscHouse
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        void closeForm(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login newForm = new Login();
            newForm.FormClosed += new FormClosedEventHandler(closeForm);
            this.Hide();
            newForm.Show();
            newForm.Left = this.Left;
            newForm.Top = this.Top;
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Signup newForm = new Signup();
            newForm.FormClosed += new FormClosedEventHandler(closeForm);
            this.Hide();
            newForm.Show();
            newForm.Left = this.Left;
            newForm.Top = this.Top;
        }
    }
}
