using Npgsql;
using System;
using System.Data;
using System.Resources;
using System.Windows.Forms;

namespace DataBase
{
    public partial class MainWindow : Form
    {
        private NpgsqlConnection? connection;
        private const string connectionParams = "Server=192.168.0.20;Port=5432;User ID=postgres;Password=333;Database=GoodsStorage;";
        // private const string connectionParams = "Server=localhost;Port=5432;User ID=postgres;Password=333;Database=GoodsStorage;";
        private string[] tableNames = { "Покупатели", "Товары", "Упаковки", "Поставщики", "Улицы" };
        public MainWindow()
        {
            InitializeComponent();
            listOfTables.Items.AddRange(tableNames);
        }
        /// <summary>
        /// Connects to the database.
        /// </summary>
        /// <param name="connectionParams">Put your data instead of '_' sign: "Server=_;Port=_;User ID=_;Password=_;Database=_;"</param>
        private void ConnectDB(string connectionParams)
        {
            connection = new NpgsqlConnection(connectionParams);
            connection.Open();
        }

        private void DisconnectDB()
        {
            if (connection != null && connection.FullState != ConnectionState.Closed)
                connection.Close();
        }

        private DataSet? dataSet;
        private void LoadDB()
        {
            try
            {
                dataSet = new DataSet();

                NpgsqlCommand customersCom = new NpgsqlCommand("SELECT \"ИД товара\", \"\", \"\" FROM " + tableNames[0], connection);
                NpgsqlCommand goodsCom = new NpgsqlCommand("SELECT * FROM " + tableNames[1], connection);
                NpgsqlCommand packagesCom = new NpgsqlCommand("SELECT * FROM " + tableNames[2], connection);
                NpgsqlCommand producersCom = new NpgsqlCommand("SELECT \"Правовая форма\", \"Название компании\", \"ИНН\", \"Телефон\", \"Признак адреса\", \"Название\" AS \"Улица\", \"Номер здания\", \"Признак посредника\" FROM " + tableNames[3] + " JOIN Улицы ON Улица = ИД", connection);
                NpgsqlCommand streetsCom = new NpgsqlCommand("SELECT * FROM " + tableNames[4], connection);

                NpgsqlDataAdapter customersAdapter = new NpgsqlDataAdapter(customersCom);
                NpgsqlDataAdapter goodsAdapter = new NpgsqlDataAdapter(goodsCom);
                NpgsqlDataAdapter packagesAdapter = new NpgsqlDataAdapter(packagesCom);
                NpgsqlDataAdapter producersAdapter = new NpgsqlDataAdapter(producersCom);
                NpgsqlDataAdapter streetsAdapter = new NpgsqlDataAdapter(streetsCom);

                customersAdapter.Fill(dataSet, tableNames[0]);
                goodsAdapter.Fill(dataSet, tableNames[1]);
                packagesAdapter.Fill(dataSet, tableNames[2]);
                producersAdapter.Fill(dataSet, tableNames[3]);
                streetsAdapter.Fill(dataSet, tableNames[4]);
            }
            catch (Exception unknownExeption)
            {
                MessageBox.Show(unknownExeption.Message);
            }
        }

        private void ConnectDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataSet == null)
            {
                ConnectDB(connectionParams);
                LoadDB();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            DisconnectDB();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e) => DisconnectDB();

        private void listOfTables_SelectedValueChanged(object sender, EventArgs e)
        {
            ConnectDBToolStripMenuItem_Click(this, new EventArgs());
            Table.DataSource = dataSet.Tables[listOfTables.SelectedIndex];
            Table.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            GC.Collect();
        }
    }
}