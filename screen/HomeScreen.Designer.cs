namespace sqlitedb
{
    partial class HomeScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Newbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.Phonetxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.DataContainer = new System.Windows.Forms.Panel();
            this.PersonsGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Personslbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.DataContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Deletebtn);
            this.panel1.Controls.Add(this.Updatebtn);
            this.panel1.Controls.Add(this.Savebtn);
            this.panel1.Controls.Add(this.Newbtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Emailtxt);
            this.panel1.Controls.Add(this.Phonetxt);
            this.panel1.Controls.Add(this.Nametxt);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 134);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.Searchtxt);
            this.panel3.Location = new System.Drawing.Point(358, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 62);
            this.panel3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "search..";
            // 
            // Searchtxt
            // 
            this.Searchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchtxt.Location = new System.Drawing.Point(65, 22);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(246, 22);
            this.Searchtxt.TabIndex = 0;
            this.Searchtxt.TextChanged += new System.EventHandler(this.Searchtxt_TextChanged);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Deletebtn.ForeColor = System.Drawing.Color.Firebrick;
            this.Deletebtn.Location = new System.Drawing.Point(617, 93);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(72, 23);
            this.Deletebtn.TabIndex = 9;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Updatebtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.Updatebtn.Location = new System.Drawing.Point(537, 93);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(72, 23);
            this.Updatebtn.TabIndex = 8;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Savebtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.Savebtn.Location = new System.Drawing.Point(444, 95);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(87, 23);
            this.Savebtn.TabIndex = 7;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Newbtn
            // 
            this.Newbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Newbtn.ForeColor = System.Drawing.Color.Coral;
            this.Newbtn.Location = new System.Drawing.Point(358, 95);
            this.Newbtn.Name = "Newbtn";
            this.Newbtn.Size = new System.Drawing.Size(80, 23);
            this.Newbtn.TabIndex = 6;
            this.Newbtn.Text = "New";
            this.Newbtn.UseVisualStyleBackColor = true;
            this.Newbtn.Click += new System.EventHandler(this.Newbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // Emailtxt
            // 
            this.Emailtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Emailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emailtxt.Location = new System.Drawing.Point(66, 91);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(273, 26);
            this.Emailtxt.TabIndex = 2;
            // 
            // Phonetxt
            // 
            this.Phonetxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Phonetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phonetxt.Location = new System.Drawing.Point(66, 56);
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.Size = new System.Drawing.Size(273, 26);
            this.Phonetxt.TabIndex = 1;
            // 
            // Nametxt
            // 
            this.Nametxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nametxt.Location = new System.Drawing.Point(66, 23);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(273, 26);
            this.Nametxt.TabIndex = 0;
            // 
            // DataContainer
            // 
            this.DataContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataContainer.Controls.Add(this.PersonsGrid);
            this.DataContainer.Location = new System.Drawing.Point(12, 183);
            this.DataContainer.Name = "DataContainer";
            this.DataContainer.Size = new System.Drawing.Size(723, 255);
            this.DataContainer.TabIndex = 1;
            // 
            // PersonsGrid
            // 
            this.PersonsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PersonsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PersonsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonsGrid.Location = new System.Drawing.Point(0, 0);
            this.PersonsGrid.MultiSelect = false;
            this.PersonsGrid.Name = "PersonsGrid";
            this.PersonsGrid.ReadOnly = true;
            this.PersonsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PersonsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PersonsGrid.Size = new System.Drawing.Size(719, 251);
            this.PersonsGrid.TabIndex = 0;
            this.PersonsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HandleSelectedCell);
            this.PersonsGrid.SelectionChanged += new System.EventHandler(this.HandlePersonSelected);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(587, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Contacts:";
            // 
            // Personslbl
            // 
            this.Personslbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Personslbl.AutoSize = true;
            this.Personslbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Personslbl.Location = new System.Drawing.Point(712, 157);
            this.Personslbl.Name = "Personslbl";
            this.Personslbl.Size = new System.Drawing.Size(21, 22);
            this.Personslbl.TabIndex = 3;
            this.Personslbl.Text = "0";
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.Personslbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DataContainer);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(763, 489);
            this.Name = "HomeScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Contact Book";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.DataContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PersonsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel DataContainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.TextBox Phonetxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.DataGridView PersonsGrid;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Newbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Personslbl;
    }
}

