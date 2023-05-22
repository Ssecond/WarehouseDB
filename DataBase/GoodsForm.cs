using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class GoodsForm : Form
    {
        private NpgsqlConnection connection;
        private List<Dictionary<string, long>> dictionaries;
        private List<string>[] keys;
        public GoodsForm(bool isNewNoteAdding, NpgsqlConnection connection, List<Dictionary<string, long>> dictionaries, List<string>[] keys, DataGridViewCellCollection? selectedRowCells = null)
        {
            InitializeComponent();

            if (isNewNoteAdding)
            {
                saveChanges.Visible = false;
                idTextBox.Visible = false;
                idLabel.Visible = false;
            }
            this.connection = connection;
            this.dictionaries = dictionaries;
            this.keys = keys;


            choosePackage.Items.AddRange(keys[1].ToArray());
            producerTIN.Items.AddRange(keys[3].ToArray());

            if (selectedRowCells != null)
            {
                idTextBox.Text = selectedRowCells[0].Value.ToString();
                choosePackage.SelectedItem = dictionaries[1].FirstOrDefault(x => x.Value == (int)selectedRowCells[1].Value).Key;
                producerTIN.SelectedItem = dictionaries[3].FirstOrDefault(x => x.Value == (long)selectedRowCells[2].Value).Key;
                signData.Text = ((DateTime)selectedRowCells[3].Value).ToString("dd.MM.yyyy");
                signCheckBox.Checked = (bool)selectedRowCells[4].Value;
                outCheckNumber.Text = selectedRowCells[5].Value.ToString();
                instrustionsTextBox.Text = selectedRowCells[6].Value.ToString();
                price.Text = ((int)(decimal)selectedRowCells[7].Value).ToString();
                inCheckNumber.Text = selectedRowCells[8].Value.ToString();
                givenDateTextBox.Text = ((DateTime)selectedRowCells[9].Value).ToString("dd.MM.yyyy");
                experiationDateTextBox.Text = ((DateTime)selectedRowCells[10].Value).ToString("dd.MM.yyyy");
                productionDateTextBox.Text = ((DateTime)selectedRowCells[11].Value).ToString("dd.MM.yyyy");
                productNameTextBox.Text = selectedRowCells[12].Value.ToString();
            }
        }

        private void insertNewNote_Click(object sender, EventArgs e)
        {
            string command = "INSERT INTO Товары (Упаковка, \"ИНН производителя\", \"Дата сертификата соотв\", \"Сертификат соотв\", " +
                             "\"Номер выходной накладной\", Инструкции, Цена, \"Номер приходной накладной ведомос\", " +
                             "\"Дата поступления\", \"Срок годности\", \"Дата производства\", Название)" +
                             "VALUES (@p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13)";
            try
            {
                if (FormIsNotFilled())
                    throw new Exception("Заполните все обязательные поля!");

                NpgsqlCommand cmd = new NpgsqlCommand(command, connection);

                cmd.Parameters.AddWithValue("@p2", dictionaries[1][(string)choosePackage.SelectedItem]);
                cmd.Parameters.AddWithValue("@p3", dictionaries[3][(string)producerTIN.SelectedItem]);
                cmd.Parameters.AddWithValue("@p4", DateTime.Parse(signData.Text));
                cmd.Parameters.AddWithValue("@p5", signCheckBox.Checked);
                cmd.Parameters.AddWithValue("@p6", int.Parse(outCheckNumber.Text));
                cmd.Parameters.AddWithValue("@p7", instrustionsTextBox.Text);
                cmd.Parameters.AddWithValue("@p8", int.Parse(price.Text));
                cmd.Parameters.AddWithValue("@p9", int.Parse(inCheckNumber.Text));
                cmd.Parameters.AddWithValue("@p10", DateTime.Parse(givenDateTextBox.Text));
                cmd.Parameters.AddWithValue("@p11", DateTime.Parse(experiationDateTextBox.Text));
                cmd.Parameters.AddWithValue("@p12", DateTime.Parse(productionDateTextBox.Text));
                cmd.Parameters.AddWithValue("@p13", productNameTextBox.Text);

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
            return string.IsNullOrEmpty(choosePackage.Text) || string.IsNullOrEmpty(producerTIN.Text) || string.IsNullOrEmpty(signData.Text) ||
                string.IsNullOrEmpty(outCheckNumber.Text) || string.IsNullOrEmpty(instrustionsTextBox.Text) || string.IsNullOrEmpty(price.Text) ||
                string.IsNullOrEmpty(inCheckNumber.Text) || string.IsNullOrEmpty(givenDateTextBox.Text) || string.IsNullOrEmpty(givenDateTextBox.Text) ||
                string.IsNullOrEmpty(experiationDateTextBox.Text) || string.IsNullOrEmpty(productionDateTextBox.Text) || string.IsNullOrEmpty(productNameTextBox.Text);
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
            string command = "UPDATE Товары SET Упаковка = @p2, \"ИНН производителя\" = @p3, \"Дата сертификата соотв\" = @p4, \"Сертификат соотв\" = @p5, " +
                 "\"Номер выходной накладной\" = @p6, Инструкции = @p7, Цена = @p8, \"Номер приходной накладной ведомос\" = @p9, " +
                 "\"Дата поступления\" = @p10, \"Срок годности\" = @p11, \"Дата производства\" = @p12, Название = @p13 " +
                 "where \"ИНН производителя\" = @p3";

            try
            {
                if (FormIsNotFilled())
                    throw new Exception("Заполните все обязательные поля!");

                NpgsqlCommand cmd = new NpgsqlCommand(command, connection);

                cmd.Parameters.AddWithValue("@p2", dictionaries[1][(string)choosePackage.SelectedItem]);
                cmd.Parameters.AddWithValue("@p3", dictionaries[3][(string)producerTIN.SelectedItem]);
                cmd.Parameters.AddWithValue("@p4", DateTime.Parse(signData.Text));
                cmd.Parameters.AddWithValue("@p5", signCheckBox.Checked);
                cmd.Parameters.AddWithValue("@p6", int.Parse(outCheckNumber.Text));
                cmd.Parameters.AddWithValue("@p7", instrustionsTextBox.Text);
                cmd.Parameters.AddWithValue("@p8", int.Parse(price.Text));
                cmd.Parameters.AddWithValue("@p9", int.Parse(inCheckNumber.Text));
                cmd.Parameters.AddWithValue("@p10", DateTime.Parse(givenDateTextBox.Text));
                cmd.Parameters.AddWithValue("@p11", DateTime.Parse(experiationDateTextBox.Text));
                cmd.Parameters.AddWithValue("@p12", DateTime.Parse(productionDateTextBox.Text));
                cmd.Parameters.AddWithValue("@p13", productNameTextBox.Text);

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
