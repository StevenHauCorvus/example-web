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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Final_MK.I
{
    public partial class Form1 : Form
    {
        public int warningCounter = 0;
        public int counter = 0;
     
      
        List<Login> personalInfo = new List<Login>()
        {
            new Login("Steven Hau","1234"),
             new Login("Jason vu","123"),
            new Login("Nathan Lavin","12")
        };

        

        List<Employee> currentEmployee = new List<Employee>();

        Department Tickets = new Department();

        List<Department> courses = new List<Department>()
        {
           new Department( "Service Request", new List<Employee>()
           {



           }),

          

        };

        public Form1()
        {
            InitializeComponent();
            Tickets.DepartmentName = "Help Desk";
            Tickets.GetEmployees = currentEmployee;

            foreach (Employee s in Tickets.GetEmployees)
            {
                rtbOutput.Text += s.ToString();
                cboRemoveID.Items.Add(s.EmployeeID);

            }

            foreach (Department eDepartment in courses)
            {
                cboCourse.Items.Add(eDepartment.DepartmentName);

            }

          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userNameInput = txtUserName.Text;
            string userPasswordInput = txtPassword.Text;
            bool foundUser = false;
         





            if (txtPassword.Text == string.Empty && txtUserName.Text == string.Empty)
            {
                lblErrorUser.Text = "*Username Required*";
                lblErrorPass.Text = "*Password Required*";

            }

            else if (txtUserName.Text == string.Empty)
             {
                    lblErrorUser.Text = "*Username Required*";
                lblErrorPass.Text = string.Empty;

            }
                
            else if (txtPassword.Text == string.Empty)
            {
                lblErrorPass.Text = "*Password Required*";
                lblErrorUser.Text = string.Empty;
            }
           
           
                else
                {
                    try
                    {

                        SqlConnection con = new SqlConnection("Data Source=DESKTOP-H5BMTQ9\\SQLEXPRESS;Initial Catalog=loginform;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("select * from tbl_login where username = @username and password= @password", con);
                        cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();


                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {

                            for (int i = 0; i < personalInfo.Count && foundUser == false; i++)
                            {


                                if (userNameInput == personalInfo[i].GetUserName && userPasswordInput == personalInfo[i].GetPassword)
                                {

                                    lblWelcome.Text = $"Welcome {personalInfo[i].GetUserName}";
                                    lblWelcome.ForeColor = Color.White;
                                    loginScreen.Visible = false;
                                    topBar.Visible = true;
                                    foundUser = true;
                              





                            }

                            }
                        }
                        else
                        {
                        lblErrorUser.Text = "*Incorrect Username*";
                        lblErrorPass.Text = "*Incorrect Password*";
                    }

                       



                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("" + ex);
                    }

                }

            }
        

        private void btnPrintTicket_Click(object sender, EventArgs e)
        {
            Employee student = new Employee(int.Parse(txtStudentID.Text), txtFirstName.Text, txtLastName.Text, txtEmail.Text);

            courses[cboCourse.SelectedIndex].GetEmployees.Add(student);

            counter++;
            label8.Text = counter.ToString();



            DisplayStudents();
        }

        private void btnRemoveTicketID_Click(object sender, EventArgs e)
        {
            int searchID = int.Parse(cboRemoveID.Text);

            for (int i = 0; i < courses[cboCourse.SelectedIndex].GetEmployees.Count; i++)
            {
                if (searchID == courses[cboCourse.SelectedIndex].GetEmployees[i].EmployeeID)
                {
                    courses[cboCourse.SelectedIndex].GetEmployees.Remove(courses[cboCourse.SelectedIndex].GetEmployees[cboRemoveID.SelectedIndex]);
           
                    counter--;
                    label8.Text = counter.ToString();

                }

            }

            DisplayStudents();

        }

        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayStudents();
        }

        void DisplayStudents()
        {
            rtbOutput.Text = string.Empty;
            cboRemoveID.Items.Clear();

            foreach (Employee student in courses[cboCourse.SelectedIndex].GetEmployees)
            {

                rtbOutput.Text += student.ToString();
                cboRemoveID.Items.Add(student.EmployeeID);

            }
        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            gbTicket.Visible = true;
            gbStatus.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbStatus.Visible = true;
            gbTicket.Visible = false; 
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayStudents();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        

            gbAdminVerification.Visible = true;
            lblAdminError.Visible = false;



        }

        private void txtAdministratorPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdminSearch.PerformClick();
            }
        }

        private void btnAdminSearch_Click(object sender, EventArgs e)
        {
            string userAdmin = txtAdministratorPassword.Text;
           
                if (userAdmin == "1234")
                {
                    gbRemove.Visible = true;
                    gbAdminVerification.Visible = false;  

                }

                else
                {
                    lblAdminError.Visible = true;

                }

            

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            txtStudentID.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = "Details...";
            
            loginScreen.Visible = true;
            
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            
            gbStatus.Visible = false;
            gbTicket.Visible = false;
            gbAdminVerification.Visible = false;
            btnLogin.Enabled = true;


            lblErrorPass.Text = string.Empty;
            lblErrorUser.Text = string.Empty;
       



        }

        private void btnAdminVerification_Click(object sender, EventArgs e)
        {
            gbAdminVerification.Visible = false;
        }

        private void btnGBRemove_Click(object sender, EventArgs e)
        {
            gbRemove.Visible = false;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDemo ytLink = new FormDemo();
            ytLink.ShowDialog();
        }
    }
}
