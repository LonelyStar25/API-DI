﻿namespace PruebaDAL.Models
{
    public partial class Venta
    {
        public int NumSerial { get; set; }
        public string DniCliente { get; set; }
        public string DniUsuario { get; set; }
        public int Beneficios { get; set; }
        public string Plazo { get; set; }

        public virtual Cliente DniClienteNavigation { get; set; }
        public virtual Usuario DniUsuarioNavigation { get; set; }
        public virtual Vehículo NumSerialNavigation { get; set; }
    }
}
