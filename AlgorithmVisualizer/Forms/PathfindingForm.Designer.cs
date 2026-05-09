namespace AlgorithmVisualizer
{
    partial class Pathfinding_Visualizer
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
            panelGrid = new Panel();
            btnSettings = new Button();
            btnStart = new Button();
            btnClear = new Button();
            rbStart = new RadioButton();
            rbEnd = new RadioButton();
            rbWall = new RadioButton();
            grpMode = new GroupBox();
            btnback = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            grpMode.SuspendLayout();
            SuspendLayout();
            // 
            // panelGrid
            // 
            panelGrid.BorderStyle = BorderStyle.FixedSingle;
            panelGrid.Location = new Point(20, 100);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(840, 350);
            panelGrid.TabIndex = 0;
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(760, 20);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(100, 40);
            btnSettings.TabIndex = 1;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += button1_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(80, 470);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 40);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(200, 470);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 40);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // rbStart
            // 
            rbStart.AutoSize = true;
            rbStart.Location = new Point(7, 31);
            rbStart.Name = "rbStart";
            rbStart.Size = new Size(79, 29);
            rbStart.TabIndex = 4;
            rbStart.TabStop = true;
            rbStart.Text = "Start";
            rbStart.UseVisualStyleBackColor = true;
            // 
            // rbEnd
            // 
            rbEnd.AutoSize = true;
            rbEnd.Location = new Point(120, 31);
            rbEnd.Name = "rbEnd";
            rbEnd.Size = new Size(69, 29);
            rbEnd.TabIndex = 5;
            rbEnd.TabStop = true;
            rbEnd.Text = "End";
            rbEnd.UseVisualStyleBackColor = true;
            // 
            // rbWall
            // 
            rbWall.AutoSize = true;
            rbWall.Location = new Point(224, 31);
            rbWall.Name = "rbWall";
            rbWall.Size = new Size(74, 29);
            rbWall.TabIndex = 6;
            rbWall.TabStop = true;
            rbWall.Text = "Wall";
            rbWall.UseVisualStyleBackColor = true;
            // 
            // grpMode
            // 
            grpMode.Controls.Add(rbStart);
            grpMode.Controls.Add(rbWall);
            grpMode.Controls.Add(rbEnd);
            grpMode.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpMode.Location = new Point(20, 27);
            grpMode.Name = "grpMode";
            grpMode.Size = new Size(300, 70);
            grpMode.TabIndex = 7;
            grpMode.TabStop = false;
            grpMode.Text = "Mode Selection";
            // 
            // btnback
            // 
            btnback.Location = new Point(320, 470);
            btnback.Name = "btnback";
            btnback.Size = new Size(100, 40);
            btnback.TabIndex = 8;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // Pathfinding_Visualizer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 544);
            Controls.Add(btnback);
            Controls.Add(grpMode);
            Controls.Add(btnClear);
            Controls.Add(btnStart);
            Controls.Add(btnSettings);
            Controls.Add(panelGrid);
            Name = "Pathfinding_Visualizer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pathfinding Visualizer";
            grpMode.ResumeLayout(false);
            grpMode.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGrid;
        private Button btnSettings;
        private Button btnStart;
        private Button btnClear;
        private RadioButton rbStart;
        private RadioButton rbEnd;
        private RadioButton rbWall;
        private GroupBox grpMode;
        private Button btnback;
        private System.Windows.Forms.Timer timer1;
    }
}