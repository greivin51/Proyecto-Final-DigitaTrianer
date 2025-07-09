using System.ComponentModel.DataAnnotations;

namespace DigitalTrainer.Models
{
    public enum Genero
    {
        Masculino,
        Femenino,
        Otro
    }
    public class DatosPersonales
    {
        private int iddatospersonales;
        private string nombre;
        private int telefono;
        private string correoElectronico;
        private DateTime fechaNacimiento;
        private Genero genero;
        private double peso;
        private double altura;
        [Key]
        public int IdDatosPersonales 
        { 
            get => iddatospersonales; 
            set => iddatospersonales = value;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public DateTime  FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public Genero Genero { get => genero; set => genero = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }

        public DatosPersonales(int iddatospersonales, string nombre, int telefono, string correoElectronico, DateTime fechaNacimiento, Genero genero, double peso, double altura)
        {
            this.iddatospersonales = iddatospersonales;
            this.nombre = nombre;
            this.telefono = telefono;
            this.correoElectronico = correoElectronico;
            this.fechaNacimiento = fechaNacimiento;
            this.genero = genero;
            this.peso = peso;
            this.altura = altura;
        }
        public DatosPersonales()
        {
            this.iddatospersonales = 0;
            this.nombre = "";
            this.telefono = 0;
            this.correoElectronico = "";
            this.fechaNacimiento = DateTime.MinValue;
            this.genero = Genero.Otro;
            this.peso = 0;
            this.altura = 0;
        }
    }
}
