﻿namespace RTSGame
{
    partial class RTSGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RTSGame));
            this.rtbMap = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tmrGameTimer = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblUnitInformation = new System.Windows.Forms.Label();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.btnSaveGame = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnUseResources = new System.Windows.Forms.Button();
            this.txtResourcesUse = new System.Windows.Forms.TextBox();
            this.lblAvailableResources = new System.Windows.Forms.Label();
            this.lblResourcesAvailable = new System.Windows.Forms.Label();
            this.lblUseResources = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbMap
            // 
            this.rtbMap.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMap.Location = new System.Drawing.Point(63, 12);
            this.rtbMap.Name = "rtbMap";
            this.rtbMap.Size = new System.Drawing.Size(478, 466);
            this.rtbMap.TabIndex = 0;
            this.rtbMap.Text = " ";
            this.rtbMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rtbMap_MouseClick);
            // 
            // btnStart
            // 
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStart.ImageIndex = 2;
            this.btnStart.ImageList = this.imageList1;
            this.btnStart.Location = new System.Drawing.Point(571, 412);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 66);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "exit.jpeg");
            this.imageList1.Images.SetKeyName(1, "next.jpeg");
            this.imageList1.Images.SetKeyName(2, "previous.jpeg");
            // 
            // tmrGameTimer
            // 
            this.tmrGameTimer.Interval = 1000;
            this.tmrGameTimer.Tick += new System.EventHandler(this.tmrGameTimer_Tick);
            // 
            // btnPause
            // 
            this.btnPause.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPause.ImageIndex = 1;
            this.btnPause.ImageList = this.imageList1;
            this.btnPause.Location = new System.Drawing.Point(652, 412);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 66);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Pause";
            this.btnPause.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnExit
            // 
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.ImageKey = "exit.jpeg";
            this.btnExit.ImageList = this.imageList1;
            this.btnExit.Location = new System.Drawing.Point(733, 412);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 66);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblUnitInformation
            // 
            this.lblUnitInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUnitInformation.Location = new System.Drawing.Point(568, 61);
            this.lblUnitInformation.Name = "lblUnitInformation";
            this.lblUnitInformation.Size = new System.Drawing.Size(402, 300);
            this.lblUnitInformation.TabIndex = 2;
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoadGame.ImageIndex = 1;
            this.btnLoadGame.ImageList = this.imageList1;
            this.btnLoadGame.Location = new System.Drawing.Point(895, 412);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(75, 66);
            this.btnLoadGame.TabIndex = 3;
            this.btnLoadGame.Text = "Load";
            this.btnLoadGame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoadGame.UseVisualStyleBackColor = true;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // btnSaveGame
            // 
            this.btnSaveGame.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveGame.ImageIndex = 2;
            this.btnSaveGame.ImageList = this.imageList1;
            this.btnSaveGame.Location = new System.Drawing.Point(814, 412);
            this.btnSaveGame.Name = "btnSaveGame";
            this.btnSaveGame.Size = new System.Drawing.Size(75, 66);
            this.btnSaveGame.TabIndex = 4;
            this.btnSaveGame.Text = "Save";
            this.btnSaveGame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveGame.UseVisualStyleBackColor = true;
            this.btnSaveGame.Click += new System.EventHandler(this.btnSaveGame_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimer.Location = new System.Drawing.Point(568, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(406, 35);
            this.lblTimer.TabIndex = 5;
            // 
            // btnUseResources
            // 
            this.btnUseResources.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUseResources.ImageIndex = 1;
            this.btnUseResources.ImageList = this.imageList1;
            this.btnUseResources.Location = new System.Drawing.Point(985, 412);
            this.btnUseResources.Name = "btnUseResources";
            this.btnUseResources.Size = new System.Drawing.Size(75, 66);
            this.btnUseResources.TabIndex = 6;
            this.btnUseResources.Text = "Use";
            this.btnUseResources.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUseResources.UseVisualStyleBackColor = true;
            this.btnUseResources.Click += new System.EventHandler(this.btnUseResources_Click);
            // 
            // txtResourcesUse
            // 
            this.txtResourcesUse.Location = new System.Drawing.Point(960, 372);
            this.txtResourcesUse.Name = "txtResourcesUse";
            this.txtResourcesUse.Size = new System.Drawing.Size(100, 22);
            this.txtResourcesUse.TabIndex = 8;
            // 
            // lblAvailableResources
            // 
            this.lblAvailableResources.AutoSize = true;
            this.lblAvailableResources.Location = new System.Drawing.Point(616, 375);
            this.lblAvailableResources.Name = "lblAvailableResources";
            this.lblAvailableResources.Size = new System.Drawing.Size(141, 17);
            this.lblAvailableResources.TabIndex = 9;
            this.lblAvailableResources.Text = "Available Resources:";
            // 
            // lblResourcesAvailable
            // 
            this.lblResourcesAvailable.AutoSize = true;
            this.lblResourcesAvailable.Location = new System.Drawing.Point(773, 375);
            this.lblResourcesAvailable.Name = "lblResourcesAvailable";
            this.lblResourcesAvailable.Size = new System.Drawing.Size(0, 17);
            this.lblResourcesAvailable.TabIndex = 10;
            // 
            // lblUseResources
            // 
            this.lblUseResources.AutoSize = true;
            this.lblUseResources.Location = new System.Drawing.Point(849, 377);
            this.lblUseResources.Name = "lblUseResources";
            this.lblUseResources.Size = new System.Drawing.Size(105, 17);
            this.lblUseResources.TabIndex = 11;
            this.lblUseResources.Text = "Use Resources";
            // 
            // RTSGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 517);
            this.Controls.Add(this.lblUseResources);
            this.Controls.Add(this.lblResourcesAvailable);
            this.Controls.Add(this.lblAvailableResources);
            this.Controls.Add(this.txtResourcesUse);
            this.Controls.Add(this.btnUseResources);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnSaveGame);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.lblUnitInformation);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rtbMap);
            this.Name = "RTSGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RTS Game";
            this.Load += new System.EventHandler(this.RTSGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox rtbMap;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrGameTimer;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblUnitInformation;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.Button btnSaveGame;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnUseResources;
        private System.Windows.Forms.TextBox txtResourcesUse;
        private System.Windows.Forms.Label lblAvailableResources;
        private System.Windows.Forms.Label lblResourcesAvailable;
        private System.Windows.Forms.Label lblUseResources;
    }
}

