namespace AZS_New
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resetpass = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.infobox = new System.Windows.Forms.PictureBox();
            this.create = new System.Windows.Forms.Button();
            this.eyes2 = new System.Windows.Forms.PictureBox();
            this.eyes1 = new System.Windows.Forms.PictureBox();
            this.enter = new System.Windows.Forms.Button();
            this.passbox = new System.Windows.Forms.TextBox();
            this.loginbox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureclose = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infobox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyes2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureclose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(196)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.pictureclose);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 753);
            this.panel1.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(12, 24);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(10, 25);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::AZS_New.Properties.Resources._9224381_padlock_lock_security_protection_secure_icon;
            this.pictureBox2.Location = new System.Drawing.Point(12, 410);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::AZS_New.Properties.Resources._678132_account_user_person_profile_avatar_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 103);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизация";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.panel2.Controls.Add(this.resetpass);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.infobox);
            this.panel2.Controls.Add(this.create);
            this.panel2.Controls.Add(this.eyes2);
            this.panel2.Controls.Add(this.eyes1);
            this.panel2.Controls.Add(this.enter);
            this.panel2.Controls.Add(this.passbox);
            this.panel2.Controls.Add(this.loginbox);
            this.panel2.Location = new System.Drawing.Point(163, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 574);
            this.panel2.TabIndex = 0;
            // 
            // resetpass
            // 
            this.resetpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetpass.FlatAppearance.BorderSize = 0;
            this.resetpass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.resetpass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.resetpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetpass.Font = new System.Drawing.Font("Courier New", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetpass.Location = new System.Drawing.Point(35, 494);
            this.resetpass.Name = "resetpass";
            this.resetpass.Size = new System.Drawing.Size(346, 52);
            this.resetpass.TabIndex = 11;
            this.resetpass.Text = "Забыли пароль?";
            this.resetpass.UseVisualStyleBackColor = true;
            this.resetpass.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(158, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 41);
            this.label5.TabIndex = 10;
            this.label5.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 41);
            this.label4.TabIndex = 9;
            this.label4.Text = "через:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(480, 41);
            this.label3.TabIndex = 8;
            this.label3.Text = "Вы сможете продолжить";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 43);
            this.label2.TabIndex = 7;
            this.label2.Text = "Форма заблокирована!";
            // 
            // infobox
            // 
            this.infobox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infobox.Image = global::AZS_New.Properties.Resources._134192_information_question_icon;
            this.infobox.Location = new System.Drawing.Point(387, 434);
            this.infobox.Name = "infobox";
            this.infobox.Size = new System.Drawing.Size(45, 45);
            this.infobox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.infobox.TabIndex = 6;
            this.infobox.TabStop = false;
            this.infobox.Click += new System.EventHandler(this.infobox_Click);
            // 
            // create
            // 
            this.create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create.FlatAppearance.BorderSize = 0;
            this.create.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create.Font = new System.Drawing.Font("Courier New", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create.Location = new System.Drawing.Point(35, 504);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(346, 52);
            this.create.TabIndex = 5;
            this.create.Text = "Ещё нет аккаунта? Создать!";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // eyes2
            // 
            this.eyes2.BackColor = System.Drawing.Color.White;
            this.eyes2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyes2.Image = global::AZS_New.Properties.Resources.скрыть;
            this.eyes2.Location = new System.Drawing.Point(396, 272);
            this.eyes2.Name = "eyes2";
            this.eyes2.Size = new System.Drawing.Size(48, 48);
            this.eyes2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eyes2.TabIndex = 4;
            this.eyes2.TabStop = false;
            this.eyes2.Click += new System.EventHandler(this.eyes2_Click);
            // 
            // eyes1
            // 
            this.eyes1.BackColor = System.Drawing.Color.White;
            this.eyes1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyes1.Image = global::AZS_New.Properties.Resources.показать;
            this.eyes1.Location = new System.Drawing.Point(396, 272);
            this.eyes1.Name = "eyes1";
            this.eyes1.Size = new System.Drawing.Size(48, 48);
            this.eyes1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eyes1.TabIndex = 3;
            this.eyes1.TabStop = false;
            this.eyes1.Click += new System.EventHandler(this.eyes1_Click);
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.White;
            this.enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enter.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter.Location = new System.Drawing.Point(35, 425);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(346, 63);
            this.enter.TabIndex = 2;
            this.enter.Text = "Войти";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // passbox
            // 
            this.passbox.Font = new System.Drawing.Font("Courier New", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passbox.Location = new System.Drawing.Point(35, 271);
            this.passbox.Multiline = true;
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(410, 50);
            this.passbox.TabIndex = 1;
            this.passbox.TextChanged += new System.EventHandler(this.passbox_TextChanged);
            this.passbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passbox_KeyPress);
            // 
            // loginbox
            // 
            this.loginbox.Font = new System.Drawing.Font("Courier New", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginbox.Location = new System.Drawing.Point(35, 83);
            this.loginbox.Multiline = true;
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(410, 50);
            this.loginbox.TabIndex = 0;
            this.loginbox.TextChanged += new System.EventHandler(this.loginbox_TextChanged);
            this.loginbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginbox_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureclose
            // 
            this.pictureclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureclose.Image = global::AZS_New.Properties.Resources._1564505_close_delete_exit_remove_icon;
            this.pictureclose.Location = new System.Drawing.Point(642, 12);
            this.pictureclose.Name = "pictureclose";
            this.pictureclose.Size = new System.Drawing.Size(52, 52);
            this.pictureclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureclose.TabIndex = 7;
            this.pictureclose.TabStop = false;
            this.pictureclose.Click += new System.EventHandler(this.pictureclose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 753);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infobox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyes2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureclose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox loginbox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.PictureBox eyes1;
        private System.Windows.Forms.PictureBox eyes2;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.PictureBox infobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.PictureBox pictureclose;
    }
}

