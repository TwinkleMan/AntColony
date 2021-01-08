using System.ComponentModel;

namespace AntColony
{
    partial class form_pheromonesTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_pheromonesTable));
            this.pheromones_grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize) (this.pheromones_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // pheromones_grid
            // 
            this.pheromones_grid.AllowUserToAddRows = false;
            this.pheromones_grid.AllowUserToDeleteRows = false;
            this.pheromones_grid.AllowUserToResizeColumns = false;
            this.pheromones_grid.AllowUserToResizeRows = false;
            this.pheromones_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pheromones_grid.ColumnHeadersVisible = false;
            this.pheromones_grid.Location = new System.Drawing.Point(0, 0);
            this.pheromones_grid.Name = "pheromones_grid";
            this.pheromones_grid.ReadOnly = true;
            this.pheromones_grid.RowHeadersVisible = false;
            this.pheromones_grid.RowTemplate.Height = 24;
            this.pheromones_grid.Size = new System.Drawing.Size(799, 454);
            this.pheromones_grid.TabIndex = 0;
            // 
            // form_pheromonesTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pheromones_grid);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "form_pheromonesTable";
            this.Text = "Таблица феромонов";
            this.Load += new System.EventHandler(this.form_pheromonesTable_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pheromones_grid)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView pheromones_grid;

        #endregion
    }
}