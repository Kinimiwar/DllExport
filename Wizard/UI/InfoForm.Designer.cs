﻿namespace net.r_eg.DllExport.Wizard.UI
{
    partial class InfoForm
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
            if(disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.linkLocalDxp = new System.Windows.Forms.LinkLabel();
            this.linkRemoteDxp = new System.Windows.Forms.LinkLabel();
            this.labelDllExportBatch = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.picVideo = new System.Windows.Forms.PictureBox();
            this.panelWarn = new System.Windows.Forms.Panel();
            this.labelWarn = new System.Windows.Forms.Label();
            this.linkManagerWiki = new System.Windows.Forms.LinkLabel();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVideo)).BeginInit();
            this.panelWarn.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLocalDxp
            // 
            this.linkLocalDxp.AutoSize = true;
            this.linkLocalDxp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLocalDxp.LinkColor = System.Drawing.Color.Purple;
            this.linkLocalDxp.Location = new System.Drawing.Point(41, 200);
            this.linkLocalDxp.Name = "linkLocalDxp";
            this.linkLocalDxp.Size = new System.Drawing.Size(157, 13);
            this.linkLocalDxp.TabIndex = 2;
            this.linkLocalDxp.TabStop = true;
            this.linkLocalDxp.Text = "Local version from this package";
            this.linkLocalDxp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLocalDxp_LinkClicked);
            // 
            // linkRemoteDxp
            // 
            this.linkRemoteDxp.AutoSize = true;
            this.linkRemoteDxp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRemoteDxp.Location = new System.Drawing.Point(41, 224);
            this.linkRemoteDxp.Name = "linkRemoteDxp";
            this.linkRemoteDxp.Size = new System.Drawing.Size(164, 13);
            this.linkRemoteDxp.TabIndex = 3;
            this.linkRemoteDxp.TabStop = true;
            this.linkRemoteDxp.Text = "Latest version from GitHub server";
            this.linkRemoteDxp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRemoteDxp_LinkClicked);
            // 
            // labelDllExportBatch
            // 
            this.labelDllExportBatch.AutoSize = true;
            this.labelDllExportBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDllExportBatch.Location = new System.Drawing.Point(12, 178);
            this.labelDllExportBatch.Name = "labelDllExportBatch";
            this.labelDllExportBatch.Size = new System.Drawing.Size(120, 13);
            this.labelDllExportBatch.TabIndex = 4;
            this.labelDllExportBatch.Text = "DllExport.bat ( ~ 20 Kb )";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(195)))), ((int)(((byte)(101)))));
            this.panelInfo.Controls.Add(this.textBoxInfo);
            this.panelInfo.Location = new System.Drawing.Point(2, 44);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Padding = new System.Windows.Forms.Padding(1);
            this.panelInfo.Size = new System.Drawing.Size(449, 73);
            this.panelInfo.TabIndex = 5;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.textBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfo.Location = new System.Drawing.Point(1, 1);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Size = new System.Drawing.Size(447, 71);
            this.textBoxInfo.TabIndex = 1;
            this.textBoxInfo.Text = "\r\n To continue, you should use our embeddable manager [ after removing this packa" +
    "ge ].\r\n \r\n Find it inside your solution directory, or receive latest version fro" +
    "m other place.\r\n";
            // 
            // picVideo
            // 
            this.picVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVideo.Image = ((System.Drawing.Image)(resources.GetObject("picVideo.Image")));
            this.picVideo.Location = new System.Drawing.Point(223, 138);
            this.picVideo.Name = "picVideo";
            this.picVideo.Size = new System.Drawing.Size(228, 129);
            this.picVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVideo.TabIndex = 6;
            this.picVideo.TabStop = false;
            this.picVideo.Click += new System.EventHandler(this.picVideo_Click);
            // 
            // panelWarn
            // 
            this.panelWarn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.panelWarn.Controls.Add(this.labelWarn);
            this.panelWarn.Location = new System.Drawing.Point(2, 15);
            this.panelWarn.Name = "panelWarn";
            this.panelWarn.Padding = new System.Windows.Forms.Padding(1);
            this.panelWarn.Size = new System.Drawing.Size(449, 17);
            this.panelWarn.TabIndex = 7;
            // 
            // labelWarn
            // 
            this.labelWarn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.labelWarn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarn.ForeColor = System.Drawing.Color.White;
            this.labelWarn.Location = new System.Drawing.Point(1, 1);
            this.labelWarn.Name = "labelWarn";
            this.labelWarn.Size = new System.Drawing.Size(447, 15);
            this.labelWarn.TabIndex = 0;
            this.labelWarn.Text = ".NET DllExport v1.6+ have no official support of NuGet clients";
            this.labelWarn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkManagerWiki
            // 
            this.linkManagerWiki.AutoSize = true;
            this.linkManagerWiki.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkManagerWiki.Location = new System.Drawing.Point(3, 140);
            this.linkManagerWiki.Name = "linkManagerWiki";
            this.linkManagerWiki.Size = new System.Drawing.Size(110, 13);
            this.linkManagerWiki.TabIndex = 8;
            this.linkManagerWiki.TabStop = true;
            this.linkManagerWiki.Text = "About Manager (Wiki)";
            this.linkManagerWiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkManagerWiki_LinkClicked);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 268);
            this.Controls.Add(this.linkManagerWiki);
            this.Controls.Add(this.panelWarn);
            this.Controls.Add(this.picVideo);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.labelDllExportBatch);
            this.Controls.Add(this.linkRemoteDxp);
            this.Controls.Add(this.linkLocalDxp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".NET DllExport :: Attention please !";
            this.TopMost = true;
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVideo)).EndInit();
            this.panelWarn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLocalDxp;
        private System.Windows.Forms.LinkLabel linkRemoteDxp;
        private System.Windows.Forms.Label labelDllExportBatch;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.PictureBox picVideo;
        private System.Windows.Forms.Panel panelWarn;
        private System.Windows.Forms.Label labelWarn;
        private System.Windows.Forms.LinkLabel linkManagerWiki;
    }
}