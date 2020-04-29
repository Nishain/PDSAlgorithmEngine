namespace TrainStation
{
    partial class AddDesetance
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
            this.loc1 = new System.Windows.Forms.ComboBox();
            this.Loc2 = new System.Windows.Forms.ComboBox();
            this.Text_distance = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Add_All = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loc1
            // 
            this.loc1.FormattingEnabled = true;
            this.loc1.Location = new System.Drawing.Point(96, 50);
            this.loc1.Name = "loc1";
            this.loc1.Size = new System.Drawing.Size(169, 21);
            this.loc1.TabIndex = 0;
            // 
            // Loc2
            // 
            this.Loc2.FormattingEnabled = true;
            this.Loc2.Location = new System.Drawing.Point(460, 50);
            this.Loc2.Name = "Loc2";
            this.Loc2.Size = new System.Drawing.Size(169, 21);
            this.Loc2.TabIndex = 1;
            // 
            // Text_distance
            // 
            this.Text_distance.Location = new System.Drawing.Point(236, 134);
            this.Text_distance.Name = "Text_distance";
            this.Text_distance.Size = new System.Drawing.Size(272, 20);
            this.Text_distance.TabIndex = 2;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(168, 195);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Add_All
            // 
            this.Add_All.Location = new System.Drawing.Point(262, 195);
            this.Add_All.Name = "Add_All";
            this.Add_All.Size = new System.Drawing.Size(75, 23);
            this.Add_All.TabIndex = 4;
            this.Add_All.Text = "Add All";
            this.Add_All.UseVisualStyleBackColor = true;
            this.Add_All.Click += new System.EventHandler(this.Add_All_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(360, 195);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(570, 95);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 13);
            this.lbl_result.TabIndex = 7;
            // 
            // AddDesetance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Add_All);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Text_distance);
            this.Controls.Add(this.Loc2);
            this.Controls.Add(this.loc1);
            this.Name = "AddDesetance";
            this.Text = "AddDesetance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox loc1;
        private System.Windows.Forms.ComboBox Loc2;
        private System.Windows.Forms.TextBox Text_distance;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Add_All;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_result;
    }
}