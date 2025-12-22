using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using Tyuiu.PlatonovMV.Sprint7.Project.V9.Lib;

namespace Tyuiu.PlatonovMV.Sprint7.Project.V9.Test
{
    [TestClass]
    public class CsvRepositoryTest
    {
        [TestMethod]
        public void Save_Then_Load_Works()
        {
            string path = Path.GetTempFileName();

            CsvVideoCatalogRepository repo = new CsvVideoCatalogRepository();
            List<VideoRecord> data = new List<VideoRecord>
            {
                new VideoRecord
                {
                    ClipId = 1,
                    ClipName = "X",
                    RecordDate = new DateTime(2025, 11, 20),
                    DurationMin = 12,
                    Topic = "Музыка",
                    Cost = 199.99m,
                    ActorLastName = "Иванов",
                    ActorFirstName = "Иван",
                    ActorMiddleName = "Иванович",
                    ActorRole = "Главная роль"
                }
            };

            repo.Save(path, data);
            List<VideoRecord> loaded = repo.Load(path);

            Assert.AreEqual(1, loaded.Count);
            Assert.AreEqual(1, loaded[0].ClipId);
            Assert.AreEqual("X", loaded[0].ClipName);
            Assert.AreEqual("Музыка", loaded[0].Topic);

            File.Delete(path);
        }
    }
}