    using System.Data.Entity;
using System.Data.Entity.Migrations;
namespace DigitalTrainer.Models

{
    public class Service : DbContext
    {
        public DbSet<Rutina> rutinas { get; set; }

        public DbSet<DatosPersonales> datosPersonales { get; set; }

        public DbSet<MiRutina> miRutina { get; set; }

        public DbSet<Batidos> batidos { get; set; }


        public Service() : base("DigitalTrainer")
        { }

        #region Metodos de Rutina
        public void agregarRutinas(Rutina rutina)
        {
            this.rutinas.Add(rutina);
            SaveChanges();
        }
        public Array mostrarRutinas()
        {
            return this.rutinas.ToArray();
        }




        #endregion

        #region Metodos de Datos Personales

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
        #endregion

        #region Metodos de Mi Rutina
        public void agregarMiRutina(MiRutina miRutina)
        {
            this.miRutina.Add(miRutina);
            SaveChanges();
        }
        public Array mostrarMiRutina()
        {
            return this.miRutina.ToArray();
        }
        public MiRutina buscarMiRutina(int id)
        {
            var miRutinaBuscado = this.miRutina.FirstOrDefault(x => x.Id == id);
            if (miRutinaBuscado != null)
                return miRutinaBuscado;
            else
                throw new Exception("No existe una rutina con ese id");
        }
        public void eliminarMiRutina(MiRutina miRutina)
        {
            this.miRutina.Remove(miRutina);
            SaveChanges();
        }



        public void actualizarMiRutina(MiRutina miRutina)
        {
            var miRutinaAnterior = this.miRutina.FirstOrDefault(x => x.Id == miRutina.Id);
            if (miRutinaAnterior != null)
            {
                miRutinaAnterior.Musculo = miRutina.Musculo;
                miRutinaAnterior.Ejercicio = miRutina.Ejercicio;
                miRutinaAnterior.Series = miRutina.Series;
                miRutinaAnterior.Dia = miRutina.Dia;


                SaveChanges();

            }
            else throw new Exception("Ese fabricante que intenta actualizar, no se encuentra registrado");
        }


        #endregion
        #region Metodos de Batidos

        public void agregarBatidos(Batidos batidos)
        {
            this.batidos.Add(batidos);
            SaveChanges();
        }
        public Array mostrarBatidos()
        {
            return this.batidos.ToArray();
        }

        #endregion

    }
}
