namespace StreamingApp.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Correo { get; set; }
        public string ContraseñaHash { get; set; }
        public string Rol { get; set; } // Admin o Cliente
        public DateTime FechaRegistro { get; set; }
    }
}
