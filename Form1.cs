using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
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

public class MusicID3Tag  
        {
 
            public byte[] TAGID = new byte[3];      //  3
        public byte[] Title = new byte[30];     //  30
        /*public byte[] Artist = new byte[30];    //  30 
        public byte[] Album = new byte[30];     //  30 
        public byte[] Year = new byte[4];       //  4 
        public byte[] Comment = new byte[28];   //  30 
        public byte[] Genre = new byte[1];      //  1
        public byte[] Bitrate = new byte[1];
        public byte[] Duration = new byte[1];*/
    }

    public FormMain()
        {
            InitializeComponent();
            player.Ctlcontrols.stop();
            player.settings.setMode("shuffle", true);
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            IWMPMedia media;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folder = folderBrowserDialog1.SelectedPath;
                playlist = player.newPlaylist("Playlist", folder);
                lbMusicName.Text = folder;
                // читаем папку в строку
                String[] files = Directory.GetFiles(folder, "*.mp3*", SearchOption.AllDirectories);
                if (files.Length != 0)
                {
                    songList.Items.Clear();
                    songList.ResetText();
                    for (int i = 0; i < files.Length; i++)
                    {
                        string Title = "";
                        string filePath = files[i];
                        using (FileStream fs = File.OpenRead(filePath))
                        {
                            if (fs.Length >= 128)
                            {
                                MusicID3Tag tag = new MusicID3Tag();
                                fs.Seek(-128, SeekOrigin.End);
                                fs.Read(tag.TAGID, 0, tag.TAGID.Length);
                                fs.Read(tag.Title, 0, tag.Title.Length);
                                string theTAGID = Encoding.Default.GetString(tag.TAGID);
                                if (theTAGID.Equals("TAG"))
                                {

                                    Title = Encoding.Default.GetString(tag.Title);
                                }
                            }
                        }
                        songList.Items.Add(Title);
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

                int item = 0;
                for (int i = 0; i < playlist.count; i++)
                {
                    string temp = songList.Text;
                    temp = temp.TrimStart(' ');
                    temp = temp.TrimEnd(' ');
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
            numStart.Value = Properties.Settings.Default.prepare;
            numMusic.Value = Properties.Settings.Default.music;
            numPause.Value = Properties.Settings.Default.pause;
            numCicles.Value = Properties.Settings.Default.cicles;
            numRounds.Value = Properties.Settings.Default.rounds;
            if (!folder.Equals("-"))
            {
                IWMPMedia media;
                playlist = player.newPlaylist("Playlist", folder);
                String[] files = Directory.GetFiles(folder, "*.mp3*", SearchOption.AllDirectories);
                if (files.Length != 0)
                {
                    songList.Items.Clear();
                    songList.ResetText();
                    for (int i = 0; i < files.Length; i++)
                    {
                        string Title = "";
                        string filePath = files[i];
                        using (FileStream fs = File.OpenRead(filePath))
                        {
                            if (fs.Length >= 128)
                            {
                                MusicID3Tag tag = new MusicID3Tag();
                                fs.Seek(-128, SeekOrigin.End);
                                fs.Read(tag.TAGID, 0, tag.TAGID.Length);
                                fs.Read(tag.Title, 0, tag.Title.Length);
                                string theTAGID = Encoding.Default.GetString(tag.TAGID);
                                if (theTAGID.Equals("TAG"))
                                {

                                    Title = Encoding.Default.GetString(tag.Title);
                                }
                            }
                        }
                        songList.Items.Add(Title);
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
                    songList.SelectedIndex = Properties.Settings.Default.song;
                }
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
                "6. Если вы хотите закончить работу раньше времени, нажмите на кнопку 'Стоп'. Она сбросит программу к началу с сохранением выбранного времени, папки и первой песни. \n" +
                "7. При загрытии программы сохраняется ее последнее состояние - папка, выбранная песня, значения в полях времени и количества." +
                "Стартовая песня сохранится правильно только в том случае, если между открытиями программы содержимое выбранной папки не менялось, т.к. она хранится в виде индекса в плейлисте.";
            MessageBox.Show(helpText, "Справка", MessageBoxButtons.OK);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.folder = folder;
            Properties.Settings.Default.song = songList.SelectedIndex;
            Properties.Settings.Default.prepare = numStart.Value;
            Properties.Settings.Default.music = numMusic.Value;
            Properties.Settings.Default.pause = numPause.Value;
            Properties.Settings.Default.cicles = numCicles.Value;
            Properties.Settings.Default.rounds = numRounds.Value;
            Properties.Settings.Default.Save();
        }
    }
    }
