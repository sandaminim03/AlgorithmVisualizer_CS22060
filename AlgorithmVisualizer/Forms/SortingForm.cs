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
        private int[]? data;
        private Random random = new Random();
        private int comparisons = 0;
        private int currentComparingIdx = -1;
        private int currentSwappingIdx = -1;
        private bool isSorted = false;

        private InsertionSort _insertionSort = new InsertionSort();
        private QuickSort _quickSort = new QuickSort();

        public Sorting_Visualizer()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            // Enable double buffering on the panel to prevent flickering
            var type = panelBars.GetType();
            var pi = type.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            pi?.SetValue(panelBars, true, null);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            data = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                // Scale height to fit the panel
                data[i] = random.Next(10, panelBars.Height - 20);
            }

            comparisons = 0;
            isSorted = false;
            currentComparingIdx = -1;
            currentSwappingIdx = -1;

            UpdateComparisonLabel();
            panelBars.Invalidate();
            SetControlsEnabled(true);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (data == null) btnGenerate_Click(sender, e);
            if (cmbAlgorithm.SelectedItem == null)
            {
                MessageBox.Show("Please select an algorithm from the dropdown!");
                return;
            }

            SetControlsEnabled(false);
            isSorted = false;
            comparisons = 0;

            string selected = cmbAlgorithm.SelectedItem.ToString()!;

            // Initialize the chosen algorithm
            if (selected == "Insertion Sort")
            {
                _insertionSort.Initialize(data!);
            }
            else if (selected == "Quick Sort")
            {
                _quickSort.Initialize(data!, 0, data!.Length - 1);
            }

            // Map speed: higher speed value = lower interval
            timer1.Interval = Math.Max(1, 101 - animationSpeed);
            timer1.Start();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            timer1.Stop();
            this.Close();
        }


        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (var settings = new SettingsForm(animationSpeed, arraySize))
            {
                if (settings.ShowDialog() == DialogResult.OK)
                {
                    this.animationSpeed = settings.SelectedSpeed;
                    this.arraySize = settings.SelectedSize;
                    btnGenerate_Click(sender, e); // Re-generate with new size
                }
            }
        }


        private void panelBars_Paint(object sender, PaintEventArgs e)
        {
            if (data == null) return;

            Graphics g = e.Graphics;
            // Calculate bar width based on panel size and array length
            float barWidth = (float)panelBars.Width / data.Length;

            for (int i = 0; i < data.Length; i++)
            {
                Brush brush = Brushes.SkyBlue; // Default color

                if (isSorted) brush = Brushes.LimeGreen; // Sorted state
                else if (i == currentComparingIdx) brush = Brushes.Red; // Comparing state
                else if (i == currentSwappingIdx) brush = Brushes.Gold; // Swapping state

                float x = i * barWidth;
                float height = data[i];
                float y = panelBars.Height - height;

                g.FillRectangle(brush, x, y, barWidth - 1, height);
            }
        }
        private void UpdateComparisonLabel()
        {
            lblComparisons.Text = $"{comparisons}";
        }

        private void SetControlsEnabled(bool enabled)
        {
            btnStart.Enabled = enabled;
            btnGenerate.Enabled = enabled;
            btnReset.Enabled = enabled;
            btnSettings.Enabled = enabled;
            btnBack.Enabled = enabled;
            cmbAlgorithm.Enabled = enabled;
        }


        private void Sorting_Visualizer_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool finished = false;
            string selected = cmbAlgorithm.SelectedItem.ToString()!;

            // Execute one step of the algorithm
            if (selected == "Insertion Sort")
            {
                finished = _insertionSort.Step((idx1, idx2, isSwap) =>
                {
                    currentComparingIdx = idx1;
                    currentSwappingIdx = isSwap ? idx2 : -1;
                    comparisons++;
                });
            }
            else if (selected == "Quick Sort")
            {
                finished = _quickSort.Step((idx1, idx2, isSwap) =>
                {
                    currentComparingIdx = idx1;
                    currentSwappingIdx = isSwap ? idx2 : -1;
                    comparisons++;
                });
            }

            UpdateComparisonLabel();
            panelBars.Invalidate(); // Redraw the bars

            if (finished)
            {
                timer1.Stop();
                isSorted = true;
                currentComparingIdx = -1;
                currentSwappingIdx = -1;
                panelBars.Invalidate();
                SetControlsEnabled(true);
                MessageBox.Show("Sorting Complete!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnGenerate_Click(sender, e);
        }
    }
}
