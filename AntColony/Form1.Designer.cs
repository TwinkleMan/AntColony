namespace AntColony
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._generateGraph = new System.Windows.Forms.Button();
            this.txtbox_numOfCities = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._distances = new System.Windows.Forms.Button();
            this.lbl_cities = new System.Windows.Forms.Label();
            this.lbl_alpha = new System.Windows.Forms.Label();
            this.lbl_beta = new System.Windows.Forms.Label();
            this.lbl_rho = new System.Windows.Forms.Label();
            this._alpha = new System.Windows.Forms.TextBox();
            this._beta = new System.Windows.Forms.TextBox();
            this._rho = new System.Windows.Forms.TextBox();
            this.lbl_numOfAnts = new System.Windows.Forms.Label();
            this.lbl_numOfIterations = new System.Windows.Forms.Label();
            this.lbl_Q = new System.Windows.Forms.Label();
            this._numOfAnts = new System.Windows.Forms.TextBox();
            this._numOfIterations = new System.Windows.Forms.TextBox();
            this._Q = new System.Windows.Forms.TextBox();
            this._insertGraph = new System.Windows.Forms.Button();
            this._flush = new System.Windows.Forms.Button();
            this._pheromones = new System.Windows.Forms.Button();
            this._antsStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_distance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _generateGraph
            // 
            this._generateGraph.Location = new System.Drawing.Point(933, 344);
            this._generateGraph.Name = "_generateGraph";
            this._generateGraph.Size = new System.Drawing.Size(136, 44);
            this._generateGraph.TabIndex = 1;
            this._generateGraph.Text = "Сгенерировать граф";
            this._generateGraph.UseVisualStyleBackColor = true;
            this._generateGraph.Click += new System.EventHandler(this._generateGraph_Click);
            // 
            // txtbox_numOfCities
            // 
            this.txtbox_numOfCities.Location = new System.Drawing.Point(1006, 49);
            this.txtbox_numOfCities.Name = "txtbox_numOfCities";
            this.txtbox_numOfCities.Size = new System.Drawing.Size(136, 22);
            this.txtbox_numOfCities.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(14, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(894, 726);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // _distances
            // 
            this._distances.Location = new System.Drawing.Point(1075, 697);
            this._distances.Name = "_distances";
            this._distances.Size = new System.Drawing.Size(136, 44);
            this._distances.TabIndex = 4;
            this._distances.Text = "Матрица расстояний";
            this._distances.UseVisualStyleBackColor = true;
            this._distances.Click += new System.EventHandler(this._distances_Click);
            // 
            // lbl_cities
            // 
            this.lbl_cities.Location = new System.Drawing.Point(1006, 15);
            this.lbl_cities.Name = "lbl_cities";
            this.lbl_cities.Size = new System.Drawing.Size(150, 31);
            this.lbl_cities.TabIndex = 5;
            this.lbl_cities.Text = "Количество вершин:";
            // 
            // lbl_alpha
            // 
            this.lbl_alpha.Location = new System.Drawing.Point(927, 99);
            this.lbl_alpha.Name = "lbl_alpha";
            this.lbl_alpha.Size = new System.Drawing.Size(57, 29);
            this.lbl_alpha.TabIndex = 6;
            this.lbl_alpha.Text = "Alpha:";
            // 
            // lbl_beta
            // 
            this.lbl_beta.Location = new System.Drawing.Point(927, 128);
            this.lbl_beta.Name = "lbl_beta";
            this.lbl_beta.Size = new System.Drawing.Size(57, 29);
            this.lbl_beta.TabIndex = 7;
            this.lbl_beta.Text = "Beta:";
            // 
            // lbl_rho
            // 
            this.lbl_rho.Location = new System.Drawing.Point(927, 157);
            this.lbl_rho.Name = "lbl_rho";
            this.lbl_rho.Size = new System.Drawing.Size(57, 29);
            this.lbl_rho.TabIndex = 8;
            this.lbl_rho.Text = "Rho:";
            // 
            // _alpha
            // 
            this._alpha.Location = new System.Drawing.Point(1006, 96);
            this._alpha.Name = "_alpha";
            this._alpha.Size = new System.Drawing.Size(136, 22);
            this._alpha.TabIndex = 9;
            // 
            // _beta
            // 
            this._beta.Location = new System.Drawing.Point(1006, 124);
            this._beta.Name = "_beta";
            this._beta.Size = new System.Drawing.Size(136, 22);
            this._beta.TabIndex = 10;
            // 
            // _rho
            // 
            this._rho.Location = new System.Drawing.Point(1006, 152);
            this._rho.Name = "_rho";
            this._rho.Size = new System.Drawing.Size(136, 22);
            this._rho.TabIndex = 11;
            // 
            // lbl_numOfAnts
            // 
            this.lbl_numOfAnts.Location = new System.Drawing.Point(927, 211);
            this.lbl_numOfAnts.Name = "lbl_numOfAnts";
            this.lbl_numOfAnts.Size = new System.Drawing.Size(84, 29);
            this.lbl_numOfAnts.TabIndex = 12;
            this.lbl_numOfAnts.Text = "Муравьев:";
            // 
            // lbl_numOfIterations
            // 
            this.lbl_numOfIterations.Location = new System.Drawing.Point(927, 239);
            this.lbl_numOfIterations.Name = "lbl_numOfIterations";
            this.lbl_numOfIterations.Size = new System.Drawing.Size(84, 29);
            this.lbl_numOfIterations.TabIndex = 13;
            this.lbl_numOfIterations.Text = "Итераций:";
            // 
            // lbl_Q
            // 
            this.lbl_Q.Location = new System.Drawing.Point(927, 185);
            this.lbl_Q.Name = "lbl_Q";
            this.lbl_Q.Size = new System.Drawing.Size(57, 29);
            this.lbl_Q.TabIndex = 14;
            this.lbl_Q.Text = "Q:";
            // 
            // _numOfAnts
            // 
            this._numOfAnts.Location = new System.Drawing.Point(1006, 208);
            this._numOfAnts.Name = "_numOfAnts";
            this._numOfAnts.Size = new System.Drawing.Size(136, 22);
            this._numOfAnts.TabIndex = 15;
            // 
            // _numOfIterations
            // 
            this._numOfIterations.Location = new System.Drawing.Point(1006, 236);
            this._numOfIterations.Name = "_numOfIterations";
            this._numOfIterations.Size = new System.Drawing.Size(136, 22);
            this._numOfIterations.TabIndex = 16;
            // 
            // _Q
            // 
            this._Q.Location = new System.Drawing.Point(1006, 180);
            this._Q.Name = "_Q";
            this._Q.Size = new System.Drawing.Size(136, 22);
            this._Q.TabIndex = 17;
            // 
            // _insertGraph
            // 
            this._insertGraph.Location = new System.Drawing.Point(1075, 344);
            this._insertGraph.Name = "_insertGraph";
            this._insertGraph.Size = new System.Drawing.Size(136, 44);
            this._insertGraph.TabIndex = 18;
            this._insertGraph.Text = "Расставить вершины вручную";
            this._insertGraph.UseVisualStyleBackColor = true;
            this._insertGraph.Click += new System.EventHandler(this._insertGraph_Click);
            // 
            // _flush
            // 
            this._flush.Location = new System.Drawing.Point(984, 417);
            this._flush.Name = "_flush";
            this._flush.Size = new System.Drawing.Size(172, 44);
            this._flush.TabIndex = 19;
            this._flush.Text = "Сброс";
            this._flush.UseVisualStyleBackColor = true;
            this._flush.Click += new System.EventHandler(this._flush_Click);
            // 
            // _pheromones
            // 
            this._pheromones.Location = new System.Drawing.Point(933, 697);
            this._pheromones.Name = "_pheromones";
            this._pheromones.Size = new System.Drawing.Size(136, 44);
            this._pheromones.TabIndex = 20;
            this._pheromones.Text = "Матрица феромонов";
            this._pheromones.UseVisualStyleBackColor = true;
            this._pheromones.Click += new System.EventHandler(this._pheromones_Click);
            // 
            // _antsStart
            // 
            this._antsStart.Location = new System.Drawing.Point(933, 507);
            this._antsStart.Name = "_antsStart";
            this._antsStart.Size = new System.Drawing.Size(277, 157);
            this._antsStart.TabIndex = 21;
            this._antsStart.Text = "Папалзли";
            this._antsStart.UseVisualStyleBackColor = true;
            this._antsStart.Click += new System.EventHandler(this._antsStart_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(929, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Лучшая длина пути: ";
            // 
            // lbl_distance
            // 
            this.lbl_distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lbl_distance.Location = new System.Drawing.Point(1075, 284);
            this.lbl_distance.Name = "lbl_distance";
            this.lbl_distance.Size = new System.Drawing.Size(140, 21);
            this.lbl_distance.TabIndex = 23;
            this.lbl_distance.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 753);
            this.Controls.Add(this.lbl_distance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._antsStart);
            this.Controls.Add(this._pheromones);
            this.Controls.Add(this._flush);
            this.Controls.Add(this._insertGraph);
            this.Controls.Add(this._Q);
            this.Controls.Add(this._numOfIterations);
            this.Controls.Add(this._numOfAnts);
            this.Controls.Add(this.lbl_Q);
            this.Controls.Add(this.lbl_numOfIterations);
            this.Controls.Add(this.lbl_numOfAnts);
            this.Controls.Add(this._rho);
            this.Controls.Add(this._beta);
            this.Controls.Add(this._alpha);
            this.Controls.Add(this.lbl_rho);
            this.Controls.Add(this.lbl_beta);
            this.Controls.Add(this.lbl_alpha);
            this.Controls.Add(this.lbl_cities);
            this.Controls.Add(this._distances);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtbox_numOfCities);
            this.Controls.Add(this._generateGraph);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Муравьиный алгоритм";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbl_distance;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button _antsStart;

        private System.Windows.Forms.Button _pheromones;

        private System.Windows.Forms.Button _flush;

        private System.Windows.Forms.Button _insertGraph;

        private System.Windows.Forms.TextBox _numOfAnts;
        private System.Windows.Forms.TextBox _numOfIterations;
        private System.Windows.Forms.TextBox _Q;

        private System.Windows.Forms.Label lbl_Q;

        private System.Windows.Forms.Label lbl_numOfAnts;
        private System.Windows.Forms.Label lbl_numOfIterations;

        private System.Windows.Forms.TextBox _alpha;
        private System.Windows.Forms.TextBox _beta;
        private System.Windows.Forms.TextBox _rho;

        private System.Windows.Forms.Label lbl_rho;

        private System.Windows.Forms.Label lbl_beta;

        private System.Windows.Forms.Label lbl_alpha;

        private System.Windows.Forms.Label lbl_cities;

        private System.Windows.Forms.Button _distances;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.TextBox txtbox_numOfCities;

        private System.Windows.Forms.Button _generateGraph;

        #endregion
    }
}