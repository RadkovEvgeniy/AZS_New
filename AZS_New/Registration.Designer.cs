namespace AZS_New
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.backspace = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eyes2 = new System.Windows.Forms.PictureBox();
            this.eyes1 = new System.Windows.Forms.PictureBox();
            this.enter = new System.Windows.Forms.Button();
            this.passbox = new System.Windows.Forms.TextBox();
            this.loginbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backspace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eyes2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyes1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(196)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.backspace);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 738);
            this.panel1.TabIndex = 0;
            // 
            // backspace
            // 
            this.backspace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backspace.Image = global::AZS_New.Properties.Resources._2203523_arrow_back_botton_left_icon;
            this.backspace.Location = new System.Drawing.Point(4, 13);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(52, 52);
            this.backspace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backspace.TabIndex = 4;
            this.backspace.TabStop = false;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AZS_New.Properties.Resources._9224381_padlock_lock_security_protection_secure_icon;
            this.pictureBox2.Location = new System.Drawing.Point(12, 410);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AZS_New.Properties.Resources._678158_account_add_friend_person_social_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 103);
            this.label1.TabIndex = 1;
            this.label1.Text = "Регистрация";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.panel2.Controls.Add(this.eyes2);
            this.panel2.Controls.Add(this.eyes1);
            this.panel2.Controls.Add(this.enter);
            this.panel2.Controls.Add(this.passbox);
            this.panel2.Controls.Add(this.loginbox);
            this.panel2.Location = new System.Drawing.Point(163, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 567);
            this.panel2.TabIndex = 0;
            // 
            // eyes2
            // 
            this.eyes2.BackColor = System.Drawing.Color.White;
            this.eyes2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyes2.Image = global::AZS_New.Properties.Resources.скрыть;
            this.eyes2.Location = new System.Drawing.Point(396, 273);
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
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enter.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter.Location = new System.Drawing.Point(21, 425);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(424, 65);
            this.enter.TabIndex = 2;
            this.enter.Text = "Зарегистрироваться";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // passbox
            // 
            this.passbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passbox.Location = new System.Drawing.Point(35, 271);
            this.passbox.Multiline = true;
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(410, 50);
            this.passbox.TabIndex = 1;
            // 
            // loginbox
            // 
            this.loginbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginbox.Location = new System.Drawing.Point(35, 83);
            this.loginbox.Multiline = true;
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(410, 50);
            this.loginbox.TabIndex = 0;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 738);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backspace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eyes2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyes1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox loginbox;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.PictureBox backspace;
        private System.Windows.Forms.PictureBox eyes1;
        private System.Windows.Forms.PictureBox eyes2;
    }
}