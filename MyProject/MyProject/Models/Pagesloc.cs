//مثال student 
namespace MyProject.Models
{
    public class Pagesloc
    {

            public int PageID { get; set; }
            public string? Title { get; set; }
            public string? ShortDescription { get; set; }
            public string? Text { get; set; }
            //public string ImageName { get; set; }
            //public DateTime CreateDate { get; set; }
            public string? Tags { get; set; }

            public int GroupID { get; set; }


            //Navigation Property
            //
            public Pagegroup? Pagegroup { get; set; }



    }
}
