using System;
using EjercicioIntegrador_ParaisosFiscales;

namespace ConsolaParaisos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Alvarez Carolina";
            Cliente mauri = new Cliente(eTipoCliente.PoliticoCorrupto, "Mauri");
            Cliente farinia = new Cliente(eTipoCliente.Financista, "Fariña");
            Cliente mesias = new Cliente(eTipoCliente.JugadorDeFutbol, "Lio");
            CuentaOffShore messiOff = new CuentaOffShore(mesias, 123, 15000);
            CuentaOffShore mauriOff = new CuentaOffShore(mauri, 678, 25000);
            CuentaOffShore lazaroOff = new CuentaOffShore("Lázaro", eTipoCliente.EmpresarioCorrupto, 456, 56000);
            CuentaOffShore otraDeMauri = new CuentaOffShore(mauri, 678, 50000);
            CuentaOffShore fariOff = new CuentaOffShore(farinia, 666, 3500);
            ParaisoFiscal panamaPappers = eParaisosFiscales.Panama;
            panamaPappers += messiOff;
            panamaPappers += mauriOff;
            panamaPappers += lazaroOff;
            panamaPappers.MostrarParaiso();
            panamaPappers += otraDeMauri;
            panamaPappers -= messiOff;
            panamaPappers -= fariOff;
            panamaPappers.MostrarParaiso();
            Console.ReadLine();
        }
    }
}
