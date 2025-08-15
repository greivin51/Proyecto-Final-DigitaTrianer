// Importa el namespace para usar anotaciones de datos
using System.ComponentModel.DataAnnotations;

namespace DigitalTrainer.Models
{
    // Clase que representa una Rutina de ejercicios
    public class Rutina
    {
        // Campos privados que almacenan el estado del objeto
        private string musculo;      // Almacena el grupo muscular a trabajar
        private string descripcion;  // Almacena la descripción del ejercicio

        // Constructor parametrizado para crear una rutina con valores específicos
        public Rutina(string musculo, string descripcion)
        {
            this.musculo = musculo;        // Asigna el grupo muscular
            this.descripcion = descripcion; // Asigna la descripción
        }

        // Constructor por defecto que inicializa con valores vacíos
        public Rutina()
        {
            this.musculo = "";        // Cadena vacía para músculo
            this.descripcion = "";    // Cadena vacía para descripción
        }

        // Propiedad Musculo marcada como clave primaria [Key]
        [Key]  // Indica que esta propiedad es la clave primaria en la base de datos
        public string Musculo
        {
            get => musculo;        // Devuelve el valor del campo privado
            set => musculo = value; // Asigna valor al campo privado
        }

        // Propiedad para la descripción del ejercicio
        public string Descripcion
        {
            get => descripcion;      // Devuelve la descripción
            set => descripcion = value; // Asigna nueva descripción
        }
    }
}