namespace WindowsFormsApp3
{
    partial class Form11
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.cmbValues = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.showLbl = new System.Windows.Forms.Label();
            this.btntrainstation = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnmincon = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(467, 34);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 17);
            this.outputLabel.TabIndex = 1;
            // 
            // cmbValues
            // 
            this.cmbValues.FormattingEnabled = true;
            this.cmbValues.Location = new System.Drawing.Point(20, 74);
            this.cmbValues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbValues.Name = "cmbValues";
            this.cmbValues.Size = new System.Drawing.Size(397, 24);
            this.cmbValues.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(20, 115);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(144, 44);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Find";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vertex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Distances";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Path";
            // 
            // showLbl
            // 
            this.showLbl.AutoSize = true;
            this.showLbl.Location = new System.Drawing.Point(116, 244);
            this.showLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showLbl.Name = "showLbl";
            this.showLbl.Size = new System.Drawing.Size(0, 17);
            this.showLbl.TabIndex = 7;
            // 
            // btntrainstation
            // 
            this.btntrainstation.Location = new System.Drawing.Point(784, 76);
            this.btntrainstation.Margin = new System.Windows.Forms.Padding(4);
            this.btntrainstation.Name = "btntrainstation";
            this.btntrainstation.Size = new System.Drawing.Size(155, 48);
            this.btntrainstation.TabIndex = 8;
            this.btntrainstation.Text = "Insert New Stations";
            this.btntrainstation.UseVisualStyleBackColor = true;
            this.btntrainstation.Click += new System.EventHandler(this.btntrainstation_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(784, 132);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Insert New Distances";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnmincon
            // 
            this.btnmincon.Location = new System.Drawing.Point(784, 195);
            this.btnmincon.Margin = new System.Windows.Forms.Padding(4);
            this.btnmincon.Name = "btnmincon";
            this.btnmincon.Size = new System.Drawing.Size(155, 48);
            this.btnmincon.TabIndex = 10;
            this.btnmincon.Text = "Minimum Conecters";
            this.btnmincon.UseVisualStyleBackColor = true;
            this.btnmincon.Click += new System.EventHandler(this.btnmincon_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(550, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Find Shortest Path and Distances";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(216, 115);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 44);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(964, 535);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnmincon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btntrainstation);
            this.Controls.Add(this.showLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmbValues);
            this.Controls.Add(this.outputLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form11";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.ComboBox cmbValues;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label showLbl;
        private System.Windows.Forms.Button btntrainstation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnmincon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRefresh;
    }
}

