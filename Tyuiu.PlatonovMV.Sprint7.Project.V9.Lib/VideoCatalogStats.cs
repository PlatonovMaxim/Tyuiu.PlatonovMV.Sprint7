namespace Tyuiu.PlatonovMV.Sprint7.Project.V9.Lib
{
    public class VideoCatalogStats
    {
        public int Count { get; set; }

        public decimal SumCost { get; set; }
        public decimal AvgCost { get; set; }
        public decimal MinCost { get; set; }
        public decimal MaxCost { get; set; }

        public int SumDuration { get; set; }
        public double AvgDuration { get; set; }
        public int MinDuration { get; set; }
        public int MaxDuration { get; set; }
    }
}