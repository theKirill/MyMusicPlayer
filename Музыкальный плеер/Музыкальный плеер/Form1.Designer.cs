namespace Музыкальный_плеер
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playListLB = new System.Windows.Forms.ListBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.trackLength = new System.Windows.Forms.TrackBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelCurrentPosition = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.contextMenu2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.прослушатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.паузаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стопToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.плейлистToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повторятьТрекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повторятьПлейлистToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вСлучайномПорядкеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCurrentSong = new System.Windows.Forms.Label();
            this.labelCurrentSongName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.FileLB = new Microsoft.VisualBasic.Compatibility.VB6.FileListBox();
            this.buttonClearPL = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonRepeatPL = new System.Windows.Forms.Button();
            this.buttonRepeatSong = new System.Windows.Forms.Button();
            this.buttonRand = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.DriveLB = new Microsoft.VisualBasic.Compatibility.VB6.DriveListBox();
            this.DirLB = new Microsoft.VisualBasic.Compatibility.VB6.DirListBox();
            this.FileLB2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLength)).BeginInit();
            this.contextMenu2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playListLB
            // 
            this.playListLB.BackColor = System.Drawing.SystemColors.Menu;
            this.playListLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playListLB.ContextMenuStrip = this.contextMenu;
            this.playListLB.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playListLB.FormattingEnabled = true;
            this.playListLB.ItemHeight = 16;
            this.playListLB.Location = new System.Drawing.Point(681, 118);
            this.playListLB.Name = "playListLB";
            this.playListLB.Size = new System.Drawing.Size(529, 402);
            this.playListLB.TabIndex = 3;
            this.playListLB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.playListLB_KeyDown);
            this.playListLB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.playListLB_MouseDoubleClick);
            this.playListLB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playListLB_MouseDown);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(119, 26);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // trackVolume
            // 
            this.trackVolume.BackColor = System.Drawing.Color.White;
            this.trackVolume.Location = new System.Drawing.Point(964, 532);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(241, 45);
            this.trackVolume.TabIndex = 4;
            this.trackVolume.Value = 50;
            this.trackVolume.Scroll += new System.EventHandler(this.trackVolume_Scroll);
            // 
            // trackLength
            // 
            this.trackLength.Location = new System.Drawing.Point(681, 592);
            this.trackLength.Maximum = 0;
            this.trackLength.Name = "trackLength";
            this.trackLength.Size = new System.Drawing.Size(508, 45);
            this.trackLength.TabIndex = 5;
            this.trackLength.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackLength.Scroll += new System.EventHandler(this.trackLength_Scroll);
            this.trackLength.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelCurrentPosition
            // 
            this.labelCurrentPosition.AutoSize = true;
            this.labelCurrentPosition.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentPosition.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelCurrentPosition.Location = new System.Drawing.Point(686, 619);
            this.labelCurrentPosition.Name = "labelCurrentPosition";
            this.labelCurrentPosition.Size = new System.Drawing.Size(41, 18);
            this.labelCurrentPosition.TabIndex = 6;
            this.labelCurrentPosition.Text = "0:00";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLength.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelLength.Location = new System.Drawing.Point(1148, 619);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(41, 18);
            this.labelLength.TabIndex = 7;
            this.labelLength.Text = "0:00";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "pls|*.pls";
            // 
            // contextMenu2
            // 
            this.contextMenu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прослушатьToolStripMenuItem,
            this.паузаToolStripMenuItem,
            this.стопToolStripMenuItem});
            this.contextMenu2.Name = "contextMenu2";
            this.contextMenu2.Size = new System.Drawing.Size(145, 70);
            this.contextMenu2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu2_Opening);
            // 
            // прослушатьToolStripMenuItem
            // 
            this.прослушатьToolStripMenuItem.Name = "прослушатьToolStripMenuItem";
            this.прослушатьToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.прослушатьToolStripMenuItem.Text = "Прослушать";
            this.прослушатьToolStripMenuItem.Click += new System.EventHandler(this.прослушатьToolStripMenuItem_Click_1);
            // 
            // паузаToolStripMenuItem
            // 
            this.паузаToolStripMenuItem.Name = "паузаToolStripMenuItem";
            this.паузаToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.паузаToolStripMenuItem.Text = "Пауза";
            this.паузаToolStripMenuItem.Click += new System.EventHandler(this.паузаToolStripMenuItem_Click);
            // 
            // стопToolStripMenuItem
            // 
            this.стопToolStripMenuItem.Name = "стопToolStripMenuItem";
            this.стопToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.стопToolStripMenuItem.Text = "Стоп";
            this.стопToolStripMenuItem.Click += new System.EventHandler(this.стопToolStripMenuItem_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelSearch.Location = new System.Drawing.Point(317, 88);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(155, 18);
            this.labelSearch.TabIndex = 11;
            this.labelSearch.Text = "Введите имя файла:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(478, 85);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(174, 23);
            this.textBoxSearch.TabIndex = 12;
            this.textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "pls|*.pls";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.плейлистToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // плейлистToolStripMenuItem
            // 
            this.плейлистToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.плейлистToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.плейлистToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.плейлистToolStripMenuItem.Name = "плейлистToolStripMenuItem";
            this.плейлистToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.плейлистToolStripMenuItem.Text = "Плей-лист";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.открытьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.открытьToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.сохранитьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.сохранитьToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.CheckOnClick = true;
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.повторятьТрекToolStripMenuItem,
            this.повторятьПлейлистToolStripMenuItem,
            this.вСлучайномПорядкеToolStripMenuItem});
            this.настройкиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.настройкиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // повторятьТрекToolStripMenuItem
            // 
            this.повторятьТрекToolStripMenuItem.CheckOnClick = true;
            this.повторятьТрекToolStripMenuItem.Name = "повторятьТрекToolStripMenuItem";
            this.повторятьТрекToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.повторятьТрекToolStripMenuItem.Text = "Повторять трек";
            this.повторятьТрекToolStripMenuItem.CheckedChanged += new System.EventHandler(this.повторятьТрекToolStripMenuItem_CheckedChanged);
            this.повторятьТрекToolStripMenuItem.Click += new System.EventHandler(this.buttonRepeatSong_Click);
            // 
            // повторятьПлейлистToolStripMenuItem
            // 
            this.повторятьПлейлистToolStripMenuItem.Name = "повторятьПлейлистToolStripMenuItem";
            this.повторятьПлейлистToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.повторятьПлейлистToolStripMenuItem.Text = "Повторять плей-лист";
            this.повторятьПлейлистToolStripMenuItem.Click += new System.EventHandler(this.buttonRepeatPL_Click);
            // 
            // вСлучайномПорядкеToolStripMenuItem
            // 
            this.вСлучайномПорядкеToolStripMenuItem.CheckOnClick = true;
            this.вСлучайномПорядкеToolStripMenuItem.Name = "вСлучайномПорядкеToolStripMenuItem";
            this.вСлучайномПорядкеToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.вСлучайномПорядкеToolStripMenuItem.Text = "В случайном порядке";
            this.вСлучайномПорядкеToolStripMenuItem.Click += new System.EventHandler(this.buttonRand_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.справкаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // labelCurrentSong
            // 
            this.labelCurrentSong.AutoSize = true;
            this.labelCurrentSong.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentSong.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelCurrentSong.Location = new System.Drawing.Point(681, 571);
            this.labelCurrentSong.Name = "labelCurrentSong";
            this.labelCurrentSong.Size = new System.Drawing.Size(123, 18);
            this.labelCurrentSong.TabIndex = 17;
            this.labelCurrentSong.Text = "Сейчас играет: ";
            // 
            // labelCurrentSongName
            // 
            this.labelCurrentSongName.AutoSize = true;
            this.labelCurrentSongName.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentSongName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelCurrentSongName.Location = new System.Drawing.Point(810, 571);
            this.labelCurrentSongName.Name = "labelCurrentSongName";
            this.labelCurrentSongName.Size = new System.Drawing.Size(29, 18);
            this.labelCurrentSongName.TabIndex = 19;
            this.labelCurrentSongName.Text = "---";
            // 
            // FileLB
            // 
            this.FileLB.ContextMenuStrip = this.contextMenu2;
            this.FileLB.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileLB.FormattingEnabled = true;
            this.FileLB.Location = new System.Drawing.Point(333, 117);
            this.FileLB.Name = "FileLB";
            this.FileLB.Pattern = "*.mp3";
            this.FileLB.Size = new System.Drawing.Size(319, 564);
            this.FileLB.TabIndex = 20;
            this.toolTip1.SetToolTip(this.FileLB, "Для добавления трека в плей-лист щёлкните по нему два раза или выделите его и наж" +
        "мите Enter");
            this.FileLB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FileLB_KeyDown);
            this.FileLB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FileLB_MouseDoubleClick);
            this.FileLB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FileLB_MouseDown);
            // 
            // buttonClearPL
            // 
            this.buttonClearPL.BackgroundImage = global::Музыкальный_плеер.Properties.Resources.if_023_Document_Delete_183585;
            this.buttonClearPL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClearPL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearPL.Location = new System.Drawing.Point(715, 85);
            this.buttonClearPL.Name = "buttonClearPL";
            this.buttonClearPL.Size = new System.Drawing.Size(29, 29);
            this.buttonClearPL.TabIndex = 34;
            this.toolTip1.SetToolTip(this.buttonClearPL, "Очистить плей-лист");
            this.buttonClearPL.UseVisualStyleBackColor = true;
            this.buttonClearPL.Click += new System.EventHandler(this.buttonClearPL_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.BackgroundImage = global::Музыкальный_плеер.Properties.Resources.if_BT_sort_az_905641;
            this.buttonSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSort.Location = new System.Drawing.Point(680, 85);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(29, 29);
            this.buttonSort.TabIndex = 31;
            this.toolTip1.SetToolTip(this.buttonSort, "Отсортировать плей-лист");
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonRepeatPL
            // 
            this.buttonRepeatPL.BackgroundImage = global::Музыкальный_плеер.Properties.Resources.if_044_Repeat_183173;
            this.buttonRepeatPL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRepeatPL.FlatAppearance.BorderSize = 0;
            this.buttonRepeatPL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.buttonRepeatPL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonRepeatPL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRepeatPL.Location = new System.Drawing.Point(1100, 643);
            this.buttonRepeatPL.Name = "buttonRepeatPL";
            this.buttonRepeatPL.Size = new System.Drawing.Size(45, 39);
            this.buttonRepeatPL.TabIndex = 30;
            this.toolTip1.SetToolTip(this.buttonRepeatPL, "Повтор плей-листа");
            this.buttonRepeatPL.UseVisualStyleBackColor = true;
            this.buttonRepeatPL.Click += new System.EventHandler(this.buttonRepeatPL_Click);
            // 
            // buttonRepeatSong
            // 
            this.buttonRepeatSong.BackgroundImage = global::Музыкальный_плеер.Properties.Resources.if_refresh_134221;
            this.buttonRepeatSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRepeatSong.FlatAppearance.BorderSize = 0;
            this.buttonRepeatSong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.buttonRepeatSong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonRepeatSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRepeatSong.Location = new System.Drawing.Point(1049, 643);
            this.buttonRepeatSong.Name = "buttonRepeatSong";
            this.buttonRepeatSong.Size = new System.Drawing.Size(45, 39);
            this.buttonRepeatSong.TabIndex = 29;
            this.toolTip1.SetToolTip(this.buttonRepeatSong, "Повтор текущего трека");
            this.buttonRepeatSong.UseVisualStyleBackColor = true;
            this.buttonRepeatSong.Click += new System.EventHandler(this.buttonRepeatSong_Click);
            // 
            // buttonRand
            // 
            this.buttonRand.BackgroundImage = global::Музыкальный_плеер.Properties.Resources.if_media_shuffle_49848;
            this.buttonRand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRand.FlatAppearance.BorderSize = 0;
            this.buttonRand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.buttonRand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonRand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRand.Location = new System.Drawing.Point(998, 643);
            this.buttonRand.Name = "buttonRand";
            this.buttonRand.Size = new System.Drawing.Size(45, 39);
            this.buttonRand.TabIndex = 28;
            this.toolTip1.SetToolTip(this.buttonRand, "В случайном порядке");
            this.buttonRand.UseVisualStyleBackColor = true;
            this.buttonRand.Click += new System.EventHandler(this.buttonRand_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackgroundImage = global::Музыкальный_плеер.Properties.Resources.if_controls_stop_103461;
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonStop.FlatAppearance.BorderSize = 0;
            this.buttonStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.buttonStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Location = new System.Drawing.Point(947, 643);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(45, 39);
            this.buttonStop.TabIndex = 27;
            this.toolTip1.SetToolTip(this.buttonStop, "Стоп");
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.BackgroundImage = global::Музыкальный_плеер.Properties.Resources.if_icon_pause_211871;
            this.buttonPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPause.FlatAppearance.BorderSize = 0;
            this.buttonPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.buttonPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPause.Location = new System.Drawing.Point(896, 643);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(45, 39);
            this.buttonPause.TabIndex = 26;
            this.toolTip1.SetToolTip(this.buttonPause, "Пауза");
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackgroundImage = global::Музыкальный_плеер.Properties.Resources.if_controls_chapter_next_103453;
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.buttonNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Location = new System.Drawing.Point(845, 643);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(45, 39);
            this.buttonNext.TabIndex = 25;
            this.toolTip1.SetToolTip(this.buttonNext, "Следующий трек");
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackgroundImage = global::Музыкальный_плеер.Properties.Resources.if_icon_play_211876;
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.buttonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Location = new System.Drawing.Point(794, 643);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(45, 39);
            this.buttonPlay.TabIndex = 24;
            this.toolTip1.SetToolTip(this.buttonPlay, "Воспроизвести");
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.BackgroundImage = global::Музыкальный_плеер.Properties.Resources.if_controls_chapter_previous_103454;
            this.buttonPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPrev.FlatAppearance.BorderSize = 0;
            this.buttonPrev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.buttonPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrev.Location = new System.Drawing.Point(743, 643);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(45, 39);
            this.buttonPrev.TabIndex = 23;
            this.toolTip1.SetToolTip(this.buttonPrev, "Предыдущий трек");
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // DriveLB
            // 
            this.DriveLB.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DriveLB.FormattingEnabled = true;
            this.DriveLB.Location = new System.Drawing.Point(12, 85);
            this.DriveLB.Name = "DriveLB";
            this.DriveLB.Size = new System.Drawing.Size(121, 25);
            this.DriveLB.TabIndex = 21;
            this.DriveLB.SelectedIndexChanged += new System.EventHandler(this.DriveLB_SelectedIndexChanged);
            this.DriveLB.Click += new System.EventHandler(this.DriveLB_Click);
            this.DriveLB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // DirLB
            // 
            this.DirLB.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirLB.FormattingEnabled = true;
            this.DirLB.IntegralHeight = false;
            this.DirLB.Location = new System.Drawing.Point(12, 116);
            this.DirLB.Name = "DirLB";
            this.DirLB.Size = new System.Drawing.Size(302, 565);
            this.DirLB.TabIndex = 22;
            this.DirLB.Change += new System.EventHandler(this.DirLB_Change);
            // 
            // FileLB2
            // 
            this.FileLB2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileLB2.FormattingEnabled = true;
            this.FileLB2.ItemHeight = 16;
            this.FileLB2.Location = new System.Drawing.Point(333, 117);
            this.FileLB2.Name = "FileLB2";
            this.FileLB2.Size = new System.Drawing.Size(319, 564);
            this.FileLB2.TabIndex = 32;
            this.FileLB2.Visible = false;
            this.FileLB2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FileLB2_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(750, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 29);
            this.button1.TabIndex = 33;
            this.button1.Text = "URL";
            this.toolTip1.SetToolTip(this.button1, "Добавить песню по URl-адресу");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 700);
            this.Controls.Add(this.buttonClearPL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FileLB2);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonRepeatPL);
            this.Controls.Add(this.buttonRepeatSong);
            this.Controls.Add(this.buttonRand);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.DirLB);
            this.Controls.Add(this.DriveLB);
            this.Controls.Add(this.FileLB);
            this.Controls.Add(this.labelCurrentSongName);
            this.Controls.Add(this.labelCurrentSong);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.labelCurrentPosition);
            this.Controls.Add(this.trackLength);
            this.Controls.Add(this.trackVolume);
            this.Controls.Add(this.playListLB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1240, 700);
            this.MinimumSize = new System.Drawing.Size(1240, 700);
            this.Name = "Form1";
            this.Text = "Музыкальный плеер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLength)).EndInit();
            this.contextMenu2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox playListLB;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.TrackBar trackLength;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelCurrentPosition;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem плейлистToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Label labelCurrentSong;
        private System.Windows.Forms.Label labelCurrentSongName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenu2;
        private System.Windows.Forms.ToolStripMenuItem прослушатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem паузаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стопToolStripMenuItem;
        private Microsoft.VisualBasic.Compatibility.VB6.FileListBox FileLB;
        private Microsoft.VisualBasic.Compatibility.VB6.DriveListBox DriveLB;
        private Microsoft.VisualBasic.Compatibility.VB6.DirListBox DirLB;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повторятьТрекToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повторятьПлейлистToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вСлучайномПорядкеToolStripMenuItem;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonRand;
        private System.Windows.Forms.Button buttonRepeatSong;
        private System.Windows.Forms.Button buttonRepeatPL;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.ListBox FileLB2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonClearPL;
    }
}

