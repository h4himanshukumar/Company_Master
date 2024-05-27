using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class DepartmentMaster : Form
    {
        imp1 obj = new imp1();
        DataTable dt = new DataTable();
        public DepartmentMaster()
        {
            InitializeComponent();
            LoadDepartments();
        }
        private void LoadDepartments()
        {
            dt.Clear();
            dt = obj.GetDepartments();
            dataGridView1.DataSource = dt;
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (saveBtn.Text == "SAVE")
            {
                if (deptTxt.Text == "")
                {
                    MessageBox.Show("Field Empty");
                }
                else if (DescriptionTxt.Text == "")
                {
                    MessageBox.Show("Field Empty");
                }
                else
                {
                    obj.addDepartment(deptTxt.Text, DescriptionTxt.Text);
                    LoadDepartments();
                }

            }
            else
            {
                obj.updateDepartment(deptTxt.Text, DescriptionTxt.Text, Convert.ToInt32(deptIdTxt.Text));
                LoadDepartments();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            //{
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int DeptTxt =Convert.ToInt32( dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString()); // Assuming the company name is in the first column
                    imp1 obj2 = new imp1();
                    obj2.deleteDepartment(DeptTxt); // Delete from the database
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    //LoadDepartments();
                    //dataGridView1.Rows.RemoveAt(e.RowIndex); // Delete from the DataGridView
                }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear(main);
            saveBtn.Text = "SAVE";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void clear(Panel p)
        {
            foreach (Control C in p.Controls)
            {
                if (C is TextBox)
                {
                    TextBox t = (TextBox)C;
                    t.Text = "";
                }
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            deptTxt.Text = dataGridView1.CurrentRow.Cells["DepartmentGV"].Value.ToString();
            DescriptionTxt.Text = dataGridView1.CurrentRow.Cells["DescriptionGV"].Value.ToString();
            deptIdTxt.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            saveBtn.Text = "UPDATE";
        }
        //private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    if (dataGridView1.CurrentRow != null)
        //    {
        //        if (dataGridView1.CurrentRow.Cells["Department Name"] != null &&
        //            dataGridView1.CurrentRow.Cells["Department Name"].Value != null)
        //        {
        //            deptTxt.Text = dataGridView1.CurrentRow.Cells["DepartmentName"].Value.ToString();
        //        }

        //        if (dataGridView1.CurrentRow.Cells["Description"] != null &&
        //            dataGridView1.CurrentRow.Cells["Description"].Value != null)
        //        {
        //            DescriptionTxt.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
        //        }

        //        if (dataGridView1.CurrentRow.Cells["id"] != null &&
        //            dataGridView1.CurrentRow.Cells["id"].Value != null)
        //        {
        //            deptIdTxt.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
        //        }

        //        saveBtn.Text = "UPDATE";
        //    }
        //}

        private void DepartmentMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
