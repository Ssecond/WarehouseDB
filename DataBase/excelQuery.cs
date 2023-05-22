using System.Data;
using ClosedXML.Excel;

namespace DataBase
{
    public partial class ExcelQueryForm : Form
    {
        private DataSet? dataSet;
        public ExcelQueryForm(DataSet? dataSet)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            queryDataGridView.DataSource = dataSet.Tables["Запрос"];
        }

        private void closeButton_Click(object sender, EventArgs e) => this.Close();

        private void excelOut_Click(object sender, EventArgs e)
        {
            if (dataSet.Tables.Count == 0)
                return;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string temp = saveFileDialog1.FileName + ".xlsx";
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(dataSet.Tables["Запрос"], "Результат запроса");
                    wb.SaveAs(temp);
                }
            }
        }
    }
}
