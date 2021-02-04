namespace PruebaDAL.Models
{
    public partial class Reparación
    {
        public int NumIncidencia { get; set; }
        public string DniCliente { get; set; }
        public string DniUsuario { get; set; }
        public string Problema { get; set; }
        public int Coste { get; set; }
        public string TiempoEstimado { get; set; }
        public string Piezas { get; set; }

        public virtual Cliente DniClienteNavigation { get; set; }
        public virtual Usuario DniUsuarioNavigation { get; set; }
    }
}
