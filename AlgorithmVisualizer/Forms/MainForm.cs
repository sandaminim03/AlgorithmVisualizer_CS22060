using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlgorithmVisualizer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSorting_Click(object sender, EventArgs e)
        {
            new Sorting_Visualizer().Show();
            this.Hide();
        }

        private void btnPathfinding_Click(object sender, EventArgs e)
        {
            new Pathfinding_Visualizer().Show();
            this.Hide();
        }
    }
}
