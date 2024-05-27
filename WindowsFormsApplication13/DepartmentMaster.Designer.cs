namespace WindowsFormsApplication13
{
    partial class DepartmentMaster
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
            this.label3 = new System.Windows.Forms.Label();
            this.deptTxt = new System.Windows.Forms.TextBox();
            this.DescriptionTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.deptIdTxt = new System.Windows.Forms.TextBox();
            this.main = new System.Windows.Forms.Panel();
            this.DepartmentGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.main.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department Master";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // deptTxt
            // 
            this.deptTxt.Location = new System.Drawing.Point(214, 45);
            this.deptTxt.Name = "deptTxt";
            this.deptTxt.Size = new System.Drawing.Size(278, 20);
            this.deptTxt.TabIndex = 3;
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.Location = new System.Drawing.Point(214, 85);
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.Size = new System.Drawing.Size(278, 20);
            this.DescriptionTxt.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartmentGV,
            this.descriptionGV,
            this.id,
            this.deleteGV});
            this.dataGridView1.Location = new System.Drawing.Point(135, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(418, 222);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(28, 128);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(260, 128);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // deptIdTxt
            // 
            this.deptIdTxt.Location = new System.Drawing.Point(511, 45);
            this.deptIdTxt.Name = "deptIdTxt";
            this.deptIdTxt.Size = new System.Drawing.Size(46, 20);
            this.deptIdTxt.TabIndex = 8;
            // 
            // main
            // 
            this.main.Controls.Add(this.label1);
            this.main.Controls.Add(this.deptIdTxt);
            this.main.Controls.Add(this.label2);
            this.main.Controls.Add(this.clearBtn);
            this.main.Controls.Add(this.deptTxt);
            this.main.Controls.Add(this.saveBtn);
            this.main.Controls.Add(this.label3);
            this.main.Controls.Add(this.DescriptionTxt);
            this.main.Location = new System.Drawing.Point(80, 12);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(570, 178);
            this.main.TabIndex = 9;
            // 
            // DepartmentGV
            // 
            this.DepartmentGV.DataPropertyName = "u_deptName";
            this.DepartmentGV.HeaderText = "Department Name";
            this.DepartmentGV.Name = "DepartmentGV";
            this.DepartmentGV.ReadOnly = true;
            this.DepartmentGV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // descriptionGV
            // 
            this.descriptionGV.DataPropertyName = "u_description";
            this.descriptionGV.HeaderText = "Description";
            this.descriptionGV.Name = "descriptionGV";
            this.descriptionGV.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "u_id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // deleteGV
            // 
            this.deleteGV.HeaderText = "Delete";
            this.deleteGV.Name = "deleteGV";
            this.deleteGV.ReadOnly = true;
            this.deleteGV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteGV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DepartmentMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 466);
            this.Controls.Add(this.main);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DepartmentMaster";
            this.Text = "DepartmentMaster";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deptTxt;
        private System.Windows.Forms.TextBox DescriptionTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox deptIdTxt;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
    }
}