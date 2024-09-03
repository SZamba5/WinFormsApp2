namespace WinFormsApp2
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
            btnHello = new Button();
            lblStatus = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnHello
            // 
            btnHello.Location = new Point(342, 191);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(82, 49);
            btnHello.TabIndex = 0;
            btnHello.Text = "Hello World!";
            btnHello.UseVisualStyleBackColor = true;
            btnHello.Click += button1_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Showcard Gothic", 18F);
            lblStatus.ForeColor = Color.OrangeRed;
            lblStatus.Location = new Point(37, 35);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(191, 30);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Hello World!";
            lblStatus.Visible = false;
            lblStatus.AutoSizeChanged += False;
            lblStatus.Click += False;
            // 
            // button1
            // 
            button1.Location = new Point(141, 204);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Show/Hide";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lblStatus);
            Controls.Add(btnHello);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHello;
        private Label lblStatus;
        private Button button1;
    }
}
