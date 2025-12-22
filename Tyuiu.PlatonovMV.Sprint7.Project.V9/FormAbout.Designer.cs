namespace Tyuiu.PlatonovMV.Sprint7.Project.V9
{
    partial class FormAbout
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelInfo_PMV;
        private System.Windows.Forms.Button buttonOk_PMV;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelInfo_PMV = new System.Windows.Forms.Label();
            this.buttonOk_PMV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // labelInfo_PMV
            //
            this.labelInfo_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInfo_PMV.Name = "labelInfo_PMV";
            this.labelInfo_PMV.Padding = new System.Windows.Forms.Padding(12);
            this.labelInfo_PMV.Text =
                "Разработчик: Платонов М.В.\r\n" +
                "Группа: ИСТНб-25-1\r\n\r\n" +
                "Спринт 7 | Project.V9\r\n" +
                "Каталог видео клипов (CSV)\r\n\r\n" +
                "Tyuiu.PlatonovMV.Sprint7";
            //
            // buttonOk_PMV
            //
            this.buttonOk_PMV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonOk_PMV.Height = 40;
            this.buttonOk_PMV.Name = "buttonOk_PMV";
            this.buttonOk_PMV.Text = "OK";
            this.buttonOk_PMV.UseVisualStyleBackColor = true;
            this.buttonOk_PMV.Click += new System.EventHandler(this.buttonOk_PMV_Click);
            //
            // FormAbout
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 260);
            this.Controls.Add(this.labelInfo_PMV);
            this.Controls.Add(this.buttonOk_PMV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout_PMV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            this.ResumeLayout(false);
        }
    }
}