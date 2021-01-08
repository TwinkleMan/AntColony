using System;
using System.Windows.Forms;
using System.Data;
using ClassLibrary;

namespace AntColony
{
    public partial class form_distancesTable : Form
    {
        private Graph _graph;
        
        public form_distancesTable(Graph graph)
        { 
            InitializeComponent();

            _graph = graph;
        }

        private void form_distancesTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private DataTable getDataTable(double[,] array)
        {
            DataTable table = new DataTable();
            for (int i = 0; i < array.GetLength(1); i++)
                table.Columns.Add();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                table.Rows.Add(table.NewRow());
                for (int j = 0; j < array.GetLength(1); j++)
                    table.Rows[i][j] = array[i,j];
            }
            return table;
        }
        
        private void form_distancesTable_Load(object sender, EventArgs e)
        {
            double[,] distances;

            distances = _graph.getDistances();
            distances_grid.DataSource = getDataTable(distances);
        }
        
    }
}