using NAudio;
using System.Diagnostics;

namespace Audio_Device_Muter
{
    public partial class AudioDeviceMuter : Form
    {
        public NAudio.CoreAudioApi.MMDeviceCollection devices;
        public AudioDeviceMuter()
        {
            InitializeComponent();
        }

        private void MuteDevice(object currentItem, bool showWindow)
        {
            foreach (NAudio.CoreAudioApi.MMDevice dev in devices)
            {
                if (currentItem.ToString() == dev.FriendlyName)
                {
                    var muted = dev.AudioEndpointVolume.Mute;
                    muted = !muted;
                    dev.AudioEndpointVolume.Mute = muted;
                    if (showWindow)
                    {
                        switch (muted)
                        {
                            case true:
                                MessageBox.Show("Muted Device!", "Success!");
                                break;
                            case false:
                                MessageBox.Show("Unmuted Device!", "Success!");
                                break;
                        }
                    }
                }
            }
        }

        private void toggleButton_Click(object sender, EventArgs e)
        {

            //No device selected
            if (deviceSelectBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a device!", "Error");
                return;
            }
            if (deviceSelectBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a device!", "Error");
                return;
            }

            //Write current item to file
            var currentItem = deviceSelectBox1.SelectedItem;

            TextWriter tw = new StreamWriter("audiodevicesave.txt");
            tw.Write(currentItem.ToString());
            tw.Close();
            if (!File.Exists("audiodevicesave.txt"))
            {
                MessageBox.Show("Saving failed.", "Error");
            }

            //Mute currently selected device
            MuteDevice(deviceSelectBox1.SelectedItem, true);
        }
        private void saveButton_Click(object sender, EventArgs e)
        {

        }
        private void AudioDeviceMuter_Load(object sender, EventArgs e)
        {
            NAudio.CoreAudioApi.MMDeviceEnumerator enumerator = new NAudio.CoreAudioApi.MMDeviceEnumerator();
            devices = enumerator.EnumerateAudioEndPoints(NAudio.CoreAudioApi.DataFlow.All, NAudio.CoreAudioApi.DeviceState.Active);
            deviceSelectBox1.Items.AddRange(devices.ToArray());

            if (File.Exists("audiodevicesave.txt"))
            {
                TextReader tr = new StreamReader("audiodevicesave.txt");
                string deviceToToggle = tr.ReadToEnd();
                Debug.WriteLine(deviceToToggle);
                tr.Close();

                MuteDevice(deviceToToggle, false);

                //Check if device should be toggled and which one, then toggle it on startup.
                DialogResult dialog = MessageBox.Show("Saved device muted. \nWould you like to change the saved device?", "Success!", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }
    }
}