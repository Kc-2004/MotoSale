using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoShopLibrary
{
    
        public class MotoManager
        {
            private List<Moto> motos = new List<Moto>();
            private List<Venta> ventas = new List<Venta>();

            public event EventHandler<Moto> MotoAgregada;
            public event EventHandler<Venta> VentaRegistrada;

            public void AgregarMoto(Moto moto)
            {
                motos.Add(moto);
                MotoAgregada?.Invoke(this, moto);
            }

            public void RegistrarVenta(Moto moto)
            {
                var venta = new Venta { MotoVendida = moto, FechaVenta = DateTime.Now };
                ventas.Add(venta);
                VentaRegistrada?.Invoke(this, venta);
            }

            public IEnumerable<Moto> ObtenerMotos()
            {
                return motos;
            }

            public IEnumerable<Venta> ObtenerVentas()
            {
                return ventas;
            }
        }
    }


