namespace DevTaskApp
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.btnListUsers = new System.Windows.Forms.Button();
            this.btnAddUsers = new System.Windows.Forms.Button();
            this.btnDeleteUsers = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListUsers
            // 
            this.btnListUsers.Location = new System.Drawing.Point(137, 18);
            this.btnListUsers.Name = "btnListUsers";
            this.btnListUsers.Size = new System.Drawing.Size(105, 76);
            this.btnListUsers.TabIndex = 0;
            this.btnListUsers.Text = "List users";
            this.btnListUsers.UseVisualStyleBackColor = true;
            this.btnListUsers.Click += new System.EventHandler(this.btnListUsers_Click);
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.Location = new System.Drawing.Point(26, 18);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(105, 76);
            this.btnAddUsers.TabIndex = 1;
            this.btnAddUsers.Text = "Add/Edit user";
            this.btnAddUsers.UseVisualStyleBackColor = true;
            this.btnAddUsers.Click += new System.EventHandler(this.btnAddUsers_Click);
            // 
            // btnDeleteUsers
            // 
            this.btnDeleteUsers.Location = new System.Drawing.Point(248, 18);
            this.btnDeleteUsers.Name = "btnDeleteUsers";
            this.btnDeleteUsers.Size = new System.Drawing.Size(105, 76);
            this.btnDeleteUsers.TabIndex = 4;
            this.btnDeleteUsers.Text = "Delete user";
            this.btnDeleteUsers.UseVisualStyleBackColor = true;
            this.btnDeleteUsers.Click += new System.EventHandler(this.btnDeleteUsers_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(459, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 76);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnListUsers);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnAddUsers);
            this.panel1.Controls.Add(this.btnDeleteUsers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 125);
            this.panel1.TabIndex = 6;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(601, 453);
            this.Controls.Add(this.panel1);
            this.Name = "HomeForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnListUsers;
        private Button btnAddUsers;
        private Button btnDeleteUsers;
        private Button btnExit;
        private Panel panel1;
    }
}