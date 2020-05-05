namespace WPF.Practices.Binding.Models
{
    public class Persona 
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Identificador { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Nombre, Apellido);
        }
    }
}