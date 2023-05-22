using Npgsql;

namespace DataBase
{
    public partial class PackagesForm : Form
    {
        private NpgsqlConnection connection;
        public PackagesForm(bool isNewNoteAdding, NpgsqlConnection connection, DataGridViewCellCollection? selectedRowCells = null)
        {
            InitializeComponent();

            if (isNewNoteAdding)
            {
                saveChanges.Visible = false;
                idTextBox.Visible = false;
                idLabel.Visible = false;
            }
            this.connection = connection;

            if (selectedRowCells != null)
            {
                idTextBox.Text = selectedRowCells[0].Value.ToString();
                nameTextBox.Text = selectedRowCells[1].Value.ToString();
            }
        }

        private void insertNewNote_Click(object sender, EventArgs e)
        {
            string command = "INSERT INTO Упаковки (Название)" +
                             "VALUES (@p1)";
            try
            {
                if (FormIsNotFilled())
                    throw new Exception("Заполните все обязательные поля!");

                NpgsqlCommand cmd = new NpgsqlCommand(command, connection);

                cmd.Parameters.AddWithValue("@p1", nameTextBox.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private bool FormIsNotFilled()
        {
            return string.IsNullOrEmpty(nameTextBox.Text);
        }

        private void closeForm_Click(object sender, EventArgs e) => this.Close();

        private void clearForm_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
                if (control is TextBox)
                    if (!((TextBox)control).ReadOnly)
                        ((TextBox)control).Text = string.Empty;
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            string command = "UPDATE Упаковки SET Название = @p2 " +
                             "where ИД = @p1";
            try
            {
                if (FormIsNotFilled())
                    throw new Exception("Заполните все обязательные поля!");

                NpgsqlCommand cmd = new NpgsqlCommand(command, connection);

                cmd.Parameters.AddWithValue("@p1", int.Parse(idTextBox.Text));
                cmd.Parameters.AddWithValue("@p2", nameTextBox.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
