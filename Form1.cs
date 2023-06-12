using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Localization_Programm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            switch (selectedItem)
            {
                case "English":
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-EN");
                    Controls.Clear();
                    this.Text = "English";
                    Image image = Image.FromFile(@"D:\Visual Studio ШАГ\C#\Localization_Programm\Images\USA.png");
                    CountryImage(image);
                    InitializeComponent();
                    break;
                case "日本":
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ja-JA");
                    Controls.Clear();
                    this.Text = "日本";
                    Image image2 = Image.FromFile(@"D:\Visual Studio ШАГ\C#\Localization_Programm\Images\Japan.png");
                    CountryImage(image2);
                    InitializeComponent();
                    break;
                case "Italiano":
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("it-IT");
                    Controls.Clear();
                    this.Text = "Italiano";
                    Image image3 = Image.FromFile(@"D:\Visual Studio ШАГ\C#\Localization_Programm\Images\Italy.png");
                    CountryImage(image3);
                    InitializeComponent();
                    break;
                case "Français":
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("fr-FR");
                    Controls.Clear();
                    this.Text = "Français";
                    Image image4 = Image.FromFile(@"D:\Visual Studio ШАГ\C#\Localization_Programm\Images\France.png");
                    CountryImage(image4);
                    InitializeComponent();
                    break;
            }
        }
        public void CountryImage(Image image)
        {
            this.pictureBox1.BackgroundImage = image;
            this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            this.pictureBox1.Location = new Point(613, 27);
            this.Controls.Add(this.pictureBox1);
        }
    }
}
