//معادل college
namespace MyProject.Models
{
    public class Pagegroup
    {
        public int GroupID { get; set; }
        public string? GroupTitle { get; set; }




        //Navigation Property
        //یدونه شهر مجموعه ای از لوکیشنهارو داره 
        public ICollection<Pagesloc>? Pageslocs { get; set; }


    }
}
