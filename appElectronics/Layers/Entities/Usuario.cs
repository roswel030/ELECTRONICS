

using UTN.Winform.Electronics.Interfaces;

namespace UTN.Winform.Electronics.Layers.Entities
{
    public class Usuario
    {
        public string Login { set; get; }
        public int IdRol { set; get; }
        public string Password { set; get; }
        public string Nombre { set; get; }
        public bool Estado { set; get; }
        public override string ToString() => $"{Login.Trim()} - {Nombre.Trim()}";
         
    }
}
