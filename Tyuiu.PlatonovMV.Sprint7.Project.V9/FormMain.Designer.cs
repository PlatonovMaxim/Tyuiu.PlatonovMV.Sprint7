namespace Tyuiu.PlatonovMV.Sprint7.Project.V9
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        // ===== components =====
        private System.Windows.Forms.ToolTip toolTipMain_PMV;
        private System.Windows.Forms.OpenFileDialog openFileDialog_PMV;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_PMV;

        // ===== menu =====
        private System.Windows.Forms.MenuStrip menuStripMain_PMV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile_PMV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen_PMV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave_PMV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit_PMV;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTools_PMV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStats_PMV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemChart_PMV;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp_PMV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGuide_PMV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout_PMV;

        // ===== toolbar =====
        private System.Windows.Forms.ToolStrip toolStripMain_PMV;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen_PMV;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave_PMV;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1_PMV;
        private System.Windows.Forms.ToolStripButton toolStripButtonStats_PMV;
        private System.Windows.Forms.ToolStripButton toolStripButtonChart_PMV;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2_PMV;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout_PMV;

        // ===== status =====
        private System.Windows.Forms.StatusStrip statusStripMain_PMV;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelState_PMV;

        // ===== main layout =====
        private System.Windows.Forms.SplitContainer splitContainerMain_PMV;
        private System.Windows.Forms.DataGridView dataGridViewCatalog_PMV;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRight_PMV;

        // ===== search group =====
        private System.Windows.Forms.GroupBox groupBoxSearch_PMV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSearch_PMV;

        private System.Windows.Forms.Label labelSearch_PMV;
        private System.Windows.Forms.TextBox textBoxSearch_PMV;

        private System.Windows.Forms.Label labelTopicFilter_PMV;
        private System.Windows.Forms.ComboBox comboBoxTopicFilter_PMV;

        private System.Windows.Forms.Label labelSort_PMV;
        private System.Windows.Forms.ComboBox comboBoxSort_PMV;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSearchButtons_PMV;
        private System.Windows.Forms.Button buttonApplyFilter_PMV;
        private System.Windows.Forms.Button buttonResetFilter_PMV;

        // ===== edit group =====
        private System.Windows.Forms.GroupBox groupBoxEdit_PMV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelEdit_PMV;

        private System.Windows.Forms.Label labelClipId_PMV;
        private System.Windows.Forms.NumericUpDown numericUpDownClipId_PMV;

        private System.Windows.Forms.Label labelClipName_PMV;
        private System.Windows.Forms.TextBox textBoxClipName_PMV;

        private System.Windows.Forms.Label labelRecordDate_PMV;
        private System.Windows.Forms.DateTimePicker dateTimePickerRecordDate_PMV;

        private System.Windows.Forms.Label labelDuration_PMV;
        private System.Windows.Forms.NumericUpDown numericUpDownDuration_PMV;

        private System.Windows.Forms.Label labelTopic_PMV;
        private System.Windows.Forms.TextBox textBoxTopic_PMV;

        private System.Windows.Forms.Label labelCost_PMV;
        private System.Windows.Forms.NumericUpDown numericUpDownCost_PMV;

        private System.Windows.Forms.Label labelActorLastName_PMV;
        private System.Windows.Forms.TextBox textBoxActorLastName_PMV;

        private System.Windows.Forms.Label labelActorFirstName_PMV;
        private System.Windows.Forms.TextBox textBoxActorFirstName_PMV;

        private System.Windows.Forms.Label labelActorMiddleName_PMV;
        private System.Windows.Forms.TextBox textBoxActorMiddleName_PMV;

        private System.Windows.Forms.Label labelActorRole_PMV;
        private System.Windows.Forms.TextBox textBoxActorRole_PMV;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCrud_PMV;
        private System.Windows.Forms.Button buttonAdd_PMV;
        private System.Windows.Forms.Button buttonUpdate_PMV;
        private System.Windows.Forms.Button buttonDelete_PMV;
        private System.Windows.Forms.Button buttonClear_PMV;

        // ===== stats group =====
        private System.Windows.Forms.GroupBox groupBoxStats_PMV;
        private System.Windows.Forms.Label labelStats_PMV;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelStatsButtons_PMV;
        private System.Windows.Forms.Button buttonStats_PMV;
        private System.Windows.Forms.Button buttonChart_PMV;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTipMain_PMV = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog_PMV = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_PMV = new System.Windows.Forms.SaveFileDialog();

            this.menuStripMain_PMV = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile_PMV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpen_PMV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave_PMV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit_PMV = new System.Windows.Forms.ToolStripMenuItem();

            this.toolStripMenuItemTools_PMV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStats_PMV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemChart_PMV = new System.Windows.Forms.ToolStripMenuItem();

            this.toolStripMenuItemHelp_PMV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGuide_PMV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout_PMV = new System.Windows.Forms.ToolStripMenuItem();

            this.toolStripMain_PMV = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen_PMV = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave_PMV = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1_PMV = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonStats_PMV = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonChart_PMV = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2_PMV = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAbout_PMV = new System.Windows.Forms.ToolStripButton();

            this.statusStripMain_PMV = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelState_PMV = new System.Windows.Forms.ToolStripStatusLabel();

            this.splitContainerMain_PMV = new System.Windows.Forms.SplitContainer();
            this.dataGridViewCatalog_PMV = new System.Windows.Forms.DataGridView();

            this.tableLayoutPanelRight_PMV = new System.Windows.Forms.TableLayoutPanel();

            this.groupBoxSearch_PMV = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelSearch_PMV = new System.Windows.Forms.TableLayoutPanel();
            this.labelSearch_PMV = new System.Windows.Forms.Label();
            this.textBoxSearch_PMV = new System.Windows.Forms.TextBox();
            this.labelTopicFilter_PMV = new System.Windows.Forms.Label();
            this.comboBoxTopicFilter_PMV = new System.Windows.Forms.ComboBox();
            this.labelSort_PMV = new System.Windows.Forms.Label();
            this.comboBoxSort_PMV = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelSearchButtons_PMV = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonApplyFilter_PMV = new System.Windows.Forms.Button();
            this.buttonResetFilter_PMV = new System.Windows.Forms.Button();

            this.groupBoxEdit_PMV = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelEdit_PMV = new System.Windows.Forms.TableLayoutPanel();
            this.labelClipId_PMV = new System.Windows.Forms.Label();
            this.numericUpDownClipId_PMV = new System.Windows.Forms.NumericUpDown();
            this.labelClipName_PMV = new System.Windows.Forms.Label();
            this.textBoxClipName_PMV = new System.Windows.Forms.TextBox();
            this.labelRecordDate_PMV = new System.Windows.Forms.Label();
            this.dateTimePickerRecordDate_PMV = new System.Windows.Forms.DateTimePicker();
            this.labelDuration_PMV = new System.Windows.Forms.Label();
            this.numericUpDownDuration_PMV = new System.Windows.Forms.NumericUpDown();
            this.labelTopic_PMV = new System.Windows.Forms.Label();
            this.textBoxTopic_PMV = new System.Windows.Forms.TextBox();
            this.labelCost_PMV = new System.Windows.Forms.Label();
            this.numericUpDownCost_PMV = new System.Windows.Forms.NumericUpDown();
            this.labelActorLastName_PMV = new System.Windows.Forms.Label();
            this.textBoxActorLastName_PMV = new System.Windows.Forms.TextBox();
            this.labelActorFirstName_PMV = new System.Windows.Forms.Label();
            this.textBoxActorFirstName_PMV = new System.Windows.Forms.TextBox();
            this.labelActorMiddleName_PMV = new System.Windows.Forms.Label();
            this.textBoxActorMiddleName_PMV = new System.Windows.Forms.TextBox();
            this.labelActorRole_PMV = new System.Windows.Forms.Label();
            this.textBoxActorRole_PMV = new System.Windows.Forms.TextBox();

            this.flowLayoutPanelCrud_PMV = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAdd_PMV = new System.Windows.Forms.Button();
            this.buttonUpdate_PMV = new System.Windows.Forms.Button();
            this.buttonDelete_PMV = new System.Windows.Forms.Button();
            this.buttonClear_PMV = new System.Windows.Forms.Button();

            this.groupBoxStats_PMV = new System.Windows.Forms.GroupBox();
            this.labelStats_PMV = new System.Windows.Forms.Label();
            this.flowLayoutPanelStatsButtons_PMV = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonStats_PMV = new System.Windows.Forms.Button();
            this.buttonChart_PMV = new System.Windows.Forms.Button();

            // ===== toolTip =====
            this.toolTipMain_PMV.IsBalloon = true;
            this.toolTipMain_PMV.ShowAlways = true;

            // ===== dialogs =====
            this.openFileDialog_PMV.Filter = "CSV (*.csv)|*.csv|All files (*.*)|*.*";
            this.saveFileDialog_PMV.Filter = "CSV (*.csv)|*.csv|All files (*.*)|*.*";
            this.saveFileDialog_PMV.FileName = "VideoCatalog.csv";

            // ===== menu =====
            this.menuStripMain_PMV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.toolStripMenuItemFile_PMV,
                this.toolStripMenuItemTools_PMV,
                this.toolStripMenuItemHelp_PMV
            });
            this.menuStripMain_PMV.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain_PMV.Name = "menuStripMain_PMV";
            this.menuStripMain_PMV.Size = new System.Drawing.Size(1200, 24);
            this.menuStripMain_PMV.TabIndex = 0;

            this.toolStripMenuItemFile_PMV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.toolStripMenuItemOpen_PMV,
                this.toolStripMenuItemSave_PMV,
                new System.Windows.Forms.ToolStripSeparator(),
                this.toolStripMenuItemExit_PMV
            });
            this.toolStripMenuItemFile_PMV.Name = "toolStripMenuItemFile_PMV";
            this.toolStripMenuItemFile_PMV.Text = "Файл";

            this.toolStripMenuItemOpen_PMV.Name = "toolStripMenuItemOpen_PMV";
            this.toolStripMenuItemOpen_PMV.Text = "Открыть";
            this.toolStripMenuItemOpen_PMV.Click += new System.EventHandler(this.toolStripMenuItemOpen_PMV_Click);

            this.toolStripMenuItemSave_PMV.Name = "toolStripMenuItemSave_PMV";
            this.toolStripMenuItemSave_PMV.Text = "Сохранить";
            this.toolStripMenuItemSave_PMV.Click += new System.EventHandler(this.toolStripMenuItemSave_PMV_Click);

            this.toolStripMenuItemExit_PMV.Name = "toolStripMenuItemExit_PMV";
            this.toolStripMenuItemExit_PMV.Text = "Выход";
            this.toolStripMenuItemExit_PMV.Click += new System.EventHandler(this.toolStripMenuItemExit_PMV_Click);

            this.toolStripMenuItemTools_PMV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.toolStripMenuItemStats_PMV,
                this.toolStripMenuItemChart_PMV
            });
            this.toolStripMenuItemTools_PMV.Name = "toolStripMenuItemTools_PMV";
            this.toolStripMenuItemTools_PMV.Text = "Инструменты";

            this.toolStripMenuItemStats_PMV.Name = "toolStripMenuItemStats_PMV";
            this.toolStripMenuItemStats_PMV.Text = "Статистика";
            this.toolStripMenuItemStats_PMV.Click += new System.EventHandler(this.toolStripMenuItemStats_PMV_Click);

            this.toolStripMenuItemChart_PMV.Name = "toolStripMenuItemChart_PMV";
            this.toolStripMenuItemChart_PMV.Text = "График";
            this.toolStripMenuItemChart_PMV.Click += new System.EventHandler(this.toolStripMenuItemChart_PMV_Click);

            this.toolStripMenuItemHelp_PMV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.toolStripMenuItemGuide_PMV,
                this.toolStripMenuItemAbout_PMV
            });
            this.toolStripMenuItemHelp_PMV.Name = "toolStripMenuItemHelp_PMV";
            this.toolStripMenuItemHelp_PMV.Text = "Справка";

            this.toolStripMenuItemGuide_PMV.Name = "toolStripMenuItemGuide_PMV";
            this.toolStripMenuItemGuide_PMV.Text = "Руководство";
            this.toolStripMenuItemGuide_PMV.Click += new System.EventHandler(this.toolStripMenuItemGuide_PMV_Click);

            this.toolStripMenuItemAbout_PMV.Name = "toolStripMenuItemAbout_PMV";
            this.toolStripMenuItemAbout_PMV.Text = "О программе";
            this.toolStripMenuItemAbout_PMV.Click += new System.EventHandler(this.toolStripMenuItemAbout_PMV_Click);

            // ===== toolstrip =====
            this.toolStripMain_PMV.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStripMain_PMV.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMain_PMV.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain_PMV.Name = "toolStripMain_PMV";
            this.toolStripMain_PMV.Size = new System.Drawing.Size(1200, 25);
            this.toolStripMain_PMV.TabIndex = 1;
            this.toolStripMain_PMV.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.toolStripButtonOpen_PMV,
                this.toolStripButtonSave_PMV,
                this.toolStripSeparator1_PMV,
                this.toolStripButtonStats_PMV,
                this.toolStripButtonChart_PMV,
                this.toolStripSeparator2_PMV,
                this.toolStripButtonAbout_PMV
            });

            this.toolStripButtonOpen_PMV.Name = "toolStripButtonOpen_PMV";
            this.toolStripButtonOpen_PMV.Text = "Открыть";
            this.toolStripButtonOpen_PMV.Click += new System.EventHandler(this.toolStripButtonOpen_PMV_Click);

            this.toolStripButtonSave_PMV.Name = "toolStripButtonSave_PMV";
            this.toolStripButtonSave_PMV.Text = "Сохранить";
            this.toolStripButtonSave_PMV.Click += new System.EventHandler(this.toolStripButtonSave_PMV_Click);

            this.toolStripButtonStats_PMV.Name = "toolStripButtonStats_PMV";
            this.toolStripButtonStats_PMV.Text = "Статистика";
            this.toolStripButtonStats_PMV.Click += new System.EventHandler(this.toolStripButtonStats_PMV_Click);

            this.toolStripButtonChart_PMV.Name = "toolStripButtonChart_PMV";
            this.toolStripButtonChart_PMV.Text = "График";
            this.toolStripButtonChart_PMV.Click += new System.EventHandler(this.toolStripButtonChart_PMV_Click);

            this.toolStripButtonAbout_PMV.Name = "toolStripButtonAbout_PMV";
            this.toolStripButtonAbout_PMV.Text = "О программе";
            this.toolStripButtonAbout_PMV.Click += new System.EventHandler(this.toolStripButtonAbout_PMV_Click);

            // ===== status strip =====
            this.statusStripMain_PMV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripMain_PMV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.toolStripStatusLabelState_PMV
            });
            this.statusStripMain_PMV.Location = new System.Drawing.Point(0, 678);
            this.statusStripMain_PMV.Name = "statusStripMain_PMV";
            this.statusStripMain_PMV.Size = new System.Drawing.Size(1200, 22);

            this.toolStripStatusLabelState_PMV.Name = "toolStripStatusLabelState_PMV";
            this.toolStripStatusLabelState_PMV.Text = "Готово";

            // ===== split container =====
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain_PMV)).BeginInit();
            this.splitContainerMain_PMV.Panel1.SuspendLayout();
            this.splitContainerMain_PMV.Panel2.SuspendLayout();
            this.splitContainerMain_PMV.SuspendLayout();

            this.splitContainerMain_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain_PMV.Location = new System.Drawing.Point(0, 49);
            this.splitContainerMain_PMV.Name = "splitContainerMain_PMV";
            this.splitContainerMain_PMV.SplitterDistance = 780;
            this.splitContainerMain_PMV.TabIndex = 2;

            // left (grid)
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalog_PMV)).BeginInit();
            this.dataGridViewCatalog_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCatalog_PMV.Name = "dataGridViewCatalog_PMV";
            this.splitContainerMain_PMV.Panel1.Controls.Add(this.dataGridViewCatalog_PMV);

            // right layout
            this.tableLayoutPanelRight_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRight_PMV.ColumnCount = 1;
            this.tableLayoutPanelRight_PMV.RowCount = 3;
            this.tableLayoutPanelRight_PMV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelRight_PMV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRight_PMV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanelRight_PMV.Name = "tableLayoutPanelRight_PMV";

            this.splitContainerMain_PMV.Panel2.Controls.Add(this.tableLayoutPanelRight_PMV);

            // ===== Search Group =====
            this.groupBoxSearch_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSearch_PMV.Name = "groupBoxSearch_PMV";
            this.groupBoxSearch_PMV.Text = "Поиск / фильтр / сортировка";

            this.tableLayoutPanelRight_PMV.Controls.Add(this.groupBoxSearch_PMV, 0, 0);

            this.tableLayoutPanelSearch_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSearch_PMV.ColumnCount = 2;
            this.tableLayoutPanelSearch_PMV.RowCount = 4;
            this.tableLayoutPanelSearch_PMV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelSearch_PMV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelSearch_PMV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanelSearch_PMV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanelSearch_PMV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanelSearch_PMV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanelSearch_PMV.Name = "tableLayoutPanelSearch_PMV";
            this.groupBoxSearch_PMV.Controls.Add(this.tableLayoutPanelSearch_PMV);

            this.labelSearch_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSearch_PMV.Text = "Поиск:";
            this.labelSearch_PMV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSearch_PMV.Name = "labelSearch_PMV";

            this.textBoxSearch_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearch_PMV.Name = "textBoxSearch_PMV";

            this.labelTopicFilter_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTopicFilter_PMV.Text = "Тема:";
            this.labelTopicFilter_PMV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTopicFilter_PMV.Name = "labelTopicFilter_PMV";

            this.comboBoxTopicFilter_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxTopicFilter_PMV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTopicFilter_PMV.Name = "comboBoxTopicFilter_PMV";

            this.labelSort_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSort_PMV.Text = "Сортировка:";
            this.labelSort_PMV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSort_PMV.Name = "labelSort_PMV";

            this.comboBoxSort_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSort_PMV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort_PMV.Name = "comboBoxSort_PMV";

            this.flowLayoutPanelSearchButtons_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelSearchButtons_PMV.Name = "flowLayoutPanelSearchButtons_PMV";

            this.buttonApplyFilter_PMV.Text = "Применить";
            this.buttonApplyFilter_PMV.Name = "buttonApplyFilter_PMV";
            this.buttonApplyFilter_PMV.Click += new System.EventHandler(this.buttonApplyFilter_PMV_Click);

            this.buttonResetFilter_PMV.Text = "Сброс";
            this.buttonResetFilter_PMV.Name = "buttonResetFilter_PMV";
            this.buttonResetFilter_PMV.Click += new System.EventHandler(this.buttonResetFilter_PMV_Click);

            this.flowLayoutPanelSearchButtons_PMV.Controls.Add(this.buttonApplyFilter_PMV);
            this.flowLayoutPanelSearchButtons_PMV.Controls.Add(this.buttonResetFilter_PMV);

            this.tableLayoutPanelSearch_PMV.Controls.Add(this.labelSearch_PMV, 0, 0);
            this.tableLayoutPanelSearch_PMV.Controls.Add(this.textBoxSearch_PMV, 1, 0);
            this.tableLayoutPanelSearch_PMV.Controls.Add(this.labelTopicFilter_PMV, 0, 1);
            this.tableLayoutPanelSearch_PMV.Controls.Add(this.comboBoxTopicFilter_PMV, 1, 1);
            this.tableLayoutPanelSearch_PMV.Controls.Add(this.labelSort_PMV, 0, 2);
            this.tableLayoutPanelSearch_PMV.Controls.Add(this.comboBoxSort_PMV, 1, 2);
            this.tableLayoutPanelSearch_PMV.Controls.Add(this.flowLayoutPanelSearchButtons_PMV, 0, 3);
            this.tableLayoutPanelSearch_PMV.SetColumnSpan(this.flowLayoutPanelSearchButtons_PMV, 2);

            // ===== Edit Group =====
            this.groupBoxEdit_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEdit_PMV.Name = "groupBoxEdit_PMV";
            this.groupBoxEdit_PMV.Text = "Ввод / редактирование";

            this.tableLayoutPanelRight_PMV.Controls.Add(this.groupBoxEdit_PMV, 0, 1);

            this.tableLayoutPanelEdit_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelEdit_PMV.ColumnCount = 2;
            this.tableLayoutPanelEdit_PMV.RowCount = 11;
            this.tableLayoutPanelEdit_PMV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelEdit_PMV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            for (int i = 0; i < 11; i++)
                this.tableLayoutPanelEdit_PMV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanelEdit_PMV.Name = "tableLayoutPanelEdit_PMV";
            this.groupBoxEdit_PMV.Controls.Add(this.tableLayoutPanelEdit_PMV);

            // labels+controls edit
            SetupLabel(this.labelClipId_PMV, "Код:", "labelClipId_PMV");
            SetupLabel(this.labelClipName_PMV, "Название:", "labelClipName_PMV");
            SetupLabel(this.labelRecordDate_PMV, "Дата:", "labelRecordDate_PMV");
            SetupLabel(this.labelDuration_PMV, "Длительность:", "labelDuration_PMV");
            SetupLabel(this.labelTopic_PMV, "Тема:", "labelTopic_PMV");
            SetupLabel(this.labelCost_PMV, "Стоимость:", "labelCost_PMV");
            SetupLabel(this.labelActorLastName_PMV, "Фамилия:", "labelActorLastName_PMV");
            SetupLabel(this.labelActorFirstName_PMV, "Имя:", "labelActorFirstName_PMV");
            SetupLabel(this.labelActorMiddleName_PMV, "Отчество:", "labelActorMiddleName_PMV");
            SetupLabel(this.labelActorRole_PMV, "Амплуа:", "labelActorRole_PMV");

            this.numericUpDownClipId_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownClipId_PMV.Minimum = 1;
            this.numericUpDownClipId_PMV.Maximum = 1000000;
            this.numericUpDownClipId_PMV.Name = "numericUpDownClipId_PMV";

            this.textBoxClipName_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxClipName_PMV.Name = "textBoxClipName_PMV";

            this.dateTimePickerRecordDate_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerRecordDate_PMV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRecordDate_PMV.Name = "dateTimePickerRecordDate_PMV";

            this.numericUpDownDuration_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownDuration_PMV.Maximum = 100000;
            this.numericUpDownDuration_PMV.Name = "numericUpDownDuration_PMV";

            this.textBoxTopic_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTopic_PMV.Name = "textBoxTopic_PMV";

            this.numericUpDownCost_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownCost_PMV.DecimalPlaces = 2;
            this.numericUpDownCost_PMV.Maximum = 1000000;
            this.numericUpDownCost_PMV.Name = "numericUpDownCost_PMV";

            this.textBoxActorLastName_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxActorLastName_PMV.Name = "textBoxActorLastName_PMV";

            this.textBoxActorFirstName_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxActorFirstName_PMV.Name = "textBoxActorFirstName_PMV";

            this.textBoxActorMiddleName_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxActorMiddleName_PMV.Name = "textBoxActorMiddleName_PMV";

            this.textBoxActorRole_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxActorRole_PMV.Name = "textBoxActorRole_PMV";

            this.tableLayoutPanelEdit_PMV.Controls.Add(this.labelClipId_PMV, 0, 0);
            this.tableLayoutPanelEdit_PMV.Controls.Add(this.numericUpDownClipId_PMV, 1, 0);

            this.tableLayoutPanelEdit_PMV.Controls.Add(this.labelClipName_PMV, 0, 1);
            this.tableLayoutPanelEdit_PMV.Controls.Add(this.textBoxClipName_PMV, 1, 1);

            this.tableLayoutPanelEdit_PMV.Controls.Add(this.labelRecordDate_PMV, 0, 2);
            this.tableLayoutPanelEdit_PMV.Controls.Add(this.dateTimePickerRecordDate_PMV, 1, 2);

            this.tableLayoutPanelEdit_PMV.Controls.Add(this.labelDuration_PMV, 0, 3);
            this.tableLayoutPanelEdit_PMV.Controls.Add(this.numericUpDownDuration_PMV, 1, 3);

            this.tableLayoutPanelEdit_PMV.Controls.Add(this.labelTopic_PMV, 0, 4);
            this.tableLayoutPanelEdit_PMV.Controls.Add(this.textBoxTopic_PMV, 1, 4);

            this.tableLayoutPanelEdit_PMV.Controls.Add(this.labelCost_PMV, 0, 5);
            this.tableLayoutPanelEdit_PMV.Controls.Add(this.numericUpDownCost_PMV, 1, 5);

            this.tableLayoutPanelEdit_PMV.Controls.Add(this.labelActorLastName_PMV, 0, 6);
            this.tableLayoutPanelEdit_PMV.Controls.Add(this.textBoxActorLastName_PMV, 1, 6);

            this.tableLayoutPanelEdit_PMV.Controls.Add(this.labelActorFirstName_PMV, 0, 7);
            this.tableLayoutPanelEdit_PMV.Controls.Add(this.textBoxActorFirstName_PMV, 1, 7);

            this.tableLayoutPanelEdit_PMV.Controls.Add(this.labelActorMiddleName_PMV, 0, 8);
            this.tableLayoutPanelEdit_PMV.Controls.Add(this.textBoxActorMiddleName_PMV, 1, 8);

            this.tableLayoutPanelEdit_PMV.Controls.Add(this.labelActorRole_PMV, 0, 9);
            this.tableLayoutPanelEdit_PMV.Controls.Add(this.textBoxActorRole_PMV, 1, 9);

            // CRUD buttons row
            this.flowLayoutPanelCrud_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelCrud_PMV.Name = "flowLayoutPanelCrud_PMV";

            this.buttonAdd_PMV.Text = "Добавить";
            this.buttonAdd_PMV.Name = "buttonAdd_PMV";
            this.buttonAdd_PMV.Click += new System.EventHandler(this.buttonAdd_PMV_Click);

            this.buttonUpdate_PMV.Text = "Изменить";
            this.buttonUpdate_PMV.Name = "buttonUpdate_PMV";
            this.buttonUpdate_PMV.Click += new System.EventHandler(this.buttonUpdate_PMV_Click);

            this.buttonDelete_PMV.Text = "Удалить";
            this.buttonDelete_PMV.Name = "buttonDelete_PMV";
            this.buttonDelete_PMV.Click += new System.EventHandler(this.buttonDelete_PMV_Click);

            this.buttonClear_PMV.Text = "Очистить";
            this.buttonClear_PMV.Name = "buttonClear_PMV";
            this.buttonClear_PMV.Click += new System.EventHandler(this.buttonClear_PMV_Click);

            this.flowLayoutPanelCrud_PMV.Controls.Add(this.buttonAdd_PMV);
            this.flowLayoutPanelCrud_PMV.Controls.Add(this.buttonUpdate_PMV);
            this.flowLayoutPanelCrud_PMV.Controls.Add(this.buttonDelete_PMV);
            this.flowLayoutPanelCrud_PMV.Controls.Add(this.buttonClear_PMV);

            this.tableLayoutPanelEdit_PMV.Controls.Add(this.flowLayoutPanelCrud_PMV, 0, 10);
            this.tableLayoutPanelEdit_PMV.SetColumnSpan(this.flowLayoutPanelCrud_PMV, 2);

            // ===== Stats Group =====
            this.groupBoxStats_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxStats_PMV.Name = "groupBoxStats_PMV";
            this.groupBoxStats_PMV.Text = "Статистика";

            this.tableLayoutPanelRight_PMV.Controls.Add(this.groupBoxStats_PMV, 0, 2);

            this.labelStats_PMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStats_PMV.Name = "labelStats_PMV";
            this.labelStats_PMV.Text = "Нажмите «Статистика»";
            this.labelStats_PMV.AutoSize = false;

            this.flowLayoutPanelStatsButtons_PMV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelStatsButtons_PMV.Height = 40;
            this.flowLayoutPanelStatsButtons_PMV.Name = "flowLayoutPanelStatsButtons_PMV";

            this.buttonStats_PMV.Text = "Статистика";
            this.buttonStats_PMV.Name = "buttonStats_PMV";
            this.buttonStats_PMV.Click += new System.EventHandler(this.buttonStats_PMV_Click);

            this.buttonChart_PMV.Text = "График";
            this.buttonChart_PMV.Name = "buttonChart_PMV";
            this.buttonChart_PMV.Click += new System.EventHandler(this.buttonChart_PMV_Click);

            this.flowLayoutPanelStatsButtons_PMV.Controls.Add(this.buttonStats_PMV);
            this.flowLayoutPanelStatsButtons_PMV.Controls.Add(this.buttonChart_PMV);

            this.groupBoxStats_PMV.Controls.Add(this.labelStats_PMV);
            this.groupBoxStats_PMV.Controls.Add(this.flowLayoutPanelStatsButtons_PMV);

            // ===== ToolTips =====
            this.toolStripButtonOpen_PMV.ToolTipText = "Открыть CSV";
            this.toolStripButtonSave_PMV.ToolTipText = "Сохранить CSV";
            this.toolStripButtonStats_PMV.ToolTipText = "Показать статистику";
            this.toolStripButtonChart_PMV.ToolTipText = "Показать график";
            this.toolStripButtonAbout_PMV.ToolTipText = "О программе";

            // ===== FormMain =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.splitContainerMain_PMV);
            this.Controls.Add(this.statusStripMain_PMV);
            this.Controls.Add(this.toolStripMain_PMV);
            this.Controls.Add(this.menuStripMain_PMV);
            this.MainMenuStrip = this.menuStripMain_PMV;
            this.Name = "FormMain_PMV";
            this.Text = "Спринт 7 | Project.V9 | Платонов М.В.";

            // end init
            this.splitContainerMain_PMV.Panel1.ResumeLayout(false);
            this.splitContainerMain_PMV.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain_PMV)).EndInit();
            this.splitContainerMain_PMV.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalog_PMV)).EndInit();
        }

        private static void SetupLabel(System.Windows.Forms.Label lbl, string text, string name)
        {
            lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lbl.Text = text;
            lbl.Name = name;
        }
    }
}