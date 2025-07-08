using System.ComponentModel.DataAnnotations;

namespace DigitalTrainer.Models
{
    public class MiRutina
    {
        private int id;
        private string musculo;
        private string tipo;






        public MiRutina(int id, string musculo, string tipo)
        {
            this.id = id;
            this.musculo = musculo;
            this.tipo = tipo;

        }
        public MiRutina()
        {
            this.id = 0;
            this.musculo = "";
            this.tipo = "";



        }
        [Key]
        public int Id { get => id; set => id = value; }
        public string Musculo { get => musculo; set => musculo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
    