namespace 医院预约挂号系统
{
    partial class frm_LogIn
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.lbl_UserNo = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txb_UserNo = new System.Windows.Forms.TextBox();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Hint = new System.Windows.Forms.Label();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LogIn.Location = new System.Drawing.Point(318, 250);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(87, 33);
            this.btn_LogIn.TabIndex = 0;
            this.btn_LogIn.Text = "登录";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // lbl_UserNo
            // 
            this.lbl_UserNo.AutoSize = true;
            this.lbl_UserNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_UserNo.Location = new System.Drawing.Point(235, 120);
            this.lbl_UserNo.Name = "lbl_UserNo";
            this.lbl_UserNo.Size = new System.Drawing.Size(89, 20);
            this.lbl_UserNo.TabIndex = 2;
            this.lbl_UserNo.Text = "用户名：";
            this.lbl_UserNo.Click += new System.EventHandler(this.lbl_UserNo_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Password.Location = new System.Drawing.Point(255, 170);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(69, 20);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "密码：";
            // 
            // txb_UserNo
            // 
            this.txb_UserNo.Location = new System.Drawing.Point(308, 117);
            this.txb_UserNo.Name = "txb_UserNo";
            this.txb_UserNo.Size = new System.Drawing.Size(117, 25);
            this.txb_UserNo.TabIndex = 4;
            this.txb_UserNo.TextChanged += new System.EventHandler(this.txb_UserNo_TextChanged);
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(308, 170);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(117, 25);
            this.txb_Password.TabIndex = 5;
            // 
            // lbl_Hint
            // 
            this.lbl_Hint.AutoSize = true;
            this.lbl_Hint.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Hint.Location = new System.Drawing.Point(304, 216);
            this.lbl_Hint.Name = "lbl_Hint";
            this.lbl_Hint.Size = new System.Drawing.Size(180, 19);
            this.lbl_Hint.TabIndex = 6;
            this.lbl_Hint.Text = "请输入用户号、密码";
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SignUp.Location = new System.Drawing.Point(318, 308);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(87, 31);
            this.btn_SignUp.TabIndex = 7;
            this.btn_SignUp.Text = "注册";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // frm_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.lbl_Hint);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_UserNo);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserNo);
            this.Controls.Add(this.btn_LogIn);
            this.Name = "frm_LogIn";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Label lbl_UserNo;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txb_UserNo;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Label lbl_Hint;
        private System.Windows.Forms.Button btn_SignUp;
    }
}

