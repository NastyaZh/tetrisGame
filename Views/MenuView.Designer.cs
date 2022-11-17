namespace tetrisGame.Views
{
    partial class MenuView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuView));
            this.ExitButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SettngHeightLabel = new System.Windows.Forms.Label();
            this.SettingWidthLabel = new System.Windows.Forms.Label();
            this.SettingMainLabel = new System.Windows.Forms.Label();
            this.WidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(112, 319);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(266, 52);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayButton.Location = new System.Drawing.Point(112, 115);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(266, 52);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateButton.Location = new System.Drawing.Point(112, 213);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(266, 52);
            this.CreateButton.TabIndex = 2;
            this.CreateButton.Text = "create new blocks";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // SettngHeightLabel
            // 
            this.SettngHeightLabel.AutoSize = true;
            this.SettngHeightLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettngHeightLabel.Location = new System.Drawing.Point(244, 50);
            this.SettngHeightLabel.Name = "SettngHeightLabel";
            this.SettngHeightLabel.Size = new System.Drawing.Size(79, 26);
            this.SettngHeightLabel.TabIndex = 19;
            this.SettngHeightLabel.Text = "height:";
            // 
            // SettingWidthLabel
            // 
            this.SettingWidthLabel.AutoSize = true;
            this.SettingWidthLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingWidthLabel.Location = new System.Drawing.Point(76, 51);
            this.SettingWidthLabel.Name = "SettingWidthLabel";
            this.SettingWidthLabel.Size = new System.Drawing.Size(72, 26);
            this.SettingWidthLabel.TabIndex = 18;
            this.SettingWidthLabel.Text = "width:";
            // 
            // SettingMainLabel
            // 
            this.SettingMainLabel.AutoSize = true;
            this.SettingMainLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingMainLabel.Location = new System.Drawing.Point(150, 9);
            this.SettingMainLabel.Name = "SettingMainLabel";
            this.SettingMainLabel.Size = new System.Drawing.Size(197, 26);
            this.SettingMainLabel.TabIndex = 17;
            this.SettingMainLabel.Text = "Playing board sizes";
            // 
            // WidthNumericUpDown
            // 
            this.WidthNumericUpDown.Location = new System.Drawing.Point(154, 57);
            this.WidthNumericUpDown.Name = "WidthNumericUpDown";
            this.WidthNumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.WidthNumericUpDown.TabIndex = 22;
            // 
            // HeightNumericUpDown
            // 
            this.HeightNumericUpDown.Location = new System.Drawing.Point(329, 58);
            this.HeightNumericUpDown.Name = "HeightNumericUpDown";
            this.HeightNumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.HeightNumericUpDown.TabIndex = 23;
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(512, 433);
            this.ControlBox = false;
            this.Controls.Add(this.HeightNumericUpDown);
            this.Controls.Add(this.WidthNumericUpDown);
            this.Controls.Add(this.SettngHeightLabel);
            this.Controls.Add(this.SettingWidthLabel);
            this.Controls.Add(this.SettingMainLabel);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.ExitButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetris";
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label SettngHeightLabel;
        private System.Windows.Forms.Label SettingWidthLabel;
        private System.Windows.Forms.Label SettingMainLabel;
        private System.Windows.Forms.NumericUpDown WidthNumericUpDown;
        private System.Windows.Forms.NumericUpDown HeightNumericUpDown;
    }
}

