using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Management;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InfOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CPU.Text = ObtainDeviceProperty("Win32_Processor", "name");

            CPUFAMILY.Text = Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER");

            GPU.Text= ObtainDeviceProperty("Win32_VideoController", "name");

            NICS.Text= ObtainDeviceProperty("Win32_NetworkAdapter", "Name");

            TRACKPAD.Text= ObtainDeviceProperty("Win32_PointingDevice", "DeviceID");
            TRACKPAD.Text += ObtainDeviceProperty("Win32_PointingDevice", "Description");

            KEYBOARD.Text = ObtainDeviceProperty("Win32_Keyboard", "DeviceID");
            KEYBOARD.Text += ObtainDeviceProperty("Win32_Keyboard", "Description");
            
            MODEL.Text = ObtainDeviceProperty("Win32_ComputerSystem", "Manufacturer");
            MODEL.Text += ObtainDeviceProperty("Win32_ComputerSystem", "Model");
            MODEL.Text += ObtainDeviceProperty("Win32_ComputerSystem", "SystemType");

            MOBO.Text = ObtainDeviceProperty("Win32_MotherboardDevice", "Name");
            MOBO.Text += ObtainDeviceProperty("Win32_MotherboardDevice", "DeviceID");
            MOBO.Text += ObtainDeviceProperty("Win32_MotherboardDevice", "Description");

            if ( (System.Environment.Is64BitOperatingSystem)== true){
                sixtyfour.Checked = sixtyfour.Enabled = true;
               
            }else
            {
                thirtytwo.Checked = thirtytwo.Enabled = true;
            }
          










        }
        public string ObtainDeviceProperty(string HWDevice, string Property)
        {
            string result = "";
            ManagementObjectSearcher infos = new ManagementObjectSearcher("SELECT * FROM " + HWDevice);
            foreach (ManagementObject prop in infos.Get())
            {
              
               if ((result+=prop[Property].ToString())=="")
                {
                    return "null";
                }
                result += "\t";
            }
            return result;
        }

        private void Salva_Click(object sender, EventArgs e)
        {
            SaveFileDialog savesettings = new SaveFileDialog();
            savesettings.FileName = "MyPCInfos";
            savesettings.DefaultExt = ".txt";
            savesettings.Filter = "Text File (*.txt)|";
            if (savesettings.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(savesettings.FileName,label1.Text + CPU.Text + "\n\n" + label2.Text + GPU.Text + "\n\n" + label3.Text + CPUFAMILY.Text + "\n\n" + label4.Text + NICS.Text + "\n\n" + label5.Text + TRACKPAD.Text + "\n\n" + label6.Text +  KEYBOARD.Text + "\n\n" + label7.Text + MODEL.Text + "\n\n" + label8.Text + MOBO.Text + "\n\n" + "32 Bit:" + thirtytwo.Checked + "\n\n" + "64 Bit:" + sixtyfour.Checked);
            }
        }

        private void HelpButtonEvent(object sender, CancelEventArgs e)
        {
            MessageBox.Show("xReB3L\nGitHub: https://github.com/xReB3L \n Fonts used: Evolution Font by PaulW (https://www.fontspace.com/evolution-font-f9365) \n \"Save\" icon made by xnimrodx from www.flaticon.com", "Credits:");
        }
    }
}
