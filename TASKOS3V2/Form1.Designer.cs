namespace TASKOS3V2
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
            namebox = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            contentbox = new RichTextBox();
            readbutton = new Button();
            SuspendLayout();
            // 
            // namebox
            // 
            namebox.Location = new Point(152, 53);
            namebox.Name = "namebox";
            namebox.Size = new Size(125, 27);
            namebox.TabIndex = 0;
            namebox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 56);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // button1
            // 
            button1.Location = new Point(183, 133);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(694, 179);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Write";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(623, 374);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(527, 56);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 5;
            label2.Text = "Content\r\n";
            // 
            // contentbox
            // 
            contentbox.Location = new Point(592, 42);
            contentbox.Name = "contentbox";
            contentbox.Size = new Size(196, 120);
            contentbox.TabIndex = 6;
            contentbox.Text = "";
            // 
            // readbutton
            // 
            readbutton.Location = new Point(494, 374);
            readbutton.Name = "readbutton";
            readbutton.Size = new Size(94, 29);
            readbutton.TabIndex = 7;
            readbutton.Text = "Read";
            readbutton.UseVisualStyleBackColor = true;
            readbutton.Click += readbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(readbutton);
            Controls.Add(contentbox);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(namebox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox namebox;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private RichTextBox contentbox;
        private Button readbutton;
    }
}