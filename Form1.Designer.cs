namespace MusicTimer
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnFolder = new System.Windows.Forms.Button();
            this.lbMusicFolder = new System.Windows.Forms.Label();
            this.lbMusicName = new System.Windows.Forms.Label();
            this.lbPauseStart = new System.Windows.Forms.Label();
            this.lbMusic = new System.Windows.Forms.Label();
            this.lbPause = new System.Windows.Forms.Label();
            this.lbRounds = new System.Windows.Forms.Label();
            this.lbCicles = new System.Windows.Forms.Label();
            this.numStart = new System.Windows.Forms.NumericUpDown();
            this.numMusic = new System.Windows.Forms.NumericUpDown();
            this.numPause = new System.Windows.Forms.NumericUpDown();
            this.numRounds = new System.Windows.Forms.NumericUpDown();
            this.numCicles = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbRoundsText = new System.Windows.Forms.Label();
            this.lbCiclesNum = new System.Windows.Forms.Label();
            this.lbRoundsNum = new System.Windows.Forms.Label();
            this.lbCiclesText = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.PrepareTimer = new System.Windows.Forms.Timer(this.components);
            this.goTimer = new System.Windows.Forms.Timer(this.components);
            this.pauseTimer = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.songList = new System.Windows.Forms.ComboBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnAboutme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(12, 12);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(169, 28);
            this.btnFolder.TabIndex = 0;
            this.btnFolder.Text = "Выбрать папку с музыкой";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // lbMusicFolder
            // 
            this.lbMusicFolder.AutoSize = true;
            this.lbMusicFolder.Location = new System.Drawing.Point(12, 52);
            this.lbMusicFolder.Name = "lbMusicFolder";
            this.lbMusicFolder.Size = new System.Drawing.Size(93, 13);
            this.lbMusicFolder.TabIndex = 1;
            this.lbMusicFolder.Text = "Выбрана папка:";
            // 
            // lbMusicName
            // 
            this.lbMusicName.AutoSize = true;
            this.lbMusicName.Location = new System.Drawing.Point(106, 52);
            this.lbMusicName.MaximumSize = new System.Drawing.Size(300, 0);
            this.lbMusicName.Name = "lbMusicName";
            this.lbMusicName.Size = new System.Drawing.Size(11, 13);
            this.lbMusicName.TabIndex = 3;
            this.lbMusicName.Text = "-";
            // 
            // lbPauseStart
            // 
            this.lbPauseStart.AutoSize = true;
            this.lbPauseStart.Location = new System.Drawing.Point(12, 120);
            this.lbPauseStart.Name = "lbPauseStart";
            this.lbPauseStart.Size = new System.Drawing.Size(102, 13);
            this.lbPauseStart.TabIndex = 4;
            this.lbPauseStart.Text = "Подготовка (мин)";
            // 
            // lbMusic
            // 
            this.lbMusic.AutoSize = true;
            this.lbMusic.Location = new System.Drawing.Point(10, 151);
            this.lbMusic.Name = "lbMusic";
            this.lbMusic.Size = new System.Drawing.Size(81, 13);
            this.lbMusic.TabIndex = 5;
            this.lbMusic.Text = "Музыка (мин)";
            // 
            // lbPause
            // 
            this.lbPause.AutoSize = true;
            this.lbPause.Location = new System.Drawing.Point(10, 179);
            this.lbPause.Name = "lbPause";
            this.lbPause.Size = new System.Drawing.Size(71, 13);
            this.lbPause.TabIndex = 6;
            this.lbPause.Text = "Пауза (мин)";
            // 
            // lbRounds
            // 
            this.lbRounds.AutoSize = true;
            this.lbRounds.Location = new System.Drawing.Point(12, 207);
            this.lbRounds.Name = "lbRounds";
            this.lbRounds.Size = new System.Drawing.Size(117, 13);
            this.lbRounds.TabIndex = 7;
            this.lbRounds.Text = "Количество раундов";
            // 
            // lbCicles
            // 
            this.lbCicles.AutoSize = true;
            this.lbCicles.Location = new System.Drawing.Point(12, 238);
            this.lbCicles.Name = "lbCicles";
            this.lbCicles.Size = new System.Drawing.Size(111, 13);
            this.lbCicles.TabIndex = 8;
            this.lbCicles.Text = "Количество циклов";
            // 
            // numStart
            // 
            this.numStart.Location = new System.Drawing.Point(148, 118);
            this.numStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStart.Name = "numStart";
            this.numStart.Size = new System.Drawing.Size(77, 22);
            this.numStart.TabIndex = 9;
            this.numStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numMusic
            // 
            this.numMusic.Location = new System.Drawing.Point(148, 149);
            this.numMusic.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMusic.Name = "numMusic";
            this.numMusic.Size = new System.Drawing.Size(77, 22);
            this.numMusic.TabIndex = 10;
            this.numMusic.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPause
            // 
            this.numPause.Location = new System.Drawing.Point(148, 177);
            this.numPause.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPause.Name = "numPause";
            this.numPause.Size = new System.Drawing.Size(77, 22);
            this.numPause.TabIndex = 11;
            this.numPause.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numRounds
            // 
            this.numRounds.Location = new System.Drawing.Point(148, 204);
            this.numRounds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRounds.Name = "numRounds";
            this.numRounds.Size = new System.Drawing.Size(77, 22);
            this.numRounds.TabIndex = 12;
            this.numRounds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numCicles
            // 
            this.numCicles.Location = new System.Drawing.Point(148, 236);
            this.numCicles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCicles.Name = "numCicles";
            this.numCicles.Size = new System.Drawing.Size(77, 22);
            this.numCicles.TabIndex = 13;
            this.numCicles.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.Enabled = false;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(247, 118);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(124, 35);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Enabled = false;
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(247, 164);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(124, 35);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbRoundsText
            // 
            this.lbRoundsText.AutoSize = true;
            this.lbRoundsText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRoundsText.Location = new System.Drawing.Point(243, 207);
            this.lbRoundsText.Name = "lbRoundsText";
            this.lbRoundsText.Size = new System.Drawing.Size(155, 21);
            this.lbRoundsText.TabIndex = 16;
            this.lbRoundsText.Text = "Осталось раундов: ";
            // 
            // lbCiclesNum
            // 
            this.lbCiclesNum.AutoSize = true;
            this.lbCiclesNum.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCiclesNum.Location = new System.Drawing.Point(397, 238);
            this.lbCiclesNum.Name = "lbCiclesNum";
            this.lbCiclesNum.Size = new System.Drawing.Size(19, 21);
            this.lbCiclesNum.TabIndex = 17;
            this.lbCiclesNum.Text = "0";
            // 
            // lbRoundsNum
            // 
            this.lbRoundsNum.AutoSize = true;
            this.lbRoundsNum.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRoundsNum.Location = new System.Drawing.Point(397, 207);
            this.lbRoundsNum.Name = "lbRoundsNum";
            this.lbRoundsNum.Size = new System.Drawing.Size(19, 21);
            this.lbRoundsNum.TabIndex = 18;
            this.lbRoundsNum.Text = "0";
            // 
            // lbCiclesText
            // 
            this.lbCiclesText.AutoSize = true;
            this.lbCiclesText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCiclesText.Location = new System.Drawing.Point(243, 238);
            this.lbCiclesText.Name = "lbCiclesText";
            this.lbCiclesText.Size = new System.Drawing.Size(144, 21);
            this.lbCiclesText.TabIndex = 19;
            this.lbCiclesText.Text = "Осталось циклов:";
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTimer.Location = new System.Drawing.Point(8, 262);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(84, 37);
            this.lbTimer.TabIndex = 20;
            this.lbTimer.Text = "00:00";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(135, 268);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(122, 30);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "Ожидание";
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 315);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(444, 46);
            this.player.TabIndex = 22;
            // 
            // PrepareTimer
            // 
            this.PrepareTimer.Tick += new System.EventHandler(this.PrepareTimer_Tick);
            // 
            // goTimer
            // 
            this.goTimer.Tick += new System.EventHandler(this.goTimer_Tick);
            // 
            // pauseTimer
            // 
            this.pauseTimer.Tick += new System.EventHandler(this.pauseTimer_Tick);
            // 
            // songList
            // 
            this.songList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.songList.Enabled = false;
            this.songList.FormattingEnabled = true;
            this.songList.Location = new System.Drawing.Point(12, 89);
            this.songList.Name = "songList";
            this.songList.Size = new System.Drawing.Size(417, 21);
            this.songList.Sorted = true;
            this.songList.TabIndex = 23;
            // 
            // btnHelp
            // 
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHelp.Location = new System.Drawing.Point(273, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(80, 28);
            this.btnHelp.TabIndex = 24;
            this.btnHelp.Text = "Справка";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnAboutme
            // 
            this.btnAboutme.Location = new System.Drawing.Point(359, 12);
            this.btnAboutme.Name = "btnAboutme";
            this.btnAboutme.Size = new System.Drawing.Size(73, 28);
            this.btnAboutme.TabIndex = 25;
            this.btnAboutme.Text = "Об авторе";
            this.btnAboutme.UseVisualStyleBackColor = true;
            this.btnAboutme.Click += new System.EventHandler(this.btnAboutme_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Стартовая песня:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAboutme);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.songList);
            this.Controls.Add(this.player);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.lbCiclesText);
            this.Controls.Add(this.lbRoundsNum);
            this.Controls.Add(this.lbCiclesNum);
            this.Controls.Add(this.lbRoundsText);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.numCicles);
            this.Controls.Add(this.numRounds);
            this.Controls.Add(this.numPause);
            this.Controls.Add(this.numMusic);
            this.Controls.Add(this.numStart);
            this.Controls.Add(this.lbCicles);
            this.Controls.Add(this.lbRounds);
            this.Controls.Add(this.lbPause);
            this.Controls.Add(this.lbMusic);
            this.Controls.Add(this.lbPauseStart);
            this.Controls.Add(this.lbMusicName);
            this.Controls.Add(this.lbMusicFolder);
            this.Controls.Add(this.btnFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Label lbMusicFolder;
        private System.Windows.Forms.Label lbMusicName;
        private System.Windows.Forms.Label lbPauseStart;
        private System.Windows.Forms.Label lbMusic;
        private System.Windows.Forms.Label lbPause;
        private System.Windows.Forms.Label lbRounds;
        private System.Windows.Forms.Label lbCicles;
        private System.Windows.Forms.NumericUpDown numStart;
        private System.Windows.Forms.NumericUpDown numMusic;
        private System.Windows.Forms.NumericUpDown numPause;
        private System.Windows.Forms.NumericUpDown numRounds;
        private System.Windows.Forms.NumericUpDown numCicles;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lbRoundsText;
        private System.Windows.Forms.Label lbCiclesNum;
        private System.Windows.Forms.Label lbRoundsNum;
        private System.Windows.Forms.Label lbCiclesText;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Label lblStatus;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Timer PrepareTimer;
        private System.Windows.Forms.Timer goTimer;
        private System.Windows.Forms.Timer pauseTimer;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox songList;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnAboutme;
        private System.Windows.Forms.Label label1;
    }
}

