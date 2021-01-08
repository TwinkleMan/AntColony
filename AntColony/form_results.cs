using System;
using System.Drawing;
using System.Windows.Forms;
using ClassLibrary;

namespace AntColony
{
    public partial class form_results : Form
    {
        private Graph _graph;
        private int index = 0;
        private int numberOfImages;
        
        public form_results(Graph graph)
        {
            InitializeComponent();

            _graph = graph;
            numberOfImages = _graph.GetImages().Count;
        }

        private void form_results_Load(object sender, EventArgs e)
        {
            if (_graph.GetImages()[index] != null) pictureBox1.Image = _graph.GetImages()[index];
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            index++;
            if (index < numberOfImages)
            {
                pictureBox1.Image = _graph.GetImages()[index];
            }
            else index = numberOfImages - 1;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            index--;
            if (index >= 0)
            {
                pictureBox1.Image = _graph.GetImages()[index];
            }
            else index = 0;
        }
        
    }
}