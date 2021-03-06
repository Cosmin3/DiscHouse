﻿using System;
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
    public partial class Albums_guest : Form
    {
        DbConnect connect = new DbConnect();
        string numeArtist;
        public Albums_guest(string nume)
        {
            this.numeArtist = nume;
            InitializeComponent();
            ArrayList list = new ArrayList();

            int id = connect.GetArtistId(nume);

            label4.Text = numeArtist;
            label3.Text = connect.readMembers(numeArtist);
            list = connect.ReadAlbumsForArtist("Select Name from Albums where [Artist.Id]="+Convert.ToString(id));
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            foreach(string slist in list)
            {
                listBox1.Items.Add(slist);
            }
            

        }

        private void Albums_guest_Load(object sender, EventArgs e)
        {

        }
        void closeForm(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Artists_guest newForm = new Artists_guest();
            newForm.FormClosed += new FormClosedEventHandler(closeForm);
            this.Hide();
            newForm.Show();
            newForm.Left = this.Left;
            newForm.Top = this.Top;
        }

        private void Albums_guest_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diskHouseDataSet.Albums' table. You can move, or remove it, as needed.
            this.albumsTableAdapter.Fill(this.diskHouseDataSet.Albums);
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            int index = listBox1.SelectedIndex + 1;
            string numeAlbum = Convert.ToString(  listBox1.SelectedItem);
            // numeAlbum = connect.ReadNameFromAlbum("Select name from artists where id=" + Convert.ToString(index));

            if (numeAlbum != "")
            {
                Album_guest newForm = new Album_guest(this.numeArtist, numeAlbum);
                newForm.FormClosed += new FormClosedEventHandler(closeForm);
                this.Hide();
                newForm.Show();
                newForm.Left = this.Left;
                newForm.Top = this.Top;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
