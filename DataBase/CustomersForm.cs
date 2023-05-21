using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataBase
{
    public partial class CustomersForm : Form
    {
        private NpgsqlConnection connection;
        public CustomersForm(bool isNewNoteAdding, NpgsqlConnection connection)
        {
            InitializeComponent();
            if (isNewNoteAdding)
            {
                saveChanges.Visible = false;
            }
            this.connection = connection;
        }

        private void insertNewNote_Click(object sender, EventArgs e)
        {
            string command = $"INSERT INTO Покупатели (Товар, Улица, ИНН, Наличные, Сумма, Дата продажи, Кол-во, Телефон, Фамилия продавца, Номер здания)" +
             "VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10)";
            try
            {

                if (FormIsFilled())
                {
                    MessageBox.Show("Заполните все обязательные поля");
                    return;
                }

                connection.Open();
                // cmd.ExecuteNonQuery();
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
            return string.IsNullOrEmpty(goodsTextBox.Text) || string.IsNullOrEmpty(streetComboBox.Text) || string.IsNullOrEmpty(TIN.Text)
                || string.IsNullOrEmpty(sumTextBox.Text) || string.IsNullOrEmpty(soldDateTextBox.Text) || string.IsNullOrEmpty(countTextBox.Text)
                || string.IsNullOrEmpty(phoneNumberTextBox.Text) || string.IsNullOrEmpty(sellerSurnameTextBox.Text) || string.IsNullOrEmpty(houseNumberTextBox.Text);
        }
    }
}
