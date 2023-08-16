namespace notGooGleUSB
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
            userNameTxtBox = new TextBox();
            createAnAccount = new LinkLabel();
            learnMore = new LinkLabel();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            forgotEmail = new LinkLabel();
            Next = new Button();
            SuspendLayout();
            // 
            // userNameTxtBox
            // 
            userNameTxtBox.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point);
            userNameTxtBox.Location = new Point(28, 445);
            userNameTxtBox.Name = "userNameTxtBox";
            userNameTxtBox.Size = new Size(604, 70);
            userNameTxtBox.TabIndex = 34;
            userNameTxtBox.KeyPress += userNameTxtBox_KeyPress;
            // 
            // createAnAccount
            // 
            createAnAccount.AutoSize = true;
            createAnAccount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createAnAccount.LinkBehavior = LinkBehavior.NeverUnderline;
            createAnAccount.Location = new Point(44, 764);
            createAnAccount.Name = "createAnAccount";
            createAnAccount.Size = new Size(225, 38);
            createAnAccount.TabIndex = 33;
            createAnAccount.TabStop = true;
            createAnAccount.Text = "Creat an account";
            // 
            // learnMore
            // 
            learnMore.AutoSize = true;
            learnMore.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            learnMore.LinkBehavior = LinkBehavior.NeverUnderline;
            learnMore.Location = new Point(79, 657);
            learnMore.Name = "learnMore";
            learnMore.Size = new Size(135, 32);
            learnMore.TabIndex = 32;
            learnMore.TabStop = true;
            learnMore.Text = "Learn more";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 659);
            label4.Name = "label4";
            label4.Size = new Size(35, 30);
            label4.TabIndex = 31;
            label4.Text = "in.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 627);
            label2.Name = "label2";
            label2.Size = new Size(588, 30);
            label2.TabIndex = 30;
            label2.Text = "Not your computer? Use a private browsing window to sign";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 8.142857F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(44, 380);
            label1.Name = "label1";
            label1.Size = new Size(219, 47);
            label1.TabIndex = 29;
            label1.Text = "Email or phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sans Serif Collection", 14.1428556F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(198, 284);
            label5.Name = "label5";
            label5.Size = new Size(205, 82);
            label5.TabIndex = 28;
            label5.Text = "Sign in";
            // 
            // forgotEmail
            // 
            forgotEmail.AutoSize = true;
            forgotEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            forgotEmail.LinkBehavior = LinkBehavior.NeverUnderline;
            forgotEmail.Location = new Point(28, 529);
            forgotEmail.Name = "forgotEmail";
            forgotEmail.Size = new Size(186, 38);
            forgotEmail.TabIndex = 27;
            forgotEmail.TabStop = true;
            forgotEmail.Text = "Forgot email?";
            // 
            // Next
            // 
            Next.BackColor = SystemColors.HotTrack;
            Next.Font = new Font("Sans Serif Collection", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            Next.ForeColor = SystemColors.HighlightText;
            Next.Location = new Point(433, 773);
            Next.Name = "Next";
            Next.Size = new Size(199, 87);
            Next.TabIndex = 26;
            Next.Text = "Next\r\n";
            Next.UseVisualStyleBackColor = false;
            Next.Click += Next_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(673, 914);
            Controls.Add(userNameTxtBox);
            Controls.Add(createAnAccount);
            Controls.Add(learnMore);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(forgotEmail);
            Controls.Add(Next);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userNameTxtBox;
        private LinkLabel createAnAccount;
        private LinkLabel learnMore;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label5;
        private LinkLabel forgotEmail;
        private Button Next;
    }
}