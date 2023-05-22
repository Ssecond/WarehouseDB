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

            //if (selectedRowCells != null)
            //{
            //    goodsComboBox.SelectedItem = dictionaries[2].FirstOrDefault(x => x.Value == (int)selectedRowCells[0].Value).Key;
            //    streetComboBox.SelectedItem = dictionaries[0].FirstOrDefault(x => x.Value == (int)selectedRowCells[1].Value).Key;
            //    TIN.Text = ((int)selectedRowCells[2].Value).ToString();
            //    isCashCheckBox.Checked = (bool)selectedRowCells[3].Value;
            //    sumTextBox.Text = ((int)selectedRowCells[4].Value).ToString();
            //    soldDateTextBox.Text = ((DateTime)selectedRowCells[5].Value).ToString("dd.MM.yyyy");
            //    countTextBox.Text = ((int)selectedRowCells[6].Value).ToString();
            //    phoneNumberTextBox.Text = (string)selectedRowCells[7].Value;
            //    sellerSurnameTextBox.Text = (string)selectedRowCells[8].Value;
            //    houseNumberTextBox.Text = ((int)selectedRowCells[9].Value).ToString();
            //}
        }

        private void insertNewNote_Click(object sender, EventArgs e)
        {
            string command = "INSERT INTO Товары (Упаковка, \"ИНН производителя\", \"Дата сертификата соотв\", \"Сертификат соотв\", \"Номер выходной накладной\", Инструкции, Цена, \"Номер приходной накладной ведомос\", \"Дата поступления\", \"Срок годности\", \"Дата производства\", Название)" +
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
            //return string.IsNullOrEmpty(goodsComboBox.Text) || string.IsNullOrEmpty(streetComboBox.Text) || string.IsNullOrEmpty(TIN.Text)
            //    || string.IsNullOrEmpty(sumTextBox.Text) || string.IsNullOrEmpty(soldDateTextBox.Text) || string.IsNullOrEmpty(countTextBox.Text)
            //    || string.IsNullOrEmpty(phoneNumberTextBox.Text) || string.IsNullOrEmpty(sellerSurnameTextBox.Text) || string.IsNullOrEmpty(houseNumberTextBox.Text);
            return false;
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
            //string command = "UPDATE Покупатели SET Товар = @p1, Улица = @p2, " +
            //                 "ИНН = @p3, Наличные = @p4, Сумма = @p5, \"Дата продажи\" = @p6, " +
            //                 "\"Кол-во\" = @p7, Телефон = @p8, \"Фамилия продавца\" = @p9, " +
            //                 "\"Номер здания\" = @p10 " +
            //                 "where \"ИНН\" = @p3";
            //if (FormIsFilled())
            //    throw new Exception("Заполните все обязательные поля!");

            //try
            //{
            //    NpgsqlCommand cmd = new NpgsqlCommand(command, connection);

            //    cmd.Parameters.AddWithValue("@p1", dictionaries[2][(string)goodsComboBox.SelectedItem]);
            //    cmd.Parameters.AddWithValue("@p2", dictionaries[0][(string)streetComboBox.SelectedItem]);
            //    cmd.Parameters.AddWithValue("@p3", int.Parse(TIN.Text));
            //    cmd.Parameters.AddWithValue("@p4", isCashCheckBox.Checked);
            //    cmd.Parameters.AddWithValue("@p5", int.Parse(sumTextBox.Text));
            //    cmd.Parameters.AddWithValue("@p6", DateTime.Parse(soldDateTextBox.Text));
            //    cmd.Parameters.AddWithValue("@p7", int.Parse(countTextBox.Text));
            //    cmd.Parameters.AddWithValue("@p8", phoneNumberTextBox.Text);
            //    cmd.Parameters.AddWithValue("@p9", sellerSurnameTextBox.Text);
            //    cmd.Parameters.AddWithValue("@p10", int.Parse(houseNumberTextBox.Text));

            //    connection.Open();
            //    cmd.ExecuteNonQuery();
            //}
            //catch (Exception exception)
            //{
            //    MessageBox.Show(exception.Message);
            //}
            //finally
            //{
            //    connection.Close();
            //}
        }
    }
}
