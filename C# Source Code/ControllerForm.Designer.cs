namespace ArduinoController
{
    partial class ControllerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LedFrequencyLabel = new System.Windows.Forms.Label();
            this.LedFrequencyValue = new System.Windows.Forms.Label();
            this.LedFrequencyLabelTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.LedFrequencyLabelTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // LedFrequencyLabel
            // 
            this.LedFrequencyLabel.AutoSize = true;
            this.LedFrequencyLabel.Location = new System.Drawing.Point(14, 36);
            this.LedFrequencyLabel.Name = "LedFrequencyLabel";
            this.LedFrequencyLabel.Size = new System.Drawing.Size(81, 13);
            this.LedFrequencyLabel.TabIndex = 2;
            this.LedFrequencyLabel.Text = "Pattern Number";
            // 
            // LedFrequencyValue
            // 
            this.LedFrequencyValue.AutoSize = true;
            this.LedFrequencyValue.Location = new System.Drawing.Point(304, 38);
            this.LedFrequencyValue.Name = "LedFrequencyValue";
            this.LedFrequencyValue.Size = new System.Drawing.Size(13, 13);
            this.LedFrequencyValue.TabIndex = 3;
            this.LedFrequencyValue.Text = "0";
            // 
            // LedFrequencyLabelTrackBar
            // 
            this.LedFrequencyLabelTrackBar.LargeChange = 1;
            this.LedFrequencyLabelTrackBar.Location = new System.Drawing.Point(90, 35);
            this.LedFrequencyLabelTrackBar.Maximum = 5;
            this.LedFrequencyLabelTrackBar.Name = "LedFrequencyLabelTrackBar";
            this.LedFrequencyLabelTrackBar.Size = new System.Drawing.Size(208, 45);
            this.LedFrequencyLabelTrackBar.TabIndex = 1;
            this.LedFrequencyLabelTrackBar.Tag = "";
            this.LedFrequencyLabelTrackBar.TickFrequency = 10;
            this.LedFrequencyLabelTrackBar.Scroll += new System.EventHandler(this.LedFrequencyTrackBarScroll);
            this.LedFrequencyLabelTrackBar.ValueChanged += new System.EventHandler(this.LedFrequencyLabelTrackBarValueChanged);
            // 
            // ControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 85);
            this.Controls.Add(this.LedFrequencyValue);
            this.Controls.Add(this.LedFrequencyLabel);
            this.Controls.Add(this.LedFrequencyLabelTrackBar);
            this.Name = "ControllerForm";
            this.Text = "Arduino Controller";
            ((System.ComponentModel.ISupportInitialize)(this.LedFrequencyLabelTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LedFrequencyLabel;
        private System.Windows.Forms.Label LedFrequencyValue;
        private System.Windows.Forms.TrackBar LedFrequencyLabelTrackBar;
    }
}

