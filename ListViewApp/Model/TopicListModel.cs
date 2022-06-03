using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewApp.Model
{
    public class TopicListModel
    {
        public List<TopicModel> Source { get; set; }

        public TopicListModel()
        {
            TopicModel topic = new TopicModel();
            this.Source = topic.GetTopicList();
        }
    }
}
