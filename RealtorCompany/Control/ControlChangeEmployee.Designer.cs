namespace RealtorCompany
{
    partial class ControlChangeEmployee
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPosition = new System.Windows.Forms.GroupBox();
            this.PositionRl = new System.Windows.Forms.RadioButton();
            this.PositionAd = new System.Windows.Forms.RadioButton();
            this.bttnSave = new System.Windows.Forms.Button();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSecondName2 = new System.Windows.Forms.Label();
            this.tbName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbSecondName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbPosition.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblName.Location = new System.Drawing.Point(26, 157);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 32);
            this.lblName.TabIndex = 58;
            this.lblName.Text = "Имя:";
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblSecondName.Location = new System.Drawing.Point(542, 157);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(130, 32);
            this.lblSecondName.TabIndex = 61;
            this.lblSecondName.Text = "Фамилия:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblPassword.Location = new System.Drawing.Point(26, 269);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 32);
            this.lblPassword.TabIndex = 64;
            this.lblPassword.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(580, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 32);
            this.label2.TabIndex = 67;
            this.label2.Text = "Email:";
            // 
            // gbPosition
            // 
            this.gbPosition.Controls.Add(this.PositionRl);
            this.gbPosition.Controls.Add(this.PositionAd);
            this.gbPosition.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbPosition.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.gbPosition.Location = new System.Drawing.Point(382, 320);
            this.gbPosition.Name = "gbPosition";
            this.gbPosition.Size = new System.Drawing.Size(320, 122);
            this.gbPosition.TabIndex = 68;
            this.gbPosition.TabStop = false;
            this.gbPosition.Text = "Должность";
            this.gbPosition.Visible = false;
            // 
            // PositionRl
            // 
            this.PositionRl.AutoSize = true;
            this.PositionRl.Location = new System.Drawing.Point(12, 61);
            this.PositionRl.Name = "PositionRl";
            this.PositionRl.Size = new System.Drawing.Size(135, 36);
            this.PositionRl.TabIndex = 1;
            this.PositionRl.Text = "Риэлтор";
            this.PositionRl.UseVisualStyleBackColor = true;
            this.PositionRl.Visible = false;
            // 
            // PositionAd
            // 
            this.PositionAd.AutoSize = true;
            this.PositionAd.Checked = true;
            this.PositionAd.Location = new System.Drawing.Point(12, 24);
            this.PositionAd.Name = "PositionAd";
            this.PositionAd.Size = new System.Drawing.Size(230, 36);
            this.PositionAd.TabIndex = 0;
            this.PositionAd.TabStop = true;
            this.PositionAd.Text = "Администратор";
            this.PositionAd.UseVisualStyleBackColor = true;
            this.PositionAd.Visible = false;
            // 
            // bttnSave
            // 
            this.bttnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bttnSave.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.bttnSave.FlatAppearance.BorderSize = 0;
            this.bttnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bttnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSave.Font = new System.Drawing.Font("Segoe Script", 16F);
            this.bttnSave.ForeColor = System.Drawing.Color.OldLace;
            this.bttnSave.Location = new System.Drawing.Point(32, 464);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(971, 54);
            this.bttnSave.TabIndex = 69;
            this.bttnSave.Text = "Сохранить";
            this.bttnSave.UseVisualStyleBackColor = false;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 45;
            this.bunifuElipse3.TargetControl = this.bttnSave;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(460, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 40);
            this.comboBox1.TabIndex = 72;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblSecondName2
            // 
            this.lblSecondName2.AutoSize = true;
            this.lblSecondName2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblSecondName2.Location = new System.Drawing.Point(336, 98);
            this.lblSecondName2.Name = "lblSecondName2";
            this.lblSecondName2.Size = new System.Drawing.Size(130, 32);
            this.lblSecondName2.TabIndex = 73;
            this.lblSecondName2.Text = "Фамилия:";
            this.lblSecondName2.Visible = false;
            // 
            // tbName
            // 
            this.tbName.Depth = 0;
            this.tbName.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Hint = "";
            this.tbName.Location = new System.Drawing.Point(129, 161);
            this.tbName.MaxLength = 32767;
            this.tbName.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.SelectedText = "";
            this.tbName.SelectionLength = 0;
            this.tbName.SelectionStart = 0;
            this.tbName.Size = new System.Drawing.Size(299, 28);
            this.tbName.TabIndex = 74;
            this.tbName.TabStop = false;
            this.tbName.UseSystemPasswordChar = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Depth = 0;
            this.tbPassword.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Hint = "";
            this.tbPassword.Location = new System.Drawing.Point(129, 273);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.Size = new System.Drawing.Size(299, 28);
            this.tbPassword.TabIndex = 75;
            this.tbPassword.TabStop = false;
            this.tbPassword.UseSystemPasswordChar = false;
            // 
            // tbSecondName
            // 
            this.tbSecondName.Depth = 0;
            this.tbSecondName.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSecondName.Hint = "";
            this.tbSecondName.Location = new System.Drawing.Point(683, 161);
            this.tbSecondName.MaxLength = 32767;
            this.tbSecondName.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.PasswordChar = '\0';
            this.tbSecondName.SelectedText = "";
            this.tbSecondName.SelectionLength = 0;
            this.tbSecondName.SelectionStart = 0;
            this.tbSecondName.Size = new System.Drawing.Size(299, 28);
            this.tbSecondName.TabIndex = 76;
            this.tbSecondName.TabStop = false;
            this.tbSecondName.UseSystemPasswordChar = false;
            // 
            // tbEmail
            // 
            this.tbEmail.Depth = 0;
            this.tbEmail.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmail.Hint = "";
            this.tbEmail.Location = new System.Drawing.Point(683, 273);
            this.tbEmail.MaxLength = 32767;
            this.tbEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.SelectedText = "";
            this.tbEmail.SelectionLength = 0;
            this.tbEmail.SelectionStart = 0;
            this.tbEmail.Size = new System.Drawing.Size(299, 28);
            this.tbEmail.TabIndex = 77;
            this.tbEmail.TabStop = false;
            this.tbEmail.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 70);
            this.panel1.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(356, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Изменение профиля";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1006, 10);
            this.panel2.TabIndex = 79;
            // 
            // ControlChangeEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbSecondName);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblSecondName2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.gbPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblSecondName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ControlChangeEmployee";
            this.Size = new System.Drawing.Size(1006, 560);
            this.Load += new System.EventHandler(this.ControlChangeEmployee_Load);
            this.gbPosition.ResumeLayout(false);
            this.gbPosition.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbPosition;
        private System.Windows.Forms.RadioButton PositionRl;
        private System.Windows.Forms.RadioButton PositionAd;
        private System.Windows.Forms.Button bttnSave;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSecondName2;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbName;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbSecondName;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}
