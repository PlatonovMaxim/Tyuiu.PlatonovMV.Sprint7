using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Tyuiu.PlatonovMV.Sprint7.Project.V9.Lib
{
    public class CsvVideoCatalogRepository
    {
        private const string Header =
            "ClipId;ClipName;RecordDate;DurationMin;Topic;Cost;ActorLastName;ActorFirstName;ActorMiddleName;ActorRole";

        public List<VideoRecord> Load(string path)
        {
            List<VideoRecord> result = new List<VideoRecord>();

            string[] lines = File.ReadAllLines(path);
            if (lines.Length == 0) return result;

            int start = 0;
            if (lines[0].StartsWith("ClipId;", StringComparison.OrdinalIgnoreCase))
                start = 1;

            for (int i = start; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i])) continue;

                string[] p = lines[i].Split(';');
                if (p.Length < 10) continue;

                VideoRecord r = new VideoRecord();
                r.ClipId = int.Parse(p[0]);
                r.ClipName = p[1];
                r.RecordDate = DateTime.ParseExact(p[2], "yyyy-MM-dd", CultureInfo.InvariantCulture);
                r.DurationMin = int.Parse(p[3]);
                r.Topic = p[4];
                r.Cost = decimal.Parse(p[5], CultureInfo.InvariantCulture);

                r.ActorLastName = p[6];
                r.ActorFirstName = p[7];
                r.ActorMiddleName = p[8];
                r.ActorRole = p[9];

                result.Add(r);
            }

            return result;
        }

        public void Save(string path, List<VideoRecord> data)
        {
            List<string> lines = new List<string>();
            lines.Add(Header);

            for (int i = 0; i < data.Count; i++)
            {
                VideoRecord r = data[i];

                string line =
                    $"{r.ClipId};{r.ClipName};{r.RecordDate:yyyy-MM-dd};{r.DurationMin};{r.Topic};" +
                    $"{r.Cost.ToString(CultureInfo.InvariantCulture)};" +
                    $"{r.ActorLastName};{r.ActorFirstName};{r.ActorMiddleName};{r.ActorRole}";

                lines.Add(line);
            }

            File.WriteAllLines(path, lines);
        }
    }
}