using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TxtEditor
{
    public partial class Form2 : Form
    {
        public byte pressedButton { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            this.pressedButton = 0;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCreateFile_Click(object sender, EventArgs e)
        {
            this.pressedButton = 1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
