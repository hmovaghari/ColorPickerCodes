using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPickerCodes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Set GroupBox BackColor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_Click(object sender, EventArgs e)
        {
            colorPicker();
        }

        private void colorPicker()
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                listBox1.BackColor = colorDialog1.Color;
            }
        }




        /// <summary>
        /// Convert Color to Code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowCode_Click(object sender, EventArgs e)
        {
            if (cmbMode.SelectedIndex != -1)
            {
                switch (cmbMode.SelectedIndex)
                {
                    case 0:
                        //Hex
                        HexConverter(listBox1.BackColor);
                        break;
                    case 1:
                        //RGB
                        RGBConverter(listBox1.BackColor);
                        break;
                }
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }

        private void RGBConverter(Color Color)
        {
            try
            {
                txtCode.Text = "RGB(" + Color.R.ToString() + "," + Color.G.ToString() + "," + Color.B.ToString() + ")";
            }
            catch (Exception ex)
            {
                SystemSounds.Beep.Play();
            }
        }

        private void HexConverter(Color Color)
        {
            try
            {
                txtCode.Text = "#" + Color.R.ToString("X2") + Color.G.ToString("X2") + Color.B.ToString("X2");
            }
            catch (Exception ex)
            {
                SystemSounds.Beep.Play();
            }
        }

        /// <summary>
        /// Convert Code to Color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowColor_Click(object sender, EventArgs e)
        {
            if (cmbMode.SelectedIndex != -1)
            {
                switch (cmbMode.SelectedIndex)
                {
                    case 0:
                        //Hex
                        GetColorFromHex(txtCode.Text);
                        break;
                    case 1:
                        //RGB
                        GetColorFromRGB(txtCode.Text);
                        break;
                }
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }

        private void GetColorFromRGB(string Code)
        {
            try
            {
                string[] RGB = Code.Split(',');
                RGB[0] = RGB[0].Replace("RGB(", null);
                RGB[2] = RGB[2].Replace(")", null);
                listBox1.BackColor = Color.FromArgb(Convert.ToInt32(RGB[0]), Convert.ToInt32(RGB[1]),
                    Convert.ToInt32(RGB[2]));
            }
            catch (Exception)
            {
                SystemSounds.Beep.Play();
            }
        }

        private void GetColorFromHex(string Code)
        {
            try
            {
                listBox1.BackColor = ColorTranslator.FromHtml(Code);
            }
            catch (Exception)
            {
                SystemSounds.Beep.Play();
            }
        }
    }
}
