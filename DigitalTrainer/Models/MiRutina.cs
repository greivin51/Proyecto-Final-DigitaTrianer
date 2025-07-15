using System.ComponentModel.DataAnnotations;

namespace DigitalTrainer.Models
{
    public class MiRutina
    {
        private int id;
        private string musculo;
        private string ejercicio;
        private int series;
        private string dia;

      

        public MiRutina(int id, string musculo, string ejercicio, int series, string dia)
        {
            this.Id = id;
            this.Musculo = musculo;
            this.Ejercicio = ejercicio;
            this.Series = series;
            this.Dia = dia;
        }
        public MiRutina()
        {
            this.Id = 0;
            this.Musculo = "";
            this.Ejercicio = "";
            this.Series = 0;
            this.Dia = "";
        }
        public int Id { get => id; set => id = value; }
        public string Musculo { get => musculo; set => musculo = value; }
        public string Ejercicio { get => ejercicio; set => ejercicio = value; }
        public int Series { get => series; set => series = value; }
        public string Dia { get => dia; set => dia = value; }

    }
}
    