namespace WindowsFormsApplication13
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.main = new System.Windows.Forms.Panel();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CompanyLogo = new System.Windows.Forms.PictureBox();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.GstinNum = new System.Windows.Forms.TextBox();
            this.CompanyMotoTxt = new System.Windows.Forms.TextBox();
            this.CompanyNameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gstinGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.establishedGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageGV = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.Controls.Add(this.idTxt);
            this.main.Controls.Add(this.textBox1);
            this.main.Controls.Add(this.CompanyLogo);
            this.main.Controls.Add(this.BrowseBtn);
            this.main.Controls.Add(this.ClearBtn);
            this.main.Controls.Add(this.SaveBtn);
            this.main.Controls.Add(this.dateTimePicker2);
            this.main.Controls.Add(this.GstinNum);
            this.main.Controls.Add(this.CompanyMotoTxt);
            this.main.Controls.Add(this.CompanyNameTxt);
            this.main.Controls.Add(this.label4);
            this.main.Controls.Add(this.label3);
            this.main.Controls.Add(this.label2);
            this.main.Controls.Add(this.label1);
            this.main.Location = new System.Drawing.Point(54, 30);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(708, 241);
            this.main.TabIndex = 0;
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(425, 124);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(100, 20);
            this.idTxt.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(425, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // CompanyLogo
            // 
            this.CompanyLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyLogo.Location = new System.Drawing.Point(578, 21);
            this.CompanyLogo.Name = "CompanyLogo";
            this.CompanyLogo.Size = new System.Drawing.Size(100, 133);
            this.CompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CompanyLogo.TabIndex = 13;
            this.CompanyLogo.TabStop = false;
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(589, 177);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.BrowseBtn.TabIndex = 12;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(288, 177);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 11;
            this.ClearBtn.Text = "CLEAR";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(117, 178);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "SAVE";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(264, 135);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(115, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // GstinNum
            // 
            this.GstinNum.Location = new System.Drawing.Point(264, 92);
            this.GstinNum.Name = "GstinNum";
            this.GstinNum.Size = new System.Drawing.Size(100, 20);
            this.GstinNum.TabIndex = 8;
            // 
            // CompanyMotoTxt
            // 
            this.CompanyMotoTxt.Location = new System.Drawing.Point(264, 51);
            this.CompanyMotoTxt.Name = "CompanyMotoTxt";
            this.CompanyMotoTxt.Size = new System.Drawing.Size(100, 20);
            this.CompanyMotoTxt.TabIndex = 7;
            // 
            // CompanyNameTxt
            // 
            this.CompanyNameTxt.Location = new System.Drawing.Point(264, 18);
            this.CompanyNameTxt.Name = "CompanyNameTxt";
            this.CompanyNameTxt.Size = new System.Drawing.Size(100, 20);
            this.CompanyNameTxt.TabIndex = 6;
            this.CompanyNameTxt.Click += new System.EventHandler(this.tty);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Established Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gstin Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Company Moto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Company Name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameGV,
            this.motoGV,
            this.gstinGV,
            this.establishedGV,
            this.imageGV,
            this.id,
            this.deleteGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(101, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(703, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // nameGV
            // 
            this.nameGV.DataPropertyName = "u_name";
            this.nameGV.HeaderText = "Company name";
            this.nameGV.Name = "nameGV";
            this.nameGV.ReadOnly = true;
            // 
            // motoGV
            // 
            this.motoGV.DataPropertyName = "u_moto";
            this.motoGV.HeaderText = "Company Moto";
            this.motoGV.Name = "motoGV";
            this.motoGV.ReadOnly = true;
            // 
            // gstinGV
            // 
            this.gstinGV.DataPropertyName = "u_gstin";
            this.gstinGV.HeaderText = "Company Gstin";
            this.gstinGV.Name = "gstinGV";
            this.gstinGV.ReadOnly = true;
            // 
            // establishedGV
            // 
            this.establishedGV.DataPropertyName = "u_established";
            this.establishedGV.HeaderText = "Established Year";
            this.establishedGV.Name = "establishedGV";
            this.establishedGV.ReadOnly = true;
            // 
            // imageGV
            // 
            this.imageGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imageGV.DataPropertyName = "u_image";
            this.imageGV.HeaderText = "Company Logo";
            this.imageGV.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imageGV.Name = "imageGV";
            this.imageGV.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "u_companyID";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // deleteGV
            // 
            this.deleteGV.DataPropertyName = "u_companyID";
            this.deleteGV.HeaderText = "Delete";
            this.deleteGV.Name = "deleteGV";
            this.deleteGV.ReadOnly = true;
            this.deleteGV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteGV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deleteGV.Text = "Delete";
            this.deleteGV.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 497);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.PictureBox CompanyLogo;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox GstinNum;
        private System.Windows.Forms.TextBox CompanyMotoTxt;
        private System.Windows.Forms.TextBox CompanyNameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn motoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn gstinGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn establishedGV;
        private System.Windows.Forms.DataGridViewImageColumn imageGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
    }
}

