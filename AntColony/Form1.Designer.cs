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
            this.panel1 = new System.Windows.Forms.Panel();
            this._generateGraph = new System.Windows.Forms.Button();
            this.txtbox_numOfCities = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 310);
            this.panel1.TabIndex = 0;
            // 
            // _generateGraph
            // 
            this._generateGraph.Location = new System.Drawing.Point(546, 14);
            this._generateGraph.Name = "_generateGraph";
            this._generateGraph.Size = new System.Drawing.Size(172, 44);
            this._generateGraph.TabIndex = 1;
            this._generateGraph.Text = "Сгенерировать граф";
            this._generateGraph.UseVisualStyleBackColor = true;
            this._generateGraph.Click += new System.EventHandler(this._generateGraph_Click);
            // 
            // txtbox_numOfCities
            // 
            this.txtbox_numOfCities.Location = new System.Drawing.Point(547, 73);
            this.txtbox_numOfCities.Name = "txtbox_numOfCities";
            this.txtbox_numOfCities.Size = new System.Drawing.Size(206, 22);
            this.txtbox_numOfCities.TabIndex = 2;
            this.txtbox_numOfCities.Text = "Введите количество городов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbox_numOfCities);
            this.Controls.Add(this._generateGraph);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtbox_numOfCities;

        private System.Windows.Forms.Button _generateGraph;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}