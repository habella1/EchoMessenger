namespace Echo_Messenger
{
    partial class Form1
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
            lbTitle = new Label();
            lstChat = new ListBox();
            txtMessage = new TextBox();
            btnSend = new Button();
            lbCount = new Label();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("한컴 백제 M", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lbTitle.ForeColor = Color.Turquoise;
            lbTitle.Location = new Point(38, 22);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(446, 63);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Echo Messenger";
            lbTitle.Click += lbTitle_Click;
            // 
            // lstChat
            // 
            lstChat.FormattingEnabled = true;
            lstChat.Location = new Point(48, 85);
            lstChat.Name = "lstChat";
            lstChat.Size = new Size(707, 196);
            lstChat.TabIndex = 1;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(38, 335);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(573, 39);
            txtMessage.TabIndex = 2;
            txtMessage.TextChanged += textBox1_TextChanged;
            txtMessage.KeyDown += txtMessage_KeyDown;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.MistyRose;
            btnSend.Font = new Font("문체부 바탕체", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSend.Location = new Point(643, 328);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(112, 54);
            btnSend.TabIndex = 3;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // lbCount
            // 
            lbCount.AutoSize = true;
            lbCount.Font = new Font("문체부 바탕체", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lbCount.Location = new Point(36, 390);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(181, 24);
            lbCount.TabIndex = 4;
            lbCount.Text = "현재 대화 : 0개";
            lbCount.Click += lbCount_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(800, 450);
            Controls.Add(lbCount);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(lstChat);
            Controls.Add(lbTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private ListBox lstChat;
        private TextBox txtMessage;
        private Button btnSend;
        private Label lbCount;
    }
}
