using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEUTEC;
using Proyecto_Hospital;

namespace Proyecto_Hospital
{
    public partial class Login : Form
    {
        
        public int p_id_usuario = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void ValidarUsuario()
        {
            DataRow dr = null;

            string query = @"SELECT * FROM usuarios
                            WHERE
                            nombre_usuario= '"+ txtusuario.Text + "' and password='" + txtpassword.Text + "'";

            if (auxiliar.conn.SQLSelectDataRow(query, ref dr))
            {
                string usuario= dr["nombre_usuario"].ToString();
                string contra= dr["password"].ToString();

                if(usuario==txtusuario.Text && contra==txtpassword.Text)
                {
                    MessageBox.Show("Bienvenido al sistema de inventario");
                    frmMenu.validacion = true;
                    
                }
                else
                {
                    MessageBox.Show("Error al Conectarse");
                }

            }
           // this.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ValidarUsuario();
            this.Close();
            
        }
    }
}
