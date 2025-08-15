// Importa el namespace para usar anotaciones de datos como [Key]
using System.ComponentModel.DataAnnotations;

namespace DigitalTrainer.Models
{
    // Enumeración que define los posibles valores para el género
    public enum Genero
    {
        Masculino,   // Valor para género masculino
        Femenino,    // Valor para género femenino
        Otro         // Valor para otros géneros no especificados
    }

    // Clase que representa los datos personales de un usuario
    public class DatosPersonales
    {
        // Campos privados que almacenan el estado del objeto
        private int iddatospersonales;        // Identificador único
        private string nombre;               // Nombre de la persona
        private int telefono;               // Número de teléfono
        private string correoElectronico;    // Dirección de correo electrónico
        private DateTime fechaNacimiento;   // Fecha de nacimiento
        private Genero genero;              // Género (usando el enum Genero)
        private double peso;                // Peso en kilogramos
        private double altura;              // Altura en metros
        private string password;           // Contraseña del usuario

        // Propiedad clave primaria marcada con [Key]
        [Key]
        public int IdDatosPersonales
        {
            get => iddatospersonales;
            set => iddatospersonales = value;
        }

        // Propiedad para el nombre
        public string Nombre { get => nombre; set => nombre = value; }

        // Propiedad para el teléfono (considerar cambiar a string para formatos internacionales)
        public int Telefono { get => telefono; set => telefono = value; }

        // Propiedad para el correo electrónico (hay un error tipográfico en el nombre)
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }

        // Propiedad para la fecha de nacimiento
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        // Propiedad para el género usando el enum Genero
        public Genero Genero { get => genero; set => genero = value; }

        // Propiedad para el peso (en kg)
        public double Peso { get => peso; set => peso = value; }

        // Propiedad para la altura (en metros)
        public double Altura { get => altura; set => altura = value; }

        // Propiedad para la contraseña (auto-implementada)
        public string Password { get; set; }

        // Constructor parametrizado para inicializar todos los campos
        public DatosPersonales(string password, int iddatospersonales, string nombre,
                              int telefono, string correoElectronico, DateTime fechaNacimiento,
                              Genero genero, double peso, double altura)
        {
            this.password = password;
            this.iddatospersonales = iddatospersonales;
            this.nombre = nombre;
            this.telefono = telefono;
            this.correoElectronico = correoElectronico;
            this.fechaNacimiento = fechaNacimiento;
            this.genero = genero;
            this.peso = peso;
            this.altura = altura;
        }

        // Constructor por defecto que inicializa valores vacíos/por defecto
        public DatosPersonales()
        {
            this.password = "";
            this.iddatospersonales = 0;
            this.nombre = "";
            this.telefono = 0;
            this.correoElectronico = "";
            this.fechaNacimiento = DateTime.MinValue;  // Fecha mínima posible
            this.genero = Genero.Otro;                // Valor por defecto del enum
            this.peso = 0;
            this.altura = 0;
        }
    }
}