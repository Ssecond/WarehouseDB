using Npgsql;

namespace DataBase
{
    public partial class StreetsForm : Form
    {
        private NpgsqlConnection connection;
        public StreetsForm(bool isNewNoteAdding, NpgsqlConnection connection, DataGridViewCellCollection? selectedRowCells = null)
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
                nameStreet.Text = selectedRowCells[1].Value.ToString();
                streetRoad.Text = selectedRowCells[2].Value.ToString();
                orderStreet.Checked = (bool)selectedRowCells[3].Value;
            }
        }

        private void insertNewNote_Click(object sender, EventArgs e)
        {
            string command = "INSERT INTO Улицы (Название, \"Признак адреса\", \"До названия\")" +
                             "VALUES (@p1, @p2, @p3)";
            try
            {
                if (FormIsNotFilled())
                    throw new Exception("Заполните все обязательные поля!");

                NpgsqlCommand cmd = new NpgsqlCommand(command, connection);

                cmd.Parameters.AddWithValue("@p1", nameStreet.Text);
                cmd.Parameters.AddWithValue("@p2", streetRoad.Text);
                cmd.Parameters.AddWithValue("@p3", orderStreet.Checked);

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
            return string.IsNullOrEmpty(nameStreet.Text) || string.IsNullOrEmpty(streetRoad.Text);
        }

        private void closeForm_Click(object sender, EventArgs e) => this.Close();

        private void clearForm_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
                if (control is TextBox)
                {
                    if (!((TextBox)control).ReadOnly)
                        ((TextBox)control).Text = string.Empty;
                }
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            string command = "UPDATE Улицы SET Название = @p2, \"Признак адреса\" = @p3, \"До названия\" = @p4 " +
                             "where ИД = @p1";
            try
            {
                if (FormIsNotFilled())
                    throw new Exception("Заполните все обязательные поля!");

                NpgsqlCommand cmd = new NpgsqlCommand(command, connection);

                cmd.Parameters.AddWithValue("@p1", int.Parse(idTextBox.Text));
                cmd.Parameters.AddWithValue("@p2", nameStreet.Text);
                cmd.Parameters.AddWithValue("@p3", streetRoad.Text);
                cmd.Parameters.AddWithValue("@p4", orderStreet.Checked);

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
