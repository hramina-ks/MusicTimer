using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WMPLib;

namespace MusicTimer
{
    public partial class FormMain : Form
    {
        IWMPPlaylist playlist;
        int prepareTime;
        int musicTime;
        int pauseTime;
        int rounds;
        int cicles;
        int tk;

        string folder;

        /// <summary>
        /// Создание дерева каталогов.
        /// </summary>
        /// <param name="Dir">Начальная папка.</param>
        /// <param name="Sub">Искать в подпапках.</param>
        /// <param name="Ws">Поток куда записывать дерево.</param>
        /// <param name="Level">Уровень вложенности (не используется).</param>
        /// <returns>Возвращает True, если начальная папка существует, иначе False.</returns>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        struct WIN32_FIND_DATA
        {
            public uint dwFileAttributes;
            public long ftCreationTime;
            public long ftLastAccessTime;
            public long ftLastWriteTime;
            public uint nFileSizeHigh;
            public uint nFileSizeLow;
            private uint dwReserved0;
            private uint dwReserved1;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string cFileName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
            public string cAlternateFileName;
        }

        private const string KERNEL32 = "kernel32.dll";

        [DllImport(KERNEL32, SetLastError = true, CharSet = CharSet.Unicode)]
        static extern IntPtr FindFirstFile(
            string lpFileName,
            ref WIN32_FIND_DATA lpFindFileData
            );

