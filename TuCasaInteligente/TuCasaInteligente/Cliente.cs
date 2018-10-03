using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuCasaInteligente
{
    class Cliente
    {

        #region Atributos
        string nombre;
        int fecha;
        string correo;
        string ocupacion;
        int celular;
        int telCasa;
        short codigopostal;
        string domicilio;
        string usuario;
        string contraseña;
        
        #endregion

        #region Propiedades
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public int Fecha
        {
            get => fecha;
            set => fecha = value;
        }

        public string Correo
        {
            get => correo;
            set => correo = value;
        }

        public string Ocupacion
        {
            get => ocupacion;
            set => ocupacion = value;
        }

        public int Celular
        {
            get => celular;
            set => celular = value;
        }

        public int TelCasa
        {
            get => telCasa;
            set => telCasa = value;
        }

        public short Codigopostal
        {
            get => codigopostal;
            set => codigopostal = value;
        }

        public string Domicilio
        {
            get => domicilio;
            set => domicilio = value;
        }

        public string Usuario
        {
            get => usuario;
            set => usuario = value;
        }

        public string Contraseña
        {
            get => contraseña;
            set => contraseña = value;
        }

        #endregion

        #region Constructor
        public Cliente(string nombre, int fecha, string correo, string ocupacion, int celular, int telCasa, short codigopostal, string domicilio, string usuario, string contraseña)
        {
            this.Nombre = nombre;
            this.Fecha = fecha;
            this.Correo = correo;
            this.Ocupacion = ocupacion;
            this.Celular = celular;
            this.TelCasa = telCasa;
            this.Codigopostal = codigopostal;
            this.Domicilio = domicilio;
            this.Usuario = usuario;
            this.Contraseña = contraseña;
        }
        #endregion

    }
}
