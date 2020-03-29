namespace SheetMaterialDataBaseApp
{
    partial class MaterialsListForm
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
            this.materialsGrid = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tailsButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.materialsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // materialsGrid
            // 
            this.materialsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.name,
            this.count,
            this.tailsButton});
            this.materialsGrid.Location = new System.Drawing.Point(13, 58);
            this.materialsGrid.Margin = new System.Windows.Forms.Padding(4);
            this.materialsGrid.Name = "materialsGrid";
            this.materialsGrid.RowHeadersWidth = 51;
            this.materialsGrid.Size = new System.Drawing.Size(751, 185);
            this.materialsGrid.TabIndex = 1;
            // 
            // number
            // 
            this.number.HeaderText = "ID";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // count
            // 
            this.count.HeaderText = "Count";
            this.count.MinimumWidth = 6;
            this.count.Name = "count";
            this.count.Width = 125;
            // 
            // tailsButton
            // 
            this.tailsButton.HeaderText = "Tails";
            this.tailsButton.MinimumWidth = 6;
            this.tailsButton.Name = "tailsButton";
            this.tailsButton.Width = 125;
            // 
            // MaterialsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialsGrid);
            this.Name = "MaterialsListForm";
            this.Text = "MaterialsListForm";
            ((System.ComponentModel.ISupportInitialize)(this.materialsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView materialsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewButtonColumn tailsButton;
    }
}