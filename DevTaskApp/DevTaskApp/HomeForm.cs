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

namespace DevTaskApp
{
    public partial class HomeForm : Form
    {

        //addUserForm add = new addUserForm();
        //ListUsersForm list = new ListUsersForm();
        
        //string path = @"Data Source =DESKTOP-4LNA1LG;Initial Catalog=developmenttask;Integrated Security=True";

        public HomeForm()
        {
            InitializeComponent();
            //con = new SqlConnection(path);
        }

        

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            addUserForm add = new addUserForm();
            add.Show();
        }

        private void btnDeleteUsers_Click(object sender, EventArgs e)
        {
            addUserForm add = new addUserForm();
            add.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnListUsers_Click(object sender, EventArgs e)
        {
            addUserForm add = new addUserForm();
            add.Show();
        }

        /*private void btnImportUsers_Click(object sender, EventArgs e)
        {
            addUserForm add = new addUserForm();
            add.Show();
        }*/
    }
}