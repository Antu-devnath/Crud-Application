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
namespace CRUD
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
            this.Load += new EventHandler(Contact_Load);
        }
        private void LoadData()
        {
            try
            {
                Con.Open();
                SqlDataAdapter Contactdb = new SqlDataAdapter("SELECT * FROM Contact", Con);
                DataTable murubbi = new DataTable();
                Contactdb.Fill(murubbi);
                data1.DataSource = murubbi;
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Contact_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\antu3\Documents\Contact.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\antu3\Documents\Contact.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");


        private void button1_Click(object sender, EventArgs e)
        {
            if (ContactIdTb.Text == "" || FirstNameTb.Text == "" || LastNameTb.Text == "" || ContactNoTb.Text == "" || GenderCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    String query = "INSERT INTO Contact ([Contact ID], [First Name], [Gender], [Last Name], [Contact No]) " +
                "VALUES ('" + ContactIdTb.Text + "', '" + FirstNameTb.Text + "', '" + GenderCb.SelectedItem.ToString() + "', '" + LastNameTb.Text + "', '" + ContactNoTb.Text + "')";

                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Contact Successfully Saved");


                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ContactIdTb.Text == "" || FirstNameTb.Text == "" || LastNameTb.Text == "" || ContactNoTb.Text == "" || GenderCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    String query = "UPDATE Contact SET [First Name] = '" + FirstNameTb.Text + "', [Last Name] = '" + LastNameTb.Text + "', [Contact No] = '" + ContactNoTb.Text + "', [Gender] = '" + GenderCb.SelectedItem.ToString() + "' WHERE [Contact ID] = '" + ContactIdTb.Text + "'";

                    Con.Open();

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Contact Successfully Updated");
                    SqlDataAdapter Contactdb = new SqlDataAdapter("Select * From Contact", Con);
                    DataTable murubbi = new DataTable();
                    Contactdb.Fill(murubbi);
                    data1.DataSource = murubbi;
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ContactIdTb.Text == "")
            {
                MessageBox.Show("Please provide a Contact ID to delete.");
            }
            else
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this contact?", "Delete Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        String query = "DELETE FROM Contact WHERE [Contact ID] = '" + ContactIdTb.Text + "'";

                        Con.Open();
                        SqlCommand cmd = new SqlCommand(query, Con);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        Con.Close();


                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Contact Successfully Deleted");
                            LoadData(); 
                        }
                        else
                        {
                            MessageBox.Show("No Contact found with the provided ID.");
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ContactIdTb.Clear();
          FirstNameTb.Clear();
            LastNameTb.Clear();
            ContactNoTb.Clear();
            GenderCb.SelectedIndex = -1;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
                try
                {
                   
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete all contacts?", "Delete All Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        
                        String query = "DELETE FROM Contact";

                        Con.Open();
                        SqlCommand cmd = new SqlCommand(query, Con);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        Con.Close();

                       
                        MessageBox.Show(rowsAffected + " contacts successfully deleted.");

                       
                        LoadData();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }


        
    }
}

