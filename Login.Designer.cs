namespace ProiectPartea1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.btnLoggin = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajutorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajutorToolStripMenuItem
            // 
            this.ajutorToolStripMenuItem.Name = "ajutorToolStripMenuItem";
            this.ajutorToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ajutorToolStripMenuItem.Text = "Ajutor";
            // 
            // lb1
            // 
            this.lb1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb1.Image = ((System.Drawing.Image)(resources.GetObject("lb1.Image")));
            this.lb1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb1.Location = new System.Drawing.Point(46, 24);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(390, 89);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Byonic Gym";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb2
            // 
            this.lb2.BackColor = System.Drawing.Color.Transparent;
            this.lb2.Location = new System.Drawing.Point(86, 149);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(139, 28);
            this.lb2.TabIndex = 2;
            this.lb2.Text = "Username:";
            // 
            // lb3
            // 
            this.lb3.Location = new System.Drawing.Point(86, 210);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(100, 23);
            this.lb3.TabIndex = 3;
            this.lb3.Text = "Password:";
            // 
            // btnLoggin
            // 
            this.btnLoggin.BackColor = System.Drawing.Color.Transparent;
            this.btnLoggin.Location = new System.Drawing.Point(152, 290);
            this.btnLoggin.Name = "btnLoggin";
            this.btnLoggin.Size = new System.Drawing.Size(140, 37);
            this.btnLoggin.TabIndex = 4;
            this.btnLoggin.Text = "Login";
            this.btnLoggin.UseVisualStyleBackColor = false;
            this.btnLoggin.Click += new System.EventHandler(this.btnLoggin_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(259, 146);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 23);
            this.txtUser.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(259, 207);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 23);
            this.txtPassword.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(521, 435);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnLoggin);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ajutorToolStripMenuItem;
        private Label lb1;
        private Label lb2;
        private Label lb3;
        private Button btnLoggin;
        private TextBox txtUser;
        private TextBox txtPassword;
    }
}