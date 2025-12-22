using System;
using System.Collections.Generic;
using System.Linq;

namespace Tyuiu.PlatonovMV.Sprint7.Project.V9.Lib
{
    public class VideoCatalogService
    {
        public void Add(List<VideoRecord> data, VideoRecord record)
        {
            if (data.Any(x => x.ClipId == record.ClipId))
                throw new ArgumentException("Клип с таким ClipId уже существует.");
            data.Add(record);
        }

        public bool Update(List<VideoRecord> data, VideoRecord record)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].ClipId == record.ClipId)
                {
                    data[i] = record;
                    return true;
                }
            }
            return false;
        }

        public bool RemoveById(List<VideoRecord> data, int clipId)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].ClipId == clipId)
                {
                    data.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public List<VideoRecord> Search(List<VideoRecord> data, string text)
        {
            text = (text ?? "").Trim().ToLower();
            if (text.Length == 0) return data.ToList();

            return data.Where(x =>
                    (x.ClipName ?? "").ToLower().Contains(text) ||
                    (x.Topic ?? "").ToLower().Contains(text) ||
                    (x.ActorLastName ?? "").ToLower().Contains(text) ||
                    (x.ActorFirstName ?? "").ToLower().Contains(text) ||
                    (x.ActorMiddleName ?? "").ToLower().Contains(text) ||
                    (x.ActorRole ?? "").ToLower().Contains(text))
                .ToList();
        }

        public List<VideoRecord> FilterByTopic(List<VideoRecord> data, string topic)
        {
            topic = (topic ?? "").Trim();
            if (topic.Length == 0 || topic == "Все") return data.ToList();

            return data.Where(x => string.Equals(x.Topic, topic, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<VideoRecord> Sort(List<VideoRecord> data, string mode)
        {
            mode = (mode ?? "").Trim();

            return mode switch
            {
                "Стоимость ↑" => data.OrderBy(x => x.Cost).ToList(),
                "Стоимость ↓" => data.OrderByDescending(x => x.Cost).ToList(),
                "Дата ↑" => data.OrderBy(x => x.RecordDate).ToList(),
                "Дата ↓" => data.OrderByDescending(x => x.RecordDate).ToList(),
                "Длительность ↑" => data.OrderBy(x => x.DurationMin).ToList(),
                "Длительность ↓" => data.OrderByDescending(x => x.DurationMin).ToList(),
                _ => data.ToList()
            };
        }

        public VideoCatalogStats GetStats(List<VideoRecord> data)
        {
            VideoCatalogStats s = new VideoCatalogStats();
            s.Count = data.Count;
            if (data.Count == 0) return s;

            s.SumCost = data.Sum(x => x.Cost);
            s.AvgCost = s.SumCost / data.Count;
            s.MinCost = data.Min(x => x.Cost);
            s.MaxCost = data.Max(x => x.Cost);

            s.SumDuration = data.Sum(x => x.DurationMin);
            s.AvgDuration = (double)s.SumDuration / data.Count;
            s.MinDuration = data.Min(x => x.DurationMin);
            s.MaxDuration = data.Max(x => x.DurationMin);

            return s;
        }

        public List<string> GetTopics(List<VideoRecord> data)
        {
            return data.Select(x => x.Topic)
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(x => x)
                .ToList();
        }
    }
}