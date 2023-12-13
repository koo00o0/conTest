namespace WindowsFormsApp3
{
    partial class Index
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
            this.todolist = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 25F);
            this.label1.Location = new System.Drawing.Point(298, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "메인";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // todolist
            // 
            this.todolist.Location = new System.Drawing.Point(71, 196);
            this.todolist.Name = "todolist";
            this.todolist.Size = new System.Drawing.Size(171, 62);
            this.todolist.TabIndex = 1;
            this.todolist.Text = "TODOLIST";
            this.todolist.UseVisualStyleBackColor = true;
            this.todolist.Click += new System.EventHandler(this.todolist_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(305, 196);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(171, 62);
            this.logout.TabIndex = 1;
            this.logout.Text = "로그아웃";
            this.logout.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(541, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 62);
            this.button3.TabIndex = 1;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.todolist);
            this.Controls.Add(this.label1);
            this.Name = "Index";
            this.Text = "Index";
            this.Load += new System.EventHandler(this.Index_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button todolist;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button button3;
    }
}