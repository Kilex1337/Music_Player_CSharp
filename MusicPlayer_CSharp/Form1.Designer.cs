
namespace MusicPlayer_CSharp
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.buttonSkipStart = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonSkipEnd = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 61);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(482, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 61);
            this.button1.TabIndex = 8;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Music Player";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusicPlayer_CSharp.Properties.Resources.red_music_note;
            this.pictureBox1.Location = new System.Drawing.Point(142, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonFolder
            // 
            this.buttonFolder.FlatAppearance.BorderSize = 0;
            this.buttonFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFolder.Image = global::MusicPlayer_CSharp.Properties.Resources.icons8_opened_folder_80;
            this.buttonFolder.Location = new System.Drawing.Point(44, 440);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(82, 56);
            this.buttonFolder.TabIndex = 3;
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // buttonSkipStart
            // 
            this.buttonSkipStart.FlatAppearance.BorderSize = 0;
            this.buttonSkipStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSkipStart.Image = global::MusicPlayer_CSharp.Properties.Resources.icons8_skip_to_start_80;
            this.buttonSkipStart.Location = new System.Drawing.Point(132, 435);
            this.buttonSkipStart.Name = "buttonSkipStart";
            this.buttonSkipStart.Size = new System.Drawing.Size(92, 66);
            this.buttonSkipStart.TabIndex = 4;
            this.buttonSkipStart.UseVisualStyleBackColor = true;
            // 
            // buttonPlay
            // 
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Image = global::MusicPlayer_CSharp.Properties.Resources.icons8_circled_play_80;
            this.buttonPlay.Location = new System.Drawing.Point(216, 430);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(104, 77);
            this.buttonPlay.TabIndex = 5;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonSkipEnd
            // 
            this.buttonSkipEnd.FlatAppearance.BorderSize = 0;
            this.buttonSkipEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSkipEnd.Image = global::MusicPlayer_CSharp.Properties.Resources.icons8_end_80;
            this.buttonSkipEnd.Location = new System.Drawing.Point(316, 435);
            this.buttonSkipEnd.Name = "buttonSkipEnd";
            this.buttonSkipEnd.Size = new System.Drawing.Size(92, 66);
            this.buttonSkipEnd.TabIndex = 6;
            this.buttonSkipEnd.UseVisualStyleBackColor = true;
            // 
            // buttonPause
            // 
            this.buttonPause.FlatAppearance.BorderSize = 0;
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPause.Image = global::MusicPlayer_CSharp.Properties.Resources.icons8_stop_64;
            this.buttonPause.Location = new System.Drawing.Point(414, 435);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(92, 66);
            this.buttonPause.TabIndex = 7;
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(164, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Designed by: Aleksa Aksic";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(548, 541);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonSkipEnd);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonSkipStart);
            this.Controls.Add(this.buttonFolder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.Button buttonSkipStart;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonSkipEnd;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

