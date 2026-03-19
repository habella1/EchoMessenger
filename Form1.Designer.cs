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
            label1 = new Label();
            lstChat = new ListBox();
            txtMessage = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("한컴 백제 M", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.Turquoise;
            label1.Location = new Point(38, 22);
            label1.Name = "label1";
            label1.Size = new Size(446, 63);
            label1.TabIndex = 0;
            label1.Text = "Echo Messenger";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(lstChat);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstChat;
        private TextBox txtMessage;
        private Button btnSend;
    }
}
