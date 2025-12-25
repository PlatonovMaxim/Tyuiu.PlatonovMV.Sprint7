using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Tyuiu.PlatonovMV.Sprint7.Project.V9.Lib;

namespace Tyuiu.PlatonovMV.Sprint7.Project.V9.Test
{
    [TestClass]
    public class StatsTest
    {
        [TestMethod]
        public void GetStats_Correct()
        {
            VideoCatalogService s = new VideoCatalogService();
            List<VideoRecord> data = new List<VideoRecord>
            {
                new VideoRecord { ClipId=1, ClipName="A", RecordDate=DateTime.Today, DurationMin=10, Topic="T", Cost=100 },
                new VideoRecord { ClipId=2, ClipName="B", RecordDate=DateTime.Today, DurationMin=20, Topic="T", Cost=300 },
            };

            VideoCatalogStats st = s.GetStats(data);

            Assert.AreEqual(2, st.Count);
            Assert.AreEqual(400m, st.SumCost);
            Assert.AreEqual(200m, st.AvgCost);
            Assert.AreEqual(100m, st.MinCost);
            Assert.AreEqual(300m, st.MaxCost);

            Assert.AreEqual(30, st.SumDuration);
            Assert.AreEqual(10, st.MinDuration);
            Assert.AreEqual(20, st.MaxDuration);
        }
    }
}
//