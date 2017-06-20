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
    public partial class Mostrar_Reposicion_Stock : Form
    {
        public Mostrar_Reposicion_Stock()
        {
            InitializeComponent();
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

        private void CargarCodigoPacto()
        {
            string query = @"SELECT
                             codigopacto
                             FROM
                             pacto_stock
                             ORDER BY codigopacto";

            DataTable dt = null;

            if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
            {
                cmbCodigoPacto.DisplayMember = "codigopacto";
                cmbCodigoPacto.ValueMember = "codigopacto";
                cmbCodigoPacto.DataSource = dt;
            }
        }

        private void mostrar()
        {
            try
            {
                string query = "";
                DataTable dt = null;

                query = @"SELECT 
                       codigo_stock,descripcion,unidad_de_medida,pacto_stock,frecuencia,
                       costo_unitario,costo_total,fecha,existencia,entregada,pendiente
                      FROM
                      reposicion_stock
                     ";

                if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
                {
                    dtgReposicion.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Mostrar: " +
                                 ex.ToString());
            }
        }

        private void Mostrar_Reposicion_Stock_Load(object sender, EventArgs e)
        {
            CargarUnidades();
            CargarFrecuencia();
            CargarCodigoPacto();
            mostrar();
        }

        private void BuscarFecha()
        {
            try
            {
                string query = "";
                DataTable dt = null;

                query = @"SELECT 
                      codigo_stock,descripcion,unidad_de_medida,pacto_stock,frecuencia,
                       costo_unitario,costo_total,fecha,existencia,entregada,pendiente
                      FROM
                      reposicion_stock
                      where
                      fecha = '{0}'
                     ";
                query = string.Format(query, dtpfecha.Text);
                if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
                {
                    dtgReposicion.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Mostrar: " +
                                 ex.ToString());
            }
        }

        private void BuscarCodigoPacto()
        {
            try
            {
                string query = "";
                DataTable dt = null;

                query = @"SELECT 
                      codigo_stock,descripcion,unidad_de_medida,pacto_stock,frecuencia,
                       costo_unitario,costo_total,fecha,existencia,entregada,pendiente
                      FROM
                      reposicion_stock
                      where
                      codigopacto = '{0}'
                     ";
                query = string.Format(query, cmbCodigoPacto.Text);
                if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
                {
                    dtgReposicion.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Mostrar: " +
                                 ex.ToString());
            }
        }

        private void BuscarFechaYCodigoPacto()
        {
            try
            {
                string query = "";
                DataTable dt = null;

                query = @"SELECT 
                      codigo_stock,descripcion,unidad_de_medida,pacto_stock,frecuencia,
                       costo_unitario,costo_total,fecha,existencia,entregada,pendiente
                      FROM
                      reposicion_stock
                      where
                      fecha = '{0}' and
                      codigopacto = '{1}'
                     ";
                query = string.Format(query, dtpfecha.Text, cmbCodigoPacto.Text);
                if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
                {
                    dtgReposicion.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Mostrar: " +
                                 ex.ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbFecha.Checked && !cbCodigoPacto.Checked)
            {
                BuscarFecha();
            }

            if (!cbFecha.Checked && cbCodigoPacto.Checked)
            {
                BuscarCodigoPacto();
            }

            if (cbFecha.Checked && cbCodigoPacto.Checked)
            {
                BuscarFechaYCodigoPacto();
            }

            if (!cbFecha.Checked && !cbCodigoPacto.Checked)
            {
                mostrar();
            }
        }
    }
}


