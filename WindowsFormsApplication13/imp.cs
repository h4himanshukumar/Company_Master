using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace WindowsFormsApplication13
{
    class imp
    {
        private static string s = "Data Source = DESKTOP-JENDBJ4; Initial Catalog=tytt ;User ID=sa; Password=addsoft@123";
        public static SqlConnection con = new SqlConnection(s);
        public DataTable GetDepartments() // getDepartments is a method used to retirive data and store in "dt" and call it in imp.cs file
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT u_name, u_moto,u_gstin,u_established,u_image,u_companyID FROM compny1 order by u_companyID desc";//in descending order to add one the table top of the gridview
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

        public void addCompany(string name, string moto, string gstin, DateTime established, byte[] image)//add company 
        {
            try
            {
                // Check company name or GSTIN already exists
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM compny1 WHERE u_name = @name OR u_gstin = @gstin ", con);
                checkCmd.Parameters.AddWithValue("@name", name);
                checkCmd.Parameters.AddWithValue("@gstin", gstin);
                con.Open();
                int count = (int)checkCmd.ExecuteScalar();
                con.Close();
                if (count > 0)
                {
                    MessageBox.Show("Company name or GSTIN already exists. Please enter a unique name and GSTIN.");
                    return;
                }

                // If the name and GSTIN are different proceed with adding the company
                SqlCommand cmd = new SqlCommand("st_CompanyInfoAdd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@moto", moto);
                cmd.Parameters.AddWithValue("@gstin", gstin);
                cmd.Parameters.AddWithValue("@established", established);
                cmd.Parameters.AddWithValue("@image", image);
                con.Open();
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show(name + " added successfully into system ");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void UpdateCompany(string name, string moto, string gstin, DateTime established, int companyID)//update the company existing data
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@moto", moto);
                cmd.Parameters.AddWithValue("@gstin", gstin);
                cmd.Parameters.AddWithValue("@established", established);
                cmd.Parameters.AddWithValue("@companyID", companyID);
                //cmd.Parameters.AddWithValue("@image", image);
                con.Open();
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show(name + " updated successfully into system ");
                }
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void deleteUser(int companyID) //delete user
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_deleteCompany", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@companyID", companyID);
                con.Open();
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show("data deleted from the system.");
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}