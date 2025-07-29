using System.ComponentModel.DataAnnotations;

namespace DigitalTrainer.Models
{
    public class Batidos
    {
        private string nombre;
        private string ingredientes;

       
        public Batidos(string nombre, string ingredientes)
        {
            this.Nombre = nombre;
            this.Ingredientes = ingredientes;
        }
        public Batidos()
        {
            this.Nombre = "";
            this.Ingredientes = "";
        }

        [Key]
        public string Nombre { get => nombre; set => nombre = value; }
        public string Ingredientes { get => ingredientes; set => ingredientes = value; }
    }
    
}

