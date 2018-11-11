using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceUtils;
using ClassLib;


namespace Task3
{
    public partial class MainWindow : Form
    {
        List<IPaper> papers;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            papers = new List<IPaper>();
        }

        private void CreateDrawingNotebook_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int quality = int.Parse(inputQuality_txt.Text);
                double thickness = double.Parse(inputThickness_txt.Text);
                int sheetsNum = int.Parse(inputSheetsNum_txt.Text);
                Countries countryManufacturer = (Countries)rnd.Next(0, 5);
                IPaper drawingNotebook = new NotebookForDrawing(quality, thickness, sheetsNum, countryManufacturer);
                papers.Add(drawingNotebook);
                DataGridUtils.NbForDrawingToGrid(dataGrid_dgv, papers);
            }
            catch(Exception)
            {
                MessagesExceptions.ShowError("Проверьте правильность введенных данных!(Качество может быть от 1 до 10; Толщина от 0.5 до 2 мм)");
            }
        }

        private void dataGrid_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
            e.RowIndex >= 0)
                {
                    if (senderGrid.Columns[e.ColumnIndex] == dataGrid_dgv.Columns[OutputQuality.Index])
                    {
                        senderGrid.Rows[e.RowIndex].Cells[OutputQuality.Index].Value = ((NotebookForDrawing)papers[e.RowIndex]).OutputQuality().ToString();
                    }
                    if (senderGrid.Columns[e.ColumnIndex] == dataGrid_dgv.Columns[OutputThickness.Index])
                    {
                        senderGrid.Rows[e.RowIndex].Cells[OutputThickness.Index].Value = ((NotebookForDrawing)papers[e.RowIndex]).OutputThickness().ToString();
                    }
                    if (senderGrid.Columns[e.ColumnIndex] == dataGrid_dgv.Columns[OutputType.Index])
                    {
                        senderGrid.Rows[e.RowIndex].Cells[OutputType.Index].Value = ((NotebookForDrawing)papers[e.RowIndex]).DefineTypeOfProduct().ToString();
                    }
                    if (senderGrid.Columns[e.ColumnIndex] == dataGrid_dgv.Columns[OutputSheetsNum.Index])
                    {
                        senderGrid.Rows[e.RowIndex].Cells[OutputSheetsNum.Index].Value = ((NotebookForDrawing)papers[e.RowIndex]).OutputSheetsNumber().ToString();
                    }
                    if (senderGrid.Columns[e.ColumnIndex] == dataGrid_dgv.Columns[OutputCountryManufacturer.Index])
                    {
                        senderGrid.Rows[e.RowIndex].Cells[OutputCountryManufacturer.Index].Value = ((NotebookForDrawing)papers[e.RowIndex]).OutputCountryManufacturer().ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessagesExceptions.ShowError("Вы вызвали метод для несуществующего объекта, создайте объект");
            }
        }
    }
}
