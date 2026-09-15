namespace SourdoughApp
{
    partial class RegisterScreen
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
            label1 = new Label();
            txtPassConfirm = new TextBox();
            txtPass = new TextBox();
            lblPassConfirm = new Label();
            label2 = new Label();
            txtUsernameIn = new TextBox();
            label4 = new Label();
            btnCreateAccount = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(113, 21);
            label1.Name = "label1";
            label1.Size = new Size(180, 33);
            label1.TabIndex = 1;
            label1.Text = "Login/Register";
            // 
            // txtPassConfirm
            // 
            txtPassConfirm.BackColor = Color.White;
            txtPassConfirm.Location = new Point(158, 212);
            txtPassConfirm.Name = "txtPassConfirm";
            txtPassConfirm.Size = new Size(100, 23);
            txtPassConfirm.TabIndex = 8;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.White;
            txtPass.Location = new Point(158, 156);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 7;
            // 
            // lblPassConfirm
            // 
            lblPassConfirm.AutoSize = true;
            lblPassConfirm.Location = new Point(149, 194);
            lblPassConfirm.Name = "lblPassConfirm";
            lblPassConfirm.Size = new Size(107, 15);
            lblPassConfirm.TabIndex = 6;
            lblPassConfirm.Text = "Confirm Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 138);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // txtUsernameIn
            // 
            txtUsernameIn.BackColor = Color.White;
            txtUsernameIn.Location = new Point(158, 101);
            txtUsernameIn.Name = "txtUsernameIn";
            txtUsernameIn.Size = new Size(100, 23);
            txtUsernameIn.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 83);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 9;
            label4.Text = "Username:";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(158, 266);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(105, 23);
            btnCreateAccount.TabIndex = 11;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // RegisterScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(406, 330);
            Controls.Add(btnCreateAccount);
            Controls.Add(txtUsernameIn);
            Controls.Add(label4);
            Controls.Add(txtPassConfirm);
            Controls.Add(txtPass);
            Controls.Add(lblPassConfirm);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterScreen";
            Text = "RegisterScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox txtPassConfirm;
        public TextBox txtPass;
        private Label lblPassConfirm;
        private Label label2;
        public TextBox txtUsernameIn;
        private Label label4;
        private Button btnCreateAccount;
    }
}