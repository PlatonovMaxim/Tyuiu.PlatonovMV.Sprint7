using System;

namespace Tyuiu.PlatonovMV.Sprint7.Project.V9.Lib
{
    public class VideoRecord
    {
        public int ClipId { get; set; }
        public string ClipName { get; set; } = "";
        public DateTime RecordDate { get; set; } = DateTime.Today;
        public int DurationMin { get; set; }
        public string Topic { get; set; } = "";
        public decimal Cost { get; set; }

        public string ActorLastName { get; set; } = "";
        public string ActorFirstName { get; set; } = "";
        public string ActorMiddleName { get; set; } = "";
        public string ActorRole { get; set; } = "";
    }
}