using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EquivalenciasBcoNeg.DAO;
using System.Collections;
using CrystalDecisions.CrystalReports;

namespace EquivalenciasBcoNeg
{
    public partial class Form1 : Form
    {        
        DataTable dtSupremo = new DataTable();
        public Form1()
        {
            InitializeComponent();          
        }
        private void cREAREQUIVALENCIAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Consulta dao = new Consulta();
                chlArticuloLiso.DataSource = dao.ConsultaArticulo(1, "'BCO/NEG%LISO%'");
                chlArticuloLiso.DisplayMember = "nombre";
                chlArticuloLiso.ValueMember = "nombre";

                chlColorLiso.DataSource = dao.ConsultaColor(1, "'BCO/NEG%LISO%'");
                chlColorLiso.DisplayMember = "nombre";
                chlColorLiso.ValueMember = "nombre";

                chlCodigoLiso.DataSource = dao.ConsultaCodigo(1, "'BCO/NEG%LISO%'");
                chlCodigoLiso.DisplayMember = "codigo";
                chlCodigoLiso.ValueMember = "codigo";

                chlTallaLiso.DataSource = dao.ConsultaTalla(1, "'BCO/NEG%LISO%'");
                chlTallaLiso.DisplayMember = "nombre";
                chlTallaLiso.ValueMember = "nombre";

                cmbPlazas.DataSource = dao.ConsultaPlazas(1);
                cmbPlazas.ValueMember = "id_plaza";
                cmbPlazas.DisplayMember = "descripcion";

