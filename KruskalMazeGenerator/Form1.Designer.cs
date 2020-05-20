namespace MazeGenerator
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mazeAppearanceSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLineColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLineWidthMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi6 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi7 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi8 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi9 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi10 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnSaveAsAscii = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.chooseCellSize = new System.Windows.Forms.NumericUpDown();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.chooseHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.chooseWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mazePic = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chooseCellSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazePic)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mazeAppearanceSettings});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1340, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mazeAppearanceSettings
            // 
            this.mazeAppearanceSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLineColor,
            this.tsmiLineWidthMenu});
            this.mazeAppearanceSettings.Name = "mazeAppearanceSettings";
            this.mazeAppearanceSettings.Size = new System.Drawing.Size(125, 24);
            this.mazeAppearanceSettings.Text = "Налаштування";
            // 
            // tsmiLineColor
            // 
            this.tsmiLineColor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tsmiLineColor.Name = "tsmiLineColor";
            this.tsmiLineColor.Size = new System.Drawing.Size(188, 26);
            this.tsmiLineColor.Text = "Колір лінії";
            this.tsmiLineColor.Click += new System.EventHandler(this.tsmiLineColor_Click);
            // 
            // tsmiLineWidthMenu
            // 
            this.tsmiLineWidthMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tsmiLineWidthMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi1,
            this.tsmi2,
            this.tsmi3,
            this.tsmi4,
            this.tsmi5,
            this.tsmi6,
            this.tsmi7,
            this.tsmi8,
            this.tsmi9,
            this.tsmi10});
            this.tsmiLineWidthMenu.Name = "tsmiLineWidthMenu";
            this.tsmiLineWidthMenu.Size = new System.Drawing.Size(188, 26);
            this.tsmiLineWidthMenu.Text = "Товщина лінії";
            // 
            // tsmi1
            // 
            this.tsmi1.Checked = true;
            this.tsmi1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmi1.Name = "tsmi1";
            this.tsmi1.Size = new System.Drawing.Size(108, 26);
            this.tsmi1.Text = "1";
            this.tsmi1.Click += new System.EventHandler(this.tsmiLineWidthMenu_Click);
            // 
            // tsmi2
            // 
            this.tsmi2.Name = "tsmi2";
            this.tsmi2.Size = new System.Drawing.Size(108, 26);
            this.tsmi2.Text = "2";
            this.tsmi2.Click += new System.EventHandler(this.tsmiLineWidthMenu_Click);
            // 
            // tsmi3
            // 
            this.tsmi3.Name = "tsmi3";
            this.tsmi3.Size = new System.Drawing.Size(108, 26);
            this.tsmi3.Text = "3";
            this.tsmi3.Click += new System.EventHandler(this.tsmiLineWidthMenu_Click);
            // 
            // tsmi4
            // 
            this.tsmi4.Name = "tsmi4";
            this.tsmi4.Size = new System.Drawing.Size(108, 26);
            this.tsmi4.Text = "4";
            this.tsmi4.Click += new System.EventHandler(this.tsmiLineWidthMenu_Click);
            // 
            // tsmi5
            // 
            this.tsmi5.Name = "tsmi5";
            this.tsmi5.Size = new System.Drawing.Size(108, 26);
            this.tsmi5.Text = "5";
            this.tsmi5.Click += new System.EventHandler(this.tsmiLineWidthMenu_Click);
            // 
            // tsmi6
            // 
            this.tsmi6.Name = "tsmi6";
            this.tsmi6.Size = new System.Drawing.Size(108, 26);
            this.tsmi6.Text = "6";
            this.tsmi6.Click += new System.EventHandler(this.tsmiLineWidthMenu_Click);
            // 
            // tsmi7
            // 
            this.tsmi7.Name = "tsmi7";
            this.tsmi7.Size = new System.Drawing.Size(108, 26);
            this.tsmi7.Text = "7";
            this.tsmi7.Click += new System.EventHandler(this.tsmiLineWidthMenu_Click);
            // 
            // tsmi8
            // 
            this.tsmi8.Name = "tsmi8";
            this.tsmi8.Size = new System.Drawing.Size(108, 26);
            this.tsmi8.Text = "8";
            this.tsmi8.Click += new System.EventHandler(this.tsmiLineWidthMenu_Click);
            // 
            // tsmi9
            // 
            this.tsmi9.Name = "tsmi9";
            this.tsmi9.Size = new System.Drawing.Size(108, 26);
            this.tsmi9.Text = "9";
            this.tsmi9.Click += new System.EventHandler(this.tsmiLineWidthMenu_Click);
            // 
            // tsmi10
            // 
            this.tsmi10.Name = "tsmi10";
            this.tsmi10.Size = new System.Drawing.Size(108, 26);
            this.tsmi10.Text = "10";
            this.tsmi10.Click += new System.EventHandler(this.tsmiLineWidthMenu_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContent.Controls.Add(this.btnSaveAsAscii);
            this.pnlContent.Controls.Add(this.label5);
            this.pnlContent.Controls.Add(this.chooseCellSize);
            this.pnlContent.Controls.Add(this.buttonCreate);
            this.pnlContent.Controls.Add(this.chooseHeight);
            this.pnlContent.Controls.Add(this.label3);
            this.pnlContent.Controls.Add(this.chooseWidth);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.pictureBox2);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.mazePic);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 28);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pnlContent.Size = new System.Drawing.Size(1340, 792);
            this.pnlContent.TabIndex = 1;
            // 
            // btnSaveAsAscii
            // 
            this.btnSaveAsAscii.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveAsAscii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAsAscii.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.btnSaveAsAscii.Location = new System.Drawing.Point(1068, 103);
            this.btnSaveAsAscii.Name = "btnSaveAsAscii";
            this.btnSaveAsAscii.Size = new System.Drawing.Size(308, 43);
            this.btnSaveAsAscii.TabIndex = 22;
            this.btnSaveAsAscii.Text = "Зберегти у .txt";
            this.btnSaveAsAscii.UseVisualStyleBackColor = false;
            this.btnSaveAsAscii.Click += new System.EventHandler(this.saveAsAscii_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(851, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Розмір клітинки";
            // 
            // chooseCellSize
            // 
            this.chooseCellSize.BackColor = System.Drawing.Color.White;
            this.chooseCellSize.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.chooseCellSize.Location = new System.Drawing.Point(855, 89);
            this.chooseCellSize.Margin = new System.Windows.Forms.Padding(4);
            this.chooseCellSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.chooseCellSize.Name = "chooseCellSize";
            this.chooseCellSize.Size = new System.Drawing.Size(151, 28);
            this.chooseCellSize.TabIndex = 14;
            this.chooseCellSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chooseCellSize.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.Transparent;
            this.buttonCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreate.ForeColor = System.Drawing.Color.Black;
            this.buttonCreate.Location = new System.Drawing.Point(1068, 20);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(308, 43);
            this.buttonCreate.TabIndex = 16;
            this.buttonCreate.Text = "Створити лабіринт";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // chooseHeight
            // 
            this.chooseHeight.BackColor = System.Drawing.Color.White;
            this.chooseHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chooseHeight.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.chooseHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.chooseHeight.Location = new System.Drawing.Point(651, 89);
            this.chooseHeight.Margin = new System.Windows.Forms.Padding(4);
            this.chooseHeight.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.chooseHeight.Name = "chooseHeight";
            this.chooseHeight.Size = new System.Drawing.Size(151, 28);
            this.chooseHeight.TabIndex = 14;
            this.chooseHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chooseHeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(420, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ширина лабіринту";
            // 
            // chooseWidth
            // 
            this.chooseWidth.BackColor = System.Drawing.Color.White;
            this.chooseWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chooseWidth.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.chooseWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.chooseWidth.Location = new System.Drawing.Point(445, 89);
            this.chooseWidth.Margin = new System.Windows.Forms.Padding(4);
            this.chooseWidth.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.chooseWidth.Name = "chooseWidth";
            this.chooseWidth.Size = new System.Drawing.Size(151, 28);
            this.chooseWidth.TabIndex = 12;
            this.chooseWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chooseWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(638, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Висота лабіринту";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MazeGenerator.Properties.Resources.icon;
            this.pictureBox2.Location = new System.Drawing.Point(11, 19);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(108, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Генератор лабіринтів";
            // 
            // mazePic
            // 
            this.mazePic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mazePic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.mazePic.Location = new System.Drawing.Point(274, 180);
            this.mazePic.Margin = new System.Windows.Forms.Padding(4);
            this.mazePic.Name = "mazePic";
            this.mazePic.Padding = new System.Windows.Forms.Padding(4);
            this.mazePic.Size = new System.Drawing.Size(900, 602);
            this.mazePic.TabIndex = 10;
            this.mazePic.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1340, 820);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генератор лабіринтів";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chooseCellSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.NumericUpDown chooseHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown chooseWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox mazePic;
        private System.Windows.Forms.ToolStripMenuItem mazeAppearanceSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiLineColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiLineWidthMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmi1;
        private System.Windows.Forms.ToolStripMenuItem tsmi2;
        private System.Windows.Forms.ToolStripMenuItem tsmi3;
        private System.Windows.Forms.ToolStripMenuItem tsmi4;
        private System.Windows.Forms.ToolStripMenuItem tsmi5;
        private System.Windows.Forms.ToolStripMenuItem tsmi6;
        private System.Windows.Forms.ToolStripMenuItem tsmi7;
        private System.Windows.Forms.ToolStripMenuItem tsmi8;
        private System.Windows.Forms.ToolStripMenuItem tsmi9;
        private System.Windows.Forms.ToolStripMenuItem tsmi10;
        private System.Windows.Forms.NumericUpDown chooseCellSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveAsAscii;
    }
}


