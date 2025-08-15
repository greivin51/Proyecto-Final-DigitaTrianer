// Importa el namespace para usar anotaciones de datos como [Key], [Required], etc.
using System.ComponentModel.DataAnnotations;

namespace DigitalTrainer.Models
{
    // Clase que representa una entrada de rutina de ejercicios
    public class MiRutina
    {
        // Campos privados que almacenan el estado del objeto
        private int id;            // Identificador único de la rutina
        private string musculo;    // Grupo muscular que se trabaja
        private string ejercicio;  // Nombre del ejercicio específico
        private int series;        // Cantidad de series a realizar
        private string dia;        // Día de la semana asignado

        // Constructor parametrizado para crear una rutina con valores específicos
        public MiRutina(int id, string musculo, string ejercicio, int series, string dia)
        {
            this.Id = id;               // Asigna el ID usando la propiedad
            this.Musculo = musculo;     // Asigna el grupo muscular
            this.Ejercicio = ejercicio; // Asigna el nombre del ejercicio
            this.Series = series;       // Asigna el número de series
            this.Dia = dia;            // Asigna el día de la semana
        }

        // Constructor por defecto que inicializa con valores vacíos/por defecto
        public MiRutina()
        {
            this.Id = 0;          // Valor por defecto para ID
            this.Musculo = "";    // Cadena vacía para músculo
            this.Ejercicio = "";  // Cadena vacía para ejercicio
            this.Series = 0;      // 0 series por defecto
            this.Dia = "";       // Cadena vacía para día
        }

        // Propiedad Id (posible clave primaria aunque falta atributo [Key])
        public int Id
        {
            get => id;        // Devuelve el valor del campo privado
            set => id = value; // Asigna valor al campo privado
        }

        // Propiedad para el grupo muscular trabajado
        public string Musculo
        {
            get => musculo;
            set => musculo = value;
        }

        // Propiedad para el nombre del ejercicio
        public string Ejercicio
        {
            get => ejercicio;
            set => ejercicio = value;
        }

        // Propiedad para el número de series
        public int Series
        {
            get => series;
            set => series = value;
        }

        // Propiedad para el día de la semana asignado
        public string Dia
        {
            get => dia;
            set => dia = value;
        }
    }
}