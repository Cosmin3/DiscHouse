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
    public partial class Signup : Form
    {
        DbConnect connect = new DbConnect();
        public Signup()
        {
            InitializeComponent();

            
            foreach (string elem in connect.ReadGuestArtists())
            {
                comboBox1.Items.Add(elem);

            }

        }
        void closeForm(object sender, FormClosedEventArgs e)
        {
            this.Close();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool uniqueUser = true;
            bool hasArtist = false;
            bool userCreated=false;
            bool artistLinked=false;
            ArrayList list = new ArrayList();

            list = connect.ReadUsers();
            foreach (string slist in list)
            {
                if (slist == textBox1.Text)
                    uniqueUser = false;
                
            }
            if(!uniqueUser)
                MessageBox.Show("User taken");
            else
            {
                if (textBox2.Text != textBox3.Text)
                    MessageBox.Show("Passwords do not match");
                else
                {
                    if (textBox4.Text != "45682")
                        MessageBox.Show("Wrong Registration Code");
                    else
                    {
                        

                        if (comboBox1.SelectedItem.ToString()=="")
                            MessageBox.Show("Please choose an artist!");
                        else
                        {
                            userCreated = connect.AddUser(textBox1.Text, textBox2.Text);
                            if (!userCreated)
                                MessageBox.Show("Error at user");
                            int idUser = connect.GetUserId(textBox1.Text);
                            ArrayList artistList = connect.ReadArtists();
                            artistLinked= connect.UpdateArtist(idUser, artistList, comboBox1.SelectedItem.ToString());
                            if(!artistLinked)
                                MessageBox.Show("Error at link");
                            if (artistLinked && userCreated)
                            {
                                MessageBox.Show("User created");
                                Artists_user newForm = new Artists_user(comboBox1.SelectedItem.ToString());
                                newForm.FormClosed += new FormClosedEventHandler(closeForm);
                                this.Hide();
                                newForm.Show();
                                newForm.Left = this.Left;
                                newForm.Top = this.Top;
                            }
                        }
                    }
                }
            }
            
        }


    }
}
