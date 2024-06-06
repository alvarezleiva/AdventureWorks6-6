namespace CodeFirst.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; } = string.Empty;
        public virtual ICollection<Libro> Libros { get; set; }
    }
}
