namespace Audio_Device_Muter
{
    partial class AudioDeviceMuter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AudioDeviceMuter));
            deviceSelectBox1 = new ComboBox();
            toggleButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // deviceSelectBox1
            // 
            deviceSelectBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            deviceSelectBox1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            deviceSelectBox1.FormattingEnabled = true;
            deviceSelectBox1.Location = new Point(12, 26);
            deviceSelectBox1.Name = "deviceSelectBox1";
            deviceSelectBox1.Size = new Size(291, 22);
            deviceSelectBox1.TabIndex = 0;
            // 
            // toggleButton
            // 
            toggleButton.Location = new Point(309, 19);
            toggleButton.Name = "toggleButton";
            toggleButton.Size = new Size(150, 34);
            toggleButton.TabIndex = 1;
            toggleButton.Text = "Save & Toggle Mute";
            toggleButton.UseMnemonic = false;
            toggleButton.UseVisualStyleBackColor = true;
            toggleButton.Click += toggleButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 14);
            label1.TabIndex = 2;
            label1.Text = "Select a Device";
            // 
            // AudioDeviceMuter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 68);
            Controls.Add(label1);
            Controls.Add(toggleButton);
            Controls.Add(deviceSelectBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AudioDeviceMuter";
            Text = "Audio Device Muter";
            Load += AudioDeviceMuter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox deviceSelectBox1;
        private Button toggleButton;
        private Label label1;
    }
}