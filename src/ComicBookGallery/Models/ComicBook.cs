using System;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }             
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public String DescriptionHtml { get; set; }
        public Artist[] Artist { get; set; }
        public bool IsFavorite { get; set; }
    }
}