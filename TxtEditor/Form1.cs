using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TxtEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.openFileDialog.Title = "Выберите текстовый файл";
            this.openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";

            this.saveFileDialog.Title = "Выберите место и имя для сохранения текстового файла";
            this.saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";

            this.textBox1.Enabled = false;
            this.menuStrip1.Items[1].Enabled = false;

            this.textBox1.ScrollBars = ScrollBars.Vertical; // добалвение прокрутки для textBox
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                switch (form2.pressedButton)
                {
                    case 0: this.OpenFile(); break;
                    case 1: this.CreateFile(); break;
                }
            }    
        }

        private void OpenFile()
        {
            try
            {
                if (this.openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = this.openFileDialog.FileName;

                    using (StreamReader streamReader = new StreamReader(selectedFilePath))
                    {
                        while (!streamReader.EndOfStream)
                        {
                            this.textBox1.AppendText(streamReader.ReadLine() + Environment.NewLine);
                        }
                    }

                    this.textBox1.Text = "";
                    this.textBox1.Enabled = true;
                    this.menuStrip1.Items[1].Enabled = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Произошла ошибка при чтении файла!\n{e.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateFile()
        {
            this.textBox1.Text = "";
            this.textBox1.Enabled = true;
            this.menuStrip1.Items[1].Enabled = true;
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = this.saveFileDialog.FileName;

                    using (StreamWriter streamWriter = new StreamWriter(selectedFilePath))
                    {
                        foreach (string str in this.textBox1.Lines)
                        {
                            streamWriter.WriteLine(str);
                        }
                    }

                    this.textBox1.Enabled = true;
                    this.menuStrip1.Items[1].Enabled = true;
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show($"Произошла ошибка при сохранении файла!\n{e1.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
