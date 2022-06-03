using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewApp.Model
{
    public class TopicModel
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<TopicModel> GetTopicList()
        {
            var list = new List<TopicModel>
            {
                new TopicModel { ID = 1, Name = "Topic - 1" },
                new TopicModel { ID = 2, Name = "Topic - 2" },
                new TopicModel { ID = 3, Name = "Topic - 3" },
                new TopicModel { ID = 4, Name = "Topic - 4" },
                new TopicModel { ID = 5, Name = "Topic - 5" },
                new TopicModel { ID = 6, Name = "Topic - 6" },
                new TopicModel { ID = 7, Name = "Topic - 7" },
                new TopicModel { ID = 8, Name = "Topic - 8" },
                new TopicModel { ID = 9, Name = "Topic - 9" },
                new TopicModel { ID = 10, Name = "Topic - 10" },
                new TopicModel { ID = 11, Name = "Topic - 11" },
                new TopicModel { ID = 12, Name = "Topic - 12" },
                new TopicModel { ID = 13, Name = "Topic - 13" },
                new TopicModel { ID = 14, Name = "Topic - 14" },
                new TopicModel { ID = 15, Name = "Topic - 15" },
                new TopicModel { ID = 16, Name = "Topic - 16" },
                new TopicModel { ID = 17, Name = "Topic - 17" },
                new TopicModel { ID = 18, Name = "Topic - 18" },
                new TopicModel { ID = 19, Name = "Topic - 19" },
                new TopicModel { ID = 20, Name = "Topic - 20" },
                new TopicModel { ID = 21, Name = "Topic - 21" }
            };

            return list;
        }
    }
}
