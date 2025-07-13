    using System.Data.Entity;
using System.Data.Entity.Migrations;
namespace DigitalTrainer.Models

{
    public class Service : DbContext
    {
        public DbSet<Rutina> rutinas { get; set; }

        public DbSet<DatosPersonales> datosPersonales { get; set; }



        public  Service() : base("DigitalTrainer")
        { }
        public void agregarRutinas(Rutina rutina)
        {
            this.rutinas.Add(rutina);
            SaveChanges();
        }
        public Array mostrarRutinas()
        {
            return this.rutinas.ToArray();
        }


        public void agregarDatosPersonales(DatosPersonales datos)
        {
            this.datosPersonales.Add(datos);
            SaveChanges();
        }
        public Array mostrarDatosPersonales()
        {
            return this.datosPersonales.ToArray();
        }
        public void eliminarDatosPersonales(DatosPersonales datos)
        {
            
            if (datos != null)
            {
                this.datosPersonales.Remove(datos);
                SaveChanges();
            }
        }
        public void actualizarDatosPersonales(DatosPersonales datos)
        {
            var datosExistentes = this.datosPersonales.FirstOrDefault(x => x.IdDatosPersonales == datos.IdDatosPersonales);
            if (datosExistentes != null)
            {
                datosExistentes.Nombre = datos.Nombre;
                datosExistentes.Telefono = datos.Telefono;
                datosExistentes.CorreoElectronico = datos.CorreoElectronico;
                datosExistentes.FechaNacimiento = datos.FechaNacimiento;
                datosExistentes.Genero = datos.Genero;
                datosExistentes.Peso = datos.Peso;
                datosExistentes.Altura = datos.Altura;
                SaveChanges();
            }
            else
            {
                throw new Exception("Datos personales no encontrados");
            }
        }
        public DatosPersonales buscarDatosPersonales(int id)
        {
            var datos = this.datosPersonales.FirstOrDefault(x => x.IdDatosPersonales == id);
            if (datos != null)
                return datos;
            else
                throw new Exception("Datos personales no encontrados");
        }
    }
}
