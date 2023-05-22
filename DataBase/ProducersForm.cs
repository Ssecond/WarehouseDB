using Npgsql;

namespace DataBase
{
    public partial class ProducersForm : Form
    {
        private NpgsqlConnection connection;
        private List<Dictionary<string, long>> dictionaries;
        public ProducersForm(bool isNewNoteAdding, NpgsqlConnection connection, List<Dictionary<string, long>> dictionaries, List<string>[] keys, DataGridViewCellCollection? selectedRowCells = null)
        {
            InitializeComponent();

            if (isNewNoteAdding)
            {
                saveChanges.Visible = false;
            }
            this.connection = connection;
            this.dictionaries = dictionaries;

            streetComboBox.Items.AddRange(keys[0].ToArray());

            if (selectedRowCells != null)
            {
                tinTextBox.Text = selectedRowCells[0].Value.ToString();
                brokerSignCheckBox.Checked = (bool)selectedRowCells[1].Value;
                houseNumberTextBox.Text = selectedRowCells[2].Value.ToString();
                phoneNumber.Text = selectedRowCells[3].Value.ToString();
                companyName.Text = selectedRowCells[4].Value.ToString();
                additionalTextBox.Text = selectedRowCells[5].Value.ToString();
                streetComboBox.SelectedItem = dictionaries[0].FirstOrDefault(x => x.Value == (int)selectedRowCells[6].Value).Key;
            }
        }

        private void insertNewNote_Click(object sender, EventArgs e)
        {
            string command = "INSERT INTO Поставщики (ИНН, \"Признак посредника\", \"Номер здания\", " +
                             "Телефон, \"Название компании\", \"Правовая форма\", Улица)" +
                             "VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7)";
            try
            {
                if (FormIsNotFilled())
                    throw new Exception("Заполните все обязательные поля!");

                NpgsqlCommand cmd = new NpgsqlCommand(command, connection);

                cmd.Parameters.AddWithValue("@p1", int.Parse(tinTextBox.Text));
                cmd.Parameters.AddWithValue("@p2", brokerSignCheckBox.Checked);
                cmd.Parameters.AddWithValue("@p3", int.Parse(houseNumberTextBox.Text));
                cmd.Parameters.AddWithValue("@p4", phoneNumber.Text);
                cmd.Parameters.AddWithValue("@p5", companyName.Text);
                cmd.Parameters.AddWithValue("@p6", additionalTextBox.Text);
                cmd.Parameters.AddWithValue("@p7", dictionaries[0][(string)streetComboBox.SelectedItem]);

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
            return string.IsNullOrEmpty(tinTextBox.Text) || string.IsNullOrEmpty(houseNumberTextBox.Text) ||
                   string.IsNullOrEmpty(phoneNumber.Text) || string.IsNullOrEmpty(companyName.Text) || 
                   string.IsNullOrEmpty(additionalTextBox.Text) || string.IsNullOrEmpty(streetComboBox.Text);
        }

        private void closeForm_Click(object sender, EventArgs e) => this.Close();

        private void clearForm_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
                if (control is TextBox)
                    ((TextBox)control).Text = string.Empty;
                else if (control is ComboBox)
                    ((ComboBox)control).SelectedItem = null;
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            string command = "UPDATE Поставщики SET ИНН = @p1, \"Признак посредника\" = @p2, \"Номер здания\" = @p3, " +
                 "Телефон  = @p4, \"Название компании\" = @p5, \"Правовая форма\" = @p6, Улица = @p7 " +
                 "where ИНН = @p1";
            try
            {
                if (FormIsNotFilled())
                    throw new Exception("Заполните все обязательные поля!");

                NpgsqlCommand cmd = new NpgsqlCommand(command, connection);

                cmd.Parameters.AddWithValue("@p1", int.Parse(tinTextBox.Text));
                cmd.Parameters.AddWithValue("@p2", brokerSignCheckBox.Checked);
                cmd.Parameters.AddWithValue("@p3", int.Parse(houseNumberTextBox.Text));
                cmd.Parameters.AddWithValue("@p4", phoneNumber.Text);
                cmd.Parameters.AddWithValue("@p5", companyName.Text);
                cmd.Parameters.AddWithValue("@p6", additionalTextBox.Text);
                cmd.Parameters.AddWithValue("@p7", dictionaries[0][(string)streetComboBox.SelectedItem]);

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
