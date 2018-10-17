using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DemoSplitView.Model
{
    public class NewItems
    {
        public int Id { get; set; }

        public string Category { get; set; }
        
        public string Headline { get; set; }

        public string Subhead { get; set; }

        public string DateLine { get; set; }

        public string Image { get; set; }
    }

    public class NewsManager
    {
        public static void GetNews(string category, ObservableCollection<NewItems> newsItems)
        {
            var allItems = getNewsItems();

            var filteredNewsItems = allItems.Where(p => p.Category == category).ToList();

            newsItems.Clear();

            filteredNewsItems.ForEach(p => newsItems.Add(p));
        }

        private static List<NewItems> getNewsItems()
        {
            var items = new List<NewItems>();

            items.Add(new NewItems()
            {
                Id = 1,
                Category = "Financial",
                Headline = "Lorem Ipsum",
                Subhead = "doro sit amet",
                DateLine = "Nunc tristique nec",
                Image = "Assets/Financial.png"
            });
            items.Add(new NewItems()
            {
                Id = 2,
                Category = "Financial2",
                Headline = "Lorem Ipsum",
                Subhead = "doro sit amet",
                DateLine = "Nunc tristique nec",
                Image = "Assets/Financial3.png"
            });
            items.Add(new NewItems()
            {
                Id = 3,
                Category = "Financial3",
                Headline = "Lorem Ipsum",
                Subhead = "doro sit amet",
                DateLine = "Nunc tristique nec",
                Image = "Assets/Financial3.png"
            });
            items.Add(new NewItems()
            {
                Id = 4,
                Category = "Financial4",
                Headline = "Lorem Ipsum",
                Subhead = "doro sit amet",
                DateLine = "Nunc tristique nec",
                Image = "Assets/Financial4.png"
            });
            items.Add(new NewItems()
            {
                Id = 5,
                Category = "Financial5",
                Headline = "Lorem Ipsum",
                Subhead = "doro sit amet",
                DateLine = "Nunc tristique nec",
                Image = "Assets/Financial5.png"
            });

            return items;
        }

        
    }
}
