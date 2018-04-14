namespace DiscHouse
{
    partial class Artists_user
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.diskHouseDataSet = new DiscHouse.DiskHouseDataSet();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumsTableAdapter = new DiscHouse.DiskHouseDataSetTableAdapters.AlbumsTableAdapter();
            this.albumsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.artistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artistsTableAdapter = new DiscHouse.DiskHouseDataSetTableAdapters.artistsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.diskHouseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.DataSource = this.artistsBindingSource;
            this.listBox1.DisplayMember = "Name";
            this.listBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(506, 530);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "Name";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 4;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(629, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 4;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(629, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
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
            this.button4.Text = "Log Out";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(629, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 22);
            this.textBox1.TabIndex = 5;
            // 
            // diskHouseDataSet
            // 
            this.diskHouseDataSet.DataSetName = "DiskHouseDataSet";
            this.diskHouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.diskHouseDataSet;
            // 
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // albumsBindingSource1
            // 
            this.albumsBindingSource1.DataMember = "Albums";
            this.albumsBindingSource1.DataSource = this.diskHouseDataSet;
            // 
            // artistsBindingSource
            // 
            this.artistsBindingSource.DataMember = "artists";
            this.artistsBindingSource.DataSource = this.diskHouseDataSet;
            // 
            // artistsTableAdapter
            // 
            this.artistsTableAdapter.ClearBeforeFill = true;
            // 
            // Artists_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DiscHouse.Properties.Resources.Funky2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Artists_admin";
            this.Text = "Artists";
            ((System.ComponentModel.ISupportInitialize)(this.diskHouseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private DiskHouseDataSet diskHouseDataSet;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private DiskHouseDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
        private System.Windows.Forms.BindingSource albumsBindingSource1;
        private System.Windows.Forms.BindingSource artistsBindingSource;
        private DiskHouseDataSetTableAdapters.artistsTableAdapter artistsTableAdapter;
    }
}