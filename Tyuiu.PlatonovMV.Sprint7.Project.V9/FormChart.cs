using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.PlatonovMV.Sprint7.Project.V9.Lib;

namespace Tyuiu.PlatonovMV.Sprint7.Project.V9
{
    public partial class FormChart : Form
    {
        private readonly List<VideoRecord> data_PMV;

        public FormChart(List<VideoRecord> data)
        {
            InitializeComponent();
            data_PMV = data ?? new List<VideoRecord>();

            panelChart_PMV.Paint += panelChart_PMV_Paint;
        }

        private void panelChart_PMV_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            var items = data_PMV.Take(15).ToList();
            if (items.Count == 0)
            {
                g.DrawString("Нет данных", Font, Brushes.Black, 10, 10);
                return;
            }

            decimal max = items.Max(x => x.Cost);
            if (max <= 0) max = 1;

            int w = panelChart_PMV.ClientSize.Width;
            int h = panelChart_PMV.ClientSize.Height;

            int left = 50, right = 20, top = 20, bottom = 60;

            g.DrawLine(Pens.Black, left, top, left, h - bottom);
            g.DrawLine(Pens.Black, left, h - bottom, w - right, h - bottom);

            int chartW = (w - right) - left;
            int chartH = (h - bottom) - top;

            int barCount = items.Count;
            int barW = Math.Max(10, chartW / barCount - 6);

            for (int i = 0; i < barCount; i++)
            {
                var r = items[i];
                float k = (float)(r.Cost / max);
                int barH = (int)(chartH * k);

                int x = left + 10 + i * (barW + 6);
                int y = (h - bottom) - barH;

                g.FillRectangle(Brushes.SteelBlue, x, y, barW, barH);
                g.DrawRectangle(Pens.Black, x, y, barW, barH);

                string label = r.ClipId.ToString();
                var size = g.MeasureString(label, Font);
                g.DrawString(label, Font, Brushes.Black, x + (barW - size.Width) / 2, h - bottom + 5);
            }
        }
    }
}