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

        private void toggleButton_Click(object sender, EventArgs e)
        {
            if (deviceSelectBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a device!", "Error");
                return;
            }

            var currentItem = deviceSelectBox1.SelectedItem;

            foreach (NAudio.CoreAudioApi.MMDevice dev in devices)
            {
                if (currentItem.ToString() == dev.FriendlyName)
                {
                    var muted = dev.AudioEndpointVolume.Mute;
                    muted = !muted;
                    dev.AudioEndpointVolume.Mute = muted;
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
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (deviceSelectBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a device!", "Error");
                return;
            }

            var currentItem = deviceSelectBox2.SelectedItem;

            TextWriter tw = new StreamWriter("audiodevicesave.txt");
            tw.Write(currentItem.ToString());
            tw.Close();
            if (File.Exists("audiodevicesave.txt"))
            {
                MessageBox.Show("Saved Successfully!", "Success!");
            }
        }
        private void AudioDeviceMuter_Load(object sender, EventArgs e)
        {
            NAudio.CoreAudioApi.MMDeviceEnumerator enumerator = new NAudio.CoreAudioApi.MMDeviceEnumerator();
            devices = enumerator.EnumerateAudioEndPoints(NAudio.CoreAudioApi.DataFlow.All, NAudio.CoreAudioApi.DeviceState.Active);
            deviceSelectBox1.Items.AddRange(devices.ToArray());
            deviceSelectBox2.Items.AddRange(devices.ToArray());

            //Check if device should be toggled and which one, then toggle it on startup.
            if (File.Exists("audiodevicesave.txt"))
            {
                TextReader tr = new StreamReader("audiodevicesave.txt");
                string deviceToToggle = tr.ReadToEnd();
                Debug.WriteLine(deviceToToggle);
                tr.Close();

                foreach (NAudio.CoreAudioApi.MMDevice device in devices)
                {
                    if (device.FriendlyName == deviceToToggle)
                    {
                        var muted = device.AudioEndpointVolume.Mute;
                        muted = !muted;
                        device.AudioEndpointVolume.Mute = muted;
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
    }
}