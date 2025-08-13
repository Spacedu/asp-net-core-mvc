using FirstProject.Models;

namespace FirstProject.Database
{
    public class DatabaseNews
    {
        public static List<News> News = new List<News>()
        {
            new News(){ Id = 1, Title = "Title 1", Text = "Text 1" },
            new News(){ Id = 2, Title = "Title 2", Text = "Text 2" },
            new News(){ Id = 3, Title = "Title 3", Text = "Text 3" },
            new News(){ Id = 4, Title = "Title 4", Text = "Text 4" },
            new News(){ Id = 5, Title = "Title 5", Text = "Text 5" },
            new News(){ Id = 6, Title = "Title 6", Text = "Text 6" },
        };
    }
}
