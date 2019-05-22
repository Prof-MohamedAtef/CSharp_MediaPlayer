namespace loopingsound_Good
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOpenAudioFile = new System.Windows.Forms.Button();
            this.playLoopingButton = new System.Windows.Forms.Button();
            this.stopPlayingButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenAudioFile
            // 
            this.btnOpenAudioFile.Location = new System.Drawing.Point(12, 134);
            this.btnOpenAudioFile.Name = "btnOpenAudioFile";
            this.btnOpenAudioFile.Size = new System.Drawing.Size(163, 23);
            this.btnOpenAudioFile.TabIndex = 1;
            this.btnOpenAudioFile.Text = "Select a Sound File to repeat";
            this.btnOpenAudioFile.UseVisualStyleBackColor = true;
            this.btnOpenAudioFile.Click += new System.EventHandler(this.btnOpenAudioFile_Click);
            // 
            // playLoopingButton
            // 
            this.playLoopingButton.Location = new System.Drawing.Point(12, 29);
            this.playLoopingButton.Name = "playLoopingButton";
            this.playLoopingButton.Size = new System.Drawing.Size(75, 23);
            this.playLoopingButton.TabIndex = 0;
            this.playLoopingButton.Text = "Play";
            this.playLoopingButton.UseVisualStyleBackColor = true;
            this.playLoopingButton.Click += new System.EventHandler(this.playLoopingButton_Click);
            // 
            // stopPlayingButton
            // 
            this.stopPlayingButton.Location = new System.Drawing.Point(12, 68);
            this.stopPlayingButton.Name = "stopPlayingButton";
            this.stopPlayingButton.Size = new System.Drawing.Size(75, 23);
            this.stopPlayingButton.TabIndex = 1;
            this.stopPlayingButton.Text = "Stop";
            this.stopPlayingButton.UseVisualStyleBackColor = true;
            this.stopPlayingButton.Click += new System.EventHandler(this.stopPlayingButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-1, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prof-Mohamed - Mob : 2001097555350";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(-1, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "E_mail : proofesser@gmail.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(256, 218);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenAudioFile);
            this.Controls.Add(this.stopPlayingButton);
            this.Controls.Add(this.playLoopingButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Repeat Song";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stopPlayingButton;
        private System.Windows.Forms.Button playLoopingButton;
        private System.Windows.Forms.Button btnOpenAudioFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

