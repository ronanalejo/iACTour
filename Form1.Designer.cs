
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
            this.groundFloorImageList = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mezzanineFloorImageList = new System.Windows.Forms.ImageList(this.components);
            this.secondFloorImageList = new System.Windows.Forms.ImageList(this.components);
            this.thirdFloorImageList = new System.Windows.Forms.ImageList(this.components);
            this.fourthFloorImageList = new System.Windows.Forms.ImageList(this.components);
            this.fifthFloorImageList = new System.Windows.Forms.ImageList(this.components);
            this.sixthFloorImageList = new System.Windows.Forms.ImageList(this.components);
            this.seventhFloorImageList = new System.Windows.Forms.ImageList(this.components);
            this.eighthFloorImageList = new System.Windows.Forms.ImageList(this.components);
            this.ninthFloorImageList = new System.Windows.Forms.ImageList(this.components);
            this.tenthFloorImageList = new System.Windows.Forms.ImageList(this.components);
            this.twelfthFloorImageList = new System.Windows.Forms.ImageList(this.components);
            this.lpFloorImageList = new System.Windows.Forms.ImageList(this.components);
            this.upFloorImageList = new System.Windows.Forms.ImageList(this.components);
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
            // groundFloorImageList
            // 
            this.groundFloorImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("groundFloorImageList.ImageStream")));
            this.groundFloorImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.groundFloorImageList.Images.SetKeyName(0, "LOBBY - MAKATI.jpg");
            this.groundFloorImageList.Images.SetKeyName(1, "Turnstile.JPG");
            this.groundFloorImageList.Images.SetKeyName(2, "Equipment.JPG");
            this.groundFloorImageList.Images.SetKeyName(3, "PARTNERS HIVE - MAKATI.JPG");
            this.groundFloorImageList.Images.SetKeyName(4, "Gamer\'s Hive.JPG");
            this.groundFloorImageList.Images.SetKeyName(5, "ATM Machine.JPG");
            this.groundFloorImageList.Images.SetKeyName(6, "Admission\'s Office.JPG");
            this.groundFloorImageList.Images.SetKeyName(7, "Registrar.JPG");
            this.groundFloorImageList.Images.SetKeyName(8, "Finance.JPG");
            this.groundFloorImageList.Images.SetKeyName(9, "Clinic.JPG");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
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
            this.pictureBox1.Size = new System.Drawing.Size(486, 434);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // mezzanineFloorImageList
            // 
            this.mezzanineFloorImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mezzanineFloorImageList.ImageStream")));
            this.mezzanineFloorImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.mezzanineFloorImageList.Images.SetKeyName(0, "Meeting Rooms.JPG");
            this.mezzanineFloorImageList.Images.SetKeyName(1, "OSAS.JPG");
            this.mezzanineFloorImageList.Images.SetKeyName(2, "IMG_5874.JPG");
            this.mezzanineFloorImageList.Images.SetKeyName(3, "IT.JPG");
            this.mezzanineFloorImageList.Images.SetKeyName(4, "HR.JPG");
            // 
            // secondFloorImageList
            // 
            this.secondFloorImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("secondFloorImageList.ImageStream")));
            this.secondFloorImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.secondFloorImageList.Images.SetKeyName(0, "Parking.JPG");
            this.secondFloorImageList.Images.SetKeyName(1, "Purchasing Dept..JPG");
            // 
            // thirdFloorImageList
            // 
            this.thirdFloorImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("thirdFloorImageList.ImageStream")));
            this.thirdFloorImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.thirdFloorImageList.Images.SetKeyName(0, "Parking.JPG");
            // 
            // fourthFloorImageList
            // 
            this.fourthFloorImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fourthFloorImageList.ImageStream")));
            this.fourthFloorImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.fourthFloorImageList.Images.SetKeyName(0, "Parking.JPG");
            // 
            // fifthFloorImageList
            // 
            this.fifthFloorImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fifthFloorImageList.ImageStream")));
            this.fifthFloorImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.fifthFloorImageList.Images.SetKeyName(0, "CAFETERIA.jpg");
            this.fifthFloorImageList.Images.SetKeyName(1, "GRASS AREA 1.jpg");
            this.fifthFloorImageList.Images.SetKeyName(2, "GRASS AREA 2.JPG");
            // 
            // sixthFloorImageList
            // 
            this.sixthFloorImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("sixthFloorImageList.ImageStream")));
            this.sixthFloorImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.sixthFloorImageList.Images.SetKeyName(0, "Library.JPG");
            // 
            // seventhFloorImageList
            // 
            this.seventhFloorImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("seventhFloorImageList.ImageStream")));
            this.seventhFloorImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.seventhFloorImageList.Images.SetKeyName(0, "IMG_5858.JPG");
            this.seventhFloorImageList.Images.SetKeyName(1, "IMG_5860.JPG");
            this.seventhFloorImageList.Images.SetKeyName(2, "IMG_5862.JPG");
            this.seventhFloorImageList.Images.SetKeyName(3, "MMA LAB - MAKATI.jpg");
            this.seventhFloorImageList.Images.SetKeyName(4, "MUSIC ROOM - MAKATI.jpg");
            this.seventhFloorImageList.Images.SetKeyName(5, "MUSIC ROOM 2 - MAKATI.jpg");
            this.seventhFloorImageList.Images.SetKeyName(6, "SEWING ROOM - MAKATI.jpg");
            // 
            // eighthFloorImageList
            // 
            this.eighthFloorImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("eighthFloorImageList.ImageStream")));
            this.eighthFloorImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.eighthFloorImageList.Images.SetKeyName(0, "IMG_5856.JPG");
            this.eighthFloorImageList.Images.SetKeyName(1, "MMA LAB - MAKATI.jpg");
            // 
            // ninthFloorImageList
            // 
            this.ninthFloorImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ninthFloorImageList.ImageStream")));
            this.ninthFloorImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ninthFloorImageList.Images.SetKeyName(0, "Library.JPG");
            // 
            // tenthFloorImageList
            // 
            this.tenthFloorImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tenthFloorImageList.ImageStream")));
            this.tenthFloorImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.tenthFloorImageList.Images.SetKeyName(0, "iMAC LAB - MAKATI.jpg");
            this.tenthFloorImageList.Images.SetKeyName(1, "IMG_5848.JPG");
            this.tenthFloorImageList.Images.SetKeyName(2, "IMG_5851.JPG");
            this.tenthFloorImageList.Images.SetKeyName(3, "IMG_5852.JPG");
            this.tenthFloorImageList.Images.SetKeyName(4, "Lightbox.JPG");
            // 
            // twelfthFloorImageList
            // 
            this.twelfthFloorImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("twelfthFloorImageList.ImageStream")));
            this.twelfthFloorImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.twelfthFloorImageList.Images.SetKeyName(0, "AUDITORIUM - MAKATI.jpg");
            this.twelfthFloorImageList.Images.SetKeyName(1, "NEXUS - MAKATI.JPG");
            // 
            // lpFloorImageList
            // 
            this.lpFloorImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lpFloorImageList.ImageStream")));
            this.lpFloorImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.lpFloorImageList.Images.SetKeyName(0, "GYM 1 - MAKATI.jpg");
            this.lpFloorImageList.Images.SetKeyName(1, "GYM 2 - MAKATI.jpg");
            this.lpFloorImageList.Images.SetKeyName(2, "IMG_5844.JPG");
            this.lpFloorImageList.Images.SetKeyName(3, "IMG_5889.JPG");
            // 
            // upFloorImageList
            // 
            this.upFloorImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("upFloorImageList.ImageStream")));
            this.upFloorImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.upFloorImageList.Images.SetKeyName(0, "LIBRARY - MAKATI.jpg");
            this.upFloorImageList.Images.SetKeyName(1, "TRACK - MAKATI.jpg");
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
        private System.Windows.Forms.ImageList groundFloorImageList;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList mezzanineFloorImageList;
        private System.Windows.Forms.ImageList secondFloorImageList;
        private System.Windows.Forms.ImageList thirdFloorImageList;
        private System.Windows.Forms.ImageList fourthFloorImageList;
        private System.Windows.Forms.ImageList fifthFloorImageList;
        private System.Windows.Forms.ImageList sixthFloorImageList;
        private System.Windows.Forms.ImageList seventhFloorImageList;
        private System.Windows.Forms.ImageList eighthFloorImageList;
        private System.Windows.Forms.ImageList ninthFloorImageList;
        private System.Windows.Forms.ImageList tenthFloorImageList;
        private System.Windows.Forms.ImageList twelfthFloorImageList;
        private System.Windows.Forms.ImageList lpFloorImageList;
        private System.Windows.Forms.ImageList upFloorImageList;
    }
}

