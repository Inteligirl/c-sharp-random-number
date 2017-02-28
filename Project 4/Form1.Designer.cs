namespace Project_4
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
            this.choiceListBox = new System.Windows.Forms.ListBox();
            this.userGuess_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.choose = new System.Windows.Forms.Label();
            this.userInputTextBox = new System.Windows.Forms.TextBox();
            this.instruction = new System.Windows.Forms.Label();
            this.choiceList_Label = new System.Windows.Forms.Label();
            this.showRandomLabel = new System.Windows.Forms.Label();
            this.guessMessageLabel = new System.Windows.Forms.Label();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // choiceListBox
            // 
            this.choiceListBox.FormattingEnabled = true;
            this.choiceListBox.Location = new System.Drawing.Point(117, 137);
            this.choiceListBox.Name = "choiceListBox";
            this.choiceListBox.Size = new System.Drawing.Size(83, 30);
            this.choiceListBox.TabIndex = 0;
            // 
            // userGuess_btn
            // 
            this.userGuess_btn.Location = new System.Drawing.Point(223, 68);
            this.userGuess_btn.Name = "userGuess_btn";
            this.userGuess_btn.Size = new System.Drawing.Size(75, 23);
            this.userGuess_btn.TabIndex = 1;
            this.userGuess_btn.Text = "Guess";
            this.userGuess_btn.UseVisualStyleBackColor = true;
            this.userGuess_btn.Click += new System.EventHandler(this.userGuess_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_btn.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(117, 206);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 2;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // choose
            // 
            this.choose.AutoSize = true;
            this.choose.Location = new System.Drawing.Point(12, 73);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(93, 13);
            this.choose.TabIndex = 3;
            this.choose.Text = "Enter your number";
            // 
            // userInputTextBox
            // 
            this.userInputTextBox.Location = new System.Drawing.Point(117, 70);
            this.userInputTextBox.Name = "userInputTextBox";
            this.userInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.userInputTextBox.TabIndex = 4;
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.Location = new System.Drawing.Point(12, 33);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(323, 15);
            this.instruction.TabIndex = 5;
            this.instruction.Text = "Play a Guessing Game! Pick a number between 1 and 100.";
            // 
            // choiceList_Label
            // 
            this.choiceList_Label.AutoSize = true;
            this.choiceList_Label.Location = new System.Drawing.Point(10, 137);
            this.choiceList_Label.Name = "choiceList_Label";
            this.choiceList_Label.Size = new System.Drawing.Size(101, 13);
            this.choiceList_Label.TabIndex = 6;
            this.choiceList_Label.Text = "Your choices so far:";
            // 
            // showRandomLabel
            // 
            this.showRandomLabel.AutoSize = true;
            this.showRandomLabel.Location = new System.Drawing.Point(10, 181);
            this.showRandomLabel.Name = "showRandomLabel";
            this.showRandomLabel.Size = new System.Drawing.Size(123, 13);
            this.showRandomLabel.TabIndex = 7;
            this.showRandomLabel.Text = "Random number chosen";
            // 
            // guessMessageLabel
            // 
            this.guessMessageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guessMessageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.guessMessageLabel.Location = new System.Drawing.Point(12, 103);
            this.guessMessageLabel.Name = "guessMessageLabel";
            this.guessMessageLabel.Size = new System.Drawing.Size(205, 23);
            this.guessMessageLabel.TabIndex = 8;
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.Image = global::Project_4.Properties.Resources.YouWin;
            this.resultPictureBox.Location = new System.Drawing.Point(223, 103);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(155, 145);
            this.resultPictureBox.TabIndex = 9;
            this.resultPictureBox.TabStop = false;
            this.resultPictureBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(382, 254);
            this.Controls.Add(this.resultPictureBox);
            this.Controls.Add(this.guessMessageLabel);
            this.Controls.Add(this.showRandomLabel);
            this.Controls.Add(this.choiceList_Label);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.userInputTextBox);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.userGuess_btn);
            this.Controls.Add(this.choiceListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox choiceListBox;
        private System.Windows.Forms.Button userGuess_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label choose;
        private System.Windows.Forms.TextBox userInputTextBox;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.Label choiceList_Label;
        private System.Windows.Forms.Label showRandomLabel;
        private System.Windows.Forms.Label guessMessageLabel;
        private System.Windows.Forms.PictureBox resultPictureBox;
    }
}

