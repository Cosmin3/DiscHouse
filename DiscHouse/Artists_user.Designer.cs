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
            this.artistsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.diskHouseDataSet = new DiscHouse.DiskHouseDataSet();
            this.artistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumsTableAdapter = new DiscHouse.DiskHouseDataSetTableAdapters.AlbumsTableAdapter();
            this.albumsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.artistsTableAdapter = new DiscHouse.DiskHouseDataSetTableAdapters.artistsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diskHouseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(234)))), ((int)(((byte)(218)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.DataSource = this.artistsBindingSource1;
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
            // artistsBindingSource1
            // 
            this.artistsBindingSource1.DataMember = "artists";
            this.artistsBindingSource1.DataSource = this.diskHouseDataSet;
            // 
            // diskHouseDataSet
            // 
            this.diskHouseDataSet.DataSetName = "DiskHouseDataSet";
            this.diskHouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artistsBindingSource
            // 
            this.artistsBindingSource.DataMember = "artists";
            this.artistsBindingSource.DataSource = this.diskHouseDataSet;
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
            // artistsTableAdapter
            // 
            this.artistsTableAdapter.ClearBeforeFill = true;
            // 
            // Artists_user
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
            this.MaximizeBox = false;
            this.Name = "Artists_user";
            this.Text = "Artists";
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diskHouseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button4;
        private DiskHouseDataSet diskHouseDataSet;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private DiskHouseDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
        private System.Windows.Forms.BindingSource albumsBindingSource1;
        private System.Windows.Forms.BindingSource artistsBindingSource;
        private DiskHouseDataSetTableAdapters.artistsTableAdapter artistsTableAdapter;
        private System.Windows.Forms.BindingSource artistsBindingSource1;
    }
}