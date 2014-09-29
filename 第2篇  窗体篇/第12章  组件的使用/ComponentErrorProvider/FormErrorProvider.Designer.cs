namespace ComponentErrorProvider
{
    partial class FormErrorProvider
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bLogin = new System.Windows.Forms.Button();
            this.ePError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tBUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).BeginInit();
            this.SuspendLayout();
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(124, 66);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(75, 23);
            this.bLogin.TabIndex = 0;
            this.bLogin.Text = "登陆";
            this.bLogin.UseVisualStyleBackColor = true;
            // 
            // ePError
            // 
            this.ePError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.ePError.ContainerControl = this;
            // 
            // tBUser
            // 
            this.tBUser.Location = new System.Drawing.Point(84, 12);
            this.tBUser.Name = "tBUser";
            this.tBUser.Size = new System.Drawing.Size(154, 21);
            this.tBUser.TabIndex = 1;
            this.tBUser.Validating += new System.ComponentModel.CancelEventHandler(this.tBUser_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名:";
            // 
            // tBPassword
            // 
            this.tBPassword.Location = new System.Drawing.Point(84, 39);
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.PasswordChar = '*';
            this.tBPassword.Size = new System.Drawing.Size(154, 21);
            this.tBPassword.TabIndex = 1;
            this.tBPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tBPassword_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码:";
            // 
            // FormErrorProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 101);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBUser);
            this.Controls.Add(this.bLogin);
            this.Name = "FormErrorProvider";
            this.Text = "利用ErrorProvider组件实现密码错误提示";
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.ErrorProvider ePError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBUser;
    }
}

