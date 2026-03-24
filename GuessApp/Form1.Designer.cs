namespace GuessApp
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
            lblWord = new Label();
            txtGuess = new TextBox();
            button1 = new Button();
            listWrong = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblWord
            // 
            lblWord.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblWord.BackColor = Color.DarkSeaGreen;
            lblWord.BorderStyle = BorderStyle.Fixed3D;
            lblWord.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblWord.ForeColor = Color.White;
            lblWord.Location = new Point(26, 27);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(530, 88);
            lblWord.TabIndex = 0;
            lblWord.Text = "label1";
            lblWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtGuess
            // 
            txtGuess.Font = new Font("Segoe UI", 14F);
            txtGuess.Location = new Point(113, 134);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(342, 39);
            txtGuess.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(222, 179);
            button1.Name = "button1";
            button1.Size = new Size(134, 43);
            button1.TabIndex = 2;
            button1.Text = "Guess";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnGuess_Click;
            // 
            // listWrong
            // 
            listWrong.FormattingEnabled = true;
            listWrong.Location = new Point(622, 45);
            listWrong.Name = "listWrong";
            listWrong.Size = new Size(150, 164);
            listWrong.TabIndex = 3;
            // 
            // label2
            // 
            label2.BackColor = Color.DarkSeaGreen;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(622, 13);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 4;
            label2.Text = "Wrong guess";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.abstract_gaming_background_xa5qru2gdfqot34z;
            ClientSize = new Size(800, 234);
            Controls.Add(label2);
            Controls.Add(listWrong);
            Controls.Add(button1);
            Controls.Add(txtGuess);
            Controls.Add(lblWord);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWord;
        private TextBox txtGuess;
        private Button button1;
        private ListBox listWrong;
        private Label label2;
    }
}
