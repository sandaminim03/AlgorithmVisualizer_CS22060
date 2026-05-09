using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlgorithmVisualizer
{
    public partial class Sorting_Visualizer : Form
    {
        int arraySize = 50;
        int animationSpeed = 100;
        public Sorting_Visualizer()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm(arraySize, animationSpeed);

            if (form.ShowDialog() == DialogResult.OK)
            {
                arraySize = form.SelectedSize;
                animationSpeed = form.SelectedSpeed;

                // Apply changes
                // Example (later):
                // timer.Interval = animationSpeed;
                // GenerateArray(arraySize);
            }
        }
    }
}
