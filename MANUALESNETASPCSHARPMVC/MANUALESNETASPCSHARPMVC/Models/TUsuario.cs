using System;
using System.Data.Entity;

namespace MANUALESNETASPCSHARPMVC.Models
{
    public class TUsuario
    {
        public string codigoUsuario { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string correoElectronico { get; set; }
        public string contrasenia { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public Boolean sexo { get; set; }
    }

    public class DbContextTUsuario : DbContext 
    {
        public DbSet<TUsuario> tUsuario { get; set; }
    }
}