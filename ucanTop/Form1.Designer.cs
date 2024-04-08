namespace ucanTop
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            kontrol = new Button();
            ball = new Button();
            button1 = new Button();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 255, 192);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(15, 445);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(192, 255, 192);
            label2.Location = new Point(538, 9);
            label2.Name = "label2";
            label2.Size = new Size(15, 445);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(255, 255, 128);
            label3.Location = new Point(33, 9);
            label3.Name = "label3";
            label3.Size = new Size(499, 18);
            label3.TabIndex = 2;
            // 
            // kontrol
            // 
            kontrol.BackColor = Color.FromArgb(128, 255, 255);
            kontrol.Location = new Point(223, 429);
            kontrol.Name = "kontrol";
            kontrol.Size = new Size(115, 25);
            kontrol.TabIndex = 3;
            kontrol.UseVisualStyleBackColor = false;
            kontrol.MouseMove += kontrol_MouseMove;
            // 
            // ball
            // 
            ball.BackColor = Color.FromArgb(255, 128, 128);
            ball.Location = new Point(246, 114);
            ball.Name = "ball";
            ball.Size = new Size(24, 24);
            ball.TabIndex = 4;
            ball.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(627, 64);
            button1.Name = "button1";
            button1.Size = new Size(24, 24);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(672, 66);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 6;
            label4.Text = "3";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 468);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(ball);
            Controls.Add(kontrol);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button kontrol;
        private Button ball;
        private Button button1;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}
