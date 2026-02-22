namespace StreamingApp.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string ImagenUrl { get; set; }
        public string Descripcion { get; set; }
        public string TrailerUrl { get; set; }
        public bool Activo { get; set; }
    }
}
