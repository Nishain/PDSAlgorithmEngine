namespace WindowsFormsApp3
{
    partial class Distances
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbs1 = new System.Windows.Forms.ComboBox();
            this.cmbs2 = new System.Windows.Forms.ComboBox();
            this.dgvdistances = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdistance = new System.Windows.Forms.TextBox();
            this.lblLoadEx = new System.Windows.Forms.Label();
            this.lblInsert = new System.Windows.Forms.Label();
            this.lblUp = new System.Windows.Forms.Label();
            this.txtdeleteid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbldeleteex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdistances)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Station 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Station 2";
            // 
            // cmbs1
            // 
            this.cmbs1.FormattingEnabled = true;
            this.cmbs1.Location = new System.Drawing.Point(89, 55);
            this.cmbs1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbs1.Name = "cmbs1";
            this.cmbs1.Size = new System.Drawing.Size(160, 24);
            this.cmbs1.TabIndex = 2;
            // 
            // cmbs2
            // 
            this.cmbs2.FormattingEnabled = true;
            this.cmbs2.Location = new System.Drawing.Point(353, 55);
            this.cmbs2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbs2.Name = "cmbs2";
            this.cmbs2.Size = new System.Drawing.Size(160, 24);
            this.cmbs2.TabIndex = 3;
            // 
            // dgvdistances
            // 
            this.dgvdistances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdistances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvdistances.Location = new System.Drawing.Point(65, 284);
            this.dgvdistances.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvdistances.Name = "dgvdistances";
            this.dgvdistances.RowHeadersWidth = 51;
            this.dgvdistances.Size = new System.Drawing.Size(587, 229);
            this.dgvdistances.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "station1";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "station2";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "distance";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(65, 135);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 43);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Insert";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(212, 135);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 43);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(201, 42);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Distance";
            // 
            // txtdistance
            // 
            this.txtdistance.Location = new System.Drawing.Point(632, 58);
            this.txtdistance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdistance.Name = "txtdistance";
            this.txtdistance.Size = new System.Drawing.Size(147, 22);
            this.txtdistance.TabIndex = 9;
            // 
            // lblLoadEx
            // 
            this.lblLoadEx.AutoSize = true;
            this.lblLoadEx.Location = new System.Drawing.Point(660, 284);
            this.lblLoadEx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoadEx.Name = "lblLoadEx";
            this.lblLoadEx.Size = new System.Drawing.Size(55, 17);
            this.lblLoadEx.TabIndex = 10;
            this.lblLoadEx.Text = "LoadEx";
            // 
            // lblInsert
            // 
            this.lblInsert.AutoSize = true;
            this.lblInsert.Location = new System.Drawing.Point(660, 322);
            this.lblInsert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInsert.Name = "lblInsert";
            this.lblInsert.Size = new System.Drawing.Size(58, 17);
            this.lblInsert.TabIndex = 11;
            this.lblInsert.Text = "InsertEx";
            // 
            // lblUp
            // 
            this.lblUp.AutoSize = true;
            this.lblUp.Location = new System.Drawing.Point(660, 360);
            this.lblUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(69, 17);
            this.lblUp.TabIndex = 12;
            this.lblUp.Text = "UpdateEx";
            // 
            // txtdeleteid
            // 
            this.txtdeleteid.Location = new System.Drawing.Point(52, 46);
            this.txtdeleteid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdeleteid.Name = "txtdeleteid";
            this.txtdeleteid.Size = new System.Drawing.Size(107, 22);
            this.txtdeleteid.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txtdeleteid);
            this.panel1.Location = new System.Drawing.Point(360, 110);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 87);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Delete Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Id";
            // 
            // lbldeleteex
            // 
            this.lbldeleteex.AutoSize = true;
            this.lbldeleteex.Location = new System.Drawing.Point(660, 401);
            this.lbldeleteex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldeleteex.Name = "lbldeleteex";
            this.lbldeleteex.Size = new System.Drawing.Size(64, 17);
            this.lbldeleteex.TabIndex = 15;
            this.lbldeleteex.Text = "DeleteEx";
            // 
            // Distances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 586);
            this.Controls.Add(this.lbldeleteex);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUp);
            this.Controls.Add(this.lblInsert);
            this.Controls.Add(this.lblLoadEx);
            this.Controls.Add(this.txtdistance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dgvdistances);
            this.Controls.Add(this.cmbs2);
            this.Controls.Add(this.cmbs1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Distances";
            this.Text = "Distances";
            this.Load += new System.EventHandler(this.Distances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdistances)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbs1;
        private System.Windows.Forms.ComboBox cmbs2;
        private System.Windows.Forms.DataGridView dgvdistances;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdistance;
        private System.Windows.Forms.Label lblLoadEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblInsert;
        private System.Windows.Forms.Label lblUp;
        private System.Windows.Forms.TextBox txtdeleteid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbldeleteex;
    }
}