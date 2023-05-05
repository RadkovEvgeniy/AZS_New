namespace AZS_New
{
    partial class Main_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.учетТопливаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажаТопливаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.упрпавлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1057, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.учетТопливаToolStripMenuItem,
            this.продажаТопливаToolStripMenuItem,
            this.упрпавлениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(4, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(626, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // учетТопливаToolStripMenuItem
            // 
            this.учетТопливаToolStripMenuItem.Name = "учетТопливаToolStripMenuItem";
            this.учетТопливаToolStripMenuItem.Size = new System.Drawing.Size(135, 29);
            this.учетТопливаToolStripMenuItem.Text = "Учет топлива";
            // 
            // продажаТопливаToolStripMenuItem
            // 
            this.продажаТопливаToolStripMenuItem.Name = "продажаТопливаToolStripMenuItem";
            this.продажаТопливаToolStripMenuItem.Size = new System.Drawing.Size(175, 29);
            this.продажаТопливаToolStripMenuItem.Text = "Продажа топлива";
            // 
            // упрпавлениеToolStripMenuItem
            // 
            this.упрпавлениеToolStripMenuItem.Name = "упрпавлениеToolStripMenuItem";
            this.упрпавлениеToolStripMenuItem.Size = new System.Drawing.Size(125, 29);
            this.упрпавлениеToolStripMenuItem.Text = "Управление";
            this.упрпавлениеToolStripMenuItem.Click += new System.EventHandler(this.упрпавлениеToolStripMenuItem_Click);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 737);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_form";
            this.Text = "Main_form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem учетТопливаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажаТопливаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem упрпавлениеToolStripMenuItem;
    }
}