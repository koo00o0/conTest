namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.userId = new System.Windows.Forms.TextBox();
            this.userPw = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.idCheck = new System.Windows.Forms.Button();
            this.userJoin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginFormN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userId
            // 
            this.userId.Location = new System.Drawing.Point(235, 110);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(276, 25);
            this.userId.TabIndex = 0;
            // 
            // userPw
            // 
            this.userPw.Location = new System.Drawing.Point(235, 185);
            this.userPw.Name = "userPw";
            this.userPw.Size = new System.Drawing.Size(276, 25);
            this.userPw.TabIndex = 0;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(235, 284);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(276, 25);
            this.userName.TabIndex = 0;
            // 
            // idCheck
            // 
            this.idCheck.Location = new System.Drawing.Point(559, 109);
            this.idCheck.Name = "idCheck";
            this.idCheck.Size = new System.Drawing.Size(158, 23);
            this.idCheck.TabIndex = 1;
            this.idCheck.Text = "중복체크";
            this.idCheck.UseVisualStyleBackColor = true;
            this.idCheck.Click += new System.EventHandler(this.idCheck_Click);
            // 
            // userJoin
            // 
            this.userJoin.Location = new System.Drawing.Point(293, 334);
            this.userJoin.Name = "userJoin";
            this.userJoin.Size = new System.Drawing.Size(158, 60);
            this.userJoin.TabIndex = 1;
            this.userJoin.Text = "회원가입";
            this.userJoin.UseVisualStyleBackColor = true;
            this.userJoin.Click += new System.EventHandler(this.userJoin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(123, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F);
            this.label2.Location = new System.Drawing.Point(123, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "PW";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F);
            this.label3.Location = new System.Drawing.Point(123, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAME";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginFormN
            // 
            this.LoginFormN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LoginFormN.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LoginFormN.Location = new System.Drawing.Point(642, 294);
            this.LoginFormN.Name = "LoginFormN";
            this.LoginFormN.Size = new System.Drawing.Size(111, 100);
            this.LoginFormN.TabIndex = 3;
            this.LoginFormN.Text = "로그인으로";
            this.LoginFormN.UseVisualStyleBackColor = true;
            this.LoginFormN.Click += new System.EventHandler(this.LoginFormN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginFormN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userJoin);
            this.Controls.Add(this.idCheck);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.userPw);
            this.Controls.Add(this.userId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userId;
        private System.Windows.Forms.TextBox userPw;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Button idCheck;
        private System.Windows.Forms.Button userJoin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoginFormN;
    }
}

