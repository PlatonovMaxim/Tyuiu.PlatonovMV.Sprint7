namespace Tyuiu.PlatonovMV.Sprint7.Project.V9
{
    partial class FormChart
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelChart_PMV;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelChart_PMV = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            //
            // panelChart_PMV
            //
            this.panelChart_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart_PMV.Name = "panelChart_PMV";
            this.panelChart_PMV.BackColor = System.Drawing.Color.White;
            //
            // FormChart
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.panelChart_PMV);
            this.Name = "FormChart_PMV";
            this.Text = "График | Платонов М.В.";
            this.ResumeLayout(false);
        }
    }
}