using AlgorithmVisualizer.Algorithms.AlgorithmVisualizer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlgorithmVisualizer
{
    public partial class Pathfinding_Visualizer : Form
    {
        int gridSize = 20;
        int animationSpeed = 100;
       
        public Pathfinding_Visualizer()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm(gridSize, animationSpeed);

            if (form.ShowDialog() == DialogResult.OK)
            {
                gridSize = form.SelectedSize;
                animationSpeed = form.SelectedSpeed;

                // Apply changes later
                // Example:
                // Recreate grid with new size
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }
    }
}
