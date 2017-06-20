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
    public partial class Eliminar_Pacto : Form
    {
        public Eliminar_Pacto()
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

        private void CargarSala()
        {
            string query = @"SELECT
                             sala
                             FROM
                             pacto_stock
                             ORDER BY sala";

            DataTable dt = null;

            if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
            {
                cmbSala.DisplayMember = "sala";
                cmbSala.ValueMember = "sala";
                cmbSala.DataSource = dt;
            }
        }

        private void mostrar()
        {
            try
            {
                string query = "";
                DataTable dt = null;

                query = @"SELECT 
                      codigo_stock,descripcion,unidad_medida,pacto_stocks
                       ,frecuencia,costo_unitario,costo_total,fecha,codigopacto,sala
                      FROM
                      pacto_stock
                     ";

                if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
                {
                    dgpacto.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Mostrar: " +
                                 ex.ToString());
            }
        }

        private void Eliminar_Pacto_Load(object sender, EventArgs e)
        {
            CargarFrecuencia();
            CargarUnidades();
            CargarCodigoPacto();
            CargarSala();
            mostrar();
        }

        private void BuscarFecha()
        {
            try
            {
                string query = "";
                DataTable dt = null;

                query = @"SELECT 
                      codigo_stock,descripcion,unidad_medida,pacto_stocks
                       ,frecuencia,costo_unitario,costo_total,fecha,codigopacto,sala
                      FROM
                      pacto_stock
                      where
                      fecha = '{0}'
                     ";
                query = string.Format(query, dtpfecha.Text);
                if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
                {
                    dgpacto.DataSource = dt;
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
                      codigo_stock,descripcion,unidad_medida,pacto_stocks
                       ,frecuencia,costo_unitario,costo_total,fecha,codigopacto,sala
                      FROM
                      pacto_stock
                      where
                      codigopacto = '{0}'
                     ";
                query = string.Format(query, cmbCodigoPacto.Text);
                if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
                {
                    dgpacto.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Mostrar: " +
                                 ex.ToString());
            }
        }

        private void BuscarSala()
        {
            try
            {
                string query = "";
                DataTable dt = null;

                query = @"SELECT 
                      codigo_stock,descripcion,unidad_medida,pacto_stocks
                       ,frecuencia,costo_unitario,costo_total,fecha,codigopacto,sala
                      FROM
                      pacto_stock
                      where
                      sala = '{0}'
                     ";
                query = string.Format(query, cmbSala.Text);
                if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
                {
                    dgpacto.DataSource = dt;
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
                      codigo_stock,descripcion,unidad_medida,pacto_stocks
                       ,frecuencia,costo_unitario,costo_total,fecha,codigopacto,sala
                      FROM
                      pacto_stock
                      where
                      fecha = '{0}' and
                      codigopacto = '{1}'
                     ";
                query = string.Format(query, dtpfecha.Text, cmbCodigoPacto.Text);
                if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
                {
                    dgpacto.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Mostrar: " +
                                 ex.ToString());
            }
        }

        private void BuscarFechaYSala()
        {
            try
            {
                string query = "";
                DataTable dt = null;

                query = @"SELECT 
                      codigo_stock,descripcion,unidad_medida,pacto_stocks
                       ,frecuencia,costo_unitario,costo_total,fecha,codigopacto,sala
                      FROM
                      pacto_stock
                      where
                      fecha = '{0}' and
                      sala = '{1}'
                     ";
                query = string.Format(query, dtpfecha.Text, cmbSala.Text);
                if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
                {
                    dgpacto.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Mostrar: " +
                                 ex.ToString());
            }
        }

        private void BuscarCodigoPactoYSala()
        {
            try
            {
                string query = "";
                DataTable dt = null;

                query = @"SELECT 
                      codigo_stock,descripcion,unidad_medida,pacto_stocks
                       ,frecuencia,costo_unitario,costo_total,fecha,codigopacto,sala
                      FROM
                      pacto_stock
                      where
                      codigopacto = '{0}' and
                      sala = '{1}'
                     ";
                query = string.Format(query, cmbCodigoPacto.Text, cmbSala.Text);
                if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
                {
                    dgpacto.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Mostrar: " +
                                 ex.ToString());
            }
        }

        private void BuscarFechayCodigoPactoYSala()
        {
            try
            {
                string query = "";
                DataTable dt = null;

                query = @"SELECT 
                      codigo_stock,descripcion,unidad_medida,pacto_stocks
                       ,frecuencia,costo_unitario,costo_total,fecha,codigopacto,sala
                      FROM
                      pacto_stock
                      where
                      fecha = '{0}' and
                      codigopacto = '{1}' and
                      sala = '{2}'
                      
                     ";
                query = string.Format(query, dtpfecha.Text, cmbCodigoPacto.Text, cmbSala.Text);
                if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
                {
                    dgpacto.DataSource = dt;
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
            if (cbFecha.Checked && !cbCodigoPacto.Checked && !cbSala.Checked)
            {
                BuscarFecha();
            }

            if (!cbFecha.Checked && cbCodigoPacto.Checked && !cbSala.Checked)
            {
                BuscarCodigoPacto();
            }

            if (!cbFecha.Checked && !cbCodigoPacto.Checked && cbSala.Checked)
            {
                BuscarSala();
            }

            if (cbFecha.Checked && cbCodigoPacto.Checked && !cbSala.Checked)
            {
                BuscarFechaYCodigoPacto();
            }

            if (cbFecha.Checked && !cbCodigoPacto.Checked && cbSala.Checked)
            {
                BuscarFechaYSala();
            }

            if (!cbFecha.Checked && cbCodigoPacto.Checked && cbSala.Checked)
            {
                BuscarCodigoPactoYSala();
            }

            if (cbFecha.Checked && cbCodigoPacto.Checked && cbSala.Checked)
            {
                BuscarFechayCodigoPactoYSala();
            }

            if (!cbFecha.Checked && !cbCodigoPacto.Checked && !cbSala.Checked)
            {
                CargarFrecuencia();
                CargarUnidades();
                mostrar();
            }
        }

        private void EliminarPorFecha()
        {

            string query = "";

            query = @"DELETE FROM pacto_stock
                                  WHERE
                                  fecha ='{0}'";



            query = string.Format(query, dtpfecha.Text);

            // MessageBox.Show(query);

            if (auxiliar.conn.SqlExec(query))
            {
                MessageBox.Show("Eliminado");
            }
            else
            {
                MessageBox.Show("Error al eliminar: " +
                                auxiliar.conn.SQLError());
            }
        }

        private void EliminarPorCodigoPacto()
        {

            string query = "";

            query = @"DELETE FROM pacto_stock
                                  WHERE
                                  codigopacto ='{0}'";



            query = string.Format(query, cmbCodigoPacto.Text);

            // MessageBox.Show(query);

            if (auxiliar.conn.SqlExec(query))
            {
                MessageBox.Show("Eliminado");
            }
            else
            {
                MessageBox.Show("Error al eliminar: " +
                                auxiliar.conn.SQLError());
            }
        }

        private void EliminarPorSala()
        {

            string query = "";

            query = @"DELETE FROM pacto_stock
                                  WHERE
                                  sala ='{0}'";



            query = string.Format(query, cmbSala.Text);

            // MessageBox.Show(query);

            if (auxiliar.conn.SqlExec(query))
            {
                MessageBox.Show("Eliminado");
            }
            else
            {
                MessageBox.Show("Error al eliminar: " +
                                auxiliar.conn.SQLError());
            }
        }

        private void EliminarPorFechaYCodigoPacto()
        {

            string query = "";

            query = @"DELETE FROM pacto_stock
                                  WHERE
                                  fecha = '{0}' and
                                  codigopacto = '{1}'";



            query = string.Format(query, dtpfecha.Text, cmbCodigoPacto.Text);

            // MessageBox.Show(query);

            if (auxiliar.conn.SqlExec(query))
            {
                MessageBox.Show("Eliminado");
            }
            else
            {
                MessageBox.Show("Error al eliminar: " +
                                auxiliar.conn.SQLError());
            }
        }

        private void EliminarPorFechaYSala()
        {

            string query = "";

            query = @"DELETE FROM pacto_stock
                                  WHERE
                                  fecha = '{0}' and
                                  sala = '{1}'";



            query = string.Format(query, dtpfecha.Text, cmbSala.Text);

            // MessageBox.Show(query);

            if (auxiliar.conn.SqlExec(query))
            {
                MessageBox.Show("Eliminado");
            }
            else
            {
                MessageBox.Show("Error al eliminar: " +
                                auxiliar.conn.SQLError());
            }
        }

        private void EliminarPorCodigoPactoYSala()
        {

            string query = "";

            query = @"DELETE FROM pacto_stock
                                  WHERE
                                  codigopacto = '{0}' and
                                  sala = '{1}'";



            query = string.Format(query, cmbCodigoPacto.Text, cmbSala.Text);

            // MessageBox.Show(query);

            if (auxiliar.conn.SqlExec(query))
            {
                MessageBox.Show("Eliminado");
            }
            else
            {
                MessageBox.Show("Error al eliminar: " +
                                auxiliar.conn.SQLError());
            }
        }

        private void EliminarPorFechaYCodigoPactoYSala()
        {

            string query = "";

            query = @"DELETE FROM pacto_stock
                                  WHERE
                                  fecha = '{0}' and
                                  codigopacto = '{1}' and
                                  sala = '{2}'";
            query = string.Format(query, dtpfecha.Text, cmbCodigoPacto.Text, cmbSala.Text);

            // MessageBox.Show(query);

            if (auxiliar.conn.SqlExec(query))
            {
                MessageBox.Show("Eliminado");
            }
            else
            {
                MessageBox.Show("Error al eliminar: " +
                                auxiliar.conn.SQLError());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbFecha.Checked && !cbCodigoPacto.Checked && !cbSala.Checked)
            {
                EliminarPorFecha();
            }

            if (!cbFecha.Checked && cbCodigoPacto.Checked && !cbSala.Checked)
            {
                EliminarPorCodigoPacto();
            }

            if (!cbFecha.Checked && !cbCodigoPacto.Checked && cbSala.Checked)
            {
                EliminarPorSala();
            }

            if (cbFecha.Checked && cbCodigoPacto.Checked && !cbSala.Checked)
            {
                EliminarPorFechaYCodigoPacto();
            }

            if (cbFecha.Checked && !cbCodigoPacto.Checked && cbSala.Checked)
            {
                EliminarPorFechaYSala();
            }
            if (!cbFecha.Checked && cbCodigoPacto.Checked && cbSala.Checked)
            {
                EliminarPorCodigoPactoYSala();
            }

            if (cbFecha.Checked && cbCodigoPacto.Checked && cbSala.Checked)
            {
                EliminarPorFechaYCodigoPactoYSala();
            }
            CargarCodigoPacto();
            CargarSala();
            CargarFrecuencia();
            CargarUnidades();
            mostrar();
        }
    }
}

    

