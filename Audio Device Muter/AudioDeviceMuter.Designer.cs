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
            this.deviceSelectBox1 = new System.Windows.Forms.ComboBox();
            this.toggleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deviceSelectBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // deviceSelectBox1
            // 
            this.deviceSelectBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceSelectBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deviceSelectBox1.FormattingEnabled = true;
            this.deviceSelectBox1.Location = new System.Drawing.Point(12, 26);
            this.deviceSelectBox1.Name = "deviceSelectBox1";
            this.deviceSelectBox1.Size = new System.Drawing.Size(291, 22);
            this.deviceSelectBox1.TabIndex = 0;
            // 
            // toggleButton
            // 
            this.toggleButton.Location = new System.Drawing.Point(309, 19);
            this.toggleButton.Name = "toggleButton";
            this.toggleButton.Size = new System.Drawing.Size(97, 34);
            this.toggleButton.TabIndex = 1;
            this.toggleButton.Text = "Toggle Mute";
            this.toggleButton.UseVisualStyleBackColor = true;
            this.toggleButton.Click += new System.EventHandler(this.toggleButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a Device";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(309, 61);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(97, 34);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select a device to toggle on startup";
            // 
            // deviceSelectBox2
            // 
            this.deviceSelectBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceSelectBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deviceSelectBox2.FormattingEnabled = true;
            this.deviceSelectBox2.Location = new System.Drawing.Point(12, 68);
            this.deviceSelectBox2.Name = "deviceSelectBox2";
            this.deviceSelectBox2.Size = new System.Drawing.Size(291, 22);
            this.deviceSelectBox2.TabIndex = 5;
            // 
            // AudioDeviceMuter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 106);
            this.Controls.Add(this.deviceSelectBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toggleButton);
            this.Controls.Add(this.deviceSelectBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AudioDeviceMuter";
            this.Text = "Audio Device Muter";
            this.Load += new System.EventHandler(this.AudioDeviceMuter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox deviceSelectBox1;
        private Button toggleButton;
        private Label label1;
        private Button saveButton;
        private Label label2;
        private ComboBox deviceSelectBox2;
    }
}