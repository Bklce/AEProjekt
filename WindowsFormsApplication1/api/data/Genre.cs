
namespace WindowsFormsApplication1.data
{
    class Genre
    {
        public Genre(int id_genre, string description)
        {
            Id_genre = id_genre;
            Description = description;
        }

        public int Id_genre { get; set; }
        public string Description { get; set; }
    }
}
