namespace WindowsFormsApp1
{
    partial class Search_Region
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
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(792, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 50;
            this.button2.Text = "Clear ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(287, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 19);
            this.label3.TabIndex = 49;
            this.label3.Text = "Select atleast one field to search the region record!";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(134, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(626, 329);
            this.dataGridView1.TabIndex = 48;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 38);
            this.button1.TabIndex = 47;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "Region/City";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownHeight = 120;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
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
            "Mirpur Khas",
            "Rahimyar Khan",
            "Kohat",
            "Jhang Sadr",
            "Gujrat",
            "Bardar",
            "Kasur",
            "Dera Ghazi Khan",
            "Masiwala",
            "Nawabshah",
            "Okara",
            "Gilgit",
            "Chiniot",
            "Sadiqabad",
            "Turbat",
            "Dera Ismail Khan",
            "Chaman",
            "Zhob",
            "Mehra",
            "Parachinar",
            "Gwadar",
            "Kundian",
            "Shahdad Kot",
            "Haripur",
            "Matiari",
            "Dera Allahyar",
            "Lodhran",
            "Batgram",
            "Thatta",
            "Bagh",
            "Badin",
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
            "Sahiwal",
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
            "Aliabad",
            "Lakki Marwat",
            "Chilas",
            "Pishin",
            "Tank",
            "Chitral",
            "Qila Saifullah",
            "Shikarpur",
            "Panjgur",
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
            "Mandi Bahauddin",
            "Bhakkar",
            "Toba Tek Singh",
            "Jamshoro",
            "Kharan",
            "Umarkot",
            "Hangu",
            "Timargara",
            "Gakuch",
            "Jacobabad",
            "Alpurai",
            "Mianwali",
            "Musa Khel Bazar",
            "Naushahro Firoz",
            "New Mirpur",
            "Daggar",
            "Eidgah",
            "Sibi",
            "Dalbandin",
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
            this.comboBox1.Location = new System.Drawing.Point(352, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(305, 21);
            this.comboBox1.TabIndex = 51;
            // 
            // Search_Region
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Name = "Search_Region";
            this.Size = new System.Drawing.Size(894, 588);
            this.Load += new System.EventHandler(this.Search_Region_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
