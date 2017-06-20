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

namespace Proyecto_Hospital
{
    public partial class Pacto : Form
    {
        
        public Pacto()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void Guardar()
        {
            
            try {
                string query = "";
                string codigostock = "";

                codigostock = Convert.ToString(dgpacto.CurrentRow.Cells["codigo_stock"].Value);
                MessageBox.Show(dtfecha.Text);


                query = @"INSERT INTO pacto_stock
                             (codigopacto,codigo_stock, descripcion, 
                              unidad_medida, pacto_stocks,frecuencia,costo_unitario,costo_total,fecha,sala)
                            VALUES
                             ('{0}','{1}','{2}','{3}',{4},'{5}',{6},{7},'{8}','{9}')";



                query = string.Format(query,
                                        tpacto.Text,
                                        Convert.ToString(dgpacto.CurrentRow.Cells["codigo_stock"].Value),
                                        Convert.ToString(dgpacto.CurrentRow.Cells["descripcion"].Value),
                                        Convert.ToString(dgpacto.CurrentRow.Cells["unidad_medida"].Value),
                                        Convert.ToInt32(dgpacto.CurrentRow.Cells["pacto_stocks"].Value),
                                       Convert.ToString(dgpacto.CurrentRow.Cells["frecuencia"].Value),
                                        Convert.ToInt32(dgpacto.CurrentRow.Cells["costo_unitario"].Value),
                                        Convert.ToInt32(dgpacto.CurrentRow.Cells["costo_total"].Value),
                                                                            dtfecha.Text,
                                        tsala.Text
                                    );






                if (auxiliar.conn.SqlExec(query))
                {
                    MessageBox.Show("Usuario registrado");

                }
                else
                {
                    MessageBox.Show("Error al guardar: " +
                                    auxiliar.conn.SQLError());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar combo de Unidad: " +
                                 ex.ToString());
            }
           

        }
        private void bguardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void CargarUnidades()
        {
            try
            {
                string query = "";
                DataTable dt = null;

                query = @"SELECT
                      idunidad, tipounidad as unidad_medida
                      FROM
                      Unidad";

                if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
                {
                    unidad_medida.DisplayMember = "unidad_medida";
                    unidad_medida.ValueMember = "unidad_medida";
                    unidad_medida.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo de Unidad: " +
                                 ex.ToString());
            }



        }
        private void CargarFrecuencia()
        {
            try
            {
                string query = "";
                DataTable dt = null;

                query = @"SELECT
                      id, nombre as frecuencia
                      FROM
                      Frecuencia";

                if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
                {
                    frecuencia.DisplayMember = "frecuencia";
                    frecuencia.ValueMember = "frecuencia";
                    frecuencia.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo de Frecuencia: " +
                                 ex.ToString());
            }
        }

        private void sumaunidad()
        {
            int costouni = 0;

            for (int i = 0; i < dgpacto.RowCount - 1; i++)
            {
                costouni += Convert.ToInt32(dgpacto[6, i].Value.ToString());
            }
            tcosto.Text = costouni.ToString();
        }

        private void sumatotal()
        {
            int costototal = 0;
            for (int i = 0; i < dgpacto.RowCount - 1; i++)
            {
                costototal += Convert.ToInt32(dgpacto[7, i].Value.ToString());
            }
            ttotal.Text = costototal.ToString();
        }
        private void Pacto_Load(object sender, EventArgs e)
        {
            CargarFrecuencia();
            CargarUnidades();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            sumaunidad();
            sumatotal();
        }
    }
}
