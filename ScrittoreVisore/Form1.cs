using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ScrittoreVisore
{
    public partial class Form1 : Form
    {
        private Visualizzatore vis;
        private Scrittore scr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scr = new Scrittore(vis);

            richTextBox2.ReadOnly = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "" && colorDialog1.Color != Color.Empty)
            {
                scr.Nome = textBox1.Text;
                scr.Testo = textBox2.Text;

                FontStyle f;
                Font font = richTextBox2.SelectionFont;
                if (font != null)
                {
                    f = font.Style;
                    if (comboBox1.Text == "Grassetto")
                        f ^= FontStyle.Bold;
                    else if (comboBox1.Text == "Corsivo")
                        f ^= FontStyle.Italic;
                    else if (comboBox1.Text == "Sottolineato")
                        f ^= FontStyle.Underline;
                    else if (comboBox1.Text == "Default")
                        f ^= FontStyle.Regular;

                    richTextBox2.SelectionFont = new Font(font, f);

                    richTextBox2.SelectionColor = colorDialog1.Color;

                    richTextBox2.AppendText(scr.Nome + ": " + scr.Testo + "\n");
                }

                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
                colorDialog1.Color = Color.Empty;
            }
            else
                MessageBox.Show("Inserire tutti i Valori");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }
    }
}
