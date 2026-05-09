namespace AlgorithmVisualizer
{
    partial class Sorting_Visualizer
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
            panelBars = new Panel();
            btnStart = new Button();
            btnGenerate = new Button();
            btnReset = new Button();
            btnSettings = new Button();
            lblCompText = new Label();
            lblComparisons = new Label();
            cmbAlgorithm = new ComboBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // panelBars
            // 
            panelBars.BorderStyle = BorderStyle.FixedSingle;
            panelBars.Location = new Point(20, 80);
            panelBars.Name = "panelBars";
            panelBars.Size = new Size(840, 350);
            panelBars.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(200, 470);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 40);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(80, 470);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(100, 40);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(320, 470);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 40);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(760, 20);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(100, 40);
            btnSettings.TabIndex = 4;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // lblCompText
            // 
            lblCompText.AutoSize = true;
            lblCompText.Location = new Point(20, 30);
            lblCompText.Name = "lblCompText";
            lblCompText.Size = new Size(126, 25);
            lblCompText.TabIndex = 5;
            lblCompText.Text = "Comparisons :";
            // 
            // lblComparisons
            // 
            lblComparisons.AutoSize = true;
            lblComparisons.Location = new Point(139, 32);
            lblComparisons.Name = "lblComparisons";
            lblComparisons.Size = new Size(22, 25);
            lblComparisons.TabIndex = 6;
            lblComparisons.Text = "0";
            // 
            // cmbAlgorithm
            // 
            cmbAlgorithm.FormattingEnabled = true;
            cmbAlgorithm.Items.AddRange(new object[] { "Insertion Sort", "Quick Sort" });
            cmbAlgorithm.Location = new Point(600, 470);
            cmbAlgorithm.Name = "cmbAlgorithm";
            cmbAlgorithm.Size = new Size(150, 33);
            cmbAlgorithm.TabIndex = 7;
            cmbAlgorithm.Text = "Algorithm";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(440, 470);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 40);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Sorting_Visualizer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 544);
            Controls.Add(btnBack);
            Controls.Add(cmbAlgorithm);
            Controls.Add(lblComparisons);
            Controls.Add(lblCompText);
            Controls.Add(btnSettings);
            Controls.Add(btnReset);
            Controls.Add(btnGenerate);
            Controls.Add(btnStart);
            Controls.Add(panelBars);
            Name = "Sorting_Visualizer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sorting Visualizer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelBars;
        private Button btnStart;
        private Button btnGenerate;
        private Button btnReset;
        private Button btnSettings;
        private Label lblCompText;
        private Label lblComparisons;
        private ComboBox cmbAlgorithm;
        private Button btnBack;
    }
}