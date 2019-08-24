using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Security;

namespace WindowsAppCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtPalavraSecreta.Text = "";
            txtEntrada.Text = "";
            txtResultado.Text = "";
        }

        private void btEncripta_Click(object sender, EventArgs e)
        {
            DTICrypto myCrypto = new DTICrypto();
            txtResultado.Text = myCrypto.Cifrar(txtEntrada.Text, txtPalavraSecreta.Text);
        }

        private void btDecripta_Click(object sender, EventArgs e)
        {
            DTICrypto myCrypto = new DTICrypto();
            txtResultado.Text = myCrypto.Decifrar(txtEntrada.Text, txtPalavraSecreta.Text);
        }
    }
}