// Importa los namespaces necesarios para Entity Framework
using System.Data.Entity;          // Para DbContext y funcionalidades principales
using System.Data.Entity.Migrations; // Para operaciones de migración/actualización

namespace DigitalTrainer.Models
{
    // Clase principal que representa el contexto de la base de datos
    public class Service : DbContext
    {
        // DbSet para la entidad Rutina - representa la tabla Rutinas en la base de datos
        public DbSet<Rutina> rutinas { get; set; }

        // DbSet para la entidad DatosPersonales - representa la tabla DatosPersonales
        public DbSet<DatosPersonales> datosPersonales { get; set; }

        // DbSet para la entidad MiRutina - representa la tabla MiRutina
        public DbSet<MiRutina> miRutina { get; set; }

        // DbSet para la entidad Batidos - representa la tabla Batidos
        public DbSet<Batidos> batidos { get; set; }

        // Constructor que inicializa el contexto con la cadena de conexión "DigitalTrainer"
        public Service() : base("DigitalTrainer")
        { }

        #region Métodos de Rutina

        // Agrega una nueva rutina a la base de datos
        public void agregarRutinas(Rutina rutina)
        {
            this.rutinas.Add(rutina);  // Añade la rutina al contexto
            SaveChanges();             // Guarda los cambios en la base de datos
        }

        // Obtiene todas las rutinas como un array
        public Array mostrarRutinas()
        {
            return this.rutinas.ToArray();  // Convierte el DbSet a array
        }

        #endregion

        #region Métodos de Datos Personales

        // Agrega nuevos datos personales a la base de datos
        public void agregarDatosPersonales(DatosPersonales datos)
        {
            this.datosPersonales.Add(datos);
            SaveChanges();
        }

        // Obtiene todos los registros de datos personales
        public Array mostrarDatosPersonales()
        {
            return this.datosPersonales.ToArray();
        }

        // Elimina datos personales de la base de datos
        public void eliminarDatosPersonales(DatosPersonales datos)
        {
            if (datos != null)  // Verifica que el objeto no sea nulo
            {
                this.datosPersonales.Remove(datos);
                SaveChanges();
            }
        }

        // Actualiza los datos personales existentes
        public void actualizarDatosPersonales(DatosPersonales datos)
        {
            // Busca el registro existente por ID
            var datosExistentes = this.datosPersonales.FirstOrDefault(x => x.IdDatosPersonales == datos.IdDatosPersonales);

            if (datosExistentes != null)
            {
                // Actualiza todas las propiedades
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

        // Busca datos personales por ID
        public DatosPersonales buscarDatosPersonales(int id)
        {
            var datos = this.datosPersonales.FirstOrDefault(x => x.IdDatosPersonales == id);
            if (datos != null)
                return datos;
            else
                throw new Exception("Datos personales no encontrados");
        }

        #endregion

        #region Métodos de Mi Rutina

        // Agrega una nueva rutina personalizada
        public void agregarMiRutina(MiRutina miRutina)
        {
            this.miRutina.Add(miRutina);
            SaveChanges();
        }

        // Obtiene todas las rutinas personalizadas
        public Array mostrarMiRutina()
        {
            return this.miRutina.ToArray();
        }

        // Busca una rutina personalizada por ID
        public MiRutina buscarMiRutina(int id)
        {
            var miRutinaBuscado = this.miRutina.FirstOrDefault(x => x.Id == id);
            if (miRutinaBuscado != null)
                return miRutinaBuscado;
            else
                throw new Exception("No existe una rutina con ese id");
        }

        // Elimina una rutina personalizada
        public void eliminarMiRutina(MiRutina miRutina)
        {
            this.miRutina.Remove(miRutina);
            SaveChanges();
        }

        // Actualiza una rutina personalizada existente
        public void actualizarMiRutina(MiRutina miRutina)
        {
            var miRutinaAnterior = this.miRutina.FirstOrDefault(x => x.Id == miRutina.Id);
            if (miRutinaAnterior != null)
            {
                // Actualiza todas las propiedades
                miRutinaAnterior.Musculo = miRutina.Musculo;
                miRutinaAnterior.Ejercicio = miRutina.Ejercicio;
                miRutinaAnterior.Series = miRutina.Series;
                miRutinaAnterior.Dia = miRutina.Dia;
                SaveChanges();
            }
            else throw new Exception("Ese fabricante que intenta actualizar, no se encuentra registrado");
        }

        #endregion

        #region Métodos de Batidos

        // Agrega un nuevo batido
        public void agregarBatidos(Batidos batidos)
        {
            this.batidos.Add(batidos);
            SaveChanges();
        }

        // Obtiene todos los batidos
        public Array mostrarBatidos()
        {
            return this.batidos.ToArray();
        }

        #endregion
    }
}