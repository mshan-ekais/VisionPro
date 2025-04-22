﻿
namespace BaseForm
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconButtonWindowMin = new FontAwesome.Sharp.IconButton();
            this.iconButtonWindowMax = new FontAwesome.Sharp.IconButton();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.iconButtonWindowClose = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.iconButtonSetting = new FontAwesome.Sharp.IconButton();
            this.iconButtonDataLog = new FontAwesome.Sharp.IconButton();
            this.iconButtonMeasure = new FontAwesome.Sharp.IconButton();
            this.iconButtonHome = new FontAwesome.Sharp.IconButton();
            this.iconButtonMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelTitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(230, 113);
            this.panelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1249, 766);
            this.panelControl.TabIndex = 8;
            this.panelControl.Resize += new System.EventHandler(this.Form1_Resize);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.iconButtonWindowMin);
            this.panelTitleBar.Controls.Add(this.iconButtonWindowMax);
            this.panelTitleBar.Controls.Add(this.labelDashboard);
            this.panelTitleBar.Controls.Add(this.iconButtonWindowClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(230, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1249, 113);
            this.panelTitleBar.TabIndex = 7;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconButtonWindowMin
            // 
            this.iconButtonWindowMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonWindowMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(125)))));
            this.iconButtonWindowMin.FlatAppearance.BorderSize = 0;
            this.iconButtonWindowMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonWindowMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButtonWindowMin.IconColor = System.Drawing.Color.White;
            this.iconButtonWindowMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonWindowMin.IconSize = 25;
            this.iconButtonWindowMin.Location = new System.Drawing.Point(1069, 0);
            this.iconButtonWindowMin.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonWindowMin.Name = "iconButtonWindowMin";
            this.iconButtonWindowMin.Size = new System.Drawing.Size(60, 40);
            this.iconButtonWindowMin.TabIndex = 14;
            this.iconButtonWindowMin.UseVisualStyleBackColor = false;
            this.iconButtonWindowMin.Click += new System.EventHandler(this.iconButtonWindowMin_Click);
            // 
            // iconButtonWindowMax
            // 
            this.iconButtonWindowMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonWindowMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(125)))));
            this.iconButtonWindowMax.FlatAppearance.BorderSize = 0;
            this.iconButtonWindowMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonWindowMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconButtonWindowMax.IconColor = System.Drawing.Color.White;
            this.iconButtonWindowMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonWindowMax.IconSize = 25;
            this.iconButtonWindowMax.Location = new System.Drawing.Point(1129, 0);
            this.iconButtonWindowMax.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonWindowMax.Name = "iconButtonWindowMax";
            this.iconButtonWindowMax.Size = new System.Drawing.Size(60, 40);
            this.iconButtonWindowMax.TabIndex = 13;
            this.iconButtonWindowMax.UseVisualStyleBackColor = false;
            this.iconButtonWindowMax.Click += new System.EventHandler(this.iconButtonWindowMax_Click);
            // 
            // labelDashboard
            // 
            this.labelDashboard.AutoSize = true;
            this.labelDashboard.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelDashboard.Location = new System.Drawing.Point(18, 44);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(146, 30);
            this.labelDashboard.TabIndex = 0;
            this.labelDashboard.Text = "DASHBOARD";
            // 
            // iconButtonWindowClose
            // 
            this.iconButtonWindowClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonWindowClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(125)))));
            this.iconButtonWindowClose.FlatAppearance.BorderSize = 0;
            this.iconButtonWindowClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonWindowClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButtonWindowClose.IconColor = System.Drawing.Color.White;
            this.iconButtonWindowClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonWindowClose.IconSize = 25;
            this.iconButtonWindowClose.Location = new System.Drawing.Point(1189, 0);
            this.iconButtonWindowClose.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonWindowClose.Name = "iconButtonWindowClose";
            this.iconButtonWindowClose.Size = new System.Drawing.Size(60, 40);
            this.iconButtonWindowClose.TabIndex = 12;
            this.iconButtonWindowClose.UseVisualStyleBackColor = false;
            this.iconButtonWindowClose.Click += new System.EventHandler(this.iconButtonWindowClose_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(121)))));
            this.panelMenu.Controls.Add(this.iconButtonClose);
            this.panelMenu.Controls.Add(this.iconButtonSetting);
            this.panelMenu.Controls.Add(this.iconButtonDataLog);
            this.panelMenu.Controls.Add(this.iconButtonMeasure);
            this.panelMenu.Controls.Add(this.iconButtonHome);
            this.panelMenu.Controls.Add(this.iconButtonMenu);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.panelMenu.Size = new System.Drawing.Size(230, 879);
            this.panelMenu.TabIndex = 6;
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonClose.FlatAppearance.BorderSize = 0;
            this.iconButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClose.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButtonClose.ForeColor = System.Drawing.Color.White;
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButtonClose.IconColor = System.Drawing.Color.White;
            this.iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClose.IconSize = 30;
            this.iconButtonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonClose.Location = new System.Drawing.Point(0, 810);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.iconButtonClose.Size = new System.Drawing.Size(230, 54);
            this.iconButtonClose.TabIndex = 15;
            this.iconButtonClose.Tag = "Close";
            this.iconButtonClose.Text = "Close";
            this.iconButtonClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonClose.UseVisualStyleBackColor = true;
            // 
            // iconButtonSetting
            // 
            this.iconButtonSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSetting.FlatAppearance.BorderSize = 0;
            this.iconButtonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSetting.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButtonSetting.ForeColor = System.Drawing.Color.White;
            this.iconButtonSetting.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconButtonSetting.IconColor = System.Drawing.Color.White;
            this.iconButtonSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSetting.IconSize = 30;
            this.iconButtonSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSetting.Location = new System.Drawing.Point(0, 335);
            this.iconButtonSetting.Name = "iconButtonSetting";
            this.iconButtonSetting.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.iconButtonSetting.Size = new System.Drawing.Size(230, 54);
            this.iconButtonSetting.TabIndex = 14;
            this.iconButtonSetting.Tag = "Setting";
            this.iconButtonSetting.Text = "Setting";
            this.iconButtonSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSetting.UseVisualStyleBackColor = true;
            this.iconButtonSetting.Click += new System.EventHandler(this.iconButtonSetting_Click);
            // 
            // iconButtonDataLog
            // 
            this.iconButtonDataLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonDataLog.FlatAppearance.BorderSize = 0;
            this.iconButtonDataLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDataLog.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButtonDataLog.ForeColor = System.Drawing.Color.White;
            this.iconButtonDataLog.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.iconButtonDataLog.IconColor = System.Drawing.Color.White;
            this.iconButtonDataLog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDataLog.IconSize = 30;
            this.iconButtonDataLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDataLog.Location = new System.Drawing.Point(0, 281);
            this.iconButtonDataLog.Name = "iconButtonDataLog";
            this.iconButtonDataLog.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.iconButtonDataLog.Size = new System.Drawing.Size(230, 54);
            this.iconButtonDataLog.TabIndex = 13;
            this.iconButtonDataLog.Tag = "Data Log";
            this.iconButtonDataLog.Text = "Data Log";
            this.iconButtonDataLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDataLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDataLog.UseVisualStyleBackColor = true;
            this.iconButtonDataLog.Click += new System.EventHandler(this.iconButtonDataLog_Click);
            // 
            // iconButtonMeasure
            // 
            this.iconButtonMeasure.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonMeasure.FlatAppearance.BorderSize = 0;
            this.iconButtonMeasure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMeasure.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButtonMeasure.ForeColor = System.Drawing.Color.White;
            this.iconButtonMeasure.IconChar = FontAwesome.Sharp.IconChar.Camera;
            this.iconButtonMeasure.IconColor = System.Drawing.Color.White;
            this.iconButtonMeasure.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMeasure.IconSize = 30;
            this.iconButtonMeasure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMeasure.Location = new System.Drawing.Point(0, 227);
            this.iconButtonMeasure.Name = "iconButtonMeasure";
            this.iconButtonMeasure.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.iconButtonMeasure.Size = new System.Drawing.Size(230, 54);
            this.iconButtonMeasure.TabIndex = 12;
            this.iconButtonMeasure.Tag = "Measurement";
            this.iconButtonMeasure.Text = "Measurement";
            this.iconButtonMeasure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMeasure.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMeasure.UseVisualStyleBackColor = true;
            this.iconButtonMeasure.Click += new System.EventHandler(this.iconButtonMeasure_Click);
            // 
            // iconButtonHome
            // 
            this.iconButtonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonHome.FlatAppearance.BorderSize = 0;
            this.iconButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHome.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButtonHome.ForeColor = System.Drawing.Color.White;
            this.iconButtonHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButtonHome.IconColor = System.Drawing.Color.White;
            this.iconButtonHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonHome.IconSize = 30;
            this.iconButtonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHome.Location = new System.Drawing.Point(0, 173);
            this.iconButtonHome.Name = "iconButtonHome";
            this.iconButtonHome.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.iconButtonHome.Size = new System.Drawing.Size(230, 54);
            this.iconButtonHome.TabIndex = 11;
            this.iconButtonHome.Tag = "Home";
            this.iconButtonHome.Text = "Home";
            this.iconButtonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonHome.UseVisualStyleBackColor = true;
            this.iconButtonHome.Click += new System.EventHandler(this.iconButtonHome_Click);
            // 
            // iconButtonMenu
            // 
            this.iconButtonMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonMenu.FlatAppearance.BorderSize = 0;
            this.iconButtonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconButtonMenu.IconColor = System.Drawing.Color.White;
            this.iconButtonMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMenu.IconSize = 30;
            this.iconButtonMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonMenu.Location = new System.Drawing.Point(0, 113);
            this.iconButtonMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButtonMenu.Name = "iconButtonMenu";
            this.iconButtonMenu.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.iconButtonMenu.Size = new System.Drawing.Size(230, 60);
            this.iconButtonMenu.TabIndex = 10;
            this.iconButtonMenu.Tag = "menu";
            this.iconButtonMenu.UseVisualStyleBackColor = true;
            this.iconButtonMenu.Click += new System.EventHandler(this.iconButtonMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 113);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(15);
            this.pictureBox1.Size = new System.Drawing.Size(230, 751);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 113);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = global::BaseForm.Properties.Resources.Kais_Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Padding = new System.Windows.Forms.Padding(15);
            this.pictureBoxLogo.Size = new System.Drawing.Size(230, 113);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 879);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton iconButtonWindowMin;
        private FontAwesome.Sharp.IconButton iconButtonWindowMax;
        private System.Windows.Forms.Label labelDashboard;
        private FontAwesome.Sharp.IconButton iconButtonWindowClose;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private FontAwesome.Sharp.IconButton iconButtonSetting;
        private FontAwesome.Sharp.IconButton iconButtonDataLog;
        private FontAwesome.Sharp.IconButton iconButtonMeasure;
        private FontAwesome.Sharp.IconButton iconButtonHome;
        private FontAwesome.Sharp.IconButton iconButtonMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

