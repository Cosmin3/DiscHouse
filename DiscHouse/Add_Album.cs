﻿using System;
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
    public partial class Add_Album : Form
    {
        DbConnect connect = new DbConnect();
        string artistName;
        public Add_Album(string nume)
        {
            this.artistName = nume;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        void closeForm(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int artistId = connect.GetArtistId(this.artistName);
            
            connect.AddAlbum(textBox1.Text, Convert.ToDateTime(textBox3.Text),textBox4.Text, artistId);

            Add_Song newForm = new Add_Song(this.artistName, textBox1.Text);
            newForm.FormClosed += new FormClosedEventHandler(closeForm);
            this.Hide();
            newForm.Show();
            newForm.Left = this.Left;
            newForm.Top = this.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Albums_admin newForm = new Albums_admin(this.artistName);
            newForm.FormClosed += new FormClosedEventHandler(closeForm);
            this.Hide();
            newForm.Show();
            newForm.Left = this.Left;
            newForm.Top = this.Top;
        }

        private void Add_Album_Load(object sender, EventArgs e)
        {

        }
    }
}
