
namespace WinFormsTetris
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Score = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Label();
            this.holdText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(397, 74);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(37, 15);
            this.Score.TabIndex = 0;
            this.Score.Text = "Score";
            this.Score.Click += new System.EventHandler(this.label1_Click);
            // 
            // next
            // 
            this.next.AutoSize = true;
            this.next.Location = new System.Drawing.Point(397, 126);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(39, 15);
            this.next.TabIndex = 1;
            this.next.Text = "label1";
            // 
            // holdText
            // 
            this.holdText.AutoSize = true;
            this.holdText.Location = new System.Drawing.Point(397, 245);
            this.holdText.Name = "holdText";
            this.holdText.Size = new System.Drawing.Size(39, 15);
            this.holdText.TabIndex = 2;
            this.holdText.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 338);
            this.Controls.Add(this.holdText);
            this.Controls.Add(this.next);
            this.Controls.Add(this.Score);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label next;
        private System.Windows.Forms.Label holdText;
    }
}

