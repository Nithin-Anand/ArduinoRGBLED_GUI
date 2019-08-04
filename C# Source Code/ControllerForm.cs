using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArduinoController
{
    public partial class ControllerForm : Form
    {
        private readonly ArduinoController _arduinoController;
        private double _ledFrequency;

        public ControllerForm()
        {
            InitializeComponent();
            _arduinoController = new ArduinoController();
            _arduinoController.Setup(this);
        }

        // Update arduinoController on value checkbox checked/unchecked


        // Update value label and arduinoController on value changed using slider
        private void LedFrequencyTrackBarScroll(object sender, EventArgs e)
        {
            _ledFrequency = 1 + ((double)LedFrequencyLabelTrackBar.Value) ;
            LedFrequencyValue.Text = _ledFrequency.ToString(CultureInfo.InvariantCulture);
            _arduinoController.SetLedFrequency(_ledFrequency);
        }

        // Set ledState checkbox
        public void SetLedState(bool ledState)
        {
        }

        // Set frequency slider
        public void SetFrequency(double ledFrequency)
        {
            LedFrequencyLabelTrackBar.Value = (int) ((ledFrequency));
        }

        // Update value label and arduinoController on value changed
        private void LedFrequencyLabelTrackBarValueChanged(object sender, EventArgs e)
        {
            LedFrequencyTrackBarScroll(sender,e);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing )
            {
                _arduinoController.Exit();
                if (components!=null)
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
