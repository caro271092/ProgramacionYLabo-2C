using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador_ParaisosFiscales
{
    public class ParaisoFiscal
    {
        private List<CuentaOffShore> _listadoCuentas;
        private eParaisosFiscales _lugar;
        static int cantidadDeCuentas;
        static DateTime fechaInicioDeActividades;
        static ParaisoFiscal()
        {
            cantidadDeCuentas = 0;
            fechaInicioDeActividades = DateTime.Now;
        }
        private ParaisoFiscal()
        {
            List<CuentaOffShore> listadoCuentas = new List<CuentaOffShore>();
            this._listadoCuentas = listadoCuentas;
        }
        private ParaisoFiscal(eParaisosFiscales lugar):this()
        {
            _lugar = lugar; 
        }
        public void MostrarParaiso()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Fecha de Inicio: {ParaisoFiscal.fechaInicioDeActividades}");
            sb.AppendLine($"Locación: {this._lugar}");
            sb.AppendLine($"Cantidad de cuentitas: {ParaisoFiscal.cantidadDeCuentas}");
            sb.AppendLine("********* Listado de cuentas *********");
            foreach (var item in this._listadoCuentas)
            {
                sb.Append($"{Cliente.RetornarDatos(item.Duenio)}");
                sb.AppendLine($"Número de cuenta: {(int)item}");
                sb.AppendLine($"Saldo: {item.Saldo}\n");
                
            }
            Console.WriteLine(sb.ToString());
        }
        /// <summary>
        /// Crea un paraiso con el lugar que recibe como parámetro
        /// </summary>
        /// <param name="epf"></param> locación del paraiso
        public static implicit operator ParaisoFiscal(eParaisosFiscales epf)
        {
            ParaisoFiscal paraisoFiscal = new ParaisoFiscal(epf);
            return paraisoFiscal;
        }
        public static bool operator ==(ParaisoFiscal paraiso, CuentaOffShore cuentaOffShore)
        {
            foreach (var item in paraiso._listadoCuentas){
                if(cuentaOffShore == item)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(ParaisoFiscal paraiso, CuentaOffShore cuentaOffShore)
        {
            return !(paraiso == cuentaOffShore);
        }
        public static ParaisoFiscal operator -(ParaisoFiscal paraiso, CuentaOffShore cuentaOffShore)
        {
            foreach (var item in paraiso._listadoCuentas)
            {
                if (cuentaOffShore == item)
                {
                    cantidadDeCuentas--;
                    paraiso._listadoCuentas.Remove(cuentaOffShore);
                    Console.WriteLine("Se quitó la cuenta del paraíso...");
                    return paraiso;
                }
            }
            Console.WriteLine("La cuenta no existe...");
            return paraiso;
        }
        public static ParaisoFiscal operator +(ParaisoFiscal paraiso, CuentaOffShore cuentaOffShore)
        {
            foreach (var item in paraiso._listadoCuentas)
            {
                if (cuentaOffShore == item)
                {
                    item.Saldo += cuentaOffShore.Saldo;
                    Console.WriteLine("Se actualizó el saldo de la cuenta...");
                    return paraiso;
                }
            }
            cantidadDeCuentas++;
            paraiso._listadoCuentas.Add(cuentaOffShore);
            Console.WriteLine("Se agregó la cuenta al paraiso...");
            return paraiso;
        }


    }
}
