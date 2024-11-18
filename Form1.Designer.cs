
namespace AI_VOICE_RECOGNITION_BENNETT_TANYAG
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.txtSpeech = new System.Windows.Forms.TextBox();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groundFloorImageList = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(12, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(159, 24);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "MIC IS DISABLED";
            // 
            // btnEnable
            // 
            this.btnEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnable.Location = new System.Drawing.Point(512, 624);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(99, 38);
            this.btnEnable.TabIndex = 1;
            this.btnEnable.Text = "ENABLE";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisable.Location = new System.Drawing.Point(391, 624);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(99, 38);
            this.btnDisable.TabIndex = 2;
            this.btnDisable.Text = "DISABLE";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // txtSpeech
            // 
            this.txtSpeech.BackColor = System.Drawing.Color.White;
            this.txtSpeech.Enabled = false;
            this.txtSpeech.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpeech.Location = new System.Drawing.Point(50, 476);
            this.txtSpeech.Multiline = true;
            this.txtSpeech.Name = "txtSpeech";
            this.txtSpeech.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSpeech.Size = new System.Drawing.Size(561, 125);
            this.txtSpeech.TabIndex = 3;
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(50, 36);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(561, 434);
            this.mediaPlayer.TabIndex = 4;
            this.mediaPlayer.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(617, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(464, 434);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groundFloorImageList
            // 
            this.groundFloorImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.groundFloorImageList.ImageSize = new System.Drawing.Size(256, 256);
            this.groundFloorImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1115, 689);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.txtSpeech);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "VOICE RECOGNITION PROGRAM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.TextBox txtSpeech;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList groundFloorImageList;
        private System.Windows.Forms.Timer timer1;
    }
}