        [DllImport(KERNEL32, SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FindNextFile(
            IntPtr hFindFile,
            out WIN32_FIND_DATA lpFindFileData
            );

        [DllImport(KERNEL32, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FindClose(
            IntPtr hFindFile
            );

        static List<string> CreateTree(string Dir, bool SubDir)
        {
            const string unicode_version = @"\\?\";

            var stack = new Stack<string>();
            var list = new List<string>();
            var wfd = new WIN32_FIND_DATA();
            IntPtr hFile;

            stack.Push(Dir);

            do
            {
                string path;

                do
                {
                    list.Add(Dir = stack.Pop());
                    path = unicode_version + Path.Combine(Dir, "*");
                    hFile = FindFirstFile(path, ref wfd);
                } while (hFile == (IntPtr)(-1));

                do
                {
                    if (wfd.cFileName == "." || wfd.cFileName == "..")
                        continue;

                    path = Path.Combine(Dir, wfd.cFileName);

                    if ((wfd.dwFileAttributes & 0x10) != 0 && SubDir)
                        stack.Push(path);
                    else
                        list.Add(path);
                } while (FindNextFile(hFile, out wfd));

                FindClose(hFile);
            } while (stack.Count != 0);

            return list;
        }
        public FormMain()
        {
            InitializeComponent();
            player.Ctlcontrols.stop();
            player.settings.setMode("shuffle", true);
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            List<string> files = new List<string>();
            IWMPMedia media;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folder = folderBrowserDialog1.SelectedPath;
                playlist = player.newPlaylist("Playlist", folder);
                lbMusicName.Text = folder;
                // читаем папку в строку
                List<string> folderList = CreateTree(folder, true);
                foreach (string dir in folderList)
                {
                    if (dir.Substring(dir.Length - 4) == ".mp3")
                    {
                        files.Add(dir);
                    }
                }
                if (files.Count != 0)
                {
                    songList.Items.Clear();
                    songList.ResetText();
                    for (int i = 0; i < files.Count; i++)
                    {
                        int num = files[i].LastIndexOf("\\");
                        string temp = files[i].Substring(num+1);
                        songList.Items.Add(temp);
                        songList.SelectedIndex = 0;
                    }
                    foreach (string file in files)
                    {
                        media = player.newMedia(file);
                        playlist.appendItem(media);
                    }
                    player.currentPlaylist = playlist;
                    player.Ctlcontrols.stop();
                    btnStart.Enabled = true;
                    songList.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Не найдено ни одного файла mp3");
                }
            }
            else
            {
                MessageBox.Show("Путь не выбран!");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            btnFolder.Enabled = true;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            songList.Enabled = true;
            numStart.Enabled = true;
            numMusic.Enabled = true;
            numPause.Enabled = true;
            numRounds.Enabled = true;
            numCicles.Enabled = true;

            lblStatus.Text = "Ожидание";

            prepareTime = Convert.ToInt32(numStart.Value) * 60;
            musicTime = Convert.ToInt32(numMusic.Value) * 60;
            pauseTime = Convert.ToInt32(numPause.Value) * 60;
            rounds = Convert.ToInt32(numRounds.Value);
            cicles = Convert.ToInt32(numCicles.Value);

            lbCiclesNum.Text = "0";
            lbRoundsNum.Text = "0";
            lbTimer.Text = "00:00";

            PrepareTimer.Stop();
            goTimer.Stop();
            pauseTimer.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            prepareTime = Convert.ToInt32(numStart.Value) * 60;
            musicTime = Convert.ToInt32(numMusic.Value) * 60;
            pauseTime = Convert.ToInt32(numPause.Value) * 60;
            rounds = Convert.ToInt32(numRounds.Value);
            cicles = Convert.ToInt32(numCicles.Value);
            btnStart.Enabled = false;
            btnFolder.Enabled = false;
            btnStop.Enabled = true;
            songList.Enabled = false;

            numStart.Enabled = false;
            numMusic.Enabled = false;
            numPause.Enabled = false;
            numRounds.Enabled = false;
            numCicles.Enabled = false;

            lblStatus.Text = "Подготовка";
            lbRoundsNum.Text = Convert.ToString(rounds);
            lbCiclesNum.Text = Convert.ToString(cicles-1);

            PrepareTimer.Start();
        }

        private void PrepareTimer_Tick(object sender, EventArgs e)
        {
            if (prepareTime >= 1)
            {
                tk = --prepareTime;
                TimeSpan span = TimeSpan.FromSeconds(tk);
                string label;
                if (tk < 3600)
                {
                    label = span.ToString(@"mm\:ss");
                }
                else
                {

                    label = span.ToString(@"hh\:mm\:ss");
                }
                lbTimer.Text = label.ToString();
            }
            else
            {
                PrepareTimer.Stop(); // stops the timer
                PrepareTimer.Dispose(); //releases teh resources used by the timer
                prepareTime = Convert.ToInt32(numStart.Value);

                lblStatus.Text = "Music time";
                lbRoundsNum.Text = Convert.ToString(rounds-1);

                goTimer.Start(); //starts the workout
                goTimer.Enabled = true;

                //Random rnd = new Random();
                //int item = rnd.Next(0, playlist.count - 1);
                int item = 0;
                for (int i = 0; i < playlist.count; i++)
                {
                    int num = songList.Text.LastIndexOf(".");
                    string temp = songList.Text.Substring(0, num);
                    if (playlist.Item[i].name.Equals(temp))
                    {
                        item = i;
                        break;
                    }
                }
                player.Ctlcontrols.playItem(playlist.Item[item]);
            }
        }

        private void goTimer_Tick(object sender, EventArgs e)
        {
            if (musicTime >= 1)
            {
                tk = --musicTime;
                TimeSpan span = TimeSpan.FromSeconds(tk);
                string label;
                if (tk < 3600)
                {
                    label = span.ToString(@"mm\:ss");
                }
                else
                {

                    label = span.ToString(@"hh\:mm\:ss");
                }
                lbTimer.Text = label.ToString();
            }
            else
            {
                player.Ctlcontrols.stop();
                goTimer.Stop(); // stops the timer
                goTimer.Dispose(); //releases teh resources used by the timer
                goTimer.Enabled = false;
                musicTime = Convert.ToInt32(numMusic.Value);

                lblStatus.Text = "Пауза";

                pauseTimer.Enabled = true;
                pauseTimer.Start();
            }

        }

        private void pauseTimer_Tick(object sender, EventArgs e)
        {
            if (pauseTime >= 1)
            {
                tk = --pauseTime;
                TimeSpan span = TimeSpan.FromSeconds(tk);
                string label;
                if (tk < 3600)
                {
                    label = span.ToString(@"mm\:ss");
                }
                else
                {

                    label = span.ToString(@"hh\:mm\:ss");
                }
                lbTimer.Text = label.ToString();
            }
            else
            {
                pauseTimer.Stop(); // stops the timer
                pauseTimer.Dispose(); //releases teh resources used by the timer
                pauseTimer.Enabled = false;
                pauseTime = Convert.ToInt32(numMusic.Value);

                rounds--;
                lbRoundsNum.Text = Convert.ToString(rounds-1);
                prepareTime = Convert.ToInt32(numStart.Value) * 60;
                musicTime = Convert.ToInt32(numMusic.Value) * 60;
                pauseTime = Convert.ToInt32(numPause.Value) * 60;
                if (rounds <= 0)
                {
                    --cicles;
                    rounds = Convert.ToInt32(numRounds.Value);
                    lbCiclesNum.Text = Convert.ToString(cicles-1);
                    player.Ctlcontrols.stop();
                    SoundPlayer fin = new SoundPlayer(Properties.Resources.GlsShutdn);
                    fin.PlaySync();
                    if (cicles <= 0)
                    {
                        fin.PlaySync();
                        btnFolder.Enabled = true;
                        btnStop.Enabled = false;
                        btnStart.Enabled = true;
                        songList.Enabled = true;
                        numStart.Enabled = true;
                        numMusic.Enabled = true;
                        numPause.Enabled = true;
                        numRounds.Enabled = true;
                        numCicles.Enabled = true;

                        lbCiclesNum.Text = "0";
                        lbRoundsNum.Text = "0";
                        lbTimer.Text = "00:00";

                        lblStatus.Text = "Ожидание";
                    }
                    else
                    {
                        lblStatus.Text = "Подготовка";
                        Convert.ToInt32(numCicles.Value);
                        lbRoundsNum.Text = Convert.ToString(rounds-1);
                        lbCiclesNum.Text = Convert.ToString(cicles);

                        PrepareTimer.Start();
                    }
                }
                else
                {
                    lblStatus.Text = "Music time";

                    goTimer.Start(); //starts the workout
                    goTimer.Enabled = true;

                    Random rnd = new Random();
                    int item = rnd.Next(0, playlist.count - 1);
                    player.Ctlcontrols.playItem(playlist.Item[item]);
                }

            }
        }

            private void FormMain_Load(object sender, EventArgs e)
        {
            PrepareTimer.Interval = 1000;
            goTimer.Interval = 1000;
            pauseTimer.Interval = 1000;
            folder = Properties.Settings.Default.folder;
            lbMusicName.Text = Properties.Settings.Default.folder;
            if (!folder.Equals("-"))
            {
                List<string> files = new List<string>();
                IWMPMedia media;
                playlist = player.newPlaylist("Playlist", folder);
                // читаем папку в строку
                List<string> folderList = CreateTree(folder, true);
                foreach (string dir in folderList)
                {
                    if (dir.Substring(dir.Length - 4) == ".mp3")
                    {
                        files.Add(dir);
                    }
                }
                songList.Items.Clear();
                songList.ResetText();
                for (int i = 0; i < files.Count; i++)
                {
                    int num = files[i].LastIndexOf("\\");
                    string temp = files[i].Substring(num + 1);
                    songList.Items.Add(temp);
                    songList.SelectedIndex = 0;
                }
                foreach (string file in files)
                {
                    media = player.newMedia(file);
                    playlist.appendItem(media);
                }
                player.currentPlaylist = playlist;
                player.Ctlcontrols.stop();
                btnStart.Enabled = true;
                songList.Enabled = true;
            }
        }

        private void btnAboutme_Click(object sender, EventArgs e)
        {
            AboutMe f = new AboutMe();
            f.ShowDialog();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string helpText = "Эта программа работает как табата-таймер, в первой части каждого раунда запускающий музыку.\n\n " +
                "Порядок настройки: \n" +
                "1. Выбрать папку с файлами .mp3 \n" +
                "2. Выбрать из списка файл, с которого начнется воспроизведение. Следующие песни будут проигрываться из выбранной папки в случайном порядке. \n" +
                "3. Ввести в поля время в минутах для каждой фазы работы (подготовка к циклу, время на музыку, время паузы). \n" +
                "Если нужный промежуток занимает больше часа, также укажите время в минутах, например, 1 час 20 минут это 80 минут \n" +
                "4. Ввести в поля количество раундов и циклов \n" +
                "5. Нажать на кнопку 'Старт' \n" +
                "6. Если вы хотите закончить работу раньше времени, нажмите на кнопку 'Стоп'. Она сбросит программу к началу с сохранением выбранного времени, папки и первой песни.";
            MessageBox.Show(helpText, "Справка", MessageBoxButtons.OK);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.folder = folder;
            Properties.Settings.Default.Save();
        }
    }
    }
