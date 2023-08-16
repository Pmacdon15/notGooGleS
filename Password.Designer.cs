namespace notGooGleUSB
{
    partial class Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password));
            label1 = new Label();
            Next = new Button();
            forgotPasslinkLabel = new LinkLabel();
            showPassBox = new CheckBox();
            passwordBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(211, 315);
            label1.Name = "label1";
            label1.Size = new Size(139, 65);
            label1.TabIndex = 13;
            label1.Text = "Hello";
            label1.Click += label1_Click;
            // 
            // Next
            // 
            Next.BackColor = SystemColors.HotTrack;
            Next.Font = new Font("Sans Serif Collection", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            Next.ForeColor = SystemColors.HighlightText;
            Next.ImeMode = ImeMode.NoControl;
            Next.Location = new Point(412, 719);
            Next.Name = "Next";
            Next.Size = new Size(199, 87);
            Next.TabIndex = 12;
            Next.Text = "Next\r\n";
            Next.UseVisualStyleBackColor = false;
            Next.Click += Next_Click;
            // 
            // forgotPasslinkLabel
            // 
            forgotPasslinkLabel.AutoSize = true;
            forgotPasslinkLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            forgotPasslinkLabel.ImeMode = ImeMode.NoControl;
            forgotPasslinkLabel.Location = new Point(70, 719);
            forgotPasslinkLabel.Name = "forgotPasslinkLabel";
            forgotPasslinkLabel.Size = new Size(235, 38);
            forgotPasslinkLabel.TabIndex = 11;
            forgotPasslinkLabel.TabStop = true;
            forgotPasslinkLabel.Text = "Forgot password?";
            forgotPasslinkLabel.LinkClicked += forgotPasslinkLabel_LinkClicked;
            // 
            // showPassBox
            // 
            showPassBox.AutoSize = true;
            showPassBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            showPassBox.ForeColor = SystemColors.ControlDarkDark;
            showPassBox.ImeMode = ImeMode.NoControl;
            showPassBox.Location = new Point(45, 531);
            showPassBox.Name = "showPassBox";
            showPassBox.Size = new Size(242, 42);
            showPassBox.TabIndex = 10;
            showPassBox.Text = " Show password";
            showPassBox.UseVisualStyleBackColor = true;
            showPassBox.CheckedChanged += showPassBox_CheckedChanged;
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point);
            passwordBox.Location = new Point(45, 433);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(566, 70);
            passwordBox.TabIndex = 9;
            passwordBox.TextChanged += passwordBox_TextChanged;
            passwordBox.KeyPress += passwordBox_KeyPress;
            // 
            // Password
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(649, 850);
            Controls.Add(label1);
            Controls.Add(Next);
            Controls.Add(forgotPasslinkLabel);
            Controls.Add(showPassBox);
            Controls.Add(passwordBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Password";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Next;
        private LinkLabel forgotPasslinkLabel;
        private CheckBox showPassBox;
        private TextBox passwordBox;
    }
}