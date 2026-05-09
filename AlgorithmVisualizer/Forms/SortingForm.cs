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
            new SettingsForm().Show();
        }
    }
}
