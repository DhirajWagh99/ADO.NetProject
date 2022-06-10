using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO.NetProject
{
    public partial class Course : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Course()
        {
            InitializeComponent();
            string strConnection = ConfigurationManager.ConnectionStrings["DefaultConnection1"].ConnectionString;
            con = new SqlConnection(strConnection);

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "insert into Course values(@name,@fees)";
                cmd = new SqlCommand(str, con);
              //  cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtcid.Text));
                cmd.Parameters.AddWithValue("@name", txtcname.Text);
                cmd.Parameters.AddWithValue("@fees", Convert.ToInt32(txtfees.Text));
                //open Db Connection 
                con.Open();
                //fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record inserted");
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "update Employee set Name=@name, Fees=@fees where Id=@id";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtcid.Text));
                cmd.Parameters.AddWithValue("@name", txtcname.Text);
                cmd.Parameters.AddWithValue("@fees", Convert.ToInt32(txtfees.Text));
                //open Db Connection 
                con.Open();
                //fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record inserted");
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "select * from Course where Id=@id ";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtcid.Text));
                //open Db Connection 
                con.Open();
                //fire the query

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtcname.Text = dr["Name"].ToString();
                        txtfees.Text = dr["fees"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record Not Found");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "delete from Course where Id=@id";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtcid.Text));
                //open Db Connection 
                con.Open();
                //fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record Delete");
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "select * from Course ";
                cmd = new SqlCommand(str, con);
                //open Db Connection 
                con.Open();
                //fire the query

                dr = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(dr);
                dataGridView1.DataSource = table;

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
