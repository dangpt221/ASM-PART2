using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PTCar
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban muon thoat chu");
            Application.Exit();

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtpassword.Text = string.Empty;
            txtusername.Text = string.Empty;
            txtusername.Focus();
            MessageBox.Show("Ban da xoa thanh cong");
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Server= (localdb)\\MSSQLLocalDB.;Database=PTCar;Trusted_Connection=True;";
            string query = "SELECT COUNT(*) FROM [Users] WHERE [Username] = @Username AND [Password] = @Password";

            // Lấy giá trị từ giao diện
            string username = txtusername.Text;
            string password = txtpassword.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = (int)command.ExecuteScalar(); // Trả về số lượng kết quả tìm được

                        if (count > 0)
                        {
                            MessageBox.Show("Login successful!");
                            // Chuyển đến form khác hoặc thực hiện hành động tiếp theo
                            Main f = new Main();
                            f.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void F_Logout(object? sender, EventArgs e)
        {
            (sender as Main).isExit = false;
            (sender as Main).Close();
            this.Show();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.Cancel)
            {
                if (MessageBox.Show("Ban muon thoat khoi chuong trinh", "Canh Bao ", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

       
    }
}
