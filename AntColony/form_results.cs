using System;
using System.Drawing;
using System.Windows.Forms;
using ClassLibrary;

namespace AntColony
{
    public partial class form_results : Form
    {
        private Graph _graph;
        
        public form_results(Graph graph)
        {
            InitializeComponent();

            _graph = graph;
        }

        private void form_results_Load(object sender, EventArgs e)
        {
            if (_graph.GetImages()[0] != null) pictureBox1.Image = _graph.GetImages()[0];
        }
    }
}