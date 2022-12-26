namespace FinalProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Empname = new System.Windows.Forms.TextBox();
            this.emptype = new System.Windows.Forms.TextBox();
            this.empdepart = new System.Windows.Forms.TextBox();
            this.empphno = new System.Windows.Forms.TextBox();
            this.empadress = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbByPhno = new System.Windows.Forms.RadioButton();
            this.Search = new System.Windows.Forms.Button();
            this.rbByType = new System.Windows.Forms.RadioButton();
            this.rbByName = new System.Windows.Forms.RadioButton();
            this.rbByAdress = new System.Windows.Forms.RadioButton();
            this.rbByDepart = new System.Windows.Forms.RadioButton();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.SearchRecord = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emp_Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(510, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emp_Type";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(53, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Emp_Depart";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(53, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Emp_Phno";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(510, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Emp_Adress";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // Empname
            // 
            this.Empname.Location = new System.Drawing.Point(231, 51);
            this.Empname.Name = "Empname";
            this.Empname.Size = new System.Drawing.Size(180, 27);
            this.Empname.TabIndex = 2;
            this.Empname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // emptype
            // 
            this.emptype.Location = new System.Drawing.Point(663, 53);
            this.emptype.Name = "emptype";
            this.emptype.Size = new System.Drawing.Size(187, 27);
            this.emptype.TabIndex = 2;
            this.emptype.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // empdepart
            // 
            this.empdepart.Location = new System.Drawing.Point(231, 102);
            this.empdepart.Name = "empdepart";
            this.empdepart.Size = new System.Drawing.Size(180, 27);
            this.empdepart.TabIndex = 2;
            this.empdepart.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // empphno
            // 
            this.empphno.Location = new System.Drawing.Point(231, 153);
            this.empphno.Name = "empphno";
            this.empphno.Size = new System.Drawing.Size(180, 27);
            this.empphno.TabIndex = 2;
            this.empphno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // empadress
            // 
            this.empadress.Location = new System.Drawing.Point(663, 102);
            this.empadress.Name = "empadress";
            this.empadress.Size = new System.Drawing.Size(187, 27);
            this.empadress.TabIndex = 2;
            this.empadress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(850, 193);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(991, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(949, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(949, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(949, 107);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 29);
            this.button5.TabIndex = 4;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(53, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Emp_Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbByPhno);
            this.groupBox2.Controls.Add(this.Search);
            this.groupBox2.Controls.Add(this.rbByType);
            this.groupBox2.Controls.Add(this.rbByName);
            this.groupBox2.Controls.Add(this.rbByAdress);
            this.groupBox2.Controls.Add(this.rbByDepart);
            this.groupBox2.Controls.Add(this.searchbox);
            this.groupBox2.Controls.Add(this.SearchRecord);
            this.groupBox2.Location = new System.Drawing.Point(35, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(850, 125);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SearchBox";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // rbByPhno
            // 
            this.rbByPhno.AutoSize = true;
            this.rbByPhno.Location = new System.Drawing.Point(539, 25);
            this.rbByPhno.Name = "rbByPhno";
            this.rbByPhno.Size = new System.Drawing.Size(83, 24);
            this.rbByPhno.TabIndex = 4;
            this.rbByPhno.TabStop = true;
            this.rbByPhno.Text = "By Phno";
            this.rbByPhno.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(729, 35);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(94, 29);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // rbByType
            // 
            this.rbByType.AutoSize = true;
            this.rbByType.Location = new System.Drawing.Point(386, 83);
            this.rbByType.Name = "rbByType";
            this.rbByType.Size = new System.Drawing.Size(81, 24);
            this.rbByType.TabIndex = 2;
            this.rbByType.TabStop = true;
            this.rbByType.Text = "By Type";
            this.rbByType.UseVisualStyleBackColor = true;
            // 
            // rbByName
            // 
            this.rbByName.AutoSize = true;
            this.rbByName.Checked = true;
            this.rbByName.Location = new System.Drawing.Point(386, 26);
            this.rbByName.Name = "rbByName";
            this.rbByName.Size = new System.Drawing.Size(90, 24);
            this.rbByName.TabIndex = 2;
            this.rbByName.TabStop = true;
            this.rbByName.Text = "By Name";
            this.rbByName.UseVisualStyleBackColor = true;
            // 
            // rbByAdress
            // 
            this.rbByAdress.AutoSize = true;
            this.rbByAdress.Location = new System.Drawing.Point(539, 56);
            this.rbByAdress.Name = "rbByAdress";
            this.rbByAdress.Size = new System.Drawing.Size(94, 24);
            this.rbByAdress.TabIndex = 2;
            this.rbByAdress.TabStop = true;
            this.rbByAdress.Text = "By Adress";
            this.rbByAdress.UseVisualStyleBackColor = true;
            // 
            // rbByDepart
            // 
            this.rbByDepart.AutoSize = true;
            this.rbByDepart.Location = new System.Drawing.Point(386, 53);
            this.rbByDepart.Name = "rbByDepart";
            this.rbByDepart.Size = new System.Drawing.Size(96, 24);
            this.rbByDepart.TabIndex = 2;
            this.rbByDepart.TabStop = true;
            this.rbByDepart.Text = "By Depart";
            this.rbByDepart.UseVisualStyleBackColor = true;
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(129, 40);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(211, 27);
            this.searchbox.TabIndex = 1;
            // 
            // SearchRecord
            // 
            this.SearchRecord.AutoSize = true;
            this.SearchRecord.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchRecord.Location = new System.Drawing.Point(0, 41);
            this.SearchRecord.Name = "SearchRecord";
            this.SearchRecord.Size = new System.Drawing.Size(114, 23);
            this.SearchRecord.TabIndex = 0;
            this.SearchRecord.Text = "SearchRecord";
            // 
            // label7
            // 
         
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 561);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.empadress);
            this.Controls.Add(this.empphno);
            this.Controls.Add(this.empdepart);
            this.Controls.Add(this.emptype);
            this.Controls.Add(this.Empname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Record";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox Empname;
        private TextBox emptype;
        private TextBox empdepart;
        private TextBox empphno;
        private TextBox empadress;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox searchbox;
        private Label SearchRecord;
        private RadioButton rbByType;
        private RadioButton rbByName;
        private RadioButton rbByAdress;
        private RadioButton rbByDepart;
        private Button Search;
        private RadioButton rbByPhno;
       
    }
}