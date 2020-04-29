namespace WindowsFormsApp3
{
    partial class Nav
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
            this.lbldeex = new System.Windows.Forms.Label();
            this.lblupex = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.Lblinsert = new System.Windows.Forms.Label();
            this.lblshowtime = new System.Windows.Forms.Label();
            this.dgvstation = new System.Windows.Forms.DataGridView();
            this.one = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.two = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btntdelete = new System.Windows.Forms.Button();
            this.btntupdate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btntsave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstation)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbldeex);
            this.panel1.Controls.Add(this.lblupex);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.Lblinsert);
            this.panel1.Controls.Add(this.lblshowtime);
            this.panel1.Controls.Add(this.dgvstation);
            this.panel1.Controls.Add(this.btntdelete);
            this.panel1.Controls.Add(this.btntupdate);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btntsave);
            this.panel1.Location = new System.Drawing.Point(19, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 433);
            this.panel1.TabIndex = 1;
            // 
            // lbldeex
            // 
            this.lbldeex.AutoSize = true;
            this.lbldeex.Location = new System.Drawing.Point(63, 325);
            this.lbldeex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldeex.Name = "lbldeex";
            this.lbldeex.Size = new System.Drawing.Size(64, 17);
            this.lbldeex.TabIndex = 10;
            this.lbldeex.Text = "DeleteEx";
            // 
            // lblupex
            // 
            this.lblupex.AutoSize = true;
            this.lblupex.Location = new System.Drawing.Point(63, 281);
            this.lblupex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblupex.Name = "lblupex";
            this.lblupex.Size = new System.Drawing.Size(69, 17);
            this.lblupex.TabIndex = 9;
            this.lblupex.Text = "UpdateEx";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(401, 42);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(268, 42);
            this.txtid.TabIndex = 8;
            // 
            // Lblinsert
            // 
            this.Lblinsert.AutoSize = true;
            this.Lblinsert.Location = new System.Drawing.Point(63, 241);
            this.Lblinsert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lblinsert.Name = "Lblinsert";
            this.Lblinsert.Size = new System.Drawing.Size(58, 17);
            this.Lblinsert.TabIndex = 7;
            this.Lblinsert.Text = "InsertEx";
            // 
            // lblshowtime
            // 
            this.lblshowtime.AutoSize = true;
            this.lblshowtime.Location = new System.Drawing.Point(63, 203);
            this.lblshowtime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblshowtime.Name = "lblshowtime";
            this.lblshowtime.Size = new System.Drawing.Size(85, 17);
            this.lblshowtime.TabIndex = 6;
            this.lblshowtime.Text = "lblshowTime";
            // 
            // dgvstation
            // 
            this.dgvstation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.one,
            this.two});
            this.dgvstation.Location = new System.Drawing.Point(701, 18);
            this.dgvstation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvstation.Name = "dgvstation";
            this.dgvstation.RowHeadersWidth = 51;
            this.dgvstation.Size = new System.Drawing.Size(390, 411);
            this.dgvstation.TabIndex = 5;
            this.dgvstation.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvstation_CellMouseClick);
            // 
            // one
            // 
            this.one.HeaderText = "Id";
            this.one.MinimumWidth = 6;
            this.one.Name = "one";
            this.one.Width = 125;
            // 
            // two
            // 
            this.two.HeaderText = "Station Name";
            this.two.MinimumWidth = 6;
            this.two.Name = "two";
            this.two.Width = 125;
            // 
            // btntdelete
            // 
            this.btntdelete.Location = new System.Drawing.Point(437, 106);
            this.btntdelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntdelete.Name = "btntdelete";
            this.btntdelete.Size = new System.Drawing.Size(188, 47);
            this.btntdelete.TabIndex = 4;
            this.btntdelete.Text = "Delete";
            this.btntdelete.UseVisualStyleBackColor = true;
            this.btntdelete.Click += new System.EventHandler(this.btntdelete_Click);
            // 
            // btntupdate
            // 
            this.btntupdate.Location = new System.Drawing.Point(225, 106);
            this.btntupdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntupdate.Name = "btntupdate";
            this.btntupdate.Size = new System.Drawing.Size(188, 47);
            this.btntupdate.TabIndex = 3;
            this.btntupdate.Text = "Update";
            this.btntupdate.UseVisualStyleBackColor = true;
            this.btntupdate.Click += new System.EventHandler(this.btntupdate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 42);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 42);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Train Station";
            // 
            // btntsave
            // 
            this.btntsave.Location = new System.Drawing.Point(15, 106);
            this.btntsave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntsave.Name = "btntsave";
            this.btntsave.Size = new System.Drawing.Size(188, 47);
            this.btntsave.TabIndex = 0;
            this.btntsave.Text = "Insert";
            this.btntsave.UseVisualStyleBackColor = true;
            this.btntsave.Click += new System.EventHandler(this.btntsave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(483, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "Insert/Update/Delete Stations";
            // 
            // Nav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 534);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Nav";
            this.Text = "Nav";
            this.Load += new System.EventHandler(this.Nav_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btntdelete;
        private System.Windows.Forms.Button btntupdate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntsave;
        private System.Windows.Forms.DataGridView dgvstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn one;
        private System.Windows.Forms.DataGridViewTextBoxColumn two;
        private System.Windows.Forms.Label lblshowtime;
        private System.Windows.Forms.Label Lblinsert;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblupex;
        private System.Windows.Forms.Label lbldeex;
        private System.Windows.Forms.Label label4;
    }
}