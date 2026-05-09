using AlgorithmVisualizer.Algorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


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

                // Apply changes later
                // Example:
                // Recreate grid with new size
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
           
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
           
        }
        private void panelBars_Paint(object sender, PaintEventArgs e)
        {


            
        }
       

        private void Sorting_Visualizer_Load(object sender, EventArgs e)
        {
            
        }
    }
}
