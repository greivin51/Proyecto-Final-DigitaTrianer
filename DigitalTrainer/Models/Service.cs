using System.Data.Entity;
using System.Data.Entity.Migrations;
namespace DigitalTrainer.Models

{
    public class Service: DbContext
    {
        public DbSet<Rutina> rutinas { get; set; }

        public DbSet<DatosPersonales> datosPersonales { get; set; }



        public Service() : base("DigitalTrainer")
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

    }
}
