using System.ComponentModel.DataAnnotations;

namespace DigitalTrainer.Models
{
    public class Rutina
    {

        private String musculo;
        private String descripcion;

        public Rutina(string musculo, string descripcion)
        {
            this.musculo = musculo;
            this.descripcion = descripcion;
        }
        public Rutina()
        {
            this.musculo = "";
            this.descripcion ="";
        }
        [Key]
        public string Musculo { get => musculo; set => musculo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

    }
}
 