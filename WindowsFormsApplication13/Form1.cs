using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        imp obj = new imp();
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (SaveBtn.Text == "SAVE")
            {
                if (CompanyLogo.Image == null)
                {
                    MessageBox.Show("Please select an image.");
                    return;
                }
                byte[] image;
                using (MemoryStream ms = new MemoryStream())
                {
                    CompanyLogo.Image.Save(ms, CompanyLogo.Image.RawFormat);
                    image = ms.ToArray();
                }

                if (CompanyNameTxt.Text == "")
                {
                    MessageBox.Show("Empty field");
                }
                else if (CompanyMotoTxt.Text == "")
                {
                    MessageBox.Show("Empty field");
                }
                else if (GstinNum.Text == "")
                {
                    MessageBox.Show("Empty field");
                }
                else if (dateTimePicker2.Text == "")
                {
                    MessageBox.Show("Empty field");
                }
                else
                {

                    imp obj = new imp();
                    obj.addCompany(CompanyNameTxt.Text, CompanyMotoTxt.Text, GstinNum.Text, Convert.ToDateTime(dateTimePicker2.Text), image);
                    

                }
            }
            
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK) 
            {
                textBox1.Text = openFileDialog1.FileName;
                Image i = new Bitmap(textBox1.Text);
                CompanyLogo.Image = i;
                CompanyLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CompanyNameTxt.Text = dataGridView1.CurrentRow.Cells["nameGV"].Value.ToString();
            CompanyMotoTxt.Text = dataGridView1.CurrentRow.Cells["motoGV"].Value.ToString();
            GstinNum.Text = dataGridView1.CurrentRow.Cells["gstinGV"].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells["establishedGV"].Value.ToString();
            idTxt.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells["imageGV"] != null)
            {
                byte[] image = dataGridView1.CurrentRow.Cells["imageGV"].Value as byte[];
                if (image != null)
                {
                    using (MemoryStream ms = new MemoryStream(image))
                    {
                        CompanyLogo.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
                else
                {
                    CompanyLogo.Image = null;
                }
            }
            else
            {
                CompanyLogo.Image = null;
            }

            SaveBtn.Text = "UPDATE";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
            {
                DialogResult dr = MessageBox.Show("SURE", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    imp obj = new imp();
                    string idTxt = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                    obj.deleteUser(Convert.ToInt32(idTxt));
                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                }
            }

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
                if (C is PictureBox)
                {
                    PictureBox pb = (PictureBox)C;
                    pb.Image = null;
                }
            }
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            clear(main);
            SaveBtn.Text = "SAVE";
        }

        private void tty(object sender, EventArgs e)
        {

        }
    }
}
