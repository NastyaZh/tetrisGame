namespace tetrisGame.Views
{
    partial class GameView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameView));
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.QueuePictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SettngHeightLabel = new System.Windows.Forms.Label();
            this.SettingWidthLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueuePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Location = new System.Drawing.Point(12, 12);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(340, 440);
            this.MainPictureBox.TabIndex = 0;
            this.MainPictureBox.TabStop = false;
            this.MainPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPictureBox_Paint);
            // 
            // QueuePictureBox
            // 
            this.QueuePictureBox.Location = new System.Drawing.Point(385, 183);
            this.QueuePictureBox.Name = "QueuePictureBox";
            this.QueuePictureBox.Size = new System.Drawing.Size(243, 266);
            this.QueuePictureBox.TabIndex = 1;
            this.QueuePictureBox.TabStop = false;
            this.QueuePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.NextPictureBox_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(380, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "left key : Move LEFT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(380, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "right key : Move RIGHT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(380, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "ESC : EXIT";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // SettngHeightLabel
            // 
            this.SettngHeightLabel.AutoSize = true;
            this.SettngHeightLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettngHeightLabel.Location = new System.Drawing.Point(556, 154);
            this.SettngHeightLabel.Name = "SettngHeightLabel";
            this.SettngHeightLabel.Size = new System.Drawing.Size(36, 26);
            this.SettngHeightLabel.TabIndex = 11;
            this.SettngHeightLabel.Text = "20";
            this.SettngHeightLabel.Visible = false;
            // 
            // SettingWidthLabel
            // 
            this.SettingWidthLabel.AutoSize = true;
            this.SettingWidthLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingWidthLabel.Location = new System.Drawing.Point(514, 154);
            this.SettingWidthLabel.Name = "SettingWidthLabel";
            this.SettingWidthLabel.Size = new System.Drawing.Size(36, 26);
            this.SettingWidthLabel.TabIndex = 10;
            this.SettingWidthLabel.Text = "15";
            this.SettingWidthLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(380, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "down key : Move DOWN";
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(654, 474);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SettngHeightLabel);
            this.Controls.Add(this.SettingWidthLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QueuePictureBox);
            this.Controls.Add(this.MainPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.GameView_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameView_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameView_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueuePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.PictureBox QueuePictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer gameTimer;
        public System.Windows.Forms.Label SettngHeightLabel;
        public System.Windows.Forms.Label SettingWidthLabel;
        private System.Windows.Forms.Label label4;
    }
}