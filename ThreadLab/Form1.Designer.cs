
namespace ThreadLab
{
    partial class Form1
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
            this.countNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.threadNumberNumeric = new System.Windows.Forms.NumericUpDown();
            this.numsListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.countNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadNumberNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // countNumeric
            // 
            this.countNumeric.Location = new System.Drawing.Point(124, 17);
            this.countNumeric.Name = "countNumeric";
            this.countNumeric.Size = new System.Drawing.Size(162, 22);
            this.countNumeric.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Count Threads:";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(293, 15);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(152, 24);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Location = new System.Drawing.Point(376, 43);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(152, 24);
            this.pauseBtn.TabIndex = 5;
            this.pauseBtn.Text = "Pause";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thread to Pause/Resume:";
            // 
            // threadNumberNumeric
            // 
            this.threadNumberNumeric.Location = new System.Drawing.Point(208, 45);
            this.threadNumberNumeric.Name = "threadNumberNumeric";
            this.threadNumberNumeric.Size = new System.Drawing.Size(162, 22);
            this.threadNumberNumeric.TabIndex = 3;
            // 
            // numsListBox
            // 
            this.numsListBox.FormattingEnabled = true;
            this.numsListBox.ItemHeight = 16;
            this.numsListBox.Location = new System.Drawing.Point(15, 73);
            this.numsListBox.Name = "numsListBox";
            this.numsListBox.Size = new System.Drawing.Size(773, 356);
            this.numsListBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numsListBox);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.threadNumberNumeric);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countNumeric);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.countNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadNumberNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown countNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown threadNumberNumeric;
        private System.Windows.Forms.ListBox numsListBox;
    }
}

