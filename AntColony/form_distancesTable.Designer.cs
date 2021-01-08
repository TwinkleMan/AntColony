using System.ComponentModel;

namespace AntColony
{
    partial class form_distancesTable
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
            this.distances_grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize) (this.distances_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // distances_grid
            // 
            this.distances_grid.AllowUserToAddRows = false;
            this.distances_grid.AllowUserToDeleteRows = false;
            this.distances_grid.AllowUserToResizeColumns = false;
            this.distances_grid.AllowUserToResizeRows = false;
            this.distances_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.distances_grid.ColumnHeadersVisible = false;
            this.distances_grid.Location = new System.Drawing.Point(0, 0);
            this.distances_grid.Name = "distances_grid";
            this.distances_grid.ReadOnly = true;
            this.distances_grid.RowHeadersVisible = false;
            this.distances_grid.RowTemplate.Height = 24;
            this.distances_grid.Size = new System.Drawing.Size(803, 452);
            this.distances_grid.TabIndex = 1;
            // 
            // form_distancesTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.distances_grid);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "form_distancesTable";
            this.Text = "form_distancesTable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_distancesTable_FormClosing);
            this.Load += new System.EventHandler(this.form_distancesTable_Load);
            ((System.ComponentModel.ISupportInitialize) (this.distances_grid)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView distances_grid;

        #endregion
    }
}