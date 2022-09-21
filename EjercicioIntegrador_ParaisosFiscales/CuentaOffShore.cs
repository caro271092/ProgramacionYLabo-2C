using System;

namespace EjercicioIntegrador_ParaisosFiscales
{
    public class CuentaOffShore
    {
        private Cliente _duenio;
        private int _numeroCuenta;
        private double _saldo;

        public Cliente Duenio { get => _duenio; }
        public double Saldo { get => _saldo; set => _saldo = value; }

        public CuentaOffShore(Cliente duenio, int numeroCuenta, double saldoInicial)
        {
            _duenio = duenio;
            _numeroCuenta = numeroCuenta;
            _saldo = saldoInicial;
        }
        public CuentaOffShore(string nombre, eTipoCliente tipo, int numeroCuenta, double saldoInicial)
        {
            Cliente duenio = new Cliente(tipo, nombre);
            _duenio = duenio;
            _numeroCuenta = numeroCuenta;
            _saldo = saldoInicial;
        }
        public static bool operator ==(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            string alias1 = cos1.Duenio.GetAlias();
            string alias2 = cos2.Duenio.GetAlias();
            if ((String.Compare(alias2, alias1) == 0) && (cos1._numeroCuenta == cos2._numeroCuenta))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            return !(cos1 == cos2); 
        }
        public static explicit operator int(CuentaOffShore cos) { 
            return cos._numeroCuenta;    
        }

    }
}
