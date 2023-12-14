using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX5WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            Conversor c;
            c = new Conversor();
            c.Setcd(double.Parse(txtCotacao.Text));
            c.SetDigitar(double.Parse(txtReais.Text));
            txtR.Text = c.ConverterParaReais().ToString();
        }
    }
}
