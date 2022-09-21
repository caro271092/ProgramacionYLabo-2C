using System;
using System.Text;

namespace EjercicioIntegrador_ParaisosFiscales
{
    public class Cliente
    {
        private string _aliasParaIncognito;
        private string _nombre;
        private eTipoCliente _tipoCliente;
        private Cliente()
        {
            this._nombre = "NN";
            this._aliasParaIncognito = "SinAlias";
            this._tipoCliente = eTipoCliente.SinTipo;
        }
        public Cliente(eTipoCliente tipoCliente): this()
        {
            _tipoCliente = tipoCliente;
        }

        public Cliente(eTipoCliente tipoCliente, string nombre):this(tipoCliente)
        {
            _nombre = nombre;
        }
        private void CrearAlias()
        {
            Random nroRandom = new Random();
            int numeroParaAlias = nroRandom.Next(1000, 10000);
            //recorrer lista y que ese num no esté en uso
            this._aliasParaIncognito = numeroParaAlias.ToString()+this._tipoCliente;
        }
        public string GetAlias()
        {
            if(_aliasParaIncognito == "SinAlias")
            {
                CrearAlias();
                return this._aliasParaIncognito;
            }
            else
            {
                return _aliasParaIncognito;
            }
        }
        private string RetornarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this._nombre}");
            sb.AppendLine($"Tipo: {this._tipoCliente.ToString()}");
            sb.AppendLine($"Alias: {this._aliasParaIncognito}");
            return sb.ToString();   
        }
        public static string RetornarDatos(Cliente unCliente)
        {
            return unCliente.RetornarDatos();
        }

        
    }
}
