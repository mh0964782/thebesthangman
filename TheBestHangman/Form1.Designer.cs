namespace TheBestHangman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl_inst = new Label();
            lbl_title = new Label();
            lbl_name = new Label();
            lbl_difficulty = new Label();
            txt_name = new TextBox();
            btn_highScores = new Button();
            btn_begin = new Button();
            rdo_easy = new RadioButton();
            rdo_med = new RadioButton();
            rdo_hard = new RadioButton();
            Description = new Label();
            Instructions = new Label();
            SuspendLayout();
            // 
            // lbl_inst
            // 
            lbl_inst.AutoSize = true;
            lbl_inst.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_inst.Location = new Point(30, 171);
            lbl_inst.Name = "lbl_inst";
            lbl_inst.Size = new Size(97, 20);
            lbl_inst.TabIndex = 1;
            lbl_inst.Text = "How to Play:";
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_title.Location = new Point(150, 21);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(217, 32);
            lbl_title.TabIndex = 2;
            lbl_title.Text = "The Best Hangman";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_name.Location = new Point(71, 267);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(51, 20);
            lbl_name.TabIndex = 3;
            lbl_name.Text = "Name";
            // 
            // lbl_difficulty
            // 
            lbl_difficulty.AutoSize = true;
            lbl_difficulty.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_difficulty.Location = new Point(362, 267);
            lbl_difficulty.Name = "lbl_difficulty";
            lbl_difficulty.Size = new Size(74, 20);
            lbl_difficulty.TabIndex = 4;
            lbl_difficulty.Text = "Difficulty";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(42, 305);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(125, 27);
            txt_name.TabIndex = 5;
            // 
            // btn_highScores
            // 
            btn_highScores.BackColor = SystemColors.Highlight;
            btn_highScores.Cursor = Cursors.Hand;
            btn_highScores.FlatAppearance.BorderColor = Color.Blue;
            btn_highScores.FlatAppearance.BorderSize = 2;
            btn_highScores.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            btn_highScores.FlatAppearance.MouseOverBackColor = Color.Blue;
            btn_highScores.FlatStyle = FlatStyle.Flat;
            btn_highScores.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_highScores.ForeColor = SystemColors.Control;
            btn_highScores.Location = new Point(181, 428);
            btn_highScores.Name = "btn_highScores";
            btn_highScores.Size = new Size(170, 36);
            btn_highScores.TabIndex = 6;
            btn_highScores.Text = "View High Scores";
            btn_highScores.UseVisualStyleBackColor = false;
            btn_highScores.Click += btn_highScores_Click;
            // 
            // btn_begin
            // 
            btn_begin.BackColor = SystemColors.Highlight;
            btn_begin.Cursor = Cursors.Hand;
            btn_begin.FlatAppearance.BorderColor = Color.Blue;
            btn_begin.FlatAppearance.BorderSize = 2;
            btn_begin.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            btn_begin.FlatAppearance.MouseOverBackColor = Color.Blue;
            btn_begin.FlatStyle = FlatStyle.Flat;
            btn_begin.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_begin.ForeColor = SystemColors.Control;
            btn_begin.Location = new Point(181, 365);
            btn_begin.Name = "btn_begin";
            btn_begin.Size = new Size(170, 36);
            btn_begin.TabIndex = 7;
            btn_begin.Text = "Start Game";
            btn_begin.UseVisualStyleBackColor = false;
            btn_begin.Click += btn_begin_Click;
            // 
            // rdo_easy
            // 
            rdo_easy.AutoSize = true;
            rdo_easy.Location = new Point(282, 305);
            rdo_easy.Name = "rdo_easy";
            rdo_easy.Size = new Size(59, 24);
            rdo_easy.TabIndex = 8;
            rdo_easy.TabStop = true;
            rdo_easy.Text = "Easy";
            rdo_easy.UseVisualStyleBackColor = true;
            // 
            // rdo_med
            // 
            rdo_med.AutoSize = true;
            rdo_med.Location = new Point(347, 305);
            rdo_med.Name = "rdo_med";
            rdo_med.Size = new Size(85, 24);
            rdo_med.TabIndex = 9;
            rdo_med.TabStop = true;
            rdo_med.Text = "Medium";
            rdo_med.UseVisualStyleBackColor = true;
            // 
            // rdo_hard
            // 
            rdo_hard.AutoSize = true;
            rdo_hard.BackColor = SystemColors.Control;
            rdo_hard.Location = new Point(449, 305);
            rdo_hard.Name = "rdo_hard";
            rdo_hard.Size = new Size(63, 24);
            rdo_hard.TabIndex = 10;
            rdo_hard.TabStop = true;
            rdo_hard.Text = "Hard";
            rdo_hard.UseVisualStyleBackColor = false;
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Location = new Point(11, 67);
            Description.Margin = new Padding(2, 0, 2, 0);
            Description.Name = "Description";
            Description.Size = new Size(542, 80);
            Description.TabIndex = 11;
            Description.Text = resources.GetString("Description.Text");
            Description.TextAlign = ContentAlignment.TopCenter;
            // 
            // Instructions
            // 
            Instructions.AutoSize = true;
            Instructions.Location = new Point(30, 189);
            Instructions.Margin = new Padding(2, 0, 2, 0);
            Instructions.Name = "Instructions";
            Instructions.Size = new Size(467, 60);
            Instructions.TabIndex = 12;
            Instructions.Text = "1. Input your name\r\n2. Select difficulty\r\n3. Click \"Start Game\" then use the built in keyboard to begin guessing";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 495);
            Controls.Add(Instructions);
            Controls.Add(Description);
            Controls.Add(rdo_hard);
            Controls.Add(rdo_med);
            Controls.Add(rdo_easy);
            Controls.Add(btn_begin);
            Controls.Add(btn_highScores);
            Controls.Add(txt_name);
            Controls.Add(lbl_difficulty);
            Controls.Add(lbl_name);
            Controls.Add(lbl_title);
            Controls.Add(lbl_inst);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(579, 542);
            MinimumSize = new Size(579, 542);
            Name = "Form1";
            Text = "Hangman";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_inst;
        private Label lbl_title;
        private Label lbl_name;
        private Label lbl_difficulty;
        private TextBox txt_name;
        private Button btn_highScores;
        private Button btn_begin;
        private RadioButton rdo_easy;
        private RadioButton rdo_med;
        private RadioButton rdo_hard;
        private Label Description;
        private Label Instructions;

    }
}