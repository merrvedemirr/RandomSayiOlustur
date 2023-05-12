namespace RandomSayi
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LemonChiffon;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(399, 303);
            button1.Name = "button1";
            button1.Size = new Size(177, 65);
            button1.TabIndex = 0;
            button1.Text = "Sayı Oluştur";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Subheading", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(264, 135);
            label1.Name = "label1";
            label1.Size = new Size(460, 33);
            label1.TabIndex = 1;
            label1.Text = "Random Sayı Oluşturmak için buttona tıkla ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(510, 244);
            label2.Name = "label2";
            label2.Size = new Size(34, 26);
            label2.TabIndex = 2;
            label2.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(412, 238);
            label3.Name = "label3";
            label3.Size = new Size(81, 33);
            label3.TabIndex = 3;
            label3.Text = "Sayı : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(974, 461);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}