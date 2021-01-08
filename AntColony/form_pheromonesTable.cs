using System.Windows.Forms;
using ClassLibrary;
using System.Data;
using System;

namespace AntColony
{
    public partial class form_pheromonesTable : Form
    {
        private Graph _graph;
        
        public form_pheromonesTable(Graph graph)
        {
            InitializeComponent();

            _graph = graph;
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

        private void form_pheromonesTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void form_pheromonesTable_Load(object sender, EventArgs e)
        {
            double[,] pheromones;

            pheromones = _graph.getPheromones();
            pheromones_grid.DataSource = getDataTable(pheromones);
        }
    }
}