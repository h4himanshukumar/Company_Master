namespace WindowsFormsApplication13
{
    partial class Main
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.c_masterBtn = new System.Windows.Forms.Button();
            this.c_deptBtn = new System.Windows.Forms.Button();
            this.c_registrationBtn = new System.Windows.Forms.Button();
            this.c_designationBtn = new System.Windows.Forms.Button();
            this.c_branchBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247F));
            this.tableLayoutPanel1.Controls.Add(this.c_masterBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.c_deptBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.c_registrationBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.c_designationBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.c_branchBtn, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.36675F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.63325F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(696, 409);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // c_masterBtn
            // 
            this.c_masterBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_masterBtn.FlatAppearance.BorderSize = 2;
            this.c_masterBtn.Location = new System.Drawing.Point(3, 3);
            this.c_masterBtn.Name = "c_masterBtn";
            this.c_masterBtn.Size = new System.Drawing.Size(222, 200);
            this.c_masterBtn.TabIndex = 0;
            this.c_masterBtn.Text = "Company Master";
            this.c_masterBtn.UseVisualStyleBackColor = true;
            this.c_masterBtn.Click += new System.EventHandler(this.c_masterBtn_Click);
            // 
            // c_deptBtn
            // 
            this.c_deptBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_deptBtn.FlatAppearance.BorderSize = 2;
            this.c_deptBtn.Location = new System.Drawing.Point(231, 3);
            this.c_deptBtn.Name = "c_deptBtn";
            this.c_deptBtn.Size = new System.Drawing.Size(214, 200);
            this.c_deptBtn.TabIndex = 1;
            this.c_deptBtn.Text = "Department Master";
            this.c_deptBtn.UseVisualStyleBackColor = true;
            this.c_deptBtn.Click += new System.EventHandler(this.c_deptBtn_Click);
            // 
            // c_registrationBtn
            // 
            this.c_registrationBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_registrationBtn.FlatAppearance.BorderSize = 2;
            this.c_registrationBtn.Location = new System.Drawing.Point(451, 3);
            this.c_registrationBtn.Name = "c_registrationBtn";
            this.c_registrationBtn.Size = new System.Drawing.Size(242, 200);
            this.c_registrationBtn.TabIndex = 2;
            this.c_registrationBtn.Text = "Employee Registration";
            this.c_registrationBtn.UseVisualStyleBackColor = true;
            // 
            // c_designationBtn
            // 
            this.c_designationBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_designationBtn.FlatAppearance.BorderSize = 2;
            this.c_designationBtn.Location = new System.Drawing.Point(3, 209);
            this.c_designationBtn.Name = "c_designationBtn";
            this.c_designationBtn.Size = new System.Drawing.Size(222, 197);
            this.c_designationBtn.TabIndex = 3;
            this.c_designationBtn.Text = "Designation Master";
            this.c_designationBtn.UseVisualStyleBackColor = true;
            // 
            // c_branchBtn
            // 
            this.c_branchBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_branchBtn.FlatAppearance.BorderSize = 2;
            this.c_branchBtn.Location = new System.Drawing.Point(231, 209);
            this.c_branchBtn.Name = "c_branchBtn";
            this.c_branchBtn.Size = new System.Drawing.Size(214, 197);
            this.c_branchBtn.TabIndex = 4;
            this.c_branchBtn.Text = "Branch Master";
            this.c_branchBtn.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 409);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button c_masterBtn;
        private System.Windows.Forms.Button c_deptBtn;
        private System.Windows.Forms.Button c_registrationBtn;
        private System.Windows.Forms.Button c_designationBtn;
        private System.Windows.Forms.Button c_branchBtn;

    }
}