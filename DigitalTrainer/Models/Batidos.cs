// Importa el espacio de nombres para usar anotaciones de datos como [Key]
using System.ComponentModel.DataAnnotations;

// Define el espacio de nombres (agrupación lógica de clases)
namespace DigitalTrainer.Models
{
    // Clase que representa la entidad 'Batidos' en el modelo de datos
    public class Batidos
    {
        // Campos privados que almacenan el estado del objeto
        private string nombre;       // Almacena el nombre del batido
        private string ingredientes; // Almacena los ingredientes del batido

        // Constructor con parámetros para inicializar un batido con valores específicos
        public Batidos(string nombre, string ingredientes)
        {
            this.Nombre = nombre;           // Asigna el nombre usando la propiedad
            this.Ingredientes = ingredientes; // Asigna los ingredientes usando la propiedad
        }

        // Constructor sin parámetros (por defecto)
        // Inicializa los valores con cadenas vacías
        public Batidos()
        {
            this.Nombre = "";        // Nombre vacío por defecto
            this.Ingredientes = "";  // Ingredientes vacíos por defecto
        }

        // Propiedad Nombre con atributo [Key] que indica que es la clave primaria
        [Key]  // Marca esta propiedad como identificador único en la base de datos
        public string Nombre
        {
            get => nombre;         // Getter: devuelve el valor del campo privado
            set => nombre = value; // Setter: asigna el valor al campo privado
        }

        // Propiedad Ingredientes (sin atributo especial)
        public string Ingredientes
        {
            get => ingredientes;     // Getter: devuelve los ingredientes
            set => ingredientes = value; // Setter: asigna nuevos ingredientes
        }
    }
}