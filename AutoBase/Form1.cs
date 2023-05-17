using Microsoft.VisualBasic.Logging;
using System.DirectoryServices.ActiveDirectory;
using System.Runtime.Intrinsics.Arm;
using System;
using System.Security.Cryptography;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Drawing;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Auto> autos;
        private bool brandOK, modelOK, VINOK, numOK, colorOK;
        private readonly string[][] models = new string[][]
        {
            new string[] { "Golf", "Polo", "Passat", "Tiguan" },
            new string[] { "Buick", "GMC", "Cadillac", "Holden" },
            new string[] { "Lexus", "Scion", "Daihatsu", "Hino" },
            new string[] { "Fiesta", "Focus", "Mustang", "Escape", "Explorer" },
            new string[] { "3 Series", "5 Series", "X3", "X5", "7 Series" },
            new string[] { "C-Class", "E-Class", "S-Class", "GLC", "GLE" },
            new string[] { "Chrysler", "Jeep", "Dodge", "Ram" },
            new string[] { "Acura", "Civic", "Accord", "CR-V" },
            new string[] { "Kia", "Genesis", "Mobis", "Namyang" },
            new string[] { "Infiniti", "Datsun", "NISMO", "Venucia" },
            new string[] { "WRX", "Forester", "Outback", "Impreza" },
            new string[] { "CX-5", "Mazda3", "Mazda6", "MX-5" },
            new string[] { "Polestar", "XC90", "S60", "V60" },
            new string[] { "Land Rover", "Range Rover", "Discovery", "F-Pace" },
            new string[] { "A4", "A6", "Q5", "Q7" },
            new string[] { "911", "Cayenne", "Macan", "Panamera" },
            new string[] { "Octavia", "Superb", "Fabia", "Kodiaq" },
            new string[] { "Leon", "Ibiza", "Ateca", "Arona" }
        };
        public Form1()
        {
            InitializeComponent();
            autos = new();
            yearNumericUpDown.Maximum = DateTime.Now.Year;
            AutosUpdate();
        }

        private void autoCreateButton(object sender, EventArgs e)
        {
            autos.Add(new(brandCombotBox.Text, modelComboBox.Text, colorComboBox.Text, vNumberTextBox.Text, cNumberTextBox.Text, (int)yearNumericUpDown.Value));
            brandOK = modelOK = VINOK = numOK = colorOK = false;
            vNumberTextBox.Text = string.Empty;
            modelComboBox.Text = string.Empty;
            brandCombotBox.Text = string.Empty;
            cNumberTextBox.Text = string.Empty;
            colorComboBox.Text = string.Empty;
            yearNumericUpDown.Value = yearNumericUpDown.Minimum;
            autoCreate.Enabled = false;
            AutosUpdate();
        }

        private void AutosUpdate()
        {
            // var autoArray = autos.ToArray();                            //  При такій 
            autosComboBox.DataSource = autos.ToArray(); //  = autoArray;  //  комбінації
            autosComboBox.SelectedIndex = -1;                             //  кнопка "Знайти"
            findComboBox.DataSource = autos.ToArray();  //  = autoArray;  //  не потрібна (?) елемент обраний в findComboBox автоматично обирається в autosComboBox
            findComboBox.Text = string.Empty;
            autosComboBox.Enabled = autoDelete.Enabled = showAuto.Enabled = findButton.Enabled = findComboBox.Enabled = autos.Count != 0;
        }

        private void deleteAutoButton(object sender, EventArgs e)
        {
            if (autosComboBox.SelectedIndex < 0) return;
            autos.RemoveAt(autosComboBox.SelectedIndex);
            AutosUpdate();
        }

        private void showAutoButton(object sender, EventArgs e)
        {
            if (autosComboBox.SelectedIndex < 0) return;
            Auto tmp = autos.ElementAt(autosComboBox.SelectedIndex);
            MessageBox.Show(tmp.GetInfo(), "Інформація по автомобілю");
        }


        private void brandChanged(object sender, EventArgs e)
        {
            if (brandCombotBox.SelectedIndex >= 0)
            {
                modelComboBox.DataSource = models[brandCombotBox.SelectedIndex];
                brandOK = true;
            }
            else
            {
                brandOK = !string.IsNullOrEmpty(brandCombotBox.Text);
                modelComboBox.DataSource = models.SelectMany(n => n.Select(s => s)).ToArray();
            }
            modelComboBox.Text = string.Empty;
            CAButtonEnable();
        }

        private void CAButtonEnable() => autoCreate.Enabled = brandOK && modelOK && VINOK && numOK && colorOK;

        private void modelChanged(object sender, EventArgs e)
        {
            modelOK = modelComboBox.SelectedIndex >= 0 || !string.IsNullOrEmpty(modelComboBox.Text);
            CAButtonEnable();
        }

        private void colorChanged(object sender, EventArgs e)
        {
            colorOK = colorComboBox.SelectedIndex >= 0 || !string.IsNullOrEmpty(colorComboBox.Text);
            CAButtonEnable();
        }

        private void cNumberLeave(object sender, EventArgs e)
        {
            if (autos.FirstOrDefault(n => n.CNumber == cNumberTextBox.Text) != null || !cNumberTextBox.MaskCompleted)
                cNumberTextBox.Text = string.Empty;
            numOK = cNumberTextBox.MaskCompleted;
            CAButtonEnable();
        }

        private void vNumberLeave(object sender, EventArgs e)
        {
            if (autos.FirstOrDefault(n => n.VinNumber == vNumberTextBox.Text) != null || !vNumberTextBox.MaskCompleted)
                vNumberTextBox.Text = string.Empty;
            VINOK = vNumberTextBox.MaskCompleted;
            CAButtonEnable();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            int index = findComboBox.SelectedIndex;
            if (index >= 0) autosComboBox.SelectedIndex = index;
            findComboBox.Text = string.Empty;
        }
    }
}