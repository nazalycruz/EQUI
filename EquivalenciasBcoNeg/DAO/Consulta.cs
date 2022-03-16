using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EquivalenciasBcoNeg.DAO
{
    class Consulta
    {
        Conexion con = new Conexion();
        string oplaza, osucursal;
        //Apartado de Consultas Básicas, principales
        public void LimpiarLineas(CheckedListBox chklLineas)
        {
            for (int i = 0; i < chklLineas.Items.Count; i++)
            {
                chklLineas.SetItemChecked(i, false);
            }
        }
        public DataTable ConsultaPlazas(int cont)
        {
            //Método Para cargar el ListCheckBox con las Plazas            
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(cont);
            con.AbrirConexion();
            string cadena = "SELECT ID_Plaza AS id_plaza, Descripcion AS descripcion FROM Plazas WHERE activa=1 AND descripcion NOT IN ('TULUM')";
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(a);
            con.CerrarConexion();
            return a;
        }
        public DataTable ConsultaSucursal(int cont)
        {
            //Método Para cargar el ListCheckBox con las sucursales
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(cont);
            con.AbrirConexion();
            string cadena = "SELECT  s.Alias, s.suc_id AS id_suc FROM sw_cat_suc s  WHERE numalias!=-1 AND numalias!=1111  AND numalias!=111 "
                            + " AND numalias!=102 AND numalias!=150 AND numalias!=121 AND numalias!=88 AND numalias!=122 AND numalias!=133 "
                            + " AND numalias!=70 AND numalias!=44 AND numalias!=140 AND numalias!=170 AND numalias!=99 AND numalias!=180 AND numalias!=55 ORDER BY Alias";
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(a);
            con.CerrarConexion();
            return a;
        }
        public DataTable ConsultaArticulo(int cont,string filtro)
        {
            //Método Para cargar el ListCheckBox con los articulos
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(cont);
            con.AbrirConexion();
            string cadena = "SELECT DISTINCT artic.nombre  FROM sw_cat_artic artic "
                            +" INNER JOIN sw_cat_linea lin ON lin.Linea_id=artic.Linea_id"
                            +" WHERE artic.nombre!=' ' AND lin.nombre LIKE "+filtro+" ORDER BY artic.nombre";
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(a);
            con.CerrarConexion();
            return a;
        }
        public DataTable ConsultaColor(int cont,string filtro)
        {
            //Método Para cargar el ListCheckBox con los colores
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(cont);
            con.AbrirConexion();
            string cadena = "SELECT DISTINCT Nombre2 AS Nombre FROM sw_cat_artic artic "
                            + " INNER JOIN sw_cat_linea lin ON lin.Linea_id=artic.Linea_id"
                            + " WHERE nombre2!=' ' AND lin.nombre LIKE " + filtro + " ORDER BY Nombre2";
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(a);
            con.CerrarConexion();
            return a;
        }
        public DataTable ConsultaTalla(int cont,string filtro)
        {
            //Método Para cargar el ListCheckBox con las tallas
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(cont);
            con.AbrirConexion();
            string cadena = "SELECT DISTINCT RTRIM(clasif) AS Nombre FROM sw_cat_artic artic "
                            + " INNER JOIN sw_cat_linea lin ON lin.Linea_id=artic.Linea_id"
                            + " WHERE artic.clasif!=' ' AND lin.nombre LIKE " + filtro + " ORDER BY RTRIM(clasif)";
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(a);
            con.CerrarConexion();
            return a;
        }
        public DataTable ConsultaCodigo(int cont, string filtro)
        {
            //Método Para cargar el ListCheckBox con las tallas
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(cont);
            con.AbrirConexion();
            string cadena = "SELECT DISTINCT artic.codigo FROM sw_cat_artic artic "
                            + " INNER JOIN sw_cat_linea lin ON lin.Linea_id=artic.Linea_id"
                            + " WHERE artic.codigo!=' ' AND lin.nombre LIKE " + filtro + " ORDER BY artic.codigo";
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(a);
            con.CerrarConexion();
            return a;
        }
        public DataTable ConsultaArticulo2(int cont, string filtro,string plaza)
        {
            //Método Para cargar el ListCheckBox con los articulos
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(cont);
            con.AbrirConexion();
            string cadena = "SELECT DISTINCT artic.nombre FROM sw_cat_artic artic "
                            + " INNER JOIN sw_cat_linea lin ON lin.Linea_id=artic.Linea_id"
                            + " WHERE artic.nombre!=' ' AND lin.nombre LIKE " + filtro + " AND clasif2='" + plaza + "' ORDER BY artic.nombre";
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(a);
            con.CerrarConexion();
            return a;
        }
        public DataTable ConsultaColor2(int cont, string filtro,string plaza)
        {
            //Método Para cargar el ListCheckBox con los colores
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(cont);
            con.AbrirConexion();
            string cadena = "SELECT DISTINCT Nombre2 AS Nombre FROM sw_cat_artic artic "
                            + " INNER JOIN sw_cat_linea lin ON lin.Linea_id=artic.Linea_id"
                            + " WHERE nombre2!=' ' AND lin.nombre LIKE " + filtro + " AND clasif2='"+plaza+"' ORDER BY Nombre2";
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(a);
            con.CerrarConexion();
            return a;
        }
        public DataTable ConsultaTalla2(int cont, string filtro,string plaza)
        {
            //Método Para cargar el ListCheckBox con las tallas
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(cont);
            con.AbrirConexion();
            string cadena = "SELECT DISTINCT RTRIM(clasif) AS Nombre FROM sw_cat_artic artic "
                            + " INNER JOIN sw_cat_linea lin ON lin.Linea_id=artic.Linea_id"
                            + " WHERE artic.clasif!=' ' AND lin.nombre LIKE " + filtro + " AND clasif2='" + plaza + "' ORDER BY RTRIM(clasif)";
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(a);
            con.CerrarConexion();
            return a;
        }
        public DataTable ConsultaCodigo2(int cont, string filtro,string plaza)
        {
            //Método Para cargar el ListCheckBox con las tallas
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(cont);
            con.AbrirConexion();
            string cadena = "SELECT DISTINCT artic.codigo FROM sw_cat_artic artic "
                            + " INNER JOIN sw_cat_linea lin ON lin.Linea_id=artic.Linea_id"
                            + " WHERE artic.codigo!=' ' AND lin.nombre LIKE " + filtro + " AND clasif2='" + plaza + "' ORDER BY artic.codigo";
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(a);
            con.CerrarConexion();
            return a;
        }
        //Filtro Final
        public string cadena(string sucur, string lin, string dep, string art, string col, string tall)
        {
            string filtros = "";
            if (sucur != "") { filtros = filtros + " AND c.suc_id IN (" + sucur + ")"; }
            if (lin != "") { filtros = filtros + " AND c.linea IN (" + lin + ") "; }
            if (dep != "") { filtros = filtros + " AND c.Dpto IN (" + dep + ")"; }
            if (art != "") { filtros = filtros + " AND c.articulo IN (" + art + ")"; }
            if (col != "") { filtros = filtros + " AND c.TipoColor IN (" + col + ")"; }
            if (tall != "") { filtros = filtros + "  AND c.talla IN (" + tall + ")"; }
            return filtros;
        }
        public DataTable consultaPlazaSuc(int id, int cont)
        {
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(cont);
            con.AbrirConexion();
            string cadena = "SELECT p.descripcion, p.id_plaza, s.nombre, s.[Alias],s.suc_id FROM plaza_sucursal ps INNER JOIN plazas p ON ps.plaza_id = p.id_plaza "
                            + "INNER JOIN sw_cat_suc s ON ps.suc_id = s.suc_id WHERE p.id_plaza=" + id + "  ORDER BY p.descripcion";
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(a);
            con.CerrarConexion();
            return a;
        }
        public string plazas(CheckedListBox chl, int cont)
        {
            //Método para obtener las sucursales de las plazas seleccionadas
            oplaza = "";
            if (chl.CheckedItems.Count != 0)
            {
                foreach (DataRowView FilaSeleccionados in chl.CheckedItems)
                {
                    int id = int.Parse(FilaSeleccionados["id_plaza"].ToString().Trim());
                    foreach (DataRow row in consultaPlazaSuc(id, cont).Rows)
                    {
                        oplaza = oplaza + row[4].ToString() + ",";
                    }
                }
                oplaza = oplaza.TrimEnd(',');
            }
            return oplaza;
        }
        public string sucursales(CheckedListBox chl, CheckedListBox chPlaza, int cont)
        {
            //Método para anexar las sucursales a las plazas seleccionas o simplemente obtener las sucursales seleccionadas
            osucursal = "";
            osucursal = plazas(chPlaza, cont);
            int bandera = 0;
            if (osucursal == "") { bandera = 0; }
            if (osucursal != "") { bandera = 1; }
            if (bandera == 0)
            {
                if (chl.CheckedItems.Count != 0)
                {
                    foreach (DataRowView FilaSeleccionados in chl.CheckedItems)
                    {
                        osucursal = osucursal + "'" + FilaSeleccionados["id_suc"].ToString().Trim() + "',";
                    }
                    osucursal = osucursal.TrimEnd(',');
                }
            }
            if (bandera != 0)
            {
                if (chl.CheckedItems.Count != 0)
                {
                    foreach (DataRowView FilaSeleccionados in chl.CheckedItems)
                    {
                        osucursal = osucursal + ",'" + FilaSeleccionados["id_suc"].ToString().Trim() + "'";
                    }
                    osucursal = osucursal.TrimEnd(',');
                }
            }
            return osucursal;
        }
        public string Articulos(CheckedListBox chl)
        {
            //Método para obtener los articulos seleccionados
            string num_plaza = "";
            if (chl.CheckedItems.Count != 0)
            {
                foreach (DataRowView FilaSeleccionados in chl.CheckedItems)
                {
                    num_plaza = num_plaza + "'" + FilaSeleccionados["Nombre"].ToString().Trim() + "',";
                }
                num_plaza = num_plaza.TrimEnd(',');
            }
            return num_plaza;
        }
        public string Colores(CheckedListBox chl)
        {
            //Método para obtener los colores seleccionados
            string num_plaza = "";
            if (chl.CheckedItems.Count != 0)
            {
                foreach (DataRowView FilaSeleccionados in chl.CheckedItems)
                {
                    num_plaza = num_plaza + "'" + FilaSeleccionados["Nombre"].ToString().Trim() + "',";
                }
                num_plaza = num_plaza.TrimEnd(',');
            }
            return num_plaza;
        }
        public string Tallas(CheckedListBox chl)
        {
            //Método para obtener las tallas seleccionadas
            string num_plaza = "";
            if (chl.CheckedItems.Count != 0)
            {
                foreach (DataRowView FilaSeleccionados in chl.CheckedItems)
                {
                    num_plaza = num_plaza + "'" + FilaSeleccionados["Nombre"].ToString().Trim() + "',";
                }
                num_plaza = num_plaza.TrimEnd(',');
            }
            return num_plaza;
        }
        public string Codigos(CheckedListBox chl)
        {
            //Método para obtener las tallas seleccionadas
            string num_plaza = "";
            if (chl.CheckedItems.Count != 0)
            {
                foreach (DataRowView FilaSeleccionados in chl.CheckedItems)
                {
                    num_plaza = num_plaza + "'" + FilaSeleccionados["Codigo"].ToString().Trim() + "',";
                }
                num_plaza = num_plaza.TrimEnd(',');
            }
            return num_plaza;
        }
        public DataTable ConsultaArticuloData(int cont, string filtro)
        {
            //Método Para cargar el ListCheckBox con los articulos
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(cont);
            con.AbrirConexion();
            string cadena = "SELECT DISTINCT artic.nombre AS Articulo,artic.nombre2 AS Color, artic.clasif AS Talla, artic.Codigo  FROM sw_cat_artic artic "
                            + " INNER JOIN sw_cat_linea lin ON lin.Linea_id=artic.Linea_id"
                            + " WHERE artic.nombre!=' ' AND lin.nombre LIKE " + filtro + " ORDER BY artic.nombre,artic.nombre2,artic.clasif";
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(a);
            con.CerrarConexion();
            return a;
        }
        public void InsertarRelacion(int cont,string filtro)
        {
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(cont);
            con.AbrirConexion();
            string cadena = filtro;
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            con.CerrarConexion();
        }
        public void EditarRelacion(int cont, string filtro)
        {
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(cont);
            con.AbrirConexion();
            string cadena = filtro;
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            con.CerrarConexion();
        }
        public DataTable ConsultaArticuloLiso(int cont, string filtro)
        {
            //Método Para cargar el ListCheckBox con los articulos
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(cont);
            con.AbrirConexion();
            string cadena = "SELECT lin.nombre AS Linea,depto.nombre AS Depto, artic.nombre AS Articulo,"
                             + " artic.nombre2 AS Color, artic.clasif AS Talla,artic.codigo, pla.Descripcion AS Plaza"
                             + " FROM sw_cat_artic artic"
                             + " INNER JOIN sw_cat_linea lin ON lin.linea_id=artic.linea_id"
                             + " INNER JOIN sw_cat_dpto depto ON depto.dpto_id=artic.depto_id"
                             + " INNER JOIN Plazas pla ON pla.id_plaza=artic.clasif2"
                             + " WHERE artic.codigo IN (" + filtro + ")"
                             + " AND artic.status=0 "
                             + " ORDER BY artic.clasif2, lin.nombre,depto.nombre,artic.nombre,artic.nombre2,artic.clasif";
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(a);
            con.CerrarConexion();
            return a;
        }
        public DataTable ConsultaArticuloTerminado(int cont, string filtro)
        {
            //Método Para cargar el ListCheckBox con los articulos
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(cont);
            con.AbrirConexion();
            string cadena = "SELECT lin.nombre AS Linea,depto.nombre AS Depto, artic.nombre AS Articulo,"
                            +" artic.nombre2 AS Color, artic.clasif AS Talla,artic.codigo, pla.Descripcion AS Plaza"
                            +" FROM sw_cat_artic artic"
                            +" INNER JOIN sw_cat_linea lin ON lin.linea_id=artic.linea_id"
                            +" INNER JOIN sw_cat_dpto depto ON depto.dpto_id=artic.depto_id"
                            +" INNER JOIN Plazas pla ON pla.id_plaza=artic.clasif2"
                            +" WHERE artic.codigo IN ("+filtro+")"
                            + " AND artic.status=0 AND lin.nombre Like 'Bco/neg%'"
                            +" ORDER BY artic.clasif2, lin.nombre,depto.nombre,artic.nombre,artic.nombre2,artic.clasif";
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(a);
            con.CerrarConexion();
            return a;
        }
        public DataTable ConsultaRelacionActiva(int cont)
        {
            //Método Para cargar el ListCheckBox con los articulos
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(cont);
            con.AbrirConexion();
            string cadena = "SELECT * FROM EquivalenciasBcoNeg WHERE activo=1";
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(a);
            con.CerrarConexion();
            return a;
        }
        public DataTable ConsultaRelacionDisactiva(int cont)
        {
            //Método Para cargar el ListCheckBox con los articulos
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(cont);
            con.AbrirConexion();
            string cadena = "SELECT * FROM EquivalenciasBcoNeg WHERE activo=0";
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(a);
            con.CerrarConexion();
            return a;
        }
        public DataTable ConsultaRelacion(int cont)
        {
            //Método Para cargar el ListCheckBox con los articulos
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(cont);
            con.AbrirConexion();
            string cadena = "SELECT * FROM EquivalenciasBcoNeg";
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(a);
            con.CerrarConexion();
            return a;
        }
        public DataTable ConsultaRelacionFiltrada(int cont,string codigo)
        {
            //Método Para cargar el ListCheckBox con los articulos
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(cont);
            con.AbrirConexion();
            string cadena = "SELECT * FROM EquivalenciasBcoNeg WHERE codigoLiso='"+codigo+"'";
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(a);
            con.CerrarConexion();
            return a;
        }
        public DataTable ConsultaRelacionFiltrada2(int cont, string codigo)
        {
            //Método Para cargar el ListCheckBox con los articulos
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(cont);
            con.AbrirConexion();
            string cadena = "SELECT * FROM EquivalenciasBcoNeg WHERE codigoBordado='" + codigo + "' ";
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(a);
            con.CerrarConexion();
            return a;
        }
        public DataTable ConsultaCodigoLiso(int cont)
        {
            //Método Para cargar el ListCheckBox con los articulos
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(cont);
            con.AbrirConexion();
            string cadena = "SELECT codigoliso FROM EquivalenciasBcoNeg WHERE activo=1";
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(a);
            con.CerrarConexion();
            return a;
        }
        public DataTable ConsultaDatosLisos(int cont,string codigos)
        {
            //Método Para cargar el ListCheckBox con los articulos
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(3);
            con.AbrirConexion();
            string plaza = "";
            DataTable does = new DataTable();
            does = ConsultaPlazas(1);
            for (int i = 0; i < does.Rows.Count; i++)
            {
                plaza = plaza + "'" + does.Rows[i]["id_plaza"].ToString().Trim() + "',";
            }
            plaza = plaza.TrimEnd(',');
            string cadena = "SELECT   c.linea,c.Dpto AS Depto,c.Articulo AS nombre, c.TipoColor AS Color, c.Talla, c.codigo, "
                            + " CAST(c.stockmax AS int) AS Maximo, CAST(c.existencia AS int) AS ext_liso"
                            + " FROM _ConsDETExistenciasSucursales c "
                            + " WHERE (c.stockmax > 0 OR c.existencia >= 0)  "
                            + " AND c.codigo IN ("+codigos+") AND c.linea LIKE 'BCO%NEG%' AND c.clasif2 IN ("+plaza+")"
                            + " ORDER BY Linea,Dpto,Articulo,TipoColor,Talla ";
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(a);
            con.CerrarConexion();
            return a;
        }
        public DataTable ConsultaCodigoBordado(int cont)
        {
            //Método Para cargar el ListCheckBox con los articulos
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(cont);
            con.AbrirConexion();
            string cadena = "SELECT codigoBordado,codigoliso FROM EquivalenciasBcoNeg WHERE activo=1";
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(a);
            con.CerrarConexion();
            return a;
        }
        public DataTable ConsultaDatosTerminado(int cont, string codigos,string suc)
        {
            //Método Para cargar el ListCheckBox con los articulos
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(3);
            con.AbrirConexion();
            string plaza = "";
            DataTable does = new DataTable();
            does = ConsultaPlazas(1);
            for (int i = 0; i < does.Rows.Count; i++)
            {
                plaza = plaza + "'" + does.Rows[i]["id_plaza"].ToString().Trim() + "',";
            }
            plaza = plaza.TrimEnd(',');
            string cadena = "SELECT c.linea AS Linea,c.Dpto AS Depto,c.Articulo AS nombre, c.TipoColor AS Color, c.Talla, c.codigo, "
                            + " c.clasif2 AS Plaza,CAST(SUM(c.existencia) AS int) AS ext"
                            + " FROM _ConsDETExistenciasSucursales c "
                            + " WHERE (c.stockmax > 0 OR c.existencia >= 0)  "
                            + " AND c.codigo IN (" + codigos + ") AND c.linea LIKE 'BCO/NEG' AND c.clasif2 IN ("+plaza+")"
                            + " GROUP BY c.linea, c.dpto,c.articulo,c.tipocolor,c.talla,c.codigo,c.clasif2"
                            + " ORDER BY linea,Dpto,Articulo,TipoColor,Talla ";
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(a);
            con.CerrarConexion();
            return a;
        }
        public DataTable ConsultaDatosTerminado2(int cont, string codigos, string suc)
        {
            //Método Para cargar el ListCheckBox con los articulos
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(3);
            con.AbrirConexion();
            string plaza = "";
            DataTable does = new DataTable();
            does = ConsultaPlazas(1);
            for (int i = 0; i < does.Rows.Count; i++)
            {
                plaza = plaza + "'" + does.Rows[i]["id_plaza"].ToString().Trim() + "',";
            }
            plaza = plaza.TrimEnd(',');
            string cadena = "SELECT c.linea AS Linea,c.Dpto AS Depto,c.Articulo AS nombre, c.TipoColor AS Color, c.Talla, "
                            + " c.clasif2 AS Plaza,CAST(SUM(c.existencia) AS int) AS ext,CAST(c.stockmax AS int) AS Maximo,c.codigo"
                            + " FROM _ConsDETExistenciasSucursales c "
                            + " WHERE (c.stockmax > 0 OR c.existencia >= 0)  "
                            + " AND c.clasif2 IN ("+plaza+")"
                            + " AND c.codigo NOT IN (" + codigos + ") AND c.linea LIKE 'BCO/NEG'"
                            + " GROUP BY c.linea,c.dpto,c.articulo,c.tipocolor,c.talla,c.clasif2,c.stockmax,c.codigo"
                            + " ORDER BY linea,Dpto,Articulo,TipoColor,Talla,clasif2";
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(a);
            con.CerrarConexion();
            return a;
        }
        public DataTable ConsultaDatosTerminado2(int cont, string codigos)
        {
            //Método Para cargar el ListCheckBox con los articulos
            DataTable a = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con.conexion(3);
            con.AbrirConexion();
            string plaza = "";
            DataTable does = new DataTable();
            does = ConsultaPlazas(1);
            for (int i = 0; i < does.Rows.Count; i++)
            {
                plaza = plaza + "'" + does.Rows[i]["id_plaza"].ToString().Trim() + "',";
            }
            plaza = plaza.TrimEnd(',');
            string cadena = "SELECT   CAST(c.Existencia AS int) AS ext_liso, CAST(c.stockmax AS int) AS Maximo,c.codigo"
                            + " FROM _ConsDETExistenciasSucursales c "
                            + " WHERE (c.stockmax > 0 OR c.existencia >= 0)  "
                            + codigos + " AND c.linea LIKE 'BCO/NEG' AND c.clasif2 IN ("+plaza+")"
                            + " ORDER BY Dpto,Articulo,TipoColor,Talla ";
            cmd.CommandText = cadena;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(a);
            con.CerrarConexion();
            return a;
        }
    }
}
