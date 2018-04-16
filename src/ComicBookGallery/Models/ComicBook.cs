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

        public string DisplayText
        {
            get { return SeriesTitle + " #" + IssueNumber; }
        }

        //series.title-issuenumber.jpg
        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace(" ", "-")
                           .ToLower() + "-" + IssueNumber + ".jpg";
            }
        }
    }

}