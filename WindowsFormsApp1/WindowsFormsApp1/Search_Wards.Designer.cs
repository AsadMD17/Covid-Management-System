namespace WindowsFormsApp1
{
    partial class Search_Wards
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.IntegralHeight = false;
            this.comboBox4.Items.AddRange(new object[] {
            "Karachi",
            "Lahore",
            "Faisalabad",
            "Serai",
            "Rawalpindi",
            "Multan",
            "Gujranwala",
            "Hyderabad City",
            "Peshawar",
            "Abbottabad",
            "Islamabad",
            "Quetta",
            "Bannu",
            "Bahawalpur",
            "Sargodha",
            "Sialkot City",
            "Sukkur",
            "Larkana",
            "Sheikhupura",
            "Mīrpur Khas",
            "Rahīmyar Khan",
            "Kohat",
            "Jhang Sadr",
            "Gujrat",
            "Bardar",
            "Kasūr",
            "Dera Ghazi Khan",
            "Masīwala",
            "Nawabshah",
            "Okara",
            "Gilgit",
            "Chiniot",
            "Sadiqabad",
            "Turbat",
            "Dera Ismaīl Khan",
            "Chaman",
            "Zhob",
            "Mehra",
            "Parachinar",
            "Gwadar",
            "Kundian",
            "Shahdad Kot",
            "Harīpur",
            "Matiari",
            "Dera Allahyar",
            "Lodhran",
            "Batgram",
            "Thatta",
            "Bagh",
            "Badīn",
            "Mansehra",
            "Ziarat",
            "Muzaffargarh",
            "Tando Allahyar",
            "Dera Murad Jamali",
            "Karak",
            "Mardan",
            "Uthal",
            "Nankana Sahib",
            "Barkhan",
            "Hafizabad",
            "Kotli",
            "Loralai",
            "Dera Bugti",
            "Jhang City",
            "Sahīwal",
            "Sanghar",
            "Pakpattan",
            "Chakwal",
            "Khushab",
            "Ghotki",
            "Kohlu",
            "Khuzdar",
            "Awaran",
            "Nowshera",
            "Charsadda",
            "Qila Abdullah",
            "Bahawalnagar",
            "Dadu",
            "Alīabad",
            "Lakki Marwat",
            "Chilas",
            "Pishin",
            "Tank",
            "Chitral",
            "Qila Saifullah",
            "Shikarpur",
            "Panjgūr",
            "Mastung",
            "Kalat",
            "Gandava",
            "Khanewal",
            "Narowal",
            "Khairpur",
            "Malakand",
            "Vihari",
            "Saidu Sharif",
            "Jhelum",
            "Mandi Bahauddīn",
            "Bhakkar",
            "Toba Tek Singh",
            "Jamshoro",
            "Kharan",
            "Umarkot",
            "Hangu",
            "Timargara",
            "Gakuch",
            "Jacobabad",
            "Alpūrai",
            "Mianwali",
            "Mūsa Khel Bazar",
            "Naushahro Fīroz",
            "New Mīrpur",
            "Daggar",
            "Eidgah",
            "Sibi",
            "Dalbandīn",
            "Rajanpur",
            "Leiah",
            "Upper Dir",
            "Tando Muhammad Khan",
            "Attock City",
            "Rawala Kot",
            "Swabi",
            "Kandhkot",
            "Dasu",
            "Athmuqam"});
            this.comboBox4.Location = new System.Drawing.Point(163, 129);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(202, 21);
            this.comboBox4.TabIndex = 59;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(792, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 58;
            this.button2.Text = "Clear ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(287, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 19);
            this.label3.TabIndex = 57;
            this.label3.Text = "Select atleast one field to search the ward record!";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(841, 329);
            this.dataGridView1.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 38);
            this.button1.TabIndex = 55;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 53;
            this.label2.Text = "Ward ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(44, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 21);
            this.label15.TabIndex = 52;
            this.label15.Text = "Region/City";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 61;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "Isolation",
            "Quarantine"});
            this.comboBox1.Location = new System.Drawing.Point(592, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 21);
            this.comboBox1.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 62;
            this.label1.Text = "Type";
            // 
            // Search_Wards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label15);
            this.Name = "Search_Wards";
            this.Size = new System.Drawing.Size(894, 588);
            this.Load += new System.EventHandler(this.Search_Wards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}
