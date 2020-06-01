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
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnAboutme = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbMusicFolder = new System.Windows.Forms.Label();
            this.lbMusicName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbRoundsText = new System.Windows.Forms.Label();
            this.lbCiclesText = new System.Windows.Forms.Label();
            this.lbRoundsNum = new System.Windows.Forms.Label();
            this.lbCiclesNum = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.songList = new System.Windows.Forms.ComboBox();
            this.numStart = new System.Windows.Forms.NumericUpDown();
            this.numMusic = new System.Windows.Forms.NumericUpDown();
            this.numPause = new System.Windows.Forms.NumericUpDown();
            this.numRounds = new System.Windows.Forms.NumericUpDown();
            this.numCicles = new System.Windows.Forms.NumericUpDown();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.PrepareTimer = new System.Windows.Forms.Timer(this.components);
            this.goTimer = new System.Windows.Forms.Timer(this.components);
            this.pauseTimer = new System.Windows.Forms.Timer(this.components);
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
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
            this.btnFolder.Location = new System.Drawing.Point(13, 13);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(161, 23);
            this.btnFolder.TabIndex = 1;
            this.btnFolder.Text = "Выбрать папку с музыкой";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(295, 13);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "Справка";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnAboutme
            // 
            this.btnAboutme.Location = new System.Drawing.Point(376, 13);
            this.btnAboutme.Name = "btnAboutme";
            this.btnAboutme.Size = new System.Drawing.Size(75, 23);
            this.btnAboutme.TabIndex = 3;
            this.btnAboutme.Text = "Об авторе";
            this.btnAboutme.UseVisualStyleBackColor = true;
            this.btnAboutme.Click += new System.EventHandler(this.btnAboutme_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.Enabled = false;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(265, 132);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 35);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Enabled = false;
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(265, 178);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(150, 35);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbMusicFolder
            // 
            this.lbMusicFolder.AutoSize = true;
            this.lbMusicFolder.Location = new System.Drawing.Point(10, 48);
            this.lbMusicFolder.Name = "lbMusicFolder";
            this.lbMusicFolder.Size = new System.Drawing.Size(93, 13);
            this.lbMusicFolder.TabIndex = 6;
            this.lbMusicFolder.Text = "Выбрана папка:";
            // 
            // lbMusicName
            // 
            this.lbMusicName.AutoSize = true;
            this.lbMusicName.Location = new System.Drawing.Point(109, 48);
            this.lbMusicName.Name = "lbMusicName";
            this.lbMusicName.Size = new System.Drawing.Size(11, 13);
            this.lbMusicName.TabIndex = 7;
            this.lbMusicName.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Стартовая песня:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Подготовка (мин)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Музыка (мин)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Пауза (мин)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Количество раундов";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Количество циклов";
            // 
            // lbRoundsText
            // 
            this.lbRoundsText.AutoSize = true;
            this.lbRoundsText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRoundsText.Location = new System.Drawing.Point(264, 230);
            this.lbRoundsText.Name = "lbRoundsText";
            this.lbRoundsText.Size = new System.Drawing.Size(151, 21);
            this.lbRoundsText.TabIndex = 14;
            this.lbRoundsText.Text = "Осталось раундов:";
            // 
            // lbCiclesText
            // 
            this.lbCiclesText.AutoSize = true;
            this.lbCiclesText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCiclesText.Location = new System.Drawing.Point(264, 258);
            this.lbCiclesText.Name = "lbCiclesText";
            this.lbCiclesText.Size = new System.Drawing.Size(144, 21);
            this.lbCiclesText.TabIndex = 15;
            this.lbCiclesText.Text = "Осталось циклов:";
            // 
            // lbRoundsNum
            // 
            this.lbRoundsNum.AutoSize = true;
            this.lbRoundsNum.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRoundsNum.Location = new System.Drawing.Point(425, 230);
            this.lbRoundsNum.Name = "lbRoundsNum";
            this.lbRoundsNum.Size = new System.Drawing.Size(19, 21);
            this.lbRoundsNum.TabIndex = 16;
            this.lbRoundsNum.Text = "0";
            // 
            // lbCiclesNum
            // 
            this.lbCiclesNum.AutoSize = true;
            this.lbCiclesNum.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCiclesNum.Location = new System.Drawing.Point(425, 258);
            this.lbCiclesNum.Name = "lbCiclesNum";
            this.lbCiclesNum.Size = new System.Drawing.Size(19, 21);
            this.lbCiclesNum.TabIndex = 17;
            this.lbCiclesNum.Text = "0";
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTimer.Location = new System.Drawing.Point(8, 280);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(66, 30);
            this.lbTimer.TabIndex = 18;
            this.lbTimer.Text = "00:00";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(130, 280);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(122, 30);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Ожидание";
            // 
            // songList
            // 
            this.songList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.songList.Enabled = false;
            this.songList.FormattingEnabled = true;
            this.songList.Location = new System.Drawing.Point(12, 93);
            this.songList.Name = "songList";
            this.songList.Size = new System.Drawing.Size(439, 21);
            this.songList.TabIndex = 20;
            // 
            // numStart
            // 
            this.numStart.Location = new System.Drawing.Point(135, 130);
            this.numStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStart.Name = "numStart";
            this.numStart.Size = new System.Drawing.Size(78, 22);
            this.numStart.TabIndex = 21;
            this.numStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numMusic
            // 
            this.numMusic.Location = new System.Drawing.Point(135, 159);
            this.numMusic.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMusic.Name = "numMusic";
            this.numMusic.Size = new System.Drawing.Size(78, 22);
            this.numMusic.TabIndex = 22;
            this.numMusic.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPause
            // 
            this.numPause.Location = new System.Drawing.Point(135, 187);
            this.numPause.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPause.Name = "numPause";
            this.numPause.Size = new System.Drawing.Size(78, 22);
            this.numPause.TabIndex = 23;
            this.numPause.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numRounds
            // 
            this.numRounds.Location = new System.Drawing.Point(135, 217);
            this.numRounds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRounds.Name = "numRounds";
            this.numRounds.Size = new System.Drawing.Size(78, 22);
            this.numRounds.TabIndex = 24;
            this.numRounds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numCicles
            // 
            this.numCicles.Location = new System.Drawing.Point(135, 245);
            this.numCicles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCicles.Name = "numCicles";
            this.numCicles.Size = new System.Drawing.Size(78, 22);
            this.numCicles.TabIndex = 25;
            this.numCicles.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 325);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(463, 46);
            this.player.TabIndex = 26;
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(463, 371);
            this.Controls.Add(this.player);
            this.Controls.Add(this.numCicles);
            this.Controls.Add(this.numRounds);
            this.Controls.Add(this.numPause);
            this.Controls.Add(this.numMusic);
            this.Controls.Add(this.numStart);
            this.Controls.Add(this.songList);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.lbCiclesNum);
            this.Controls.Add(this.lbRoundsNum);
            this.Controls.Add(this.lbCiclesText);
            this.Controls.Add(this.lbRoundsText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbMusicName);
            this.Controls.Add(this.lbMusicFolder);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnAboutme);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Music Timer";
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
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnAboutme;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lbMusicFolder;
        private System.Windows.Forms.Label lbMusicName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbRoundsText;
        private System.Windows.Forms.Label lbCiclesText;
        private System.Windows.Forms.Label lbRoundsNum;
        private System.Windows.Forms.Label lbCiclesNum;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox songList;
        private System.Windows.Forms.NumericUpDown numStart;
        private System.Windows.Forms.NumericUpDown numMusic;
        private System.Windows.Forms.NumericUpDown numPause;
        private System.Windows.Forms.NumericUpDown numRounds;
        private System.Windows.Forms.NumericUpDown numCicles;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer PrepareTimer;
        private System.Windows.Forms.Timer goTimer;
        private System.Windows.Forms.Timer pauseTimer;
        private AxWMPLib.AxWindowsMediaPlayer player;
    }
}

