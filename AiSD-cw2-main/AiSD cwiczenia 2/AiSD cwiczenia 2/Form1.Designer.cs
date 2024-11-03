namespace AiSD_cwiczenia_2
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
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(81, 149);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "ADD FIRST";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddFirst;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(452, 168);
            label1.Name = "label1";
            label1.Size = new Size(79, 46);
            label1.TabIndex = 1;
            label1.Text = "lista";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(81, 184);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "ADD LAST";
            button2.UseVisualStyleBackColor = true;
            button2.Click += AddLast;
            // 
            // button3
            // 
            button3.Location = new Point(65, 219);
            button3.Name = "button3";
            button3.Size = new Size(125, 29);
            button3.TabIndex = 4;
            button3.Text = "REMOVE FIRST";
            button3.UseVisualStyleBackColor = true;
            button3.Click += RemoveFirst;
            // 
            // button4
            // 
            button4.Location = new Point(65, 254);
            button4.Name = "button4";
            button4.Size = new Size(125, 29);
            button4.TabIndex = 5;
            button4.Text = "REMOVE LAST";
            button4.UseVisualStyleBackColor = true;
            button4.Click += RemoveLast;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(452, 138);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 6;
            label2.Text = "Ilość elementów:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(575, 138);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 7;
            label3.Text = "0";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private Label label3;
    }
}