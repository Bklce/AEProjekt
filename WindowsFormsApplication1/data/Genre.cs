
namespace WindowsFormsApplication1.data
{
    class Genre
    {
        private int id_genre;
        private string description;

        public Genre(int id_genre, string description)
        {
            this.id_genre = id_genre;
            this.description = description;
        }

        public int Id_genre
        { get; set; }

        public string Description
        { get; set; }
    }
}
