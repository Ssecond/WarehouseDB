using Npgsql;
using NpgsqlTypes;
using System.Data;

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
        private List<Dictionary<string, long>> dictionaries;
        private void UpdateData()
        {
            try
            {
                dataSet = new DataSet();

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
        private List<string>[] keys;
        private List<Dictionary<string, long>> CreateDictionaries()
        {
            keys = new List<string>[4];

            Dictionary<string, long> streets = new Dictionary<string, long>();
            keys[0] = new List<string>();
            for (int i = 0; i < dataSet.Tables[tableNames[4]].Rows.Count; i++)
            {
                string s;
                if ((bool)dataSet.Tables[tableNames[4]].Rows[i].ItemArray[3])
                    s = dataSet.Tables[tableNames[4]].Rows[i].ItemArray[2] + " " + dataSet.Tables[tableNames[4]].Rows[i].ItemArray[1];
                else
                    s = dataSet.Tables[tableNames[4]].Rows[i].ItemArray[1] + " " + dataSet.Tables[tableNames[4]].Rows[i].ItemArray[2];

                keys[0].Add(s);
                streets.Add(s, (long)(int)dataSet.Tables[tableNames[4]].Rows[i].ItemArray[0]);
            }

            Dictionary<string, long> packages = new Dictionary<string, long>();
            keys[1] = new List<string>();
            for (int i = 0; i < dataSet.Tables[tableNames[2]].Rows.Count; i++)
            {
                string s = (string)dataSet.Tables[tableNames[2]].Rows[i].ItemArray[1];
                keys[1].Add(s);
                packages.Add(s, (long)(int)dataSet.Tables[tableNames[2]].Rows[i].ItemArray[0]);
            }


            Dictionary<string, long> goods = new Dictionary<string, long>();
            keys[2] = new List<string>();
            for (int i = 0; i < dataSet.Tables[tableNames[1]].Rows.Count; i++)
            {
                string s = (string)dataSet.Tables[tableNames[1]].Rows[i].ItemArray[12];
                keys[2].Add(s);
                goods.Add(s, (long)(int)dataSet.Tables[tableNames[1]].Rows[i].ItemArray[0]);
            }

            Dictionary<string, long> producers = new Dictionary<string, long>();
            keys[3] = new List<string>();
            for (int i = 0; i < dataSet.Tables[tableNames[3]].Rows.Count; i++)
            {
                string s = (string)dataSet.Tables[tableNames[3]].Rows[i].ItemArray[5] + " " + (string)dataSet.Tables[tableNames[3]].Rows[i].ItemArray[4];
                keys[3].Add(s);
                producers.Add(s, (long)dataSet.Tables[tableNames[3]].Rows[i].ItemArray[0]);
            }

            return new List<Dictionary<string, long>> { streets, packages, goods, producers };
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
            if (listOfTables.Text == tableNames[0])
            {
                CustomersForm customersForm = new CustomersForm(true, connection, dictionaries, keys);
                customersForm.ShowDialog();
            }
            else if (listOfTables.Text == tableNames[1])
            {
                GoodsForm goodsForm = new GoodsForm(true, connection, dictionaries, keys);
                goodsForm.ShowDialog();
            }
            else if (listOfTables.Text == tableNames[2])
            {
                PackagesForm packagesForm = new PackagesForm();
                packagesForm.ShowDialog();
            }
            else if (listOfTables.Text == tableNames[3])
            {
                ProducersForm producersForm = new ProducersForm(true, connection, dictionaries, keys);
                producersForm.ShowDialog();
            }
            else if (listOfTables.Text == tableNames[4])
            {
                StreetsForm streetsForm = new StreetsForm(true, connection);
                streetsForm.ShowDialog();
            }
            UpdateData();
        }

        private void editNote_Click(object sender, EventArgs e)
        {
            if (listOfTables.Text == tableNames[0])
            {
                CustomersForm customersForm = new CustomersForm(false, connection, dictionaries, keys, viewTables.SelectedRows[0].Cells);
                customersForm.ShowDialog();
            }
            else if (listOfTables.Text == tableNames[1])
            {
                GoodsForm goodsForm = new GoodsForm(false, connection, dictionaries, keys, viewTables.SelectedRows[0].Cells);
                goodsForm.ShowDialog();
            }
            else if (listOfTables.Text == tableNames[2])
            {
                PackagesForm packagesForm = new PackagesForm();
                packagesForm.ShowDialog();
            }
            else if (listOfTables.Text == tableNames[3])
            {
                ProducersForm producersForm = new ProducersForm(false, connection, dictionaries, keys, viewTables.SelectedRows[0].Cells);
                producersForm.ShowDialog();
            }
            else if (listOfTables.Text == tableNames[4])
            {
                StreetsForm streetsForm = new StreetsForm(false, connection, viewTables.SelectedRows[0].Cells);
                streetsForm.ShowDialog();
            }
            UpdateData();
        }

        private void CheaperThanNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string command = $"SELECT * FROM {tableNames[1]} WHERE Цена < @p1";
                connection.Open();

                NpgsqlCommand com = new NpgsqlCommand(command, connection);
                com.Parameters.AddWithValue("@p1", NpgsqlDbType.Numeric, int.Parse(CheperNTextBox.Text));
                NpgsqlDataAdapter customersAdapter = new NpgsqlDataAdapter(com);
                customersAdapter.Fill(dataSet, "Запрос");

                ExcelQueryForm excelQueryForm = new ExcelQueryForm(dataSet);
                excelQueryForm.ShowDialog();
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

        private void ExpriredGoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string command = $"SELECT * FROM {tableNames[1]} WHERE \"Срок годности\" - @p1 < 0";
                connection.Open();

                NpgsqlCommand com = new NpgsqlCommand(command, connection);
                com.Parameters.AddWithValue("@p1", NpgsqlDbType.Date, DateTime.Today);
                NpgsqlDataAdapter customersAdapter = new NpgsqlDataAdapter(com);
                customersAdapter.Fill(dataSet, "Запрос");

                ExcelQueryForm excelQueryForm = new ExcelQueryForm(dataSet);
                excelQueryForm.ShowDialog();
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
    }
}