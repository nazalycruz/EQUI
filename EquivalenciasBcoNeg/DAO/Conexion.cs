using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EquivalenciasBcoNeg.DAO
{
    class Conexion
    {
        SqlConnection cnn;
        public SqlConnection conexion(int con)
        {
            cnn = new SqlConnection();
            if (con == 1) { cnn.ConnectionString = "Server=SERVER2;Database=sw;User Id=MrBuh0; Password=H4d4d2017;"; }
            if (con == 2) { cnn.ConnectionString = "Server=201.99.103.114,1500;Database=cs_gpo_hadad;User Id=sa; Password=brutus;"; }
            if (con == 3) { cnn.ConnectionString = "data source=ANGUAS-PC; User ID=sa; Password=brutus; Database=sw;  Integrated Security=false;Connect Timeout=9000"; }
            if (con == 4) { cnn.ConnectionString = "data source=(local); User ID=sa; Password=brutus; Database=sw;  Integrated Security=false;Connect Timeout=9000"; }
            return cnn;
        }
        public void AbrirConexion()
        {
            cnn.Open();
        }
        public void CerrarConexion()
        {
            cnn.Close();
        }
    }
}
