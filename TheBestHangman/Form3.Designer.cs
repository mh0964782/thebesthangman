namespace TheBestHangman
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            dgv_easy = new DataGridView();
            dgv_mid = new DataGridView();
            dgv_hard = new DataGridView();
            btn_backtogame = new Button();
            btn_test = new Button();
            pictureBox1 = new PictureBox();
            imageList1 = new ImageList(components);
            lbl_easyTitle = new Label();
            lbl_medTitle = new Label();
            lbl_hardTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_easy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_mid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_hard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgv_easy
            // 
            dgv_easy.AllowUserToAddRows = false;
            dgv_easy.AllowUserToDeleteRows = false;
            dgv_easy.AllowUserToResizeColumns = false;
            dgv_easy.AllowUserToResizeRows = false;
            dgv_easy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_easy.Location = new Point(38, 52);
            dgv_easy.Name = "dgv_easy";
            dgv_easy.ReadOnly = true;
            dgv_easy.RowHeadersWidth = 51;
            dgv_easy.RowTemplate.Height = 29;
            dgv_easy.ShowCellErrors = false;
            dgv_easy.ShowCellToolTips = false;
            dgv_easy.ShowEditingIcon = false;
            dgv_easy.ShowRowErrors = false;
            dgv_easy.Size = new Size(303, 392);
            dgv_easy.TabIndex = 1;
            // 
            // dgv_mid
            // 
            dgv_mid.AllowUserToAddRows = false;
            dgv_mid.AllowUserToDeleteRows = false;
            dgv_mid.AllowUserToResizeColumns = false;
            dgv_mid.AllowUserToResizeRows = false;
            dgv_mid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_mid.Location = new Point(389, 52);
            dgv_mid.Name = "dgv_mid";
            dgv_mid.ReadOnly = true;
            dgv_mid.RowHeadersWidth = 51;
            dgv_mid.RowTemplate.Height = 29;
            dgv_mid.ShowCellErrors = false;
            dgv_mid.ShowCellToolTips = false;
            dgv_mid.ShowEditingIcon = false;
            dgv_mid.ShowRowErrors = false;
            dgv_mid.Size = new Size(303, 392);
            dgv_mid.TabIndex = 2;
            // 
            // dgv_hard
            // 
            dgv_hard.AllowUserToAddRows = false;
            dgv_hard.AllowUserToDeleteRows = false;
            dgv_hard.AllowUserToResizeColumns = false;
            dgv_hard.AllowUserToResizeRows = false;
            dgv_hard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_hard.Location = new Point(741, 52);
            dgv_hard.Name = "dgv_hard";
            dgv_hard.ReadOnly = true;
            dgv_hard.RowHeadersWidth = 51;
            dgv_hard.RowTemplate.Height = 29;
            dgv_hard.ShowCellErrors = false;
            dgv_hard.ShowCellToolTips = false;
            dgv_hard.ShowEditingIcon = false;
            dgv_hard.ShowRowErrors = false;
            dgv_hard.Size = new Size(303, 392);
            dgv_hard.TabIndex = 3;
            // 
            // btn_backtogame
            // 
            btn_backtogame.BackColor = SystemColors.Highlight;
            btn_backtogame.Cursor = Cursors.Hand;
            btn_backtogame.FlatAppearance.BorderColor = Color.Blue;
            btn_backtogame.FlatAppearance.BorderSize = 2;
            btn_backtogame.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            btn_backtogame.FlatAppearance.MouseOverBackColor = Color.Blue;
            btn_backtogame.FlatStyle = FlatStyle.Flat;
            btn_backtogame.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_backtogame.ForeColor = SystemColors.Control;
            btn_backtogame.Location = new Point(491, 461);
            btn_backtogame.Name = "btn_backtogame";
            btn_backtogame.Size = new Size(94, 36);
            btn_backtogame.TabIndex = 0;
            btn_backtogame.Text = "Back";
            btn_backtogame.UseVisualStyleBackColor = false;
            btn_backtogame.Click += btn_backtogame_Click_1;
            // 
            // btn_test
            // 
            btn_test.Location = new Point(35, 697);
            btn_test.Name = "btn_test";
            btn_test.Size = new Size(94, 29);
            btn_test.TabIndex = 4;
            btn_test.Text = "test";
            btn_test.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(173, 664);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 123);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth24Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "hang1.png");
            imageList1.Images.SetKeyName(1, "hang2.png");
            imageList1.Images.SetKeyName(2, "hang3.png");
            imageList1.Images.SetKeyName(3, "hang4.png");
            imageList1.Images.SetKeyName(4, "hang5.png");
            imageList1.Images.SetKeyName(5, "hang6.png");
            // 
            // lbl_easyTitle
            // 
            lbl_easyTitle.AutoSize = true;
            lbl_easyTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_easyTitle.Location = new Point(109, 9);
            lbl_easyTitle.Name = "lbl_easyTitle";
            lbl_easyTitle.Size = new Size(157, 37);
            lbl_easyTitle.TabIndex = 6;
            lbl_easyTitle.Text = "Easy Games";
            // 
            // lbl_medTitle
            // 
            lbl_medTitle.AutoSize = true;
            lbl_medTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_medTitle.Location = new Point(439, 9);
            lbl_medTitle.Name = "lbl_medTitle";
            lbl_medTitle.Size = new Size(204, 37);
            lbl_medTitle.TabIndex = 7;
            lbl_medTitle.Text = "Medium Games";
            // 
            // lbl_hardTitle
            // 
            lbl_hardTitle.AutoSize = true;
            lbl_hardTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_hardTitle.Location = new Point(808, 9);
            lbl_hardTitle.Name = "lbl_hardTitle";
            lbl_hardTitle.Size = new Size(163, 37);
            lbl_hardTitle.TabIndex = 8;
            lbl_hardTitle.Text = "Hard Games";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 509);
            Controls.Add(lbl_hardTitle);
            Controls.Add(lbl_medTitle);
            Controls.Add(lbl_easyTitle);
            Controls.Add(pictureBox1);
            Controls.Add(btn_test);
            Controls.Add(btn_backtogame);
            Controls.Add(dgv_hard);
            Controls.Add(dgv_mid);
            Controls.Add(dgv_easy);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1100, 556);
            MinimumSize = new Size(1100, 556);
            Name = "Form3";
            Text = "High Scores";
            ((System.ComponentModel.ISupportInitialize)dgv_easy).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_mid).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_hard).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_easy;
        private DataGridView dgv_mid;
        private DataGridView dgv_hard;
        private Button btn_backtogame;
        private Button btn_test;
        private PictureBox pictureBox1;
        private ImageList imageList1;
        private Label lbl_easyTitle;
        private Label lbl_medTitle;
        private Label lbl_hardTitle;
    }
}