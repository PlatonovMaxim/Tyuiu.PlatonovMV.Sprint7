namespace Tyuiu.PlatonovMV.Sprint7.Project.V9
{
    partial class FormGuide
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxGuide_PMV;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxGuide_PMV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // textBoxGuide_PMV
            //
            this.textBoxGuide_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxGuide_PMV.Multiline = true;
            this.textBoxGuide_PMV.ReadOnly = true;
            this.textBoxGuide_PMV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGuide_PMV.Name = "textBoxGuide_PMV";
            this.textBoxGuide_PMV.Text =
                "1) Файл → Открыть: загрузить CSV.\r\n" +
                "2) Заполнить поля → Добавить.\r\n" +
                "3) Выбрать строку → изменить поля → Изменить.\r\n" +
                "4) Выбрать строку → Удалить.\r\n" +
                "5) Поиск/Фильтр/Сорт → Применить.\r\n" +
                "6) Инструменты → Статистика.\r\n" +
                "7) Инструменты → График.\r\n" +
                "8) Файл → Сохранить.\r\n";
            //
            // FormGuide
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.textBoxGuide_PMV);
            this.Name = "FormGuide_PMV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Руководство пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}