namespace RealtorCompany
{
    partial class FrmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlDiseng1Bg = new System.Windows.Forms.Panel();
            this.bttnExit = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlContext = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.bttnStatistic = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.bttnCatalog = new System.Windows.Forms.Button();
            this.bttnChange = new System.Windows.Forms.Button();
            this.bttnMain = new System.Windows.Forms.Button();
            this.bttnChangeProfile = new System.Windows.Forms.Button();
            this.bttnMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFIO = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlDiseng1Bg.SuspendLayout();
            this.pnlContext.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDiseng1Bg
            // 
            this.pnlDiseng1Bg.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlDiseng1Bg.Controls.Add(this.bttnExit);
            this.pnlDiseng1Bg.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDiseng1Bg.Location = new System.Drawing.Point(0, 0);
            this.pnlDiseng1Bg.Name = "pnlDiseng1Bg";
            this.pnlDiseng1Bg.Size = new System.Drawing.Size(1243, 37);
            this.pnlDiseng1Bg.TabIndex = 1;
            // 
            // bttnExit
            // 
            this.bttnExit.FlatAppearance.BorderSize = 0;
            this.bttnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnExit.ForeColor = System.Drawing.Color.White;
            this.bttnExit.Image = ((System.Drawing.Image)(resources.GetObject("bttnExit.Image")));
            this.bttnExit.Location = new System.Drawing.Point(1192, 4);
            this.bttnExit.Margin = new System.Windows.Forms.Padding(4);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(38, 29);
            this.bttnExit.TabIndex = 6;
            this.bttnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 45;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlDiseng1Bg;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 45;
            this.bunifuElipse2.TargetControl = this.bttnExit;
            // 
            // pnlContext
            // 
            this.pnlContext.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlContext.Controls.Add(this.lblCopyright);
            this.pnlContext.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContext.Location = new System.Drawing.Point(0, 597);
            this.pnlContext.Name = "pnlContext";
            this.pnlContext.Size = new System.Drawing.Size(1243, 29);
            this.pnlContext.TabIndex = 3;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCopyright.Location = new System.Drawing.Point(322, 3);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(575, 22);
            this.lblCopyright.TabIndex = 10;
            this.lblCopyright.Text = "Copyright 2018.      All rights reserved \"Realtor Company\" Kiev.\r\n";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlMenu.Controls.Add(this.bttnStatistic);
            this.pnlMenu.Controls.Add(this.bttnAdd);
            this.pnlMenu.Controls.Add(this.bttnCatalog);
            this.pnlMenu.Controls.Add(this.bttnChange);
            this.pnlMenu.Controls.Add(this.bttnMain);
            this.pnlMenu.Controls.Add(this.bttnChangeProfile);
            this.pnlMenu.Controls.Add(this.bttnMenu);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.lblFIO);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 37);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(237, 560);
            this.pnlMenu.TabIndex = 4;
            // 
            // bttnStatistic
            // 
            this.bttnStatistic.FlatAppearance.BorderSize = 0;
            this.bttnStatistic.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.bttnStatistic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bttnStatistic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.bttnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnStatistic.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnStatistic.ForeColor = System.Drawing.Color.White;
            this.bttnStatistic.Image = ((System.Drawing.Image)(resources.GetObject("bttnStatistic.Image")));
            this.bttnStatistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnStatistic.Location = new System.Drawing.Point(0, 357);
            this.bttnStatistic.Margin = new System.Windows.Forms.Padding(4);
            this.bttnStatistic.Name = "bttnStatistic";
            this.bttnStatistic.Size = new System.Drawing.Size(237, 45);
            this.bttnStatistic.TabIndex = 14;
            this.bttnStatistic.Text = "       Статистика";
            this.bttnStatistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnStatistic.UseVisualStyleBackColor = true;
            this.bttnStatistic.Click += new System.EventHandler(this.bttnStatistic_Click);
            // 
            // bttnAdd
            // 
            this.bttnAdd.FlatAppearance.BorderSize = 0;
            this.bttnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.bttnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bttnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.bttnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAdd.ForeColor = System.Drawing.Color.White;
            this.bttnAdd.Image = ((System.Drawing.Image)(resources.GetObject("bttnAdd.Image")));
            this.bttnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnAdd.Location = new System.Drawing.Point(0, 481);
            this.bttnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(237, 45);
            this.bttnAdd.TabIndex = 9;
            this.bttnAdd.Text = "       Добавление";
            this.bttnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Visible = false;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // bttnCatalog
            // 
            this.bttnCatalog.FlatAppearance.BorderSize = 0;
            this.bttnCatalog.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.bttnCatalog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bttnCatalog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.bttnCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCatalog.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCatalog.ForeColor = System.Drawing.Color.White;
            this.bttnCatalog.Image = ((System.Drawing.Image)(resources.GetObject("bttnCatalog.Image")));
            this.bttnCatalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnCatalog.Location = new System.Drawing.Point(0, 295);
            this.bttnCatalog.Margin = new System.Windows.Forms.Padding(4);
            this.bttnCatalog.Name = "bttnCatalog";
            this.bttnCatalog.Size = new System.Drawing.Size(237, 45);
            this.bttnCatalog.TabIndex = 11;
            this.bttnCatalog.Text = "       Каталог";
            this.bttnCatalog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnCatalog.UseVisualStyleBackColor = true;
            this.bttnCatalog.Click += new System.EventHandler(this.bttnCatalog_Click);
            // 
            // bttnChange
            // 
            this.bttnChange.FlatAppearance.BorderSize = 0;
            this.bttnChange.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.bttnChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bttnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.bttnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnChange.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnChange.ForeColor = System.Drawing.Color.White;
            this.bttnChange.Image = ((System.Drawing.Image)(resources.GetObject("bttnChange.Image")));
            this.bttnChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnChange.Location = new System.Drawing.Point(0, 419);
            this.bttnChange.Margin = new System.Windows.Forms.Padding(4);
            this.bttnChange.Name = "bttnChange";
            this.bttnChange.Size = new System.Drawing.Size(237, 45);
            this.bttnChange.TabIndex = 12;
            this.bttnChange.Text = "       Редактирование";
            this.bttnChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnChange.UseVisualStyleBackColor = true;
            this.bttnChange.Visible = false;
            this.bttnChange.Click += new System.EventHandler(this.bttnChange_Click);
            // 
            // bttnMain
            // 
            this.bttnMain.FlatAppearance.BorderSize = 0;
            this.bttnMain.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.bttnMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bttnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.bttnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnMain.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnMain.ForeColor = System.Drawing.Color.White;
            this.bttnMain.Image = ((System.Drawing.Image)(resources.GetObject("bttnMain.Image")));
            this.bttnMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnMain.Location = new System.Drawing.Point(0, 233);
            this.bttnMain.Margin = new System.Windows.Forms.Padding(4);
            this.bttnMain.Name = "bttnMain";
            this.bttnMain.Size = new System.Drawing.Size(237, 45);
            this.bttnMain.TabIndex = 13;
            this.bttnMain.Text = "       Главная";
            this.bttnMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnMain.UseVisualStyleBackColor = true;
            this.bttnMain.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnChangeProfile
            // 
            this.bttnChangeProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnChangeProfile.FlatAppearance.BorderSize = 0;
            this.bttnChangeProfile.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.bttnChangeProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnChangeProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.bttnChangeProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnChangeProfile.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnChangeProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.bttnChangeProfile.Location = new System.Drawing.Point(44, 164);
            this.bttnChangeProfile.Name = "bttnChangeProfile";
            this.bttnChangeProfile.Size = new System.Drawing.Size(129, 30);
            this.bttnChangeProfile.TabIndex = 8;
            this.bttnChangeProfile.Text = "Изменить";
            this.bttnChangeProfile.UseVisualStyleBackColor = false;
            this.bttnChangeProfile.Click += new System.EventHandler(this.bttnChangeProfile_Click);
            // 
            // bttnMenu
            // 
            this.bttnMenu.BackColor = System.Drawing.Color.Transparent;
            this.bttnMenu.BackgroundImage = global::RealtorCompany.Properties.Resources.if_th_menu_outline_216423;
            this.bttnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnMenu.FlatAppearance.BorderSize = 0;
            this.bttnMenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.bttnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bttnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.bttnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnMenu.Location = new System.Drawing.Point(0, 0);
            this.bttnMenu.Name = "bttnMenu";
            this.bttnMenu.Size = new System.Drawing.Size(47, 38);
            this.bttnMenu.TabIndex = 7;
            this.bttnMenu.UseVisualStyleBackColor = false;
            this.bttnMenu.Click += new System.EventHandler(this.bttnMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RealtorCompany.Properties.Resources.if_human_1216577;
            this.pictureBox1.Location = new System.Drawing.Point(62, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblFIO
            // 
            this.lblFIO.AutoSize = true;
            this.lblFIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFIO.Location = new System.Drawing.Point(38, 129);
            this.lblFIO.Name = "lblFIO";
            this.lblFIO.Size = new System.Drawing.Size(78, 32);
            this.lblFIO.TabIndex = 5;
            this.lblFIO.Text = "Гость";
            this.lblFIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(237, 37);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1006, 560);
            this.pnlMain.TabIndex = 5;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 45;
            this.bunifuElipse3.TargetControl = this.bttnChangeProfile;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1243, 626);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlContext);
            this.Controls.Add(this.pnlDiseng1Bg);
            this.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlDiseng1Bg.ResumeLayout(false);
            this.pnlContext.ResumeLayout(false);
            this.pnlContext.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDiseng1Bg;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button bttnExit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblFIO;
        private System.Windows.Forms.Panel pnlContext;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button bttnChangeProfile;
        private System.Windows.Forms.Button bttnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button bttnCatalog;
        private System.Windows.Forms.Button bttnChange;
        private System.Windows.Forms.Button bttnMain;
        private System.Windows.Forms.Button bttnStatistic;
    }
}

