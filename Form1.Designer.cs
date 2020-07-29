using System.Drawing;

namespace FinalProject
{
    partial class PlayerApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lvSongs = new System.Windows.Forms.ListView();
            this.hdrName = new System.Windows.Forms.ColumnHeader();
            this.hdrPath = new System.Windows.Forms.ColumnHeader();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBefore = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblPlaylist = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPlaylist = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCurrentAudio = new System.Windows.Forms.Label();
            this.timerMarquee = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.pnlPlaylist.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1041, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "Menu";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuItem2.Text = "Reset";
            // 
            // lvSongs
            // 
            this.lvSongs.AllowDrop = true;
            this.lvSongs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdrName,
            this.hdrPath});
            this.lvSongs.FullRowSelect = true;
            this.lvSongs.HideSelection = false;
            this.lvSongs.LabelWrap = false;
            this.lvSongs.Location = new System.Drawing.Point(15, 46);
            this.lvSongs.MultiSelect = false;
            this.lvSongs.Name = "lvSongs";
            this.lvSongs.Size = new System.Drawing.Size(845, 140);
            this.lvSongs.TabIndex = 1;
            this.lvSongs.UseCompatibleStateImageBehavior = false;
            this.lvSongs.View = System.Windows.Forms.View.Details;
            this.lvSongs.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvSongs_ItemDrag);
            this.lvSongs.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvSongs_DragDrop);
            this.lvSongs.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvSongs_DragEnter);
            // 
            // hdrName
            // 
            this.hdrName.Name = "hdrName";
            this.hdrName.Text = "File Name";
            this.hdrName.Width = 240;
            // 
            // hdrPath
            // 
            this.hdrPath.Name = "hdrPath";
            this.hdrPath.Text = "File Path";
            this.hdrPath.Width = 240;
            // 
            // btnPlay
            // 
            this.btnPlay.Image = new Bitmap(Properties.Resources.Play, new Size(125, 125));
            this.btnPlay.Location = new System.Drawing.Point(432, 19);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(140, 140);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = new Bitmap(Properties.Resources.Next, new Size(125, 125));
            this.btnNext.Location = new System.Drawing.Point(578, 19);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(140, 140);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBefore
            // 
            this.btnBefore.Image = new Bitmap(Properties.Resources.Back, new Size(125, 125));
            this.btnBefore.Location = new System.Drawing.Point(286, 19);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(140, 140);
            this.btnBefore.TabIndex = 4;
            this.btnBefore.UseVisualStyleBackColor = true;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // btnFind
            // 
            this.btnFind.Image = new Bitmap(Properties.Resources.Finder, new Size(125, 125));
            this.btnFind.Location = new System.Drawing.Point(866, 46);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(140, 140);
            this.btnFind.TabIndex = 5;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblPlaylist
            // 
            this.lblPlaylist.AutoSize = true;
            this.lblPlaylist.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlaylist.Location = new System.Drawing.Point(15, 13);
            this.lblPlaylist.Name = "lblPlaylist";
            this.lblPlaylist.Size = new System.Drawing.Size(78, 30);
            this.lblPlaylist.TabIndex = 6;
            this.lblPlaylist.Text = "Playlist";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(87, 20);
            this.toolStripMenuItem1.Text = "Reset Playlist";
            // 
            // pnlPlaylist
            // 
            this.pnlPlaylist.Controls.Add(this.lblPlaylist);
            this.pnlPlaylist.Controls.Add(this.btnFind);
            this.pnlPlaylist.Controls.Add(this.lvSongs);
            this.pnlPlaylist.Location = new System.Drawing.Point(12, 27);
            this.pnlPlaylist.Name = "pnlPlaylist";
            this.pnlPlaylist.Size = new System.Drawing.Size(1017, 215);
            this.pnlPlaylist.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCurrentAudio);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnBefore);
            this.panel1.Location = new System.Drawing.Point(12, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 289);
            this.panel1.TabIndex = 8;
            // 
            // lblCurrentAudio
            // 
            this.lblCurrentAudio.AutoSize = true;
            this.lblCurrentAudio.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentAudio.Location = new System.Drawing.Point(187, 179);
            this.lblCurrentAudio.MaximumSize = new System.Drawing.Size(626, 86);
            this.lblCurrentAudio.Name = "lblCurrentAudio";
            this.lblCurrentAudio.Size = new System.Drawing.Size(626, 86);
            this.lblCurrentAudio.TabIndex = 5;
            this.lblCurrentAudio.Text = "Press Play To Start !";
            this.lblCurrentAudio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerMarquee
            // 
            this.timerMarquee.Tick += new System.EventHandler(this.timerMarquee_Tick);
            // 
            // PlayerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1041, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPlaylist);
            this.Controls.Add(this.menuStrip);
            this.Name = "PlayerApp";
            this.Text = "Reproductor de Música";
            this.Load += new System.EventHandler(this.PlayerApp_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlPlaylist.ResumeLayout(false);
            this.pnlPlaylist.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ListView lvSongs;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBefore;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblPlaylist;
        private System.Windows.Forms.ColumnHeader hdrName;
        private System.Windows.Forms.ColumnHeader hdrPath;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel pnlPlaylist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label lblCurrentAudio;
        private System.Windows.Forms.Timer timerMarquee;
    }
}

