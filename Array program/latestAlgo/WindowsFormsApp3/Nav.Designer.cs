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
            this.btnrefresh = new System.Windows.Forms.Button();
            this.lbldeex = new System.Windows.Forms.Label();
            this.lblupex = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.Lblinsert = new System.Windows.Forms.Label();
            this.lblshowtime = new System.Windows.Forms.Label();
            this.dgvstation = new System.Windows.Forms.DataGridView();
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
            this.panel1.Controls.Add(this.btnrefresh);
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
            this.panel1.Location = new System.Drawing.Point(14, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 352);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(677, 45);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(141, 25);
            this.btnrefresh.TabIndex = 11;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // lbldeex
            // 
            this.lbldeex.AutoSize = true;
            this.lbldeex.Location = new System.Drawing.Point(47, 264);
            this.lbldeex.Name = "lbldeex";
            this.lbldeex.Size = new System.Drawing.Size(50, 13);
            this.lbldeex.TabIndex = 10;
            this.lbldeex.Text = "DeleteEx";
            // 
            // lblupex
            // 
            this.lblupex.AutoSize = true;
            this.lblupex.Location = new System.Drawing.Point(47, 228);
            this.lblupex.Name = "lblupex";
            this.lblupex.Size = new System.Drawing.Size(54, 13);
            this.lblupex.TabIndex = 9;
            this.lblupex.Text = "UpdateEx";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(301, 34);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(202, 35);
            this.txtid.TabIndex = 8;
            // 
            // Lblinsert
            // 
            this.Lblinsert.AutoSize = true;
            this.Lblinsert.Location = new System.Drawing.Point(47, 196);
            this.Lblinsert.Name = "Lblinsert";
            this.Lblinsert.Size = new System.Drawing.Size(45, 13);
            this.Lblinsert.TabIndex = 7;
            this.Lblinsert.Text = "InsertEx";
            // 
            // lblshowtime
            // 
            this.lblshowtime.AutoSize = true;
            this.lblshowtime.Location = new System.Drawing.Point(47, 165);
            this.lblshowtime.Name = "lblshowtime";
            this.lblshowtime.Size = new System.Drawing.Size(65, 13);
            this.lblshowtime.TabIndex = 6;
            this.lblshowtime.Text = "lblshowTime";
            // 
            // dgvstation
            // 
            this.dgvstation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstation.Location = new System.Drawing.Point(526, 73);
            this.dgvstation.Name = "dgvstation";
            this.dgvstation.RowHeadersWidth = 51;
            this.dgvstation.Size = new System.Drawing.Size(292, 276);
            this.dgvstation.TabIndex = 5;
            this.dgvstation.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvstation_CellMouseClick);
            // 
            // btntdelete
            // 
            this.btntdelete.Location = new System.Drawing.Point(328, 86);
            this.btntdelete.Name = "btntdelete";
            this.btntdelete.Size = new System.Drawing.Size(141, 38);
            this.btntdelete.TabIndex = 4;
            this.btntdelete.Text = "Delete";
            this.btntdelete.UseVisualStyleBackColor = true;
            this.btntdelete.Click += new System.EventHandler(this.btntdelete_Click);
            // 
            // btntupdate
            // 
            this.btntupdate.Location = new System.Drawing.Point(169, 86);
            this.btntupdate.Name = "btntupdate";
            this.btntupdate.Size = new System.Drawing.Size(141, 38);
            this.btntupdate.TabIndex = 3;
            this.btntupdate.Text = "Update";
            this.btntupdate.UseVisualStyleBackColor = true;
            this.btntupdate.Click += new System.EventHandler(this.btntupdate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 35);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Train Station";
            // 
            // btntsave
            // 
            this.btntsave.Location = new System.Drawing.Point(11, 86);
            this.btntsave.Name = "btntsave";
            this.btntsave.Size = new System.Drawing.Size(141, 38);
            this.btntsave.TabIndex = 0;
            this.btntsave.Text = "Insert";
            this.btntsave.UseVisualStyleBackColor = true;
            this.btntsave.Click += new System.EventHandler(this.btntsave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Insert/Update/Delete Stations";
            // 
            // Nav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 434);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Label lblshowtime;
        private System.Windows.Forms.Label Lblinsert;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblupex;
        private System.Windows.Forms.Label lbldeex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnrefresh;
    }
}