namespace HuaweiAttendance
{
    partial class frmMain
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
            this.pnlRightOptions = new System.Windows.Forms.Panel();
            this.pnlRightMain = new System.Windows.Forms.Panel();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.RightOptions = new System.Windows.Forms.Timer(this.components);
            this.ColorChange = new System.Windows.Forms.Timer(this.components);
            this.lblCopyright = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblTech = new System.Windows.Forms.Label();
            this.lblFaltu = new System.Windows.Forms.Label();
            this.Clock = new CalendarClock.CalendarClock();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSwipe = new System.Windows.Forms.Panel();
            this.lblSwipeEn = new System.Windows.Forms.Label();
            this.lblSwipeCn = new System.Windows.Forms.Label();
            this.dltextbox = new MyControls.DelayTextBox();
            this.pnlThx = new System.Windows.Forms.Panel();
            this.lblThxCn = new System.Windows.Forms.Label();
            this.lblThxEn = new System.Windows.Forms.Label();
            this.timerThx = new System.Windows.Forms.Timer(this.components);
            this.pnlRightOptions.SuspendLayout();
            this.pnlRightMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            this.pnlLogo.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlSwipe.SuspendLayout();
            this.pnlThx.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRightOptions
            // 
            this.pnlRightOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlRightOptions.Controls.Add(this.pnlRightMain);
            this.pnlRightOptions.Location = new System.Drawing.Point(1025, -43);
            this.pnlRightOptions.Name = "pnlRightOptions";
            this.pnlRightOptions.Size = new System.Drawing.Size(77, 644);
            this.pnlRightOptions.TabIndex = 18;
            // 
            // pnlRightMain
            // 
            this.pnlRightMain.Controls.Add(this.pbExit);
            this.pnlRightMain.Controls.Add(this.pbHome);
            this.pnlRightMain.Controls.Add(this.pbLogout);
            this.pnlRightMain.Location = new System.Drawing.Point(3, 52);
            this.pnlRightMain.Name = "pnlRightMain";
            this.pnlRightMain.Size = new System.Drawing.Size(70, 396);
            this.pnlRightMain.TabIndex = 1;
            // 
            // pbExit
            // 
            this.pbExit.Image = global::HuaweiAttendance.Properties.Resources.appbar_power;
            this.pbExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbExit.Location = new System.Drawing.Point(-3, 320);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(76, 76);
            this.pbExit.TabIndex = 5;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // pbHome
            // 
            this.pbHome.Image = global::HuaweiAttendance.Properties.Resources.appbar_home;
            this.pbHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbHome.Location = new System.Drawing.Point(-3, 160);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(76, 76);
            this.pbHome.TabIndex = 4;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // pbLogout
            // 
            this.pbLogout.Image = global::HuaweiAttendance.Properties.Resources.appbar_lock;
            this.pbLogout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbLogout.Location = new System.Drawing.Point(-3, 0);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(76, 76);
            this.pbLogout.TabIndex = 3;
            this.pbLogout.TabStop = false;
            // 
            // RightOptions
            // 
            this.RightOptions.Interval = 1;
            this.RightOptions.Tick += new System.EventHandler(this.RightOptions_Tick);
            // 
            // ColorChange
            // 
            this.ColorChange.Interval = 2000;
            this.ColorChange.Tick += new System.EventHandler(this.ColorChange_Tick);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(593, 627);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(431, 21);
            this.lblCopyright.TabIndex = 2;
            this.lblCopyright.Text = "Copyright @ Huawei Technologies Deutschland GmbH, 2015";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Red;
            this.pnlLogo.Controls.Add(this.lblTech);
            this.pnlLogo.Controls.Add(this.lblFaltu);
            this.pnlLogo.Location = new System.Drawing.Point(14, 396);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(256, 125);
            this.pnlLogo.TabIndex = 14;
            this.pnlLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.focusReturn);
            // 
            // lblTech
            // 
            this.lblTech.AutoSize = true;
            this.lblTech.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTech.Location = new System.Drawing.Point(53, 70);
            this.lblTech.Name = "lblTech";
            this.lblTech.Size = new System.Drawing.Size(153, 30);
            this.lblTech.TabIndex = 3;
            this.lblTech.Text = "TECHNOLOGY";
            // 
            // lblFaltu
            // 
            this.lblFaltu.AutoSize = true;
            this.lblFaltu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaltu.Location = new System.Drawing.Point(76, 24);
            this.lblFaltu.Name = "lblFaltu";
            this.lblFaltu.Size = new System.Drawing.Size(104, 30);
            this.lblFaltu.TabIndex = 2;
            this.lblFaltu.Text = "HUAWEI ";
            // 
            // Clock
            // 
            this.Clock.BackColor = System.Drawing.Color.White;
            this.Clock.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock.Location = new System.Drawing.Point(14, 130);
            this.Clock.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(256, 256);
            this.Clock.TabIndex = 15;
            this.Clock.MouseUp += new System.Windows.Forms.MouseEventHandler(this.focusReturn);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.pnlSwipe);
            this.pnlMain.Controls.Add(this.Clock);
            this.pnlMain.Controls.Add(this.pnlLogo);
            this.pnlMain.Controls.Add(this.lblCopyright);
            this.pnlMain.Controls.Add(this.dltextbox);
            this.pnlMain.Controls.Add(this.pnlThx);
            this.pnlMain.ForeColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(1, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1024, 648);
            this.pnlMain.TabIndex = 16;
            this.pnlMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.focusReturn);
            // 
            // pnlSwipe
            // 
            this.pnlSwipe.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlSwipe.Controls.Add(this.lblSwipeEn);
            this.pnlSwipe.Controls.Add(this.lblSwipeCn);
            this.pnlSwipe.Location = new System.Drawing.Point(573, 396);
            this.pnlSwipe.Name = "pnlSwipe";
            this.pnlSwipe.Size = new System.Drawing.Size(399, 178);
            this.pnlSwipe.TabIndex = 15;
            this.pnlSwipe.MouseUp += new System.Windows.Forms.MouseEventHandler(this.focusReturn);
            // 
            // lblSwipeEn
            // 
            this.lblSwipeEn.AutoSize = true;
            this.lblSwipeEn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwipeEn.Location = new System.Drawing.Point(76, 121);
            this.lblSwipeEn.Name = "lblSwipeEn";
            this.lblSwipeEn.Size = new System.Drawing.Size(238, 30);
            this.lblSwipeEn.TabIndex = 3;
            this.lblSwipeEn.Text = "Please Swipe your card";
            // 
            // lblSwipeCn
            // 
            this.lblSwipeCn.AutoSize = true;
            this.lblSwipeCn.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwipeCn.Location = new System.Drawing.Point(82, 27);
            this.lblSwipeCn.Name = "lblSwipeCn";
            this.lblSwipeCn.Size = new System.Drawing.Size(232, 86);
            this.lblSwipeCn.TabIndex = 2;
            this.lblSwipeCn.Text = "请刷卡";
            // 
            // dltextbox
            // 
            this.dltextbox.Location = new System.Drawing.Point(145, 208);
            this.dltextbox.Name = "dltextbox";
            this.dltextbox.Size = new System.Drawing.Size(100, 35);
            this.dltextbox.TabIndex = 17;
            this.dltextbox.TextChanged += new System.EventHandler(this.dltextbox_TextChanged);
            // 
            // pnlThx
            // 
            this.pnlThx.BackColor = System.Drawing.Color.Green;
            this.pnlThx.Controls.Add(this.lblThxCn);
            this.pnlThx.Controls.Add(this.lblThxEn);
            this.pnlThx.Location = new System.Drawing.Point(573, 396);
            this.pnlThx.Name = "pnlThx";
            this.pnlThx.Size = new System.Drawing.Size(399, 178);
            this.pnlThx.TabIndex = 16;
            this.pnlThx.MouseUp += new System.Windows.Forms.MouseEventHandler(this.focusReturn);
            // 
            // lblThxCn
            // 
            this.lblThxCn.AutoSize = true;
            this.lblThxCn.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThxCn.Location = new System.Drawing.Point(25, 27);
            this.lblThxCn.Name = "lblThxCn";
            this.lblThxCn.Size = new System.Drawing.Size(362, 86);
            this.lblThxCn.TabIndex = 2;
            this.lblThxCn.Text = "感谢您刷卡";
            // 
            // lblThxEn
            // 
            this.lblThxEn.AutoSize = true;
            this.lblThxEn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThxEn.Location = new System.Drawing.Point(35, 121);
            this.lblThxEn.Name = "lblThxEn";
            this.lblThxEn.Size = new System.Drawing.Size(342, 30);
            this.lblThxEn.TabIndex = 3;
            this.lblThxEn.Text = "Thank your for swiping your card";
            // 
            // timerThx
            // 
            this.timerThx.Interval = 3000;
            this.timerThx.Tick += new System.EventHandler(this.timerThx_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::HuaweiAttendance.Properties.Resources.hd_1366x768_free_background;
            this.ClientSize = new System.Drawing.Size(1024, 648);
            this.Controls.Add(this.pnlRightOptions);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.pnlRightOptions.ResumeLayout(false);
            this.pnlRightMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlSwipe.ResumeLayout(false);
            this.pnlSwipe.PerformLayout();
            this.pnlThx.ResumeLayout(false);
            this.pnlThx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbHome;


        private System.Windows.Forms.PictureBox pbLogout;
        private System.Windows.Forms.Panel pnlRightOptions;
        private System.Windows.Forms.Panel pnlRightMain;
        private System.Windows.Forms.Timer RightOptions;


        private System.Windows.Forms.Timer ColorChange;
        private MyControls.DelayTextBox dltextbox;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblTech;
        private System.Windows.Forms.Label lblFaltu;
        private CalendarClock.CalendarClock Clock;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSwipe;
        private System.Windows.Forms.Label lblSwipeEn;
        private System.Windows.Forms.Label lblSwipeCn;
        private System.Windows.Forms.Panel pnlThx;
        private System.Windows.Forms.Label lblThxCn;
        private System.Windows.Forms.Label lblThxEn;
        private System.Windows.Forms.Timer timerThx;

    }
}