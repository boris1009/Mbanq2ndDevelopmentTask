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
using System.IO;


namespace DevTaskApp
{
    public partial class addUserForm : Form
    {

        
        string path = @"Data Source =DESKTOP-4LNA1LG;Initial Catalog=developmenttask;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        int indexRow;
        int id;
        string oib;
        string fullName;
        string place;
        string address;
        string phone;
        string mail;
        SqlDataAdapter adpt;
        SqlCommandBuilder scb;
        private int userId;


        public addUserForm()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();
            showTable();
            
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (txtOib.Text == "" || txtName.Text == "" || txtPlace.Text == ""|| txtAddress.Text== "" || txtPhone.Text == "" || txtMail.Text == "")
            {
                MessageBox.Show("Please fill all the data");
            }
            else
            {
                try
                {
                    con.Open();


                    cmd = new SqlCommand("insert into bankUser (oib, fullName, place, address, phone, mail) values('" + txtOib.Text + "','" + txtName.Text + "','" + txtPlace.Text + "','" + txtAddress.Text + "','" + txtPhone.Text + "','" + txtMail.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Your data has been added");
                    showTable();
                    
                    clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }

        }

        public void clear()
        {
            txtOib.Text = "";
            txtName.Text = "";
            txtPlace.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtMail.Text = "";
        }

        
        public void display()
        {
            dt.Columns.Add("Id");
            dt.Columns.Add("OIB");
            dt.Columns.Add("Name");
            dt.Columns.Add("Place");
            dt.Columns.Add("Address");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Mail");

            DataRow dr = dt.NewRow();
            dr[0] = id;
            dr[1] = oib;
            dr[2] = fullName;
            dr[3] = place;
            dr[4] = address;
            dr[5] = phone;
            dr[6] = mail;

            dt.Rows.Add(dr);
            dataGrid.DataSource = dt;

        }

        public void showTable()
        {

            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select * from bankUser", con);
                adpt.Fill(dt);
                dataGrid.DataSource = dt;
                con.Close();
   
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGrid.Rows[indexRow];
            userId = int.Parse(row.Cells[0].Value.ToString());
            txtOib.Text = row.Cells[1].Value.ToString();
            txtName.Text = row.Cells[2].Value.ToString();
            txtPlace.Text = row.Cells[3].Value.ToString();
            txtAddress.Text = row.Cells[4].Value.ToString();
            txtPhone.Text = row.Cells[5].Value.ToString();
            txtMail.Text = row.Cells[6].Value.ToString();
           


        }

    

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtOib.Text == "" || txtName.Text == "" || txtPlace.Text == "" || txtAddress.Text == "" || txtPhone.Text == "" || txtMail.Text == "")
            {
                MessageBox.Show("Please fill all the data");
            }
            else
            {

                try
                {
                    con.Open();
                    cmd = new SqlCommand("update bankUser set fullName ='" + txtName.Text + "', place ='" + txtPlace.Text + "', address = '" + txtAddress.Text + "', phone = '" + txtPhone.Text + "', mail= '" + txtMail.Text + "' where id ='" + userId + "'", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Your data has been updated");
                    showTable();
                    clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("delete from bankUser where id ='" + userId + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User has been deleted");
                showTable();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from bankUser where fullName like '%" + txtSearchName.Text + "%'", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGrid.DataSource = dt;
            con.Close();
        }

        private void txtSearchOib_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from bankUser where oib like '%" + txtSearchOib.Text + "%'", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGrid.DataSource = dt;
            con.Close();
        }

        DataTable t = new DataTable();
        private void btnImport_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\admin\source\repos\DevTaskApp\import.txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(',');
                string[] row = new string[values.Length];
                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();

                }

                con.Open();
                cmd = new SqlCommand("insert into bankUser (oib, fullName, place, address, phone, mail) values('"+row [0]+ "','" + row[1]+"','" + row[2]+"','" + row[3] + "','" + row[4] + "','" + row[5]+ "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Users are imported");
                showTable();


                //dt.Rows.Add(row);
            }
        }
    }
}
