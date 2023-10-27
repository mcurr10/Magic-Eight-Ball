namespace magic8ball
{
    partial class magiceightball
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(magiceightball));
            questionbox = new TextBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // questionbox
            // 
            questionbox.BackColor = SystemColors.InfoText;
            questionbox.ForeColor = SystemColors.Window;
            questionbox.Location = new Point(281, 412);
            questionbox.Multiline = true;
            questionbox.Name = "questionbox";
            questionbox.Size = new Size(457, 146);
            questionbox.TabIndex = 0;
            questionbox.Text = "Type  a question then press the green button for your fortune";
            questionbox.TextAlign = HorizontalAlignment.Center;
            questionbox.Click += questionbox_Click;
            questionbox.TextChanged += questionbox_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(462, 257);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 4;
            label1.Text = "Your Fortune Awaits !";
            label1.Click += label1_Click_1;
            // 
            // magiceightball
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.CadetBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1074, 619);
            Controls.Add(label1);
            Controls.Add(questionbox);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "magiceightball";
            Load += magiceightball_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void questionbox_TextChanged(object sender, EventArgs e)
        {
            int index = random.Next(answers.Count);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            int index = random.Next(answers.Count);
            label1.Text = answers[index];
        }

        #endregion


        private TextBox questionbox;// where you enter question
        private Button button1;//press to get fortune
        private Label label1;// where fortune goes
    }
}