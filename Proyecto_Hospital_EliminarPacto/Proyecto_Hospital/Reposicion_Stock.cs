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
    public partial class Reposicion_Stock : Form
    {
        public ConexionSQL conn;
        public Reposicion_Stock()
        {
            InitializeComponent();
        }

        private void frmReposion_Stock_Load(object sender, EventArgs e)
        {
            //Mostrar();
            CargarFrecuencia();
            CargarUnidades();
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
                      Unidad
                      ";

                if (conn.SQLSelectDataTable(query, ref dt))
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

                if (conn.SQLSelectDataTable(query, ref dt))
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

        private void Mostrar()
        {
            try
            {
                string query = "";
                DataTable dt = null;
                // where codigo_stock='"+ p_id_celda + "'"
                query = @"SELECT 
                      codigo_stock,descripcion,unidad_medida,pacto_stocks
                       ,frecuencia,costo_unitario,costo_total
                      FROM
                      pacto_stock 
                   ";

                if (conn.SQLSelectDataTable(query, ref dt))
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
        private void btnmostrar_Click(object sender, EventArgs e)
        {
            //CargarFrecuencia();
            // CargarUnidades();
            Mostrar();
        }
        private void buscar()

        {
            DataTable dt = null;

            string query = @"SELECT 
                      codigo_stock,descripcion,unidad_medida,pacto_stocks
                       ,frecuencia,costo_unitario,costo_total
                      FROM
                      pacto_stock 
                      WHERE codigopacto= '" + txtCodigo.Text + "'";


            if (conn.SQLSelectDataTable(query, ref dt))
            {
                dtgReposicion.DataSource = dt;

            }
            //else
            //{
            //  MessageBox.Show("error " + conn.SQLError());

            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            // Mostrar();
            // CargarFrecuencia();
            //CargarUnidades();
            buscar();

        }
        private void FormulaCelda()
        {
            dtgReposicion["Entregado", dtgReposicion.CurrentRow.Index].Value = Convert.ToInt32(dtgReposicion["pacto_stocks", dtgReposicion.CurrentRow.Index].Value.ToString())
                                                                                         - Convert.ToInt32(dtgReposicion["Existencia", dtgReposicion.CurrentRow.Index].Value.ToString());
            dtgReposicion["Pendiente", dtgReposicion.CurrentRow.Index].Value = Convert.ToInt32(dtgReposicion["pacto_stocks", dtgReposicion.CurrentRow.Index].Value.ToString())
                                                                              - Convert.ToInt32(dtgReposicion["Entregado", dtgReposicion.CurrentRow.Index].Value.ToString());
        }

        private void dtgReposicion_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            FormulaCelda();
        }
        private void guardar()
        {
            try
            {
                string query = "";
                string codigostock = "";

                codigostock = Convert.ToString(dtgReposicion.CurrentRow.Cells["codigo_stock"].Value);
                MessageBox.Show(dtfecha.Text);

                query = @"INSERT INTO reposicion_stock
                             (codigo, descripcion, 
                              unidad_de_medida, pacto_stock,frecuencia,existencia,entregada,pendiente,costo_unitario,costo_total,fecha,codigo_stock)
                            VALUES
                             ('{0}','{1}','{2}',{3},'{4}',{5},{6},{7},{8},{9},'{10}','{11}')";



                query = string.Format(query,
                                        Convert.ToString(dtgReposicion.CurrentRow.Cells["codigo_stock"].Value),
                                        Convert.ToString(dtgReposicion.CurrentRow.Cells["descripcion"].Value),
                                        Convert.ToString(dtgReposicion.CurrentRow.Cells["unidad_medida"].Value),
                                        Convert.ToString(dtgReposicion.CurrentRow.Cells["pacto_stocks"].Value),
                                        Convert.ToString(dtgReposicion.CurrentRow.Cells["frecuencia"].Value),
                                        Convert.ToString(dtgReposicion.CurrentRow.Cells["Existencia"].Value),
                                        Convert.ToString(dtgReposicion.CurrentRow.Cells["entregado"].Value),
                                        Convert.ToString(dtgReposicion.CurrentRow.Cells["pendiente"].Value),
                                        Convert.ToString(dtgReposicion.CurrentRow.Cells["costo_unitario"].Value),
                                        Convert.ToString(dtgReposicion.CurrentRow.Cells["costo_total"].Value),
                                        dtfecha.Value.ToString("MM/dd/yyyy"),
                                        Convert.ToString(dtgReposicion.CurrentRow.Cells["costo_total"].Value)
                                    );






                if (conn.SqlExec(query))
                {
                    MessageBox.Show("Usuario registrado");

                }
                else
                {
                    MessageBox.Show("Error al guardar: " +
                                    conn.SQLError());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo de Unidad: " +
                                 ex.ToString());
            }


        }


        private void brnbguardar_Click(object sender, EventArgs e)
        {
            guardar();

        }

        private void brnbguardar_Click_1(object sender, EventArgs e)
        {
            guardar();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            buscar();
        }
    }
}
