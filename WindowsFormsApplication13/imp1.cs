using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    class imp1
    {
        private static string s = "Data Source = DESKTOP-JENDBJ4; Initial Catalog=tytt ;User ID=sa; Password=addsoft@123";
        public static SqlConnection con = new SqlConnection(s);

        public void addDepartment(string departmentName, string description)
        {
            try
            {

                SqlCommand checkCmd = new SqlCommand("select count(*)from department1 where u_deptName = @deptName", con);
                checkCmd.Parameters.AddWithValue("@deptName", departmentName);
                con.Open();
                int count = (int)checkCmd.ExecuteScalar();
                con.Close();
                if (count > 0)
                {
                    MessageBox.Show("Department name already exist in the System. Please add a new department Name");
                    return;
                }

                SqlCommand cmd = new SqlCommand("st_AddDepartment", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@deptName", departmentName);
                cmd.Parameters.AddWithValue("@description", description);
                con.Open();
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show(departmentName + " added successfully");
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public DataTable GetDepartments()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT u_deptName, u_description,u_id FROM department1 order by u_id desc";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                con.Open();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        public void updateDepartment(string departmentName, string description, int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_UpdateDepartment", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@deptName", departmentName);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show(departmentName + " updated successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }


        }

        public void deleteDepartment(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_DeleteDepartmen", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show(id + " deleted successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
