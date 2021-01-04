using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using ClassLibrary;

namespace AntColony
{
    public partial class Form1 : Form
    {
        Graphics canvas;
        Pen pen;
        
        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        
        private void _generateGraph_Click(object sender, EventArgs e)
        {
            canvas = panel1.CreateGraphics();
            pen = new Pen(Brushes.Black);
            
            panel1.SendToBack();

            // Set the pen's width.
            //skyBluePen.Width = 8.0F;
            
            Graph graph = new Graph(panel1.Size.Height,panel1.Size.Width,canvas);
            graph.generate();
            graph.setNumberOfCities(Convert.ToInt32(txtbox_numOfCities.Text));
            _generateGraph.Enabled = false;
            graph.initializeCities(canvas);
        }
    }
}