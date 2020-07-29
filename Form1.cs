using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class PlayerApp : Form
    {
        public PlayerApp()
        {
            InitializeComponent();
        }

        private int currentIndex = 0;
        private SoundPlayer player = new SoundPlayer();
        private List<Audio> audios = new List<Audio>();
        private bool playing = false;

        private void btnFind_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Audio Files (*.wav)|*.wav", ValidateNames = true, Multiselect = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    foreach (string strFile in ofd.FileNames)
                    {
                        FileInfo fileInfo = new FileInfo(strFile);
                        addAudioToPlaylist(new Audio() { Path = fileInfo.FullName, Name = fileInfo.Name });
                    }
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (lvSongs.Items.Count == 0)
            {
                MessageBox.Show(this, "No audio files added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (playing)
                {
                    player.Stop();
                    playing = false;
                    currentIndex = 0;
                    verifyPlayIcon();
                    lblCurrentAudio.Text = "Press Play to Start !";
                }
                else
                {
                    playAudio(currentIndex);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (player != null)
            {
                if (currentIndex + 1 < lvSongs.Items.Count)
                {
                    currentIndex++;
                    playAudio(currentIndex);
                }
            }
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            if (player != null)
            {
                if (!(currentIndex - 1 < 0))
                {
                    currentIndex--;
                    playAudio(currentIndex);
                }
            }
        }

        private void playAudio(int playableIndex)
        {
            player.Stop();
            player.SoundLocation = audios.ElementAt<Audio>(playableIndex).Path;
            playing = true;
            verifyPlayIcon();
            lblCurrentAudio.Text = audios.ElementAt<Audio>(playableIndex).Name;
            player.Play();
        }

        private void verifyPlayIcon()
        {
            if (playing)
            {
                this.btnPlay.Image = new Bitmap((System.Drawing.Image)Properties.Resources.Stop, new Size(125, 125));
            }
            else
            {
                this.btnPlay.Image = new Bitmap((System.Drawing.Image)Properties.Resources.Play, new Size(125, 125));
            }
        }

        private void lvSongs_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Copy);
        }

        private void lvSongs_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void addAudioToPlaylist(Audio audio)
        {
            this.audios.Add(audio);
            ListViewItem item = new ListViewItem(new string[] { audio.Name });
            item.SubItems.Add(audio.Path);
            lvSongs.Items.Add(item);
        }

        private void lvSongs_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                Debug.Print(file);
                if (Path.GetExtension(file) == ".WAV" || Path.GetExtension(file) == ".wav")
                {
                    FileInfo fileInfo = new FileInfo(file);
                    addAudioToPlaylist(new Audio() { Path = fileInfo.FullName, Name = fileInfo.Name });
                }
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Debug.Print("Reset");
        }

        private void timerMarquee_Tick(object sender, EventArgs e)
        {
            if (lblCurrentAudio.Left < 0 && (Math.Abs(lblCurrentAudio.Left) > lblCurrentAudio.Width))
            {
                lblCurrentAudio.Left = this.Width;
            }

            lblCurrentAudio.Left -= 1;
        }

        private void PlayerApp_Load(object sender, EventArgs e)
        {
            this.timerMarquee.Enabled = true;
            this.timerMarquee.Interval = 30;
        }
    }
}
