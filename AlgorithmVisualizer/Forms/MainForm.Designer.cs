namespace AlgorithmVisualizer
{
    partial class MainForm
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
            label1 = new Label();
            btnSorting = new Button();
            btnPathfinding = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 50);
            label1.Name = "label1";
            label1.Size = new Size(368, 48);
            label1.TabIndex = 0;
            label1.Text = "Algorithm Visualizer";
            // 
            // btnSorting
            // 
            btnSorting.BackColor = Color.White;
            btnSorting.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSorting.ForeColor = Color.FromArgb(20, 24, 40);
            btnSorting.Location = new Point(200, 130);
            btnSorting.Name = "btnSorting";
            btnSorting.Size = new Size(200, 50);
            btnSorting.TabIndex = 1;
            btnSorting.Text = "Sorting Visualizer";
            btnSorting.UseVisualStyleBackColor = false;
            btnSorting.Click += btnSorting_Click;
            // 
            // btnPathfinding
            // 
            btnPathfinding.BackColor = Color.White;
            btnPathfinding.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPathfinding.ForeColor = Color.FromArgb(20, 24, 40);
            btnPathfinding.Location = new Point(200, 200);
            btnPathfinding.Name = "btnPathfinding";
            btnPathfinding.Size = new Size(200, 58);
            btnPathfinding.TabIndex = 2;
            btnPathfinding.Text = "Pathfinding Visualizer";
            btnPathfinding.UseVisualStyleBackColor = false;
            btnPathfinding.Click += btnPathfinding_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 24, 40);
            ClientSize = new Size(578, 344);
            Controls.Add(btnPathfinding);
            Controls.Add(btnSorting);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSorting;
        private Button btnPathfinding;
    }
}