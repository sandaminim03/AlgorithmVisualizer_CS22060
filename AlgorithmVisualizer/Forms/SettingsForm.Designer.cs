namespace AlgorithmVisualizer
{
    partial class SettingsForm
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
            lblSize = new Label();
            lblSpeed = new Label();
            numSize = new NumericUpDown();
            numSpeed = new NumericUpDown();
            btnOK = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSpeed).BeginInit();
            SuspendLayout();
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(50, 50);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(47, 25);
            lblSize.TabIndex = 0;
            lblSize.Text = "Size:";
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Location = new Point(50, 100);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(66, 25);
            lblSpeed.TabIndex = 1;
            lblSpeed.Text = "Speed:";
            // 
            // numSize
            // 
            numSize.Location = new Point(150, 50);
            numSize.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numSize.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numSize.Name = "numSize";
            numSize.Size = new Size(120, 31);
            numSize.TabIndex = 2;
            numSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numSpeed
            // 
            numSpeed.Location = new Point(150, 100);
            numSpeed.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSpeed.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numSpeed.Name = "numSpeed";
            numSpeed.Size = new Size(120, 31);
            numSpeed.TabIndex = 3;
            numSpeed.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnOK
            // 
            btnOK.Location = new Point(80, 180);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(100, 40);
            btnOK.TabIndex = 4;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(200, 180);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 244);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(numSpeed);
            Controls.Add(numSize);
            Controls.Add(lblSpeed);
            Controls.Add(lblSize);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)numSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSpeed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSize;
        private Label lblSpeed;
        private NumericUpDown numSize;
        private NumericUpDown numSpeed;
        private Button btnOK;
        private Button btnCancel;
    }
}