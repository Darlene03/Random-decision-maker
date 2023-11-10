namespace Decision_maker
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
            this.tbxOption2 = new System.Windows.Forms.TextBox();
            this.tbxOption1 = new System.Windows.Forms.TextBox();
            this.tbxOption3 = new System.Windows.Forms.TextBox();
            this.tbxOption4 = new System.Windows.Forms.TextBox();
            this.tbxOption5 = new System.Windows.Forms.TextBox();
            this.tbxOption6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxOption2
            // 
            this.tbxOption2.Location = new System.Drawing.Point(475, 158);
            this.tbxOption2.Name = "tbxOption2";
            this.tbxOption2.Size = new System.Drawing.Size(100, 22);
            this.tbxOption2.TabIndex = 0;
            // 
            // tbxOption1
            // 
            this.tbxOption1.Location = new System.Drawing.Point(254, 158);
            this.tbxOption1.Name = "tbxOption1";
            this.tbxOption1.Size = new System.Drawing.Size(100, 22);
            this.tbxOption1.TabIndex = 1;
            // 
            // tbxOption3
            // 
            this.tbxOption3.Location = new System.Drawing.Point(254, 220);
            this.tbxOption3.Name = "tbxOption3";
            this.tbxOption3.Size = new System.Drawing.Size(100, 22);
            this.tbxOption3.TabIndex = 2;
            // 
            // tbxOption4
            // 
            this.tbxOption4.Location = new System.Drawing.Point(475, 220);
            this.tbxOption4.Name = "tbxOption4";
            this.tbxOption4.Size = new System.Drawing.Size(100, 22);
            this.tbxOption4.TabIndex = 3;
            // 
            // tbxOption5
            // 
            this.tbxOption5.Location = new System.Drawing.Point(254, 281);
            this.tbxOption5.Name = "tbxOption5";
            this.tbxOption5.Size = new System.Drawing.Size(100, 22);
            this.tbxOption5.TabIndex = 4;
            // 
            // tbxOption6
            // 
            this.tbxOption6.Location = new System.Drawing.Point(475, 281);
            this.tbxOption6.Name = "tbxOption6";
            this.tbxOption6.Size = new System.Drawing.Size(100, 22);
            this.tbxOption6.TabIndex = 5;
            this.tbxOption6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Give me your options and I will decide for you 😊";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(411, 349);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxOption6);
            this.Controls.Add(this.tbxOption5);
            this.Controls.Add(this.tbxOption4);
            this.Controls.Add(this.tbxOption3);
            this.Controls.Add(this.tbxOption1);
            this.Controls.Add(this.tbxOption2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxOption2;
        private System.Windows.Forms.TextBox tbxOption1;
        private System.Windows.Forms.TextBox tbxOption3;
        private System.Windows.Forms.TextBox tbxOption4;
        private System.Windows.Forms.TextBox tbxOption5;
        private System.Windows.Forms.TextBox tbxOption6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
    }
}

