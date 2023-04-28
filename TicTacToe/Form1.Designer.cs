namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitGameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitGameToolStripMenuItem
            // 
            this.exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            this.exitGameToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitGameToolStripMenuItem.Text = "Exit game";
            this.exitGameToolStripMenuItem.Click += new System.EventHandler(this.exitGameToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.A1.Font = new System.Drawing.Font("Snap ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.A1.Location = new System.Drawing.Point(12, 35);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(175, 175);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.button_Click);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.B1.Font = new System.Drawing.Font("Snap ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.B1.Location = new System.Drawing.Point(10, 216);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(175, 175);
            this.B1.TabIndex = 2;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.button_Click);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.C1.Font = new System.Drawing.Font("Snap ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.C1.Location = new System.Drawing.Point(12, 397);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(175, 175);
            this.C1.TabIndex = 3;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.button_Click);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.C2.Font = new System.Drawing.Font("Snap ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.C2.Location = new System.Drawing.Point(191, 397);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(175, 175);
            this.C2.TabIndex = 6;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.button_Click);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.B2.Font = new System.Drawing.Font("Snap ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.B2.Location = new System.Drawing.Point(191, 216);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(175, 175);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.button_Click);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.C3.Font = new System.Drawing.Font("Snap ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.C3.Location = new System.Drawing.Point(372, 397);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(175, 175);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.button_Click);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.B3.Font = new System.Drawing.Font("Snap ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.B3.Location = new System.Drawing.Point(372, 216);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(175, 175);
            this.B3.TabIndex = 8;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.button_Click);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.A3.Font = new System.Drawing.Font("Snap ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.A3.Location = new System.Drawing.Point(374, 35);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(175, 175);
            this.A3.TabIndex = 7;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.button_Click);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.A2.Font = new System.Drawing.Font("Snap ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.A2.Location = new System.Drawing.Point(193, 35);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(175, 175);
            this.A2.TabIndex = 10;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(559, 584);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem exitGameToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button A1;
        private Button B1;
        private Button C1;
        private Button C2;
        private Button B2;
        private Button C3;
        private Button B3;
        private Button A3;
        private Button A2;
    }
}