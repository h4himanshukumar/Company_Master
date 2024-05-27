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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void c_masterBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void c_deptBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepartmentMaster obj1 = new DepartmentMaster();
            obj1.Show();
        }
    }
}
