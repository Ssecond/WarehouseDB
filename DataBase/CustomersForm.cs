using Npgsql;
using System.Data;
using System.Linq;

namespace DataBase
{
    public partial class CustomersForm : Form
    {
        private NpgsqlConnection connection;
        private List<Dictionary<string, int>> dictionaries;
        private List<string>[] keys;
        public CustomersForm(bool isNewNoteAdding, NpgsqlConnection connection, List<Dictionary<string, int>> dictionaries, List<string>[] keys, DataGridViewCellCollection selectedRowCells = null)
        {
            InitializeComponent();
            if (isNewNoteAdding)
            {
                saveChanges.Visible = false;
            }
            this.connection = connection;
            this.dictionaries = dictionaries;
            this.keys = keys;

            streetComboBox.Items.AddRange(keys[0].ToArray());
            goodsComboBox.Items.AddRange(keys[2].ToArray());

            if (selectedRowCells != null)
            {
                goodsComboBox.SelectedItem = dictionaries[2].FirstOrDefault(x => x.Value == (int)selectedRowCells[0].Value).Key;
                streetComboBox.SelectedItem = dictionaries[0].FirstOrDefault(x => x.Value == (int)selectedRowCells[1].Value).Key;
                TIN.Text = ((int)selectedRowCells[2].Value).ToString();
                isCashCheckBox.Checked = (bool)selectedRowCells[3].Value;
                sumTextBox.Text = ((int)selectedRowCells[4].Value).ToString();
                soldDateTextBox.Text = ((DateTime)selectedRowCells[5].Value).ToString("dd.MM.yyyy");
                countTextBox.Text = ((int)selectedRowCells[6].Value).ToString();
                phoneNumberTextBox.Text = (string)selectedRowCells[7].Value;
                sellerSurnameTextBox.Text = (string)selectedRowCells[8].Value;
                houseNumberTextBox.Text = ((int)selectedRowCells[9].Value).ToString();
            }
        }

        private void insertNewNote_Click(object sender, EventArgs e)
        {
            string command = $"INSERT INTO Покупатели (Товар, Улица, ИНН, Наличные, Сумма, \"Дата продажи\", \"Кол-во\", Телефон, \"Фамилия продавца\", \"Номер здания\")" +
             "VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10)";
            try
            {
                if (FormIsFilled())
                    throw new Exception("Заполните все обязательные поля!");

                NpgsqlCommand cmd = new NpgsqlCommand(command, connection);

                cmd.Parameters.AddWithValue("@p1", dictionaries[2][(string)goodsComboBox.SelectedItem]);
                cmd.Parameters.AddWithValue("@p2", dictionaries[0][(string)streetComboBox.SelectedItem]);
                cmd.Parameters.AddWithValue("@p3", int.Parse(TIN.Text));
                cmd.Parameters.AddWithValue("@p4", isCashCheckBox.Checked);
                cmd.Parameters.AddWithValue("@p5", int.Parse(sumTextBox.Text));
                cmd.Parameters.AddWithValue("@p6", DateTime.Parse(soldDateTextBox.Text));
                cmd.Parameters.AddWithValue("@p7", int.Parse(countTextBox.Text));
                cmd.Parameters.AddWithValue("@p8", phoneNumberTextBox.Text);
                cmd.Parameters.AddWithValue("@p9", sellerSurnameTextBox.Text);
                cmd.Parameters.AddWithValue("@p10", int.Parse(houseNumberTextBox.Text));

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private bool FormIsFilled()
        {
            return string.IsNullOrEmpty(goodsComboBox.Text) || string.IsNullOrEmpty(streetComboBox.Text) || string.IsNullOrEmpty(TIN.Text)
                || string.IsNullOrEmpty(sumTextBox.Text) || string.IsNullOrEmpty(soldDateTextBox.Text) || string.IsNullOrEmpty(countTextBox.Text)
                || string.IsNullOrEmpty(phoneNumberTextBox.Text) || string.IsNullOrEmpty(sellerSurnameTextBox.Text) || string.IsNullOrEmpty(houseNumberTextBox.Text);
        }

        private void closeForm_Click(object sender, EventArgs e) => this.Close();

        private void clearForm_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
                if (control is System.Windows.Forms.TextBox)
                    ((System.Windows.Forms.TextBox)control).Text = string.Empty;
                else if (control is System.Windows.Forms.ComboBox)
                    ((System.Windows.Forms.ComboBox)control).SelectedItem = null;
                else if (control is System.Windows.Forms.CheckBox)
                    ((System.Windows.Forms.CheckBox)control).Checked = false;
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {

            
        }
    }
}
