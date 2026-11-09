namespace SourdoughApp
{
    partial class HomePage
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
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExit.AutoSize = true;
            btnExit.BackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(754, 418);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(43, 29);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HomePage";
            Text = "HomePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
    }
}