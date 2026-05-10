using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlgorithmVisualizer
{
    public partial class SettingsForm : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedSize { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedSpeed { get; set; }

        public SettingsForm(int size, int speed)
        {
            InitializeComponent();

            numSize.Value = size;
            numSpeed.Value = speed;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void numSize_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedSize = (int)numSize.Value;
            SelectedSpeed = (int)numSpeed.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void numSize_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
