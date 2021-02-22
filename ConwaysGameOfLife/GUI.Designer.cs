
namespace ConwaysGameOfLife
{
    partial class GUI
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GunButton = new System.Windows.Forms.Button();
            this.cellSizeButton = new System.Windows.Forms.NumericUpDown();
            this.cellSizeLabel = new System.Windows.Forms.Label();
            this.TimerSpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.TimerSpeedLabel = new System.Windows.Forms.Label();
            this.SpaceshipButton = new System.Windows.Forms.Button();
            this.ComplexRowButton = new System.Windows.Forms.Button();
            this.GliderButton = new System.Windows.Forms.Button();
            this.ManualInputBox = new System.Windows.Forms.TextBox();
            this.RandomButton = new System.Windows.Forms.Button();
            this.WrapCellsCheckbox = new System.Windows.Forms.CheckBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellSizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimerSpeedTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(0, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 390);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeChanged += new System.EventHandler(this.PictureBox1_SizeChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // GunButton
            // 
            this.GunButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GunButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.GunButton.Location = new System.Drawing.Point(713, 9);
            this.GunButton.Name = "GunButton";
            this.GunButton.Size = new System.Drawing.Size(75, 23);
            this.GunButton.TabIndex = 1;
            this.GunButton.Text = "Gun";
            this.GunButton.UseVisualStyleBackColor = true;
            this.GunButton.Click += new System.EventHandler(this.GunButton_Click);
            // 
            // cellSizeButton
            // 
            this.cellSizeButton.Location = new System.Drawing.Point(109, 12);
            this.cellSizeButton.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.cellSizeButton.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cellSizeButton.Name = "cellSizeButton";
            this.cellSizeButton.Size = new System.Drawing.Size(39, 20);
            this.cellSizeButton.TabIndex = 2;
            this.cellSizeButton.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.cellSizeButton.ValueChanged += new System.EventHandler(this.CellSizeButton_ValueChanged);
            // 
            // cellSizeLabel
            // 
            this.cellSizeLabel.AutoSize = true;
            this.cellSizeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellSizeLabel.Location = new System.Drawing.Point(12, 12);
            this.cellSizeLabel.Name = "cellSizeLabel";
            this.cellSizeLabel.Size = new System.Drawing.Size(65, 19);
            this.cellSizeLabel.TabIndex = 3;
            this.cellSizeLabel.Text = "Cell Size";
            // 
            // TimerSpeedTrackBar
            // 
            this.TimerSpeedTrackBar.LargeChange = 1;
            this.TimerSpeedTrackBar.Location = new System.Drawing.Point(109, 33);
            this.TimerSpeedTrackBar.Maximum = 200;
            this.TimerSpeedTrackBar.Minimum = 1;
            this.TimerSpeedTrackBar.Name = "TimerSpeedTrackBar";
            this.TimerSpeedTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TimerSpeedTrackBar.Size = new System.Drawing.Size(190, 45);
            this.TimerSpeedTrackBar.TabIndex = 4;
            this.TimerSpeedTrackBar.Value = 100;
            this.TimerSpeedTrackBar.Scroll += new System.EventHandler(this.TimerSpeedTrackBar_Scroll);
            // 
            // TimerSpeedLabel
            // 
            this.TimerSpeedLabel.AutoSize = true;
            this.TimerSpeedLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.TimerSpeedLabel.Location = new System.Drawing.Point(12, 33);
            this.TimerSpeedLabel.Name = "TimerSpeedLabel";
            this.TimerSpeedLabel.Size = new System.Drawing.Size(94, 19);
            this.TimerSpeedLabel.TabIndex = 5;
            this.TimerSpeedLabel.Text = "Game Speed";
            // 
            // SpaceshipButton
            // 
            this.SpaceshipButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpaceshipButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.SpaceshipButton.Location = new System.Drawing.Point(546, 9);
            this.SpaceshipButton.Name = "SpaceshipButton";
            this.SpaceshipButton.Size = new System.Drawing.Size(75, 23);
            this.SpaceshipButton.TabIndex = 6;
            this.SpaceshipButton.Text = "Spaceship";
            this.SpaceshipButton.UseVisualStyleBackColor = true;
            this.SpaceshipButton.Click += new System.EventHandler(this.SpaceshipButton_Click);
            // 
            // ComplexRowButton
            // 
            this.ComplexRowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComplexRowButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.ComplexRowButton.Location = new System.Drawing.Point(627, 9);
            this.ComplexRowButton.Name = "ComplexRowButton";
            this.ComplexRowButton.Size = new System.Drawing.Size(80, 23);
            this.ComplexRowButton.TabIndex = 7;
            this.ComplexRowButton.Text = "Complex Row";
            this.ComplexRowButton.UseVisualStyleBackColor = true;
            this.ComplexRowButton.Click += new System.EventHandler(this.ComplexRowButton_Click);
            // 
            // GliderButton
            // 
            this.GliderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GliderButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.GliderButton.Location = new System.Drawing.Point(460, 9);
            this.GliderButton.Name = "GliderButton";
            this.GliderButton.Size = new System.Drawing.Size(80, 23);
            this.GliderButton.TabIndex = 8;
            this.GliderButton.Text = "Glider";
            this.GliderButton.UseVisualStyleBackColor = true;
            this.GliderButton.Click += new System.EventHandler(this.GliderButton_Click);
            // 
            // ManualInputBox
            // 
            this.ManualInputBox.AcceptsReturn = true;
            this.ManualInputBox.AllowDrop = true;
            this.ManualInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ManualInputBox.Location = new System.Drawing.Point(374, 35);
            this.ManualInputBox.Multiline = true;
            this.ManualInputBox.Name = "ManualInputBox";
            this.ManualInputBox.Size = new System.Drawing.Size(414, 20);
            this.ManualInputBox.TabIndex = 9;
            this.ManualInputBox.TextChanged += new System.EventHandler(this.ManualInputBox_TextChanged);
            // 
            // RandomButton
            // 
            this.RandomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RandomButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.RandomButton.Location = new System.Drawing.Point(374, 9);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(80, 23);
            this.RandomButton.TabIndex = 11;
            this.RandomButton.Text = "Random";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // WrapCellsCheckbox
            // 
            this.WrapCellsCheckbox.AutoSize = true;
            this.WrapCellsCheckbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.WrapCellsCheckbox.Location = new System.Drawing.Point(154, 12);
            this.WrapCellsCheckbox.Name = "WrapCellsCheckbox";
            this.WrapCellsCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WrapCellsCheckbox.Size = new System.Drawing.Size(100, 23);
            this.WrapCellsCheckbox.TabIndex = 13;
            this.WrapCellsCheckbox.Text = "Wrap Cells";
            this.WrapCellsCheckbox.UseVisualStyleBackColor = true;
            this.WrapCellsCheckbox.CheckedChanged += new System.EventHandler(this.WrapCellsCheckbox_CheckedChanged);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WrapCellsCheckbox);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.ManualInputBox);
            this.Controls.Add(this.GliderButton);
            this.Controls.Add(this.ComplexRowButton);
            this.Controls.Add(this.SpaceshipButton);
            this.Controls.Add(this.TimerSpeedLabel);
            this.Controls.Add(this.TimerSpeedTrackBar);
            this.Controls.Add(this.cellSizeLabel);
            this.Controls.Add(this.cellSizeButton);
            this.Controls.Add(this.GunButton);
            this.Name = "GUI";
            this.Text = "Game of Life";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellSizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimerSpeedTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button GunButton;
        private System.Windows.Forms.NumericUpDown cellSizeButton;
        private System.Windows.Forms.Label cellSizeLabel;
        private System.Windows.Forms.TrackBar TimerSpeedTrackBar;
        private System.Windows.Forms.Label TimerSpeedLabel;
        private System.Windows.Forms.Button SpaceshipButton;
        private System.Windows.Forms.Button ComplexRowButton;
        private System.Windows.Forms.Button GliderButton;
        private System.Windows.Forms.TextBox ManualInputBox;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.CheckBox WrapCellsCheckbox;
        private System.Windows.Forms.Timer timer2;
    }
}

