﻿namespace DiscHouse
{
    partial class Artists_guest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Artists_guest));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.artistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diskHouseDataSet = new DiscHouse.DiskHouseDataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.artistsTableAdapter = new DiscHouse.DiskHouseDataSetTableAdapters.artistsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diskHouseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(234)))), ((int)(((byte)(218)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.DataSource = this.artistsBindingSource;
            this.listBox1.DisplayMember = "Name";
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(506, 522);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "Name";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // artistsBindingSource
            // 
            this.artistsBindingSource.DataMember = "artists";
            this.artistsBindingSource.DataSource = this.diskHouseDataSet;
            // 
            // diskHouseDataSet
            // 
            this.diskHouseDataSet.DataSetName = "DiskHouseDataSet";
            this.diskHouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderSize = 4;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(723, 474);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(225, 51);
            this.button4.TabIndex = 4;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // artistsTableAdapter
            // 
            this.artistsTableAdapter.ClearBeforeFill = true;
            // 
            // Artists_guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DiscHouse.Properties.Resources.Funky2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Artists_guest";
            this.Text = "Artists";
            this.Load += new System.EventHandler(this.Artists_guest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diskHouseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button4;
        private DiskHouseDataSet diskHouseDataSet;
        private System.Windows.Forms.BindingSource artistsBindingSource;
        private DiskHouseDataSetTableAdapters.artistsTableAdapter artistsTableAdapter;
    }
}