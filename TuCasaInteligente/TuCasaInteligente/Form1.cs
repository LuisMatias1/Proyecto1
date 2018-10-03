using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuCasaInteligente
{
    public partial class Form1 : Form
    {
        Cliente chuy = new Cliente("Luis",01111993,"mathh@Casa.com","ingeniero",0123456789,12345678,10293,"calle 124 colonia c","matt","123");
        Cliente math = new Cliente("Jesus", 19761992, "chuy@Casa.com", "ingeniero", 0123456789, 76945678, 10298, "calle cos colonia a", "chuy", "123");
        Cliente pp = new Cliente("Jose", 98121993, "pp@Casa.com", "ingeniero", 0123456789, 12345876, 13465, "calle sin colonia z", "pp", "123");
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txbContraseña.Visible = true;
            txbUsuario.Visible = true;
            lbContraseña.Visible = true;
            lbUsuario.Visible = true;
            llbOlvido.Visible = true;
            button3.Visible = true;
        }

        private void llbOlvido_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Ya valio");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro miRegistro = new Registro();
            miRegistro.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (txbUsuario.Text==math.Usuario && txbContraseña.Text==math.Contraseña)
            {
                Controlador miControlador = new Controlador();
                miControlador.Show();
            }
            else if(txbUsuario.Text == chuy.Usuario && txbContraseña.Text == chuy.Contraseña)
            {
                Controlador miControlador = new Controlador();
                miControlador.Show();
            }
            else if (txbUsuario.Text == pp.Usuario && txbContraseña.Text == pp.Contraseña)
            {
                Controlador miControlador = new Controlador();
                miControlador.Show();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }
        }
    }
}