                rbtnTodas.Checked=true;
                rbtnLiso.Checked=true;
                dataGridView5.DataSource = dao.ConsultaRelacion(3);
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error\nVerifique su conexión con el Servidor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }
        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            gfx.DrawLine(p, 0, 7, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 7, 5, 7);
            gfx.DrawLine(p, 0, 7, e.ClipRectangle.Width - 2, 7);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 7, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2); 
        }
        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            gfx.DrawLine(p, 0, 7, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 7, 5, 7);
            gfx.DrawLine(p, 0, 7, e.ClipRectangle.Width - 2, 7);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 7, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2); 
        }
        private void groupBox3_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            gfx.DrawLine(p, 0, 7, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 7, 5, 7);
            gfx.DrawLine(p, 0, 7, e.ClipRectangle.Width - 2, 7);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 7, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2); 
        }
        private void groupBox4_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            gfx.DrawLine(p, 0, 7, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 7, 5, 7);
            gfx.DrawLine(p, 0, 7, e.ClipRectangle.Width - 2, 7);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 7, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2); 
        }
        private void groupBox7_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            gfx.DrawLine(p, 0, 7, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 7, 5, 7);
            gfx.DrawLine(p, 0, 7, e.ClipRectangle.Width - 2, 7);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 7, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2); 
        }
        private void groupBox8_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            gfx.DrawLine(p, 0, 7, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 7, 5, 7);
            gfx.DrawLine(p, 0, 7, e.ClipRectangle.Width - 2, 7);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 7, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2); 
        }
        private void groupBox6_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            gfx.DrawLine(p, 0, 7, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 7, 5, 7);
            gfx.DrawLine(p, 0, 7, e.ClipRectangle.Width - 2, 7);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 7, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2); 
        }
        private void groupBox5_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            gfx.DrawLine(p, 0, 7, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 7, 5, 7);
            gfx.DrawLine(p, 0, 7, e.ClipRectangle.Width - 2, 7);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 7, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2); 
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void groupBox9_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Black, 2);
            gfx.DrawLine(p, 0, 7, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 7, 5, 7);
            gfx.DrawLine(p, 0, 7, e.ClipRectangle.Width - 2, 7);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 7, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2); 
        }
        private void groupBox10_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Black, 2);
            gfx.DrawLine(p, 0, 7, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 7, 5, 7);
            gfx.DrawLine(p, 0, 7, e.ClipRectangle.Width - 2, 7);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 7, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }
        private void cmbPlazas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Consulta dao = new Consulta();
                chlArticuloTerminado.DataSource = dao.ConsultaArticulo2(1, "'BCO/NEG'", cmbPlazas.SelectedValue.ToString().Trim());
                chlArticuloTerminado.DisplayMember = "nombre";
                chlArticuloTerminado.ValueMember = "nombre";

                chlColorTerminado.DataSource = dao.ConsultaColor2(1, "'BCO/NEG'", cmbPlazas.SelectedValue.ToString().Trim());
                chlColorTerminado.DisplayMember = "nombre";
                chlColorTerminado.ValueMember = "nombre";

                chlCodigoTerminado.DataSource = dao.ConsultaCodigo2(1, "'BCO/NEG'", cmbPlazas.SelectedValue.ToString().Trim());
                chlCodigoTerminado.DisplayMember = "codigo";
                chlCodigoTerminado.ValueMember = "codigo";

                chlTallaTerminado.DataSource = dao.ConsultaTalla2(1, "'BCO/NEG'", cmbPlazas.SelectedValue.ToString().Trim());
                chlTallaTerminado.DisplayMember = "nombre";
                chlTallaTerminado.ValueMember = "nombre";
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error\nVerifique su conexión con el Servidor","ADVERTENCIA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }            
        }
        private void txtArticuloLiso_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                chlArticuloLiso.SelectedIndex = chlArticuloLiso.FindString(txtArticuloLiso.Text);
            }
            catch
            {

            }      
        }
        private void txtColorLiso_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                chlColorLiso.SelectedIndex = chlColorLiso.FindString(txtColorLiso.Text);
            }
            catch
            {

            }            
        }
        private void txtTallaLiso_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                chlTallaLiso.SelectedIndex = chlTallaLiso.FindString(txtTallaLiso.Text);
            }
            catch
            {

            }     
        }
        private void txtCodigoLiso_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                chlCodigoLiso.SelectedIndex = chlCodigoLiso.FindString(txtCodigoLiso.Text);
            }
            catch
            {

            }     
        }
        private void txtArticuloTerminado_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                chlArticuloTerminado.SelectedIndex = chlArticuloTerminado.FindString(txtArticuloTerminado.Text);
            }
            catch
            {

            }   
        }
        private void txtColorTerminado_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                chlColorTerminado.SelectedIndex = chlColorTerminado.FindString(txtColorTerminado.Text);
            }
            catch
            {

            }        
        }
        private void txtTallaTerminado_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                chlTallaTerminado.SelectedIndex = chlTallaTerminado.FindString(txtTallaTerminado.Text);
            }
            catch
            {

            }  
        }
        private void txtCodigoTerminado_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                chlCodigoTerminado.SelectedIndex = chlCodigoTerminado.FindString(txtCodigoTerminado.Text);
            }
            catch
            {

            }    
        }
        private void txtArticuloLiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    chlArticuloLiso.SetItemChecked(chlArticuloLiso.SelectedIndex, true);
                }
            }
            catch
            {

            }            
        }
        private void txtColorLiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    chlColorLiso.SetItemChecked(chlColorLiso.SelectedIndex, true);
                }
            }
            catch
            {

            }  
        }
        private void txtTallaLiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    chlTallaLiso.SetItemChecked(chlTallaLiso.SelectedIndex, true);
                }
            }
            catch
            {

            }  
        }
        private void txtCodigoLiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    chlCodigoLiso.SetItemChecked(chlCodigoLiso.SelectedIndex, true);
                }
            }
            catch
            {

            }  
        }
        private void txtArticuloTerminado_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    chlArticuloTerminado.SetItemChecked(chlArticuloTerminado.SelectedIndex, true);
                }
            }
            catch
            {

            }  
        }
        private void txtColorTerminado_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    chlColorTerminado.SetItemChecked(chlColorTerminado.SelectedIndex, true);
                }
            }
            catch
            {

            }  
        }
        private void txtTallaTerminado_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    chlTallaTerminado.SetItemChecked(chlTallaTerminado.SelectedIndex, true);
                }
            }
            catch
            {

            }
        }
        private void txtCodigoTerminado_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    chlCodigoTerminado.SetItemChecked(chlCodigoTerminado.SelectedIndex, true);
                }
            }
            catch
            {

            }
        }
        private void btnBuscarLiso_Click(object sender, EventArgs e)
        {
            try
            {
                Consulta dao = new Consulta();
                string articulo = "";
                string TipoColor = "";
                string talla = "";
                string codigo = "";
                articulo = dao.Articulos(chlArticuloLiso);
                TipoColor = dao.Colores(chlColorLiso);
                talla = dao.Tallas(chlTallaLiso);
                codigo = dao.Codigos(chlCodigoLiso);
                string cadena = "'BCO/NEG%LI%'";
                if (articulo != "")
                {
                    cadena = cadena + " AND artic.nombre IN (" + articulo + ")";
                }
                if (TipoColor != "")
                {
                    cadena = cadena + " AND artic.nombre2 IN (" + TipoColor + ")";
                }
                if (talla != "")
                {
                    cadena = cadena + " AND artic.clasif IN (" + talla + ")";
                }
                if (codigo != "")
                {
                    cadena = cadena + " AND artic.codigo IN (" + codigo + ")";
                }
                dataGridView1.DataSource = dao.ConsultaArticuloData(1, cadena);
                MessageBox.Show("Filtro Realizado", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Hubo un error con la conexión a la base de datos", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }                         
        }
        private void btnBuscarTerminado_Click(object sender, EventArgs e)
        {
            try
            {
                Consulta dao = new Consulta();
                string articulo = "";
                string TipoColor = "";
                string talla = "";
                string codigo = "";
                articulo = dao.Articulos(chlArticuloTerminado);
                TipoColor = dao.Colores(chlColorTerminado);
                talla = dao.Tallas(chlTallaTerminado);
                codigo = dao.Codigos(chlCodigoTerminado);
                string plaza = "";
                plaza = cmbPlazas.SelectedValue.ToString().Trim();
                string cadena = "'BCO/NEG'";
                if (articulo != "")
                {
                    cadena = cadena + " AND artic.nombre IN (" + articulo + ") AND artic.clasif2='" + plaza + "'";
                }
                if (TipoColor != "")
                {
                    cadena = cadena + " AND artic.nombre2 IN (" + TipoColor + ") AND artic.clasif2='" + plaza + "'";
                }
                if (talla != "")
                {
                    cadena = cadena + " AND artic.clasif IN (" + talla + ") AND artic.clasif2='" + plaza + "'";
                }
                if (codigo != "")
                {
                    cadena = cadena + " AND artic.codigo IN (" + codigo + ") AND artic.clasif2='" + plaza + "'";
                }
                dataGridView2.DataSource = dao.ConsultaArticuloData(1, cadena);
                MessageBox.Show("Filtro Realizado", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            catch
            {
                MessageBox.Show("Hubo un error con la conexión a la base de datos", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList lisos = new ArrayList();
                ArrayList terminados = new ArrayList();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    BO.Producto liso = new BO.Producto();
                    liso.Nombre = dataGridView1.Rows[i].Cells["Articuloliso"].Value.ToString().Trim();
                    liso.Color = dataGridView1.Rows[i].Cells["ColorLiso"].Value.ToString().Trim();
                    liso.Talla = dataGridView1.Rows[i].Cells["TallaLiso"].Value.ToString().Trim();
                    liso.Codigo = dataGridView1.Rows[i].Cells["Codigoliso"].Value.ToString().Trim();
                    liso.Activo = "1";
                    lisos.Add(liso);
                }
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    BO.Producto terminado = new BO.Producto();
                    terminado.Nombre = dataGridView2.Rows[i].Cells["ArticuloTerminado"].Value.ToString().Trim();
                    terminado.Color = dataGridView2.Rows[i].Cells["ColorTerminado"].Value.ToString().Trim();
                    terminado.Talla = dataGridView2.Rows[i].Cells["TallaTerminado"].Value.ToString().Trim();
                    terminado.Codigo = dataGridView2.Rows[i].Cells["CodigoTerminado"].Value.ToString().Trim();
                    terminado.Activo = "1";
                    terminados.Add(terminado);
                }
                string prueba = "";
                string codigos = "";
                foreach (BO.Producto itemLiso in lisos)
                {
                    foreach (BO.Producto itemTerminado in terminados)
                    {
                        if (itemLiso.Color == itemTerminado.Color && itemLiso.Talla == itemTerminado.Talla)
                        {
                            prueba = prueba + "Se unirá " + itemLiso.Nombre + " " + itemLiso.Color + " " + itemLiso.Talla + " con:"
                                    + itemTerminado.Nombre + " " + itemTerminado.Color + " " + itemTerminado.Talla + "\n"
                                    + "con códigos: " + itemLiso.Codigo + ":" + itemTerminado.Codigo + "\n";
                            codigos = codigos + itemLiso.Codigo + "," + itemTerminado.Codigo + ",";
                        }
                    }
                }
                codigos = codigos.TrimEnd(',');
                if (prueba != "")
                {
                    var result = MessageBox.Show(prueba + "¿Seguro que desea crear estas relaciones?", "Información",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        foreach (BO.Producto itemLiso in lisos)
                        {
                            foreach (BO.Producto itemTerminado in terminados)
                            {
                                if (itemLiso.Color == itemTerminado.Color && itemLiso.Talla == itemTerminado.Talla)
                                {
                                    string cadena = "INSERT INTO EquivalenciasBcoNeg (codigoLiso,codigoBordado,activo) VALUES ('" + itemLiso.Codigo + "','"
                                                    + itemTerminado.Codigo + "','1')";
                                    Consulta dao = new Consulta();
                                    dao.InsertarRelacion(3, cadena);
                                }
                            }
                        }
                        MessageBox.Show("La relación ha sido creada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Asegúrese de que el color y la talla coincidan", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Hubo un error con la conexión a la base de datos", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }                        
        }
        private void groupBox11_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            gfx.DrawLine(p, 0, 7, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 7, 5, 7);
            gfx.DrawLine(p, 0, 7, e.ClipRectangle.Width - 2, 7);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 7, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2); 
        }
        private void groupBox12_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            gfx.DrawLine(p, 0, 7, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 7, 5, 7);
            gfx.DrawLine(p, 0, 7, e.ClipRectangle.Width - 2, 7);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 7, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }
        private void rbtnLiso_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string codigo = "";
                Consulta dao = new Consulta();
                if (rbtnTodas.Checked == true)
                {
                    dataGridView5.DataSource = dao.ConsultaRelacion(3);
                    for (int i = 0; i < dataGridView5.RowCount; i++)
                    {
                        codigo = codigo + "'" + dataGridView5.Rows[i].Cells["CodigoLiso"].Value.ToString().Trim() + "',";
                    }
                }
                if (rbtnActivas.Checked == true)
                {
                    dataGridView5.DataSource = dao.ConsultaRelacionActiva(3);
                    for (int i = 0; i < dataGridView5.RowCount; i++)
                    {
                        codigo = codigo + "'" + dataGridView5.Rows[i].Cells["CodigoLiso"].Value.ToString().Trim() + "',";
                    }
                }
                if (rbtnDisactivas.Checked == true)
                {
                    dataGridView5.DataSource = dao.ConsultaRelacionDisactiva(3);
                    for (int i = 0; i < dataGridView5.RowCount; i++)
                    {
                        codigo = codigo + "'" + dataGridView5.Rows[i].Cells["CodigoLiso"].Value.ToString().Trim() + "',";
                    }
                }
                codigo = "";
                if (rbtnLiso.Checked == true)
                {
                    for (int i = 0; i < dataGridView5.RowCount; i++)
                    {
                        codigo = codigo + "'" + dataGridView5.Rows[i].Cells["CodigoLiso"].Value.ToString().Trim() + "',";
                    }
                }
                if (rbtnLiso.Checked == false)
                {
                    for (int i = 0; i < dataGridView5.RowCount; i++)
                    {
                        codigo = codigo + "'" + dataGridView5.Rows[i].Cells["CodigoBordado"].Value.ToString().Trim() + "',";
                    }
                }
                codigo = codigo.TrimEnd(',');
                dataGridView3.DataSource = dao.ConsultaArticuloLiso(1, codigo);
                dtSupremo.Clear();
                dtSupremo = dao.ConsultaArticuloLiso(1, codigo);
            }
            catch
            {
                MessageBox.Show("Hubo un error con la conexión a la base de datos", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
        }
        private void rbtnTodas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string codigo = "";
                Consulta dao = new Consulta();
                if (rbtnTodas.Checked == true)
                {
                    dataGridView5.DataSource = dao.ConsultaRelacion(3);                   
                    codigo = "";
                    if (rbtnLiso.Checked == true)
                    {
                        for (int i = 0; i < dataGridView5.RowCount; i++)
                        {
                            codigo = codigo + "'" + dataGridView5.Rows[i].Cells["CodigoLiso"].Value.ToString().Trim() + "',";
                        }
                    }
                    if (rbtnLiso.Checked == false)
                    {

                        for (int i = 0; i < dataGridView5.RowCount; i++)
                        {
                            codigo = codigo + "'" + dataGridView5.Rows[i].Cells["CodigoBordado"].Value.ToString().Trim() + "',";
                        }
                    }
                    codigo = codigo.TrimEnd(',');
                    dataGridView3.DataSource = dao.ConsultaArticuloLiso(1, codigo);
                    dtSupremo.Clear();
                    dtSupremo = dao.ConsultaArticuloLiso(1, codigo);
                }
            }
            catch
            {
                MessageBox.Show("Hubo un error con la conexión a la base de datos", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }                                    
        }
        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int fila = 0;
                fila = e.RowIndex;
                string codigo = "";
                string codigos = "";
                if (fila >= 0)
                {
                    codigo = dataGridView3.Rows[fila].Cells["CodigoRelacion1"].Value.ToString().Trim();
                    Consulta dao = new Consulta();
                    if (rbtnLiso.Checked == true)
                    {
                        dataGridView6.DataSource = dao.ConsultaRelacionFiltrada(3, codigo);
                        for (int i = 0; i < dataGridView6.RowCount; i++)
                        {
                            codigos = codigos + "'" + dataGridView6.Rows[i].Cells["CodigoBordado"].Value.ToString().Trim() + "',";
                        }
                        codigos = codigos.TrimEnd(',');
                        DataTable dt = new DataTable();
                        dt = dao.ConsultaArticuloLiso(1, codigos);
                        dt.Columns.Add("Estado");
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            for (int i = 0; i < dataGridView6.RowCount; i++)
                            {
                                if (dt.Rows[j]["Codigo"].ToString().Trim() == dataGridView6.Rows[i].Cells["CodigoBordado"].Value.ToString().Trim())
                                {
                                    string activo = dataGridView6.Rows[i].Cells["Activo"].Value.ToString().Trim();
                                    if (activo == "1")
                                    {
                                        dt.Rows[j]["Estado"] = true;
                                    }
                                    if (activo == "0")
                                    {
                                        dt.Rows[j]["Estado"] = false;
                                    }
                                }
                            }
                        }
                        dataGridView4.DataSource = dt;
                    }
                    if (rbtnTrabajado.Checked == true)
                    {
                        dataGridView6.DataSource = dao.ConsultaRelacionFiltrada2(3, codigo);
                        for (int i = 0; i < dataGridView6.RowCount; i++)
                        {
                            codigos = codigos + "'" + dataGridView6.Rows[i].Cells["CodigoLiso"].Value.ToString().Trim() + "',";
                        }
                        codigos = codigos.TrimEnd(',');
                        DataTable dt = new DataTable();
                        dt = dao.ConsultaArticuloLiso(1, codigos);
                        dt.Columns.Add("Estado");
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            for (int i = 0; i < dataGridView6.RowCount; i++)
                            {
                                if (dt.Rows[j]["Codigo"].ToString().Trim() == dataGridView6.Rows[i].Cells["CodigoLiso"].Value.ToString().Trim())
                                {
                                    string activo = dataGridView6.Rows[i].Cells["Activo"].Value.ToString().Trim();
                                    if (activo == "1")
                                    {
                                        dt.Rows[j]["Estado"] = true;
                                    }
                                    if (activo == "0")
                                    {
                                        dt.Rows[j]["Estado"] = false;
                                    }
                                }
                            }
                        }
                        dataGridView4.DataSource = dt;
                    }
                    txtCodigoArriba.Text = dataGridView3.Rows[fila].Cells["CodigoRelacion1"].Value.ToString().Trim();
                }
            }
            catch
            {
                MessageBox.Show("Hubo un error con la conexión a la base de datos", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }                      
        }
        private void rbtnActivas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string codigo = "";
                Consulta dao = new Consulta();
                if (rbtnActivas.Checked == true)
                {
                    dataGridView5.DataSource = dao.ConsultaRelacionActiva(3);                    
                    codigo = "";
                    if (rbtnLiso.Checked == true)
                    {
                        for (int i = 0; i < dataGridView5.RowCount; i++)
                        {
                            codigo = codigo + "'" + dataGridView5.Rows[i].Cells["CodigoLiso"].Value.ToString().Trim() + "',";
                        }
                    }
                    if (rbtnLiso.Checked == false)
                    {

                        for (int i = 0; i < dataGridView5.RowCount; i++)
                        {
                            codigo = codigo + "'" + dataGridView5.Rows[i].Cells["CodigoBordado"].Value.ToString().Trim() + "',";
                        }
                    }
                    codigo = codigo.TrimEnd(',');
                    dataGridView3.DataSource = dao.ConsultaArticuloLiso(1, codigo);
                    dtSupremo.Clear();
                    dtSupremo = dao.ConsultaArticuloLiso(1, codigo);
                }
            }               
            catch
            {
                MessageBox.Show("Hubo un error con la conexión a la base de datos", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }                
        }
        private void rbtnDisactivas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string codigo = "";
                Consulta dao = new Consulta();
                if (rbtnDisactivas.Checked == true)
                {
                    dataGridView5.DataSource = dao.ConsultaRelacionDisactiva(3);                    
                    codigo = "";
                    if (rbtnLiso.Checked == true)
                    {                        
                        for (int i = 0; i < dataGridView5.RowCount; i++)
                        {
                            codigo = codigo + "'" + dataGridView5.Rows[i].Cells["CodigoLiso"].Value.ToString().Trim() + "',";
                        }
                    }
                    if (rbtnLiso.Checked == false)
                    {                        
                        for (int i = 0; i < dataGridView5.RowCount; i++)
                        {
                            codigo = codigo + "'" + dataGridView5.Rows[i].Cells["CodigoBordado"].Value.ToString().Trim() + "',";
                        }
                    }
                    codigo = codigo.TrimEnd(',');
                    dataGridView3.DataSource = dao.ConsultaArticuloLiso(1, codigo);
                    dtSupremo.Clear();
                    dtSupremo = dao.ConsultaArticuloLiso(1, codigo);
                }
            }
            catch
            {
                MessageBox.Show("Hubo un error con la conexión a la base de datos", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }         
        }
        private void dataGridView4_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila = 0;
            fila = e.RowIndex;
            if (fila >= 0)
            {
                txtCodigoAbajo.Text = dataGridView4.Rows[fila].Cells["CodigoRelacion2"].Value.ToString().Trim();
            }
        }
        private void btnCambios_Click(object sender, EventArgs e)
        {
            try
            {
                string cadena = "";
                if (rbtnLiso.Checked == true)
                {
                    for (int i = 0; i < dataGridView4.RowCount; i++)
                    {
                        if (dataGridView4.Rows[i].Cells["EstadoRelacion2"].Value.ToString().Trim().ToLower() == "true")
                        {
                            cadena = cadena + "UPDATE EquivalenciasBcoNeg SET Activo= '1' WHERE codigoLiso='" + txtCodigoArriba.Text.Trim() + "'"
                                     + " AND codigoBordado='" + dataGridView4.Rows[i].Cells["CodigoRelacion2"].Value.ToString().Trim() + "';\n";
                        }
                        else
                        {
                            cadena = cadena + "UPDATE EquivalenciasBcoNeg SET Activo= '0' WHERE codigoLiso='" + txtCodigoArriba.Text.Trim() + "'"
                                     + " AND codigoBordado='" + dataGridView4.Rows[i].Cells["CodigoRelacion2"].Value.ToString().Trim() + "';\n";
                        }
                    }
                }
                if (rbtnTrabajado.Checked == true)
                {
                    for (int i = 0; i < dataGridView4.RowCount; i++)
                    {
                        if (dataGridView4.Rows[i].Cells["EstadoRelacion2"].Value.ToString().Trim().ToLower() == "true")
                        {
                            cadena = cadena + "UPDATE EquivalenciasBcoNeg SET Activo= '1' WHERE codigoBordado='" + txtCodigoArriba.Text.Trim() + "'"
                                     + " AND codigoLiso='" + dataGridView4.Rows[i].Cells["CodigoRelacion2"].Value.ToString().Trim() + "';\n";
                        }
                        else
                        {
                            cadena = cadena + "UPDATE EquivalenciasBcoNeg SET Activo= '0' WHERE codigoBordado='" + txtCodigoArriba.Text.Trim() + "'"
                                     + " AND codigoLiso='" + dataGridView4.Rows[i].Cells["CodigoRelacion2"].Value.ToString().Trim() + "';\n";
                        }
                    }
                }
                Consulta dao = new Consulta();
                dao.EditarRelacion(3, cadena);
                MessageBox.Show("Reporte Listo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Hubo un error con la conexión a la base de datos", "Advertencia",
                                MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }            
        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {                
                DataView filter =  dtSupremo.AsDataView();
                filter.RowFilter = "Articulo like '" + textBox1.Text + "%'";
                dataGridView3.DataSource = filter;
            }
            catch
            {

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Consulta dao = new Consulta();
                DataTable liso = new DataTable();
                DataTable codigo = new DataTable();
                DataTable terminado = new DataTable();
                DataTable final = new DataTable();
                final.Columns.Add("Linea");
                final.Columns.Add("depto");
                final.Columns.Add("codigo");
                final.Columns.Add("nombre");
                final.Columns.Add("color");
                final.Columns.Add("talla");
                final.Columns.Add("ext_liso", typeof(int));
                final.Columns.Add("ext_qroo", typeof(int));
                final.Columns.Add("ext_cabos", typeof(int));
                final.Columns.Add("ext_cancun", typeof(int));
                final.Columns.Add("ext_tulum", typeof(int));
                final.Columns.Add("total", typeof(int));
                final.Columns.Add("maximo", typeof(int));
                final.Columns.Add("fabricar", typeof(int));
                codigo = dao.ConsultaCodigoLiso(3);
                string codigos = "";
                for (int i = 0; i < codigo.Rows.Count; i++)
                {
                    codigos = codigos + "'" + codigo.Rows[i]["Codigoliso"].ToString().Trim() + "',";
                }
                codigos = codigos.TrimEnd(',');
                liso = dao.ConsultaDatosLisos(1, codigos);
                codigos = "";
                codigo.Clear();
                codigo = dao.ConsultaCodigoBordado(3);
                for (int i = 0; i < codigo.Rows.Count; i++)
                {
                    codigos = codigos + "'" + codigo.Rows[i]["Codigobordado"].ToString().Trim() + "',";
                }
                DataTable suc = new DataTable();
                suc = dao.ConsultaSucursal(1);
                string sucur = "";
                for (int i = 0; i < suc.Rows.Count; i++)
                {
                    sucur = sucur + "'" + suc.Rows[i]["id_suc"].ToString().Trim() + "',";
                }
                sucur = sucur.TrimEnd(',');
                codigos = codigos.TrimEnd(',');
                terminado = dao.ConsultaDatosTerminado(1, codigos, sucur);
                DataTable terminado2 = new DataTable();
                terminado2.Columns.Add("codigo");
                terminado2.Columns.Add("ext_qroo", typeof(int));
                terminado2.Columns.Add("ext_cabos", typeof(int));
                terminado2.Columns.Add("ext_cancun", typeof(int));
                terminado2.Columns.Add("ext_tulum", typeof(int));
                for (int i = 0; i < codigo.Rows.Count; i++)
                {
                    for (int j = 0; j < terminado.Rows.Count; j++)
                    {
                        if (codigo.Rows[i]["codigoBordado"].ToString().Trim() == terminado.Rows[j]["Codigo"].ToString().Trim())
                        {
                            if (terminado.Rows[j]["PLaza"].ToString().Trim() == "3")
                            {
                                terminado2.Rows.Add(codigo.Rows[i]["codigoLiso"].ToString().Trim(), terminado.Rows[j]["ext"].ToString().Trim(), 0,0,0);
                            }
                            if (terminado.Rows[j]["PLaza"].ToString().Trim() == "6")
                            {
                                terminado2.Rows.Add(codigo.Rows[i]["codigoLiso"].ToString().Trim(), 0, terminado.Rows[j]["ext"].ToString().Trim(),0,0);
                            }
                            if (terminado.Rows[j]["PLaza"].ToString().Trim() == "7")
                            {
                                terminado2.Rows.Add(codigo.Rows[i]["codigoLiso"].ToString().Trim(), 0,0,terminado.Rows[j]["ext"].ToString().Trim(),0);
                            }
                            if (terminado.Rows[j]["PLaza"].ToString().Trim() == "14")
                            {
                                terminado2.Rows.Add(codigo.Rows[i]["codigoLiso"].ToString().Trim(), 0, 0,0, terminado.Rows[j]["ext"].ToString().Trim());
                            }
                        }
                    }
                }
                for (int i = 0; i < liso.Rows.Count; i++)
                {
                    final.Rows.Add(liso.Rows[i]["Linea"].ToString().Trim(),
                                   liso.Rows[i]["depto"].ToString().Trim(),
                                   liso.Rows[i]["codigo"].ToString().Trim(),
                                   liso.Rows[i]["nombre"].ToString().Trim(),
                                   liso.Rows[i]["color"].ToString().Trim(),
                                   liso.Rows[i]["talla"].ToString().Trim(),
                                   liso.Rows[i]["ext_liso"].ToString().Trim(),
                                   0, 0, 0,0,0,
                                   liso.Rows[i]["Maximo"].ToString().Trim(), 0);
                }
                for (int i = 0; i < terminado2.Rows.Count; i++)
                {
                    final.Rows.Add("", "",
                                   terminado2.Rows[i]["codigo"].ToString().Trim(),
                                   "", "", "", 0,
                                   terminado2.Rows[i]["ext_qroo"].ToString().Trim(),
                                   terminado2.Rows[i]["ext_cabos"].ToString().Trim(),
                                   terminado2.Rows[i]["ext_cancun"].ToString().Trim(),
                                   terminado2.Rows[i]["ext_tulum"].ToString().Trim(),
                                   0, 0, 0);
                }
                ArrayList finalizado = new ArrayList();
                for (int i = 0; i < final.Rows.Count; i++)
                {
                    object sumObject = new object();
                    object sumObject2 = new object();
                    object sumObject3 = new object();
                    object sumObject4 = new object();
                    object sumObject5 = new object();
                    string filtro = "codigo = '" + final.Rows[i]["codigo"].ToString().Trim() + "'";
                    sumObject = final.Compute("Sum(ext_liso)", filtro);
                    sumObject2 = final.Compute("Sum(ext_qroo)", filtro);
                    sumObject3 = final.Compute("Sum(ext_cabos)", filtro);
                    sumObject4 = final.Compute("Sum(ext_cancun)", filtro);
                    sumObject5 = final.Compute("Sum(ext_tulum)", filtro);
                    BO.Producto artic = new BO.Producto();
                    artic.Linea = final.Rows[i]["Linea"].ToString().Trim();
                    artic.Depto = final.Rows[i]["Depto"].ToString().Trim();
                    artic.Codigo = final.Rows[i]["codigo"].ToString().Trim();
                    artic.Nombre = final.Rows[i]["nombre"].ToString().Trim();
                    artic.Color = final.Rows[i]["color"].ToString().Trim();
                    artic.Talla = final.Rows[i]["talla"].ToString().Trim();
                    artic.Ext_liso = int.Parse(sumObject.ToString().Trim());
                    artic.Ext_qroo = int.Parse(sumObject2.ToString().Trim());
                    artic.Ext_cabos = int.Parse(sumObject3.ToString().Trim());
                    artic.Ext_cancun = int.Parse(sumObject4.ToString().Trim());
                    artic.Ext_tulum = int.Parse(sumObject5.ToString().Trim());
                    artic.Total = artic.Ext_liso + artic.Ext_qroo + artic.Ext_cabos + artic.Ext_cancun+artic.Ext_tulum;
                    artic.Maximo = int.Parse(final.Rows[i]["maximo"].ToString().Trim());
                    artic.Fabricar = artic.Total - artic.Maximo;
                    finalizado.Add(artic);
                }
                DataTable dt = new DataTable();
                dt.Columns.Add("Linea");
                dt.Columns.Add("depto");
                dt.Columns.Add("codigo");
                dt.Columns.Add("nombre");
                dt.Columns.Add("color");
                dt.Columns.Add("talla");
                dt.Columns.Add("ext_liso", typeof(int));
                dt.Columns.Add("ext_qroo", typeof(int));
                dt.Columns.Add("ext_cabos", typeof(int));
                dt.Columns.Add("ext_cancun", typeof(int));
                dt.Columns.Add("ext_tulum", typeof(int));
                dt.Columns.Add("total", typeof(int));
                dt.Columns.Add("maximo", typeof(int));
                dt.Columns.Add("fabricar", typeof(int));
                foreach (BO.Producto item in finalizado)
                {
                    dt.Rows.Add(item.Linea, item.Depto, item.Codigo, item.Nombre, item.Color, item.Talla, item.Ext_liso, item.Ext_qroo, item.Ext_cabos,
                                item.Ext_cancun,item.Ext_tulum,item.Total, item.Maximo, item.Fabricar);
                }
                DataTable orders2 = dt;
                EnumerableRowCollection<DataRow> query2 =
                    from order2 in orders2.AsEnumerable()
                    orderby order2.Field<string>("Codigo")
                    select order2;
                DataView view2 = query2.AsDataView();
                dataGridView7.DataSource = view2;
                DataTable otro = new DataTable();
                otro.Columns.Add("Linea");
                otro.Columns.Add("depto");
                otro.Columns.Add("codigo");
                otro.Columns.Add("nombre");
                otro.Columns.Add("color");
                otro.Columns.Add("talla");
                otro.Columns.Add("ext_liso", typeof(int));
                otro.Columns.Add("ext_qroo", typeof(int));
                otro.Columns.Add("ext_cabos", typeof(int));
                otro.Columns.Add("ext_cancun", typeof(int));
                otro.Columns.Add("ext_tulum", typeof(int));
                otro.Columns.Add("total", typeof(int));
                otro.Columns.Add("maximo", typeof(int));
                otro.Columns.Add("fabricar", typeof(int));
                for (int i = 0; i < dataGridView7.RowCount; i++)
                {
                    if (dataGridView7.Rows[i].Cells["Depto"].Value.ToString().Trim() != "")
                    {
                        otro.Rows.Add(dataGridView7.Rows[i].Cells["Linea"].Value.ToString().Trim(),
                                      dataGridView7.Rows[i].Cells["Depto"].Value.ToString().Trim(),
                                      dataGridView7.Rows[i].Cells["codigo"].Value.ToString().Trim(),
                                      dataGridView7.Rows[i].Cells["nombre"].Value.ToString().Trim(),
                                      dataGridView7.Rows[i].Cells["color"].Value.ToString().Trim(),
                                      dataGridView7.Rows[i].Cells["talla"].Value.ToString().Trim(),
                                      dataGridView7.Rows[i].Cells["ext_liso"].Value.ToString().Trim(),
                                      dataGridView7.Rows[i].Cells["ext_qroo"].Value.ToString().Trim(),
                                      dataGridView7.Rows[i].Cells["ext_cabos"].Value.ToString().Trim(),
                                      dataGridView7.Rows[i].Cells["ext_cancun"].Value.ToString().Trim(),
                                      dataGridView7.Rows[i].Cells["ext_tulum"].Value.ToString().Trim(),
                                      dataGridView7.Rows[i].Cells["total"].Value.ToString().Trim(),
                                      dataGridView7.Rows[i].Cells["maximo"].Value.ToString().Trim(),
                                      dataGridView7.Rows[i].Cells["fabricar"].Value.ToString().Trim());
                    }
                }
                DataTable termin = new DataTable();
                termin = dao.ConsultaDatosTerminado2(1, codigos, sucur);
                dt.Clear();
                for (int i = 0; i < termin.Rows.Count; i++)
                {
                    if (termin.Rows[i]["Plaza"].ToString().Trim() == "3")
                    {
                        string max = "";
                        string cod = "";
                        string exis = "";
                        max = termin.Rows[i]["maximo"].ToString().Trim();
                        cod = termin.Rows[i]["codigo"].ToString().Trim(); 
                        exis = termin.Rows[i]["ext"].ToString().Trim(); 
                        
                        if (max == "")
                        {
                            max = "0";
                        }
                        if (exis == "")
                        {
                            exis = "0";
                        }
                        dt.Rows.Add(termin.Rows[i]["Linea"].ToString().Trim(),
                                    termin.Rows[i]["Depto"].ToString().Trim(), cod,
                                    termin.Rows[i]["nombre"].ToString().Trim(),
                                    termin.Rows[i]["color"].ToString().Trim(),
                                    termin.Rows[i]["talla"].ToString().Trim(),
                                    exis,
                                    termin.Rows[i]["ext"].ToString().Trim(),
                                    0, 0,0, 0,max, 0);
                    }
                    if (termin.Rows[i]["Plaza"].ToString().Trim() == "6")
                    {
                        string max = "";
                        string cod = "";
                        string exis = "";
                        max = termin.Rows[i]["maximo"].ToString().Trim();
                        cod = termin.Rows[i]["codigo"].ToString().Trim();
                        exis = termin.Rows[i]["ext"].ToString().Trim();
                        if (max == "")
                        {
                            max = "0";
                        }
                        if (exis == "")
                        {
                            exis = "0";
                        }
                        dt.Rows.Add(termin.Rows[i]["Linea"].ToString().Trim(),
                                    termin.Rows[i]["Depto"].ToString().Trim(),cod,
                                    termin.Rows[i]["nombre"].ToString().Trim(),
                                    termin.Rows[i]["color"].ToString().Trim(),
                                    termin.Rows[i]["talla"].ToString().Trim(),
                                    0, 0,
                                    termin.Rows[i]["ext"].ToString().Trim(),
                                    0, 0, 0,0,0);
                    }
                    if (termin.Rows[i]["Plaza"].ToString().Trim() == "7")
                    {
                        string max = "";
                        string cod = "";
                        string exis = "";
                        max = termin.Rows[i]["maximo"].ToString().Trim();
                        cod = termin.Rows[i]["codigo"].ToString().Trim();
                        exis = termin.Rows[i]["ext"].ToString().Trim();
                        if (max == "")
                        {
                            max = "0";
                        }
                        if (exis == "")
                        {
                            exis = "0";
                        }
                        dt.Rows.Add(termin.Rows[i]["Linea"].ToString().Trim(),
                                    termin.Rows[i]["Depto"].ToString().Trim(), cod,
                                    termin.Rows[i]["nombre"].ToString().Trim(),
                                    termin.Rows[i]["color"].ToString().Trim(),
                                    termin.Rows[i]["talla"].ToString().Trim(),
                                    0, 0,0,
                                    termin.Rows[i]["ext"].ToString().Trim(),
                                    0, 0, 0,0);
                    }
                    if (termin.Rows[i]["Plaza"].ToString().Trim() == "14")
                    {
                        string max = "";
                        string cod = "";
                        string exis = "";
                        max = termin.Rows[i]["maximo"].ToString().Trim();
                        cod = termin.Rows[i]["codigo"].ToString().Trim();
                        exis = termin.Rows[i]["ext"].ToString().Trim();
                        if (max == "")
                        {
                            max = "0";
                        }
                        if (exis == "")
                        {
                            exis = "0";
                        }
                        dt.Rows.Add(termin.Rows[i]["Linea"].ToString().Trim(),
                                    termin.Rows[i]["Depto"].ToString().Trim(), cod,
                                    termin.Rows[i]["nombre"].ToString().Trim(),
                                    termin.Rows[i]["color"].ToString().Trim(),
                                    termin.Rows[i]["talla"].ToString().Trim(),
                                    0, 0, 0,0,
                                    termin.Rows[i]["ext"].ToString().Trim(),
                                    0, 0,0);
                    }
                }
                ArrayList finalizado2 = new ArrayList();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    object sumObject = new object();
                    object sumObject2 = new object();
                    object sumObject3 = new object();
                    object sumObject4 = new object();
                    object sumObject5 = new object();
                    object sumObject6 = new object();
                    string filtro = "nombre = '" + dt.Rows[i]["nombre"].ToString().Trim() + "'"
                                    +" AND color = '" + dt.Rows[i]["color"].ToString().Trim() + "'"
                                    + " AND talla = '" + dt.Rows[i]["talla"].ToString().Trim() + "'";
                    sumObject = dt.Compute("Sum(ext_liso)", filtro);
                    sumObject2 = dt.Compute("Sum(ext_qroo)", filtro);
                    sumObject3 = dt.Compute("Sum(ext_cabos)", filtro);
                    sumObject4 = dt.Compute("Sum(ext_cancun)", filtro);
                    sumObject5 = dt.Compute("Sum(ext_tulum)", filtro);
                    sumObject6 = dt.Compute("Sum(maximo)", filtro);
                    BO.Producto artic = new BO.Producto();
                    artic.Linea = dt.Rows[i]["Linea"].ToString().Trim();
                    artic.Depto = dt.Rows[i]["Depto"].ToString().Trim();
                    artic.Codigo = dt.Rows[i]["codigo"].ToString().Trim();
                    artic.Nombre = dt.Rows[i]["nombre"].ToString().Trim();
                    artic.Color = dt.Rows[i]["color"].ToString().Trim();
                    artic.Talla = dt.Rows[i]["talla"].ToString().Trim();
                    artic.Ext_liso = int.Parse(sumObject.ToString().Trim());
                    artic.Ext_qroo = int.Parse(sumObject2.ToString().Trim());
                    artic.Ext_cabos = int.Parse(sumObject3.ToString().Trim());
                    artic.Ext_cancun = int.Parse(sumObject4.ToString().Trim());
                    artic.Ext_tulum = int.Parse(sumObject5.ToString().Trim());
                    artic.Total = artic.Ext_liso + artic.Ext_qroo + artic.Ext_cabos+artic.Ext_cancun+artic.Ext_tulum;
                    artic.Maximo = int.Parse(sumObject6.ToString().Trim());
                    artic.Fabricar = artic.Total - artic.Maximo;
                    finalizado2.Add(artic);
                }
                otro = DistinctRows(otro, "codigo");
                DataTable orders3 = otro;
                EnumerableRowCollection<DataRow> query3 =
                    from order3 in orders3.AsEnumerable()
                    orderby order3.Field<string>("Linea"),
                            order3.Field<string>("Depto"),
                            order3.Field<string>("nombre"),
                            order3.Field<string>("color"),
                            order3.Field<string>("talla")
                    select order3;
                DataView view3 = query3.AsDataView();
                dataGridView7.DataSource = view3;
                DataTable otro2 = new DataTable();
                otro2.Columns.Add("Linea");
                otro2.Columns.Add("depto");
                otro2.Columns.Add("codigo");
                otro2.Columns.Add("nombre");
                otro2.Columns.Add("color");
                otro2.Columns.Add("talla");
                otro2.Columns.Add("ext_liso");
                otro2.Columns.Add("ext_qroo", typeof(int));
                otro2.Columns.Add("ext_cabos", typeof(int));
                otro2.Columns.Add("ext_cancun", typeof(int));
                otro2.Columns.Add("ext_tulum", typeof(int));
                otro2.Columns.Add("total", typeof(int));
                otro2.Columns.Add("maximo", typeof(int));
                otro2.Columns.Add("fabricar", typeof(int));
                for (int i = 0; i < dataGridView7.RowCount; i++)
                {
                    if (dataGridView7.Rows[i].Cells["Depto"].Value.ToString().Trim() != "")
                    {
                        otro2.Rows.Add(dataGridView7.Rows[i].Cells["Linea"].Value.ToString().Trim(),
                                       dataGridView7.Rows[i].Cells["Depto"].Value.ToString().Trim(),
                                       dataGridView7.Rows[i].Cells["codigo"].Value.ToString().Trim(),
                                       dataGridView7.Rows[i].Cells["nombre"].Value.ToString().Trim(),
                                       dataGridView7.Rows[i].Cells["color"].Value.ToString().Trim(),
                                       dataGridView7.Rows[i].Cells["talla"].Value.ToString().Trim(),
                                       dataGridView7.Rows[i].Cells["ext_liso"].Value.ToString().Trim(),
                                       dataGridView7.Rows[i].Cells["ext_qroo"].Value.ToString().Trim(),
                                       dataGridView7.Rows[i].Cells["ext_cabos"].Value.ToString().Trim(),
                                       dataGridView7.Rows[i].Cells["ext_cancun"].Value.ToString().Trim(),
                                       dataGridView7.Rows[i].Cells["ext_tulum"].Value.ToString().Trim(),
                                       dataGridView7.Rows[i].Cells["total"].Value.ToString().Trim(),
                                       dataGridView7.Rows[i].Cells["maximo"].Value.ToString().Trim(),
                                       dataGridView7.Rows[i].Cells["fabricar"].Value.ToString().Trim());
                    }
                }
                DataTable dt5 = new DataTable();
                dt5.Columns.Add("Linea");
                dt5.Columns.Add("depto");
                dt5.Columns.Add("codigo");
                dt5.Columns.Add("nombre");
                dt5.Columns.Add("color");
                dt5.Columns.Add("talla");
                dt5.Columns.Add("ext_liso", typeof(int));
                dt5.Columns.Add("ext_qroo", typeof(int));
                dt5.Columns.Add("ext_cabos", typeof(int));
                dt5.Columns.Add("ext_cancun", typeof(int));
                dt5.Columns.Add("ext_tulum", typeof(int));
                dt5.Columns.Add("total", typeof(int));
                dt5.Columns.Add("maximo", typeof(int));
                dt5.Columns.Add("fabricar", typeof(int));
                foreach (BO.Producto item in finalizado2)
                {
                    dt5.Rows.Add(item.Linea, item.Depto, item.Codigo, item.Nombre, item.Color, item.Talla, item.Ext_liso, item.Ext_qroo, item.Ext_cabos,
                                 item.Ext_cancun,item.Ext_tulum,item.Total, item.Maximo, item.Fabricar);
                                           
                }
                dt.Clear();
                dt = DistinctRows(dt5, "nombre","color","talla","codigo");
                int extQ = 0;
                int extC = 0;
                int extCan = 0;
                int extTul = 0;
                int total = 0;
                int max1 = 0;
                int fab = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Linea"].ToString().Trim() != "")
                    {
                        extQ = int.Parse(dt.Rows[i]["ext_qroo"].ToString().Trim());
                        extC = int.Parse(dt.Rows[i]["ext_cabos"].ToString().Trim());
                        extCan = int.Parse(dt.Rows[i]["ext_cancun"].ToString().Trim());
                        extTul = int.Parse(dt.Rows[i]["ext_tulum"].ToString().Trim());
                        total = extQ + extC+extCan;
                        max1 = int.Parse(dt.Rows[i]["maximo"].ToString().Trim());
                        fab = total - max1;
                        otro2.Rows.Add(dt.Rows[i]["Linea"].ToString().Trim(),
                                       dt.Rows[i]["Depto"].ToString().Trim(),
                                       dt.Rows[i]["codigo"].ToString().Trim(),
                                       dt.Rows[i]["nombre"].ToString().Trim(),
                                       dt.Rows[i]["color"].ToString().Trim(),
                                       dt.Rows[i]["talla"].ToString().Trim(),
                                       0,
                                       extQ,
                                       extC,
                                       extCan,
                                       extTul,
                                       total,
                                       max1,
                                       fab);
                    }
                }
                DataTable orders7 = otro2;
                EnumerableRowCollection<DataRow> query7 =
                    from order7 in orders7.AsEnumerable()
                    orderby order7.Field<string>("Linea"),
                            order7.Field<string>("Depto"),
                            order7.Field<string>("nombre"),
                            order7.Field<string>("color"),
                            order7.Field<string>("talla")
                    select order7;
                DataView view7 = query7.AsDataView();
                dataGridView7.DataSource = view7;
                dt.Clear();
                for (int i = 0; i < dataGridView7.RowCount; i++)
                {
                    if (dataGridView7.Rows[i].Cells["Linea"].Value.ToString().Trim() != "")
                    {
                        dt.Rows.Add(dataGridView7.Rows[i].Cells["Linea"].Value.ToString().Trim(),
                                    dataGridView7.Rows[i].Cells["Depto"].Value.ToString().Trim(),
                                    dataGridView7.Rows[i].Cells["codigo"].Value.ToString().Trim(),
                                    dataGridView7.Rows[i].Cells["nombre"].Value.ToString().Trim(),
                                    dataGridView7.Rows[i].Cells["color"].Value.ToString().Trim(),
                                    dataGridView7.Rows[i].Cells["talla"].Value.ToString().Trim(),
                                    dataGridView7.Rows[i].Cells["ext_liso"].Value.ToString().Trim(),
                                    dataGridView7.Rows[i].Cells["ext_qroo"].Value.ToString().Trim(),
                                    dataGridView7.Rows[i].Cells["ext_cabos"].Value.ToString().Trim(),
                                    dataGridView7.Rows[i].Cells["ext_cancun"].Value.ToString().Trim(),
                                    dataGridView7.Rows[i].Cells["ext_tulum"].Value.ToString().Trim(),
                                    dataGridView7.Rows[i].Cells["total"].Value.ToString().Trim(),
                                    dataGridView7.Rows[i].Cells["maximo"].Value.ToString().Trim(),
                                    dataGridView7.Rows[i].Cells["fabricar"].Value.ToString().Trim());
                    }
                }
                DataTable dt9 = new DataTable();
                dt9.Columns.Add("Linea");
                dt9.Columns.Add("depto");
                dt9.Columns.Add("codigo");
                dt9.Columns.Add("nombre");
                dt9.Columns.Add("color");
                dt9.Columns.Add("talla");
                dt9.Columns.Add("ext_liso");
                dt9.Columns.Add("ext_qroo", typeof(int));
                dt9.Columns.Add("ext_cabos", typeof(int));
                dt9.Columns.Add("ext_cancun", typeof(int));
                dt9.Columns.Add("ext_tulum", typeof(int));
                dt9.Columns.Add("total", typeof(int));
                dt9.Columns.Add("maximo", typeof(int));
                dt9.Columns.Add("fabricar", typeof(int));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Linea"].ToString().Trim() == "BCO/NEG")
                    {
                        dt9.Rows.Add(dt.Rows[i]["Linea"],
                                     dt.Rows[i]["depto"],
                                     dt.Rows[i]["codigo"], 
                                     dt.Rows[i]["nombre"],
                                     dt.Rows[i]["color"],
                                     dt.Rows[i]["talla"],
                                     "N/T",
                                     dt.Rows[i]["ext_qroo"],
                                     dt.Rows[i]["ext_cabos"],
                                     dt.Rows[i]["ext_cancun"],
                                     dt.Rows[i]["ext_tulum"],
                                     dt.Rows[i]["total"],
                                     dt.Rows[i]["maximo"],
                                     dt.Rows[i]["fabricar"]);
                    }
                    else
                    {
                        dt9.Rows.Add(dt.Rows[i]["Linea"],
                                     dt.Rows[i]["depto"],
                                     dt.Rows[i]["codigo"],
                                     dt.Rows[i]["nombre"],
                                     dt.Rows[i]["color"],
                                     dt.Rows[i]["talla"],
                                     dt.Rows[i]["ext_liso"],
                                     dt.Rows[i]["ext_qroo"],
                                     dt.Rows[i]["ext_cabos"],
                                     dt.Rows[i]["ext_cancun"],
                                     dt.Rows[i]["ext_tulum"],
                                     dt.Rows[i]["total"],
                                     dt.Rows[i]["maximo"],
                                     dt.Rows[i]["fabricar"]);
                    }
                }
                RepEquivalenciasBcoNeg reporte = new RepEquivalenciasBcoNeg();
                reporte.SetDataSource(dt9);
                crystalReportViewer1.ReportSource = reporte;
            }
            catch 
            {
                MessageBox.Show("Hubo un error\nVerifica tu Conexión con la base de datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static DataTable DistinctRows(DataTable tb, string ColumnName)
        {
            DataTable shortTable = null; //tabla que se regresara
            string val = "";  //variable filtro
            shortTable = new DataTable(); // Inicializa nueva tabla
            try
            {
                shortTable = tb.Clone(); // Clona tabla Source
                shortTable.ImportRow(tb.Rows[0]);//Agrega el primer registro
                val = shortTable.Rows[0][ColumnName].ToString(); //agrega valor filtro a la variable
                foreach (DataRow dr in tb.Rows)
                {
                    if (val != dr[ColumnName].ToString()) //Compara contenido del registro, si son iguales los descarata sino agrega registro a la nueva tabla
                    {
                        shortTable.ImportRow(dr); //importa Registro a la nueva tabla 
                    }
                    val = dr[ColumnName].ToString(); //Siguiente valor del filtro
                }
                return shortTable; //Regresa nueva tabla
            }
            catch
            {
                return null;
            }
        }
        public static DataTable DistinctRows(DataTable tb, string ColumnName,string column,string column2,string maxi)
        {
            DataTable shortTable = null; //tabla que se regresara
            string val = "";  //variable filtro
            string val2 = "";  //variable filtro
            string val3= "";  //variable filtro
            string val4 = "";  //variable filtro
            shortTable = new DataTable(); // Inicializa nueva tabla
            try
            {
                shortTable = tb.Clone(); // Clona tabla Source
                shortTable.ImportRow(tb.Rows[0]);//Agrega el primer registro
                val = shortTable.Rows[0][ColumnName].ToString(); //agrega valor filtro a la variable
                val2 = shortTable.Rows[0][column].ToString(); //agrega valor filtro a la variable
                val3 = shortTable.Rows[0][column2].ToString(); //agrega valor filtro a la variable
                val4 = shortTable.Rows[0][maxi].ToString(); //agrega valor filtro a la variable
                foreach (DataRow dr in tb.Rows)
                {
                    if (val4 != "")
                    {
                        //Compara contenido del registro, si son iguales los descarta sino agrega registro a la nueva tabla
                        if (val.ToLower() != dr[ColumnName].ToString().ToLower() || val2.ToLower() != dr[column].ToString().ToLower() || 
                            val3.ToLower() != dr[column2].ToString().ToLower()) 
                        {
                            shortTable.ImportRow(dr); //importa Registro a la nueva tabla 
                        }
                    }
                    val = dr[ColumnName].ToString(); //Siguiente valor del filtro
                    val2 = dr[column].ToString(); //Siguiente valor del filtro
                    val3 = dr[column2].ToString(); //Siguiente valor del filtro
                    val4 = dr[maxi].ToString(); //Siguiente valor del filtro
                }
                return shortTable; //Regresa nueva tabla
            }
            catch
            {
                return null;
            }
        }
        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string codigo = "";
                string codigos = "";
                if (dataGridView3.SelectedRows.Count > 0)
                {
                    codigo = dataGridView3.SelectedRows[0].Cells["CodigoRelacion1"].Value.ToString().Trim();
                    Consulta dao = new Consulta();
                    if (rbtnLiso.Checked == true)
                    {
                        dataGridView6.DataSource = dao.ConsultaRelacionFiltrada(3, codigo);
                        for (int i = 0; i < dataGridView6.RowCount; i++)
                        {
                            codigos = codigos + "'" + dataGridView6.Rows[i].Cells["CodigoBordado"].Value.ToString().Trim() + "',";
                        }
                        codigos = codigos.TrimEnd(',');
                        DataTable dt = new DataTable();
                        dt = dao.ConsultaArticuloLiso(1, codigos);
                        dt.Columns.Add("Estado");
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            for (int i = 0; i < dataGridView6.RowCount; i++)
                            {
                                if (dt.Rows[j]["Codigo"].ToString().Trim() == dataGridView6.Rows[i].Cells["CodigoBordado"].Value.ToString().Trim())
                                {
                                    string activo = dataGridView6.Rows[i].Cells["Activo"].Value.ToString().Trim();
                                    if (activo == "1")
                                    {
                                        dt.Rows[j]["Estado"] = true;
                                    }
                                    if (activo == "0")
                                    {
                                        dt.Rows[j]["Estado"] = false;
                                    }
                                }
                            }
                        }
                        dataGridView4.DataSource = dt;
                    }
                    if (rbtnTrabajado.Checked == true)
                    {
                        dataGridView6.DataSource = dao.ConsultaRelacionFiltrada2(3, codigo);
                        for (int i = 0; i < dataGridView6.RowCount; i++)
                        {
                            codigos = codigos + "'" + dataGridView6.Rows[i].Cells["CodigoLiso"].Value.ToString().Trim() + "',";
                        }
                        codigos = codigos.TrimEnd(',');
                        DataTable dt = new DataTable();
                        dt = dao.ConsultaArticuloLiso(1, codigos);
                        dt.Columns.Add("Estado");
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            for (int i = 0; i < dataGridView6.RowCount; i++)
                            {
                                if (dt.Rows[j]["Codigo"].ToString().Trim() == dataGridView6.Rows[i].Cells["CodigoLiso"].Value.ToString().Trim())
                                {
                                    string activo = dataGridView6.Rows[i].Cells["Activo"].Value.ToString().Trim();
                                    if (activo == "1")
                                    {
                                        dt.Rows[j]["Estado"] = true;
                                    }
                                    if (activo == "0")
                                    {
                                        dt.Rows[j]["Estado"] = false;
                                    }
                                }
                            }
                        }
                        dataGridView4.DataSource = dt;
                    }
                    txtCodigoArriba.Text = dataGridView3.SelectedRows[0].Cells["CodigoRelacion1"].Value.ToString().Trim();
                }
            }
            catch
            {
                MessageBox.Show("Hubo un error con la conexión a la base de datos", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
        }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
