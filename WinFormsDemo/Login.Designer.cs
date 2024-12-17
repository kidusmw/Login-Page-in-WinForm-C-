using System.Windows.Forms;

namespace WinFormsDemo
{
    partial class Login: Form
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
            LoginBtn = new Button();
            UsrTxtBx = new TextBox();
            UsrLbl = new Label();
            PwdLbl = new Label();
            PwdTxtBx = new TextBox();
            LblMsg = new Label();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(307, 275);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(172, 67);
            LoginBtn.TabIndex = 0;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += button1_Click;
            // 
            // UsrTxtBx
            // 
            UsrTxtBx.Location = new Point(307, 148);
            UsrTxtBx.Name = "UsrTxtBx";
            UsrTxtBx.Size = new Size(258, 27);
            UsrTxtBx.TabIndex = 1;
            UsrTxtBx.Text = "\r\n";
            UsrTxtBx.TextChanged += UsrTxtBx_TextChanged;
            // 
            // UsrLbl
            // 
            UsrLbl.AutoSize = true;
            UsrLbl.Location = new Point(223, 151);
            UsrLbl.Name = "UsrLbl";
            UsrLbl.Size = new Size(78, 20);
            UsrLbl.TabIndex = 2;
            UsrLbl.Text = "Username:";
            // 
            // PwdLbl
            // 
            PwdLbl.AutoSize = true;
            PwdLbl.Location = new Point(228, 184);
            PwdLbl.Name = "PwdLbl";
            PwdLbl.Size = new Size(73, 20);
            PwdLbl.TabIndex = 4;
            PwdLbl.Text = "Password:";
            // 
            // PwdTxtBx
            // 
            PwdTxtBx.Location = new Point(307, 181);
            PwdTxtBx.Name = "PwdTxtBx";
            PwdTxtBx.PasswordChar = '*';
            PwdTxtBx.Size = new Size(258, 27);
            PwdTxtBx.TabIndex = 3;
            PwdTxtBx.TextChanged += PwdTxtBx_TextChanged;
            // 
            // LblMsg
            // 
            LblMsg.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblMsg.Location = new Point(23, 44);
            LblMsg.Name = "LblMsg";
            LblMsg.Size = new Size(774, 59);
            LblMsg.TabIndex = 6;
            LblMsg.Text = "Label";
            LblMsg.TextAlign = ContentAlignment.TopCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 450);
            Controls.Add(LblMsg);
            Controls.Add(PwdLbl);
            Controls.Add(PwdTxtBx);
            Controls.Add(UsrLbl);
            Controls.Add(UsrTxtBx);
            Controls.Add(LoginBtn);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginBtn;
        private TextBox UsrTxtBx;
        private Label UsrLbl;
        private Label PwdLbl;
        private TextBox PwdTxtBx;
        private Label LblMsg;
    }
}
