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
        private Graphics canvas;
        private Pen pen;
        private form_distancesTable form_distances = null;
        private form_pheromonesTable form_pheromones = null;
        private form_results form_results = null;
        public Graph graph;
        private int error;
        private bool isPlacedByHand;
        private int clickCounter;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.White;
            _flush.Enabled = false;
            _distances.Enabled = false;
            _pheromones.Enabled = false;
            _antsStart.Enabled = false;
        }

        private void _generateGraph_Click(object sender, EventArgs e)
        {
            
            _insertGraph.Enabled = false;
            _generateGraph.Enabled = false;
            _flush.Enabled = true;

            if (!isPlacedByHand)
            {
                canvas = pictureBox1.CreateGraphics();
                pen = new Pen(Brushes.Black);
                graph = new Graph(pictureBox1.Size.Height, pictureBox1.Size.Width, canvas);
                _generateGraph.Enabled = false;
                graph.generate();
            }

            error = graph.checkEnteredValues(txtbox_numOfCities.Text, _alpha.Text, _beta.Text, _rho.Text,
                _numOfIterations.Text,
                _Q.Text, _numOfAnts.Text);
            errCheck(error);
            
            if (error == 0)
            {

                if (isPlacedByHand && graph.numberOfClicks != graph.getNumberOfCities())
                {
                    var result = MessageBox.Show(
                        "Количество вершин не соответствует заданному!\nУверены, что хотите продолжить?",
                        "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        graph.setNumberOfCities(clickCounter);
                    }
                }
                graph.initializeCities(canvas);
                _distances.Enabled = true;
                _pheromones.Enabled = true;
                _antsStart.Enabled = true;
            }
        }

        private void _distances_Click(object sender, EventArgs e)
        {
            if (form_distances == null)
            {
                form_distances = new form_distancesTable(graph);
            }

            form_distances.Show();
        }

        private void _flush_Click(object sender, EventArgs e)
        {
            _generateGraph.Enabled = true;
            _insertGraph.Enabled = true;
            _antsStart.Enabled = false;
            _antsStart.Text = "Папалзли";
            _generateGraph.Text = "Сгенерировать граф";
            form_distances = null;
            form_pheromones = null;
            clickCounter = 0;
            _flush.Enabled = false;
            _distances.Enabled = false;
            _pheromones.Enabled = false;
            isPlacedByHand = false;
            lbl_distance.Text = "-";
            
            pictureBox1.Image = null;
            graph = null;
            txtbox_numOfCities.Text = "";
            _alpha.Text = "";
            _beta.Text = "";
            _rho.Text = "";
            _Q.Text = "";
            _numOfAnts.Text = "";
            _numOfIterations.Text = "";
        }

        private void errCheck(int error)
        {
            MessageBoxButtons btn_error = MessageBoxButtons.OK;
            MessageBoxIcon icon_error = MessageBoxIcon.Error;
            string err_caption = "Ошибка";
            string err_text = "Что-то пошло не так с ";
            
            if (error == 0)
            {
                //all ok
                MessageBox.Show("Все данные введены корректно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (error == 1)
            {
                //number of cities
                MessageBox.Show(err_text + "количеством вершин", err_caption, btn_error, icon_error);
            }
            else if (error == 2)
            {
                //alpha
                MessageBox.Show(err_text + "Alpha", err_caption, btn_error, icon_error);
            }
            else if (error == 3)
            {
                //beta
                MessageBox.Show(err_text + "Beta", err_caption, btn_error, icon_error);
            }
            else if (error == 4)
            {
                //rho
                MessageBox.Show(err_text + "Rho", err_caption, btn_error, icon_error);
            }
            else if (error == 5)
            {
                //iterations
                MessageBox.Show(err_text + "количеством итераций", err_caption, btn_error, icon_error);
            }
            else if (error == 6)
            {
                //Q
                MessageBox.Show(err_text + "Q", err_caption, btn_error, icon_error);
            }
            else if (error == 7)
            {
                //number of ants
                MessageBox.Show(err_text + "количеством муравьев", err_caption, btn_error, icon_error);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (isPlacedByHand)
            {
                graph.placeCity(canvas,e.Location);
                clickCounter++;
            }
        }

        private void _insertGraph_Click(object sender, EventArgs e)
        {
            //граф создается относительно вершин, размещенных вручную 
            isPlacedByHand = true;
            _insertGraph.Enabled = false;
            _generateGraph.Text = "Создать граф (польз. точки)";
            _flush.Enabled = true;
            
            canvas = pictureBox1.CreateGraphics();
            pen = new Pen(Brushes.Black);
            graph = new Graph(pictureBox1.Size.Height,pictureBox1.Size.Width,canvas);
        }

        private void _pheromones_Click(object sender, EventArgs e)
        {
            form_pheromones = new form_pheromonesTable(graph);

            form_pheromones.Show();
        }

        private void _antsStart_Click(object sender, EventArgs e)
        {
            graph.Calculate();
            //form_results = new form_results(graph);
            //form_results.Show();
            lbl_distance.Text = Convert.ToString(graph.getBestTourLength());
            pictureBox1.Image = graph.GetImages()[graph.GetImages().Count - 1];
            _antsStart.Enabled = false;
            _antsStart.Text = "Доползались...";
        }

    }
}