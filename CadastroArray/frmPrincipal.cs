using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroArray
{
    public partial class frmPrincipal : Form
    {
        public struct Usuario
        {
            public int codigo;
            public string nome;
            public string nivel;
            public string login;
            public string senha;
        }
        public struct Cliente
        {
            public int codigo;
            public string nome;
            public int telefone;
            public string email;
            public int cpf;
        }
        //array vetor declarado

        static public Usuario[] usuarios = new Usuario[10];
        static public int cadusu = 0;

        //cadastrando cliente

        static public Cliente[] clientes = new Cliente[10];
        static public int cadcli = 0;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario fu = new frmUsuario();
            fu.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente fc = new frmCliente();
            fc.Show();
        }

        private void pdpCliente_Load(object sender, EventArgs e)
        {

        }

        private void pdRelUsuario_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int X = 0;
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "Relatorio de usuarios" + (char)10 + (char)10;
            strDados += "codigo nome                                          nivel login" + (char)10;
            strDados += "-------------------------------------------------------" + (char)10;
            while (X < cadusu)
            {
                strDados += usuarios[X].codigo.ToString("000000") + " " + usuarios[X].nome.PadRight(40) + "   " +
                    usuarios[X].nivel + "   " + usuarios[X].login + (char)10;
                X++;
            }

            objImpressao.DrawString(strDados, new System.Drawing.Font("Courier New", 10, FontStyle.Regular), Brushes.Black, 50, 50);
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pdpUsuario.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdpUsuario.Show();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pdpCliente.Show();
        }
    }
}
