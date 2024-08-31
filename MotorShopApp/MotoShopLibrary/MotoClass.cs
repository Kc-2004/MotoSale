using System.Collections.Generic;
namespace MotoShopLibrary
{
    public class Moto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
    }

    public class Venta
    {
        public Moto MotoVendida { get; set; }
        public DateTime FechaVenta { get; set; }
    }
    // MotoSalesLibrary/MotoManager.cs
}



