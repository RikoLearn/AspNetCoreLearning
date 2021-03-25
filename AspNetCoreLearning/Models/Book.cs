

namespace AspNetCoreLearning.Models
{
    public class Book
    {
        public Book()
        {

        }

        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
