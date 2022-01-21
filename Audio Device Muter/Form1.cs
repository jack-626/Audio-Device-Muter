using NAudio;

namespace Line_In_Disabler
{
    public partial class Form1 : Form
    {
        public NAudio.CoreAudioApi.MMDeviceCollection devices;
        public Form1()
        {
            InitializeComponent();
            NAudio.CoreAudioApi.MMDeviceEnumerator enumerator = new NAudio.CoreAudioApi.MMDeviceEnumerator();
            devices = enumerator.EnumerateAudioEndPoints(NAudio.CoreAudioApi.DataFlow.All, NAudio.CoreAudioApi.DeviceState.Active);
            comboBox1.Items.AddRange(devices.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a device!", "Error");
                return;
            }

            var currentItem = comboBox1.SelectedItem;

            foreach (NAudio.CoreAudioApi.MMDevice dev in devices)
            {
                //System.Diagnostics.Debug.Print(dev.FriendlyName);
                if(currentItem.ToString() == dev.FriendlyName)
                {
                    //dev.AudioEndpointVolume.Mute = true;
                    var muted = dev.AudioEndpointVolume.Mute;
                    muted = !muted;
                    dev.AudioEndpointVolume.Mute = muted;
                    if(muted == true)
                    {
                        MessageBox.Show("Muted Device!");
                    } else if (muted == false)
                    {
                        MessageBox.Show("Unmuted Device!");
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}