using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.PlatonovMV.Sprint7.Project.V9.Lib;

namespace Tyuiu.PlatonovMV.Sprint7.Project.V9
{
    public partial class FormMain : Form
    {
        private readonly CsvVideoCatalogRepository repo_PMV = new CsvVideoCatalogRepository();
        private readonly VideoCatalogService service_PMV = new VideoCatalogService();

        private List<VideoRecord> allData_PMV = new List<VideoRecord>();
        private List<VideoRecord> viewData_PMV = new List<VideoRecord>();

        private string currentFilePath_PMV = "";

        public FormMain()
        {
            InitializeComponent();

            // Ничего “рисовать” тут не надо. Только стартовая логика.
            SetDefaultFilePath_PMV();
            TryLoadDefaultFile_PMV();

            // Настройки грида (минимум)
            dataGridViewCatalog_PMV.ReadOnly = true;
            dataGridViewCatalog_PMV.AllowUserToAddRows = false;
            dataGridViewCatalog_PMV.AllowUserToDeleteRows = false;
            dataGridViewCatalog_PMV.RowHeadersVisible = false;
            dataGridViewCatalog_PMV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCatalog_PMV.MultiSelect = false;
            dataGridViewCatalog_PMV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCatalog_PMV.CellClick += dataGridViewCatalog_PMV_CellClick;
        }

        // ===== Путь к CSV рядом с exe: bin\...\Data\VideoCatalog.csv =====
        private void SetDefaultFilePath_PMV()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            currentFilePath_PMV = Path.Combine(baseDir, "Data", "VideoCatalog.csv");
        }

        private void TryLoadDefaultFile_PMV()
        {
            if (!File.Exists(currentFilePath_PMV))
            {
                toolStripStatusLabelState_PMV.Text = "CSV не найден. Файл → Открыть";
                allData_PMV = new List<VideoRecord>();
                RefreshTopics_PMV();
                ApplySearchFilterSort_PMV();
                return;
            }

            LoadFromPath_PMV(currentFilePath_PMV);
        }

        private void LoadFromPath_PMV(string path)
        {
            allData_PMV = repo_PMV.Load(path);
            RefreshTopics_PMV();
            ApplySearchFilterSort_PMV();
            toolStripStatusLabelState_PMV.Text = "Загружено: " + Path.GetFileName(path);
        }

        private void SaveToPath_PMV(string path)
        {
            repo_PMV.Save(path, allData_PMV);
            toolStripStatusLabelState_PMV.Text = "Сохранено: " + Path.GetFileName(path);
        }

        // ===== Обновление ComboBox тем =====
        private void RefreshTopics_PMV()
        {
            string current = comboBoxTopicFilter_PMV.SelectedItem?.ToString() ?? "Все";

            var topics = service_PMV.GetTopics(allData_PMV);

            comboBoxTopicFilter_PMV.Items.Clear();
            comboBoxTopicFilter_PMV.Items.Add("Все");
            foreach (var t in topics)
                comboBoxTopicFilter_PMV.Items.Add(t);

            int idx = comboBoxTopicFilter_PMV.Items.IndexOf(current);
            comboBoxTopicFilter_PMV.SelectedIndex = idx >= 0 ? idx : 0;
        }

        // ===== Применить поиск/фильтр/сорт =====
        private void ApplySearchFilterSort_PMV()
        {
            List<VideoRecord> tmp = allData_PMV.ToList();

            tmp = service_PMV.Search(tmp, textBoxSearch_PMV.Text);

            string topic = comboBoxTopicFilter_PMV.SelectedItem?.ToString() ?? "Все";
            tmp = service_PMV.FilterByTopic(tmp, topic);

            string sortMode = comboBoxSort_PMV.SelectedItem?.ToString() ?? "Без сортировки";
            tmp = service_PMV.Sort(tmp, sortMode);

            viewData_PMV = tmp;

            dataGridViewCatalog_PMV.DataSource = null;
            dataGridViewCatalog_PMV.DataSource = viewData_PMV;

            toolStripStatusLabelState_PMV.Text = $"Записей: {viewData_PMV.Count}";
        }

        // ===== Чтение полей ввода -> VideoRecord =====
        private VideoRecord ReadInputs_PMV()
        {
            return new VideoRecord
            {
                ClipId = (int)numericUpDownClipId_PMV.Value,
                ClipName = textBoxClipName_PMV.Text.Trim(),
                RecordDate = dateTimePickerRecordDate_PMV.Value.Date,
                DurationMin = (int)numericUpDownDuration_PMV.Value,
                Topic = textBoxTopic_PMV.Text.Trim(),
                Cost = numericUpDownCost_PMV.Value,

                ActorLastName = textBoxActorLastName_PMV.Text.Trim(),
                ActorFirstName = textBoxActorFirstName_PMV.Text.Trim(),
                ActorMiddleName = textBoxActorMiddleName_PMV.Text.Trim(),
                ActorRole = textBoxActorRole_PMV.Text.Trim(),
            };
        }

        // ===== Загрузка выбранной строки в поля ввода =====
        private void dataGridViewCatalog_PMV_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCatalog_PMV.CurrentRow?.DataBoundItem is not VideoRecord r) return;

            numericUpDownClipId_PMV.Value = r.ClipId;
            textBoxClipName_PMV.Text = r.ClipName;
            dateTimePickerRecordDate_PMV.Value = r.RecordDate;
            numericUpDownDuration_PMV.Value = r.DurationMin;
            textBoxTopic_PMV.Text = r.Topic;
            numericUpDownCost_PMV.Value = r.Cost;

            textBoxActorLastName_PMV.Text = r.ActorLastName;
            textBoxActorFirstName_PMV.Text = r.ActorFirstName;
            textBoxActorMiddleName_PMV.Text = r.ActorMiddleName;
            textBoxActorRole_PMV.Text = r.ActorRole;
        }

        private void ClearInputs_PMV()
        {
            numericUpDownClipId_PMV.Value = 1;
            textBoxClipName_PMV.Text = "";
            dateTimePickerRecordDate_PMV.Value = DateTime.Today;
            numericUpDownDuration_PMV.Value = 0;
            textBoxTopic_PMV.Text = "";
            numericUpDownCost_PMV.Value = 0;

            textBoxActorLastName_PMV.Text = "";
            textBoxActorFirstName_PMV.Text = "";
            textBoxActorMiddleName_PMV.Text = "";
            textBoxActorRole_PMV.Text = "";
        }

        // ===== CRUD кнопки =====
        private void buttonAdd_PMV_Click(object sender, EventArgs e)
        {
            try
            {
                var rec = ReadInputs_PMV();
                service_PMV.Add(allData_PMV, rec);

                RefreshTopics_PMV();
                ApplySearchFilterSort_PMV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления:\n" + ex.Message);
            }
        }

        private void buttonUpdate_PMV_Click(object sender, EventArgs e)
        {
            try
            {
                var rec = ReadInputs_PMV();
                bool ok = service_PMV.Update(allData_PMV, rec);

                if (!ok) MessageBox.Show("Не найден ClipId для изменения.");

                RefreshTopics_PMV();
                ApplySearchFilterSort_PMV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка изменения:\n" + ex.Message);
            }
        }

        private void buttonDelete_PMV_Click(object sender, EventArgs e)
        {
            if (dataGridViewCatalog_PMV.CurrentRow?.DataBoundItem is not VideoRecord r)
            {
                MessageBox.Show("Выберите запись в таблице.");
                return;
            }

            if (MessageBox.Show($"Удалить ClipId={r.ClipId}?", "Подтверждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            service_PMV.RemoveById(allData_PMV, r.ClipId);

            RefreshTopics_PMV();
            ApplySearchFilterSort_PMV();
        }

        private void buttonClear_PMV_Click(object sender, EventArgs e)
        {
            ClearInputs_PMV();
        }

        // ===== Поиск/фильтр/сорт =====
        private void buttonApplyFilter_PMV_Click(object sender, EventArgs e)
        {
            ApplySearchFilterSort_PMV();
        }

        private void buttonResetFilter_PMV_Click(object sender, EventArgs e)
        {
            textBoxSearch_PMV.Text = "";
            comboBoxTopicFilter_PMV.SelectedIndex = 0;
            comboBoxSort_PMV.SelectedIndex = 0;
            ApplySearchFilterSort_PMV(); //
        }

        // ===== Статистика =====
        private void ShowStats_PMV()
        {
            var st = service_PMV.GetStats(viewData_PMV);

            labelStats_PMV.Text =
                $"Записей: {st.Count}\r\n" +
                $"Стоимость: сумма={st.SumCost.ToString(CultureInfo.InvariantCulture)} " +
                $"ср={st.AvgCost.ToString(CultureInfo.InvariantCulture)} " +
                $"min={st.MinCost} max={st.MaxCost}\r\n" +
                $"Длительность: сумма={st.SumDuration} " +
                $"ср={st.AvgDuration:F2} " +
                $"min={st.MinDuration} max={st.MaxDuration}";
        }

        private void buttonStats_PMV_Click(object sender, EventArgs e) => ShowStats_PMV();
        private void toolStripButtonStats_PMV_Click(object sender, EventArgs e) => ShowStats_PMV();
        private void toolStripMenuItemStats_PMV_Click(object sender, EventArgs e) => ShowStats_PMV();

        // ===== График =====
        private void ShowChart_PMV()
        {
            using FormChart f = new FormChart(viewData_PMV);
            f.ShowDialog();
        }

        private void buttonChart_PMV_Click(object sender, EventArgs e) => ShowChart_PMV();
        private void toolStripButtonChart_PMV_Click(object sender, EventArgs e) => ShowChart_PMV();
        private void toolStripMenuItemChart_PMV_Click(object sender, EventArgs e) => ShowChart_PMV();

        // ===== Файл =====
        private void toolStripButtonOpen_PMV_Click(object sender, EventArgs e) => Open_PMV();
        private void toolStripMenuItemOpen_PMV_Click(object sender, EventArgs e) => Open_PMV();

        private void Open_PMV()
        {
            if (openFileDialog_PMV.ShowDialog() != DialogResult.OK) return;

            currentFilePath_PMV = openFileDialog_PMV.FileName;
            LoadFromPath_PMV(currentFilePath_PMV);
        }

        private void toolStripButtonSave_PMV_Click(object sender, EventArgs e) => Save_PMV();
        private void toolStripMenuItemSave_PMV_Click(object sender, EventArgs e) => Save_PMV();

        private void Save_PMV()
        {
            if (saveFileDialog_PMV.ShowDialog() != DialogResult.OK) return;

            currentFilePath_PMV = saveFileDialog_PMV.FileName;
            SaveToPath_PMV(currentFilePath_PMV);
        }

        private void toolStripMenuItemExit_PMV_Click(object sender, EventArgs e) => Close();

        // ===== Справка =====
        private void toolStripButtonAbout_PMV_Click(object sender, EventArgs e) => new FormAbout().ShowDialog();
        private void toolStripMenuItemAbout_PMV_Click(object sender, EventArgs e) => new FormAbout().ShowDialog();
        private void toolStripMenuItemGuide_PMV_Click(object sender, EventArgs e) => new FormGuide().ShowDialog();
    }
}