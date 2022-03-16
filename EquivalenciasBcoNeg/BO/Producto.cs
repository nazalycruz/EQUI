using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquivalenciasBcoNeg.BO
{
    class Producto
    {
        string nombre;
        string plaza;
        string alias;
        string existencias;
        string codigo;
        int maximo;
        string color;
        string talla;
        string linea;
        string activo;
        int ext_qroo;
        int ext_cabos;
        int ext_liso;
        int total;
        int fabricar;
        string depto;
        int ext_cancun;
        int ext_tulum;
        public int Ext_tulum
        {
            get { return ext_tulum; }
            set { ext_tulum = value; }
        }
        public int Ext_cancun
        {
            get { return ext_cancun; }
            set { ext_cancun = value; }
        }
        public string Depto
        {
            get { return depto; }
            set { depto = value; }
        }
        public int Fabricar
        {
            get { return fabricar; }
            set { fabricar = value; }
        }
        public int Total
        {
            get { return total; }
            set { total = value; }
        }
        public int Ext_liso
        {
            get { return ext_liso; }
            set { ext_liso = value; }
        }
        public int Ext_cabos
        {
            get { return ext_cabos; }
            set { ext_cabos = value; }
        }
        public int Ext_qroo
        {
            get { return ext_qroo; }
            set { ext_qroo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Plaza
        {
            get { return plaza; }
            set { plaza = value; }
        }
        public string Alias
        {
            get { return alias; }
            set { alias = value; }
        }
        public string Existencias
        {
            get { return existencias; }
            set { existencias = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int Maximo
        {
            get { return maximo; }
            set { maximo = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Talla
        {
            get { return talla; }
            set { talla = value; }
        }
        public string Linea
        {
            get { return linea; }
            set { linea = value; }
        }
        public string Activo
        {
            get { return activo; }
            set { activo = value; }
        }
    }
}
