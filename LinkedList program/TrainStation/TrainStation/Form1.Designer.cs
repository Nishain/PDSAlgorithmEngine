namespace TrainStation
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.addall = new System.Windows.Forms.Button();
            this.btn_updateall = new System.Windows.Forms.Button();
            this.txt_stationsearch = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_deleteall = new System.Windows.Forms.Button();
            this.btn_search_sortest = new System.Windows.Forms.Button();
            this.Add_All = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Text_distance = new System.Windows.Forms.TextBox();
            this.Loc2 = new System.Windows.Forms.ComboBox();
            this.loc1 = new System.Windows.Forms.ComboBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.lbl_distance = new System.Windows.Forms.Label();
            this.btn_distance_deleteall = new System.Windows.Forms.Button();
            this.btn_distance_delete = new System.Windows.Forms.Button();
            this.btn_update_distanceall = new System.Windows.Forms.Button();
            this.btn_update_distance = new System.Windows.Forms.Button();
            this.lbl_distance_search = new System.Windows.Forms.Label();
            this.btn_distance_search = new System.Windows.Forms.Button();
            this.txt_distance_search = new System.Windows.Forms.TextBox();
            this.lbl_shortestpath = new System.Windows.Forms.Label();
            this.loc3 = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_time = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addall
            // 
            this.addall.Location = new System.Drawing.Point(54, 128);
            this.addall.Name = "addall";
            this.addall.Size = new System.Drawing.Size(75, 23);
            this.addall.TabIndex = 2;
            this.addall.Text = "Add All";
            this.addall.UseVisualStyleBackColor = true;
            this.addall.Click += new System.EventHandler(this.addall_Click);
            // 
            // btn_updateall
            // 
            this.btn_updateall.Location = new System.Drawing.Point(146, 128);
            this.btn_updateall.Name = "btn_updateall";
            this.btn_updateall.Size = new System.Drawing.Size(75, 23);
            this.btn_updateall.TabIndex = 5;
            this.btn_updateall.Text = "Update All";
            this.btn_updateall.UseVisualStyleBackColor = true;
            this.btn_updateall.Click += new System.EventHandler(this.btn_updateall_Click);
            // 
            // txt_stationsearch
            // 
            this.txt_stationsearch.Location = new System.Drawing.Point(54, 33);
            this.txt_stationsearch.Name = "txt_stationsearch";
            this.txt_stationsearch.Size = new System.Drawing.Size(263, 20);
            this.txt_stationsearch.TabIndex = 6;
            this.txt_stationsearch.TextChanged += new System.EventHandler(this.txt_stationsearch_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(323, 30);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 7;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_deleteall
            // 
            this.btn_deleteall.Location = new System.Drawing.Point(233, 128);
            this.btn_deleteall.Name = "btn_deleteall";
            this.btn_deleteall.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteall.TabIndex = 9;
            this.btn_deleteall.Text = "Delete All";
            this.btn_deleteall.UseVisualStyleBackColor = true;
            this.btn_deleteall.Click += new System.EventHandler(this.btn_deleteall_Click);
            // 
            // btn_search_sortest
            // 
            this.btn_search_sortest.Location = new System.Drawing.Point(233, 228);
            this.btn_search_sortest.Name = "btn_search_sortest";
            this.btn_search_sortest.Size = new System.Drawing.Size(75, 23);
            this.btn_search_sortest.TabIndex = 15;
            this.btn_search_sortest.Text = "search";
            this.btn_search_sortest.UseVisualStyleBackColor = true;
            this.btn_search_sortest.Click += new System.EventHandler(this.btn_search_sortest_Click);
            // 
            // Add_All
            // 
            this.Add_All.Location = new System.Drawing.Point(478, 150);
            this.Add_All.Name = "Add_All";
            this.Add_All.Size = new System.Drawing.Size(75, 23);
            this.Add_All.TabIndex = 14;
            this.Add_All.Text = "Add All";
            this.Add_All.UseVisualStyleBackColor = true;
            this.Add_All.Click += new System.EventHandler(this.Add_All_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(478, 121);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 13;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Text_distance
            // 
            this.Text_distance.Location = new System.Drawing.Point(478, 89);
            this.Text_distance.Name = "Text_distance";
            this.Text_distance.Size = new System.Drawing.Size(377, 20);
            this.Text_distance.TabIndex = 12;
            this.Text_distance.TextChanged += new System.EventHandler(this.Text_distance_TextChanged);
            // 
            // Loc2
            // 
            this.Loc2.FormattingEnabled = true;
            this.Loc2.Location = new System.Drawing.Point(686, 60);
            this.Loc2.Name = "Loc2";
            this.Loc2.Size = new System.Drawing.Size(169, 21);
            this.Loc2.TabIndex = 11;
            // 
            // loc1
            // 
            this.loc1.FormattingEnabled = true;
            this.loc1.Location = new System.Drawing.Point(478, 59);
            this.loc1.Name = "loc1";
            this.loc1.Size = new System.Drawing.Size(169, 21);
            this.loc1.TabIndex = 10;
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(7, 35);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(41, 13);
            this.lbl_search.TabIndex = 16;
            this.lbl_search.Text = "Search";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(7, 59);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 17;
            this.lbl_name.Text = "Name";
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Location = new System.Drawing.Point(440, 62);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(30, 13);
            this.lbl_from.TabIndex = 18;
            this.lbl_from.Text = "From";
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Location = new System.Drawing.Point(659, 63);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(20, 13);
            this.lbl_to.TabIndex = 19;
            this.lbl_to.Text = "To";
            // 
            // lbl_distance
            // 
            this.lbl_distance.AutoSize = true;
            this.lbl_distance.Location = new System.Drawing.Point(424, 92);
            this.lbl_distance.Name = "lbl_distance";
            this.lbl_distance.Size = new System.Drawing.Size(49, 13);
            this.lbl_distance.TabIndex = 20;
            this.lbl_distance.Text = "Distance";
            // 
            // btn_distance_deleteall
            // 
            this.btn_distance_deleteall.Location = new System.Drawing.Point(659, 150);
            this.btn_distance_deleteall.Name = "btn_distance_deleteall";
            this.btn_distance_deleteall.Size = new System.Drawing.Size(75, 23);
            this.btn_distance_deleteall.TabIndex = 24;
            this.btn_distance_deleteall.Text = "Delete All";
            this.btn_distance_deleteall.UseVisualStyleBackColor = true;
            this.btn_distance_deleteall.Click += new System.EventHandler(this.btn_distance_deleteall_Click);
            // 
            // btn_distance_delete
            // 
            this.btn_distance_delete.Location = new System.Drawing.Point(659, 121);
            this.btn_distance_delete.Name = "btn_distance_delete";
            this.btn_distance_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_distance_delete.TabIndex = 23;
            this.btn_distance_delete.Text = "Delete";
            this.btn_distance_delete.UseVisualStyleBackColor = true;
            this.btn_distance_delete.Click += new System.EventHandler(this.btn_distance_delete_Click);
            // 
            // btn_update_distanceall
            // 
            this.btn_update_distanceall.Location = new System.Drawing.Point(572, 150);
            this.btn_update_distanceall.Name = "btn_update_distanceall";
            this.btn_update_distanceall.Size = new System.Drawing.Size(75, 23);
            this.btn_update_distanceall.TabIndex = 22;
            this.btn_update_distanceall.Text = "Update All";
            this.btn_update_distanceall.UseVisualStyleBackColor = true;
            this.btn_update_distanceall.Click += new System.EventHandler(this.btn_update_distanceall_Click);
            // 
            // btn_update_distance
            // 
            this.btn_update_distance.Location = new System.Drawing.Point(572, 121);
            this.btn_update_distance.Name = "btn_update_distance";
            this.btn_update_distance.Size = new System.Drawing.Size(75, 23);
            this.btn_update_distance.TabIndex = 21;
            this.btn_update_distance.Text = "Update";
            this.btn_update_distance.UseVisualStyleBackColor = true;
            this.btn_update_distance.Click += new System.EventHandler(this.btn_update_distance_Click);
            // 
            // lbl_distance_search
            // 
            this.lbl_distance_search.AutoSize = true;
            this.lbl_distance_search.Location = new System.Drawing.Point(431, 31);
            this.lbl_distance_search.Name = "lbl_distance_search";
            this.lbl_distance_search.Size = new System.Drawing.Size(41, 13);
            this.lbl_distance_search.TabIndex = 27;
            this.lbl_distance_search.Text = "Search";
            // 
            // btn_distance_search
            // 
            this.btn_distance_search.Location = new System.Drawing.Point(747, 26);
            this.btn_distance_search.Name = "btn_distance_search";
            this.btn_distance_search.Size = new System.Drawing.Size(75, 23);
            this.btn_distance_search.TabIndex = 26;
            this.btn_distance_search.Text = "Search";
            this.btn_distance_search.UseVisualStyleBackColor = true;
            this.btn_distance_search.Click += new System.EventHandler(this.btn_distance_search_Click);
            // 
            // txt_distance_search
            // 
            this.txt_distance_search.Location = new System.Drawing.Point(478, 29);
            this.txt_distance_search.Name = "txt_distance_search";
            this.txt_distance_search.Size = new System.Drawing.Size(263, 20);
            this.txt_distance_search.TabIndex = 25;
            this.txt_distance_search.TextChanged += new System.EventHandler(this.txt_distance_search_TextChanged);
            // 
            // lbl_shortestpath
            // 
            this.lbl_shortestpath.AutoSize = true;
            this.lbl_shortestpath.Location = new System.Drawing.Point(8, 233);
            this.lbl_shortestpath.Name = "lbl_shortestpath";
            this.lbl_shortestpath.Size = new System.Drawing.Size(41, 13);
            this.lbl_shortestpath.TabIndex = 29;
            this.lbl_shortestpath.Text = "Search";
            // 
            // loc3
            // 
            this.loc3.FormattingEnabled = true;
            this.loc3.Location = new System.Drawing.Point(54, 230);
            this.loc3.Name = "loc3";
            this.loc3.Size = new System.Drawing.Size(169, 21);
            this.loc3.TabIndex = 28;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(233, 99);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(146, 99);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(363, 203);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(0, 13);
            this.lbl_time.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(413, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(415, 192);
            this.dataGridView1.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "Find minimum connectors";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Train Stations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Train Distance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_shortestpath);
            this.Controls.Add(this.loc3);
            this.Controls.Add(this.lbl_distance_search);
            this.Controls.Add(this.btn_distance_search);
            this.Controls.Add(this.txt_distance_search);
            this.Controls.Add(this.btn_distance_deleteall);
            this.Controls.Add(this.btn_distance_delete);
            this.Controls.Add(this.btn_update_distanceall);
            this.Controls.Add(this.btn_update_distance);
            this.Controls.Add(this.lbl_distance);
            this.Controls.Add(this.lbl_to);
            this.Controls.Add(this.lbl_from);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.btn_search_sortest);
            this.Controls.Add(this.Add_All);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Text_distance);
            this.Controls.Add(this.Loc2);
            this.Controls.Add(this.loc1);
            this.Controls.Add(this.btn_deleteall);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_stationsearch);
            this.Controls.Add(this.btn_updateall);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.addall);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addall;
        private System.Windows.Forms.Button btn_updateall;
        private System.Windows.Forms.TextBox txt_stationsearch;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_deleteall;
        private System.Windows.Forms.Button btn_search_sortest;
        private System.Windows.Forms.Button Add_All;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox Text_distance;
        private System.Windows.Forms.ComboBox Loc2;
        private System.Windows.Forms.ComboBox loc1;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Label lbl_distance;
        private System.Windows.Forms.Button btn_distance_deleteall;
        private System.Windows.Forms.Button btn_distance_delete;
        private System.Windows.Forms.Button btn_update_distanceall;
        private System.Windows.Forms.Button btn_update_distance;
        private System.Windows.Forms.Label lbl_distance_search;
        private System.Windows.Forms.Button btn_distance_search;
        private System.Windows.Forms.TextBox txt_distance_search;
        private System.Windows.Forms.Label lbl_shortestpath;
        private System.Windows.Forms.ComboBox loc3;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

