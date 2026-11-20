using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AppStyle.Apply(this, btnLogin);
            picLogo.BackColor = AppStyle.Secondary;
            picLogo.Image = ProductCardControl.ReadImage(Path.Combine(AppContext.BaseDirectory, "Resources", "logo.png"));
            Disposed += (_, _) => picLogo.Image?.Dispose();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("Введите логин.", "Вход в систему",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Focus();
                return;
            }
            int userId;
            string fullName;
            string role;

            try
            {
                using var connection = Database.CreateConnection();
                connection.Open();
                const string sql = @"
                    SELECT u.last_name, u.first_name, u.patronymic, r.role_name, u.user_id
                    FROM users AS u
                    INNER JOIN roles AS r ON r.role_id = u.role_id
                    WHERE u.login = @login";
                using var command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@login", txtLogin.Text.Trim());

                using var reader = command.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Пользователь с таким логином не найден.",
                        "Вход в систему", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLogin.Focus();
                    return;
                }

                userId = reader.GetInt32(4);
                string lastName = reader.GetString(0);
                string firstName = reader.GetString(1);
                string patronymic = reader.IsDBNull(2) ? "" : reader.GetString(2);
                role = reader.GetString(3);

                fullName = $"{lastName} {firstName} {patronymic}".Trim();

                MessageBox.Show("Подключение к базе успешно.");
            }
            catch (MySqlException)
            {
                MessageBox.Show("Проверьте подключение к MySQL.");
                return;
            }

            OpenCatalog(fullName, role, userId);

        }
        private void OpenCatalog(string displayName, string? role, int userId)
        {
            using var catalog = new CatalogForm(displayName, role, userId);
            catalog.ShowDialog(this);
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            using var catalog = CatalogForm.ForGuest();
            catalog.ShowDialog(this);

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
