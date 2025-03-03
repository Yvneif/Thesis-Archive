namespace ThesisArchive.Models
{
    public class Thesis{
        public int Id {get; set;}
        public string? Author {get; set;}
        public string? Abstract {get; set;}
        public string? Filepath{get; set;}
        public DateTime Year {get; set;}

    }
}