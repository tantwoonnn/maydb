namespace dbbage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username== "")
            {
                MessageBox.Show("Please enter a user name");
                return;
            }
            else if (password == "")
            {
                MessageBox.Show("Please enter a password");
                return;
            }

            DBConnect db = new DBConnect();
            try
            {
                db.Open();

                string query = "SELECT COUNT(*) FROM students_info WHERE username=@username AND password=@password";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.Dispose();

                if (count == 0)
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
                else
                {
                    MessageBox.Show("Login Succesfully");
                    new frmDashboard().Show();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
            finally 
            {
                db.Close();
            }
        }
    }
}
