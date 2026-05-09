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
        public Pathfinding_Visualizer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SettingsForm().Show();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
        }
    }
}
