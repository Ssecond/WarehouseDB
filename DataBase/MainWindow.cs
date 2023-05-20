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
        /// <summary>
        /// Put your data instead of '_' sign: "Server=_;Port=_;User ID=_;Password=_;Database=_;"
        /// </summary>
        private const string connectionParams = "Server=192.168.0.20;Port=5432;User ID=postgres;Password=333;Database=GoodsStorage;";
        // private const string connectionParams = "Server=localhost;Port=5432;User ID=postgres;Password=333;Database=GoodsStorage;";
        private string[] tableNames = { "Покупатели", "Товары", "Упаковки", "Поставщики", "Улицы" };
        public MainWindow()
        {
            InitializeComponent();
            listOfTables.Items.AddRange(tableNames);
            connection = new NpgsqlConnection(connectionParams);
        }

        private DataSet? dataSet;
        private BindingSource? bindingSource;
        private List<Dictionary<string, int>> dictionaries;
        private void UpdateData()
        {
            try
            {
                dataSet = new DataSet();
                // bindingSource = new BindingSource();

                connection.Open();

                NpgsqlCommand customersCom = new NpgsqlCommand("SELECT * FROM " + tableNames[0], connection);
                NpgsqlCommand goodsCom = new NpgsqlCommand("SELECT * FROM " + tableNames[1], connection);
                NpgsqlCommand packagesCom = new NpgsqlCommand("SELECT * FROM " + tableNames[2], connection);
                NpgsqlCommand producersCom = new NpgsqlCommand("SELECT * FROM " + tableNames[3], connection);
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

                dictionaries = CreateDictionaries();

                viewTables.DataSource = dataSet.Tables[listOfTables.SelectedIndex];
                viewTables.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception unknownExeption)
            {
                MessageBox.Show(unknownExeption.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e) => UpdateData();

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void listOfTables_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProgramAbout().ShowDialog();
            GC.Collect();
        }

        private List<Dictionary<string, int>> CreateDictionaries()
        {
            Dictionary<string, int> streets = new Dictionary<string, int>();
            for (int i = 0; i < dataSet.Tables[tableNames[4]].Rows.Count; i++)
            {
                string s;
                if ((bool)dataSet.Tables[tableNames[4]].Rows[i].ItemArray[3])
                    s = dataSet.Tables[tableNames[4]].Rows[i].ItemArray[2] + " " + dataSet.Tables[tableNames[4]].Rows[i].ItemArray[1];
                else
                    s = dataSet.Tables[tableNames[4]].Rows[i].ItemArray[1] + " " + dataSet.Tables[tableNames[4]].Rows[i].ItemArray[2];

                streets.Add(s, (int)dataSet.Tables[tableNames[4]].Rows[i].ItemArray[0]);
            }

            Dictionary<string, int> packages = new Dictionary<string, int>();
            for (int i = 0; i < dataSet.Tables[tableNames[2]].Rows.Count; i++)
                packages.Add((string)dataSet.Tables[tableNames[2]].Rows[i].ItemArray[1], (int)dataSet.Tables[tableNames[2]].Rows[i].ItemArray[0]);

            return new List<Dictionary<string, int>> { streets, packages };
        }

        private void exit_Click(object sender, EventArgs e) => this.Close();

        private void deleteNote_Click(object sender, EventArgs e)
        {
            string command = string.Empty;
            if (listOfTables.Text == tableNames[0])
                command = $"DELETE FROM {listOfTables.Text} WHERE ИНН = '{viewTables.SelectedRows[0].Cells[0].Value}'";
            else if (listOfTables.Text == tableNames[1])
                command = $"DELETE FROM {listOfTables.Text} WHERE \"ИД товара\" = '{viewTables.SelectedRows[0].Cells[0].Value}'";
            else if (listOfTables.Text == tableNames[2])
                command = $"DELETE FROM {listOfTables.Text} WHERE ИД = '{viewTables.SelectedRows[0].Cells[0].Value}'";
            else if (listOfTables.Text == tableNames[3])
                command = $"DELETE FROM {listOfTables.Text} WHERE ИНН = '{viewTables.SelectedRows[0].Cells[0].Value}'";
            else if (listOfTables.Text == tableNames[4])
                command = $"DELETE FROM {listOfTables.Text} WHERE ИД = '{viewTables.SelectedRows[0].Cells[0].Value}'";

            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(command, connection);
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
            UpdateData();
        }

        private void createNewNote_Click(object sender, EventArgs e)
        {
            StreetsForm streetsForm = new StreetsForm();
            streetsForm.ShowDialog();
        }
    }
}