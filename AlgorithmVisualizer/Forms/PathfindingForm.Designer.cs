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
            btnback = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // panelGrid
            // 
            panelGrid.BorderStyle = BorderStyle.FixedSingle;
            panelGrid.Location = new Point(20, 25);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(560, 560);
            panelGrid.TabIndex = 0;
            panelGrid.Paint += panelGrid_Paint;
            panelGrid.MouseClick += panelGrid_MouseClick;
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(690, 400);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(100, 40);
            btnSettings.TabIndex = 1;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += button1_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(690, 160);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 40);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(690, 240);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 40);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnback
            // 
            btnback.Location = new Point(690, 320);
            btnback.Name = "btnback";
            btnback.Size = new Size(100, 40);
            btnback.TabIndex = 8;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(609, 70);
            label1.Name = "label1";
            label1.Size = new Size(277, 25);
            label1.TabIndex = 9;
            label1.Text = "Select start,End nodes on the grid";
            label1.Click += label1_Click;
            // 
            // Pathfinding_Visualizer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(label1);
            Controls.Add(btnback);
            Controls.Add(btnClear);
            Controls.Add(btnStart);
            Controls.Add(btnSettings);
            Controls.Add(panelGrid);
            Name = "Pathfinding_Visualizer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pathfinding Visualizer";
            Load += Pathfinding_Visualizer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelGrid;
        private Button btnSettings;
        private Button btnStart;
        private Button btnClear;
        private Button btnback;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}