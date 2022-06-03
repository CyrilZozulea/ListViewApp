using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewApp.Model
{
    public class QuestionModel
    {
        public int ID { get; set; }
        public int TopicID { get; set; }
        public string Name { get; set; }

        public List<QuestionModel> GetQuesstionList(object item)
        {
            var finalList = new List<QuestionModel>();
            var list = new List<QuestionModel>()
            {
                new QuestionModel() { ID = 1, TopicID = 5, Name = "Question - 1" },
                new QuestionModel() { ID = 2, TopicID = 5, Name = "Question - 2" },
                new QuestionModel() { ID = 3, TopicID = 5, Name = "Question - 3" },
                new QuestionModel() { ID = 4, TopicID = 5, Name = "Question - 4" },
                new QuestionModel() { ID = 5, TopicID = 5, Name = "Question - 5" },
                new QuestionModel() { ID = 6, TopicID = 1, Name = "Question - 6" },
                new QuestionModel() { ID = 7, TopicID = 1, Name = "Question - 7" },
                new QuestionModel() { ID = 8, TopicID = 9, Name = "Question - 8" },
                new QuestionModel() { ID = 9, TopicID = 9, Name = "Question - 9" },
                new QuestionModel() { ID = 10, TopicID = 3, Name = "Question - 10" },
                new QuestionModel() { ID = 11, TopicID = 3, Name = "Question - 11" },
                new QuestionModel() { ID = 12, TopicID = 4, Name = "Question - 12" },
                new QuestionModel() { ID = 13, TopicID = 4, Name = "Question - 13" },
                new QuestionModel() { ID = 14, TopicID = 4, Name = "Question - 14" },
                new QuestionModel() { ID = 15, TopicID = 2, Name = "Question - 15" },
                new QuestionModel() { ID = 16, TopicID = 2, Name = "Question - 16" },
                new QuestionModel() { ID = 17, TopicID = 2, Name = "Question - 17" },
                new QuestionModel() { ID = 18, TopicID = 6, Name = "Question - 18" },
                new QuestionModel() { ID = 19, TopicID = 10, Name = "Question - 19" },
                new QuestionModel() { ID = 20, TopicID = 10, Name = "Question - 20" },
                new QuestionModel() { ID = 21, TopicID = 10, Name = "Question - 21" },
                new QuestionModel() { ID = 22, TopicID = 10, Name = "Question - 22" },
                new QuestionModel() { ID = 23, TopicID = 10, Name = "Question - 23" },
                new QuestionModel() { ID = 24, TopicID = 7, Name = "Question - 24" },
                new QuestionModel() { ID = 25, TopicID = 7, Name = "Question - 25" },
                new QuestionModel() { ID = 26, TopicID = 9, Name = "Question - 26" },
                new QuestionModel() { ID = 27, TopicID = 9, Name = "Question - 27" },
                new QuestionModel() { ID = 28, TopicID = 9, Name = "Question - 28" },
                new QuestionModel() { ID = 29, TopicID = 8, Name = "Question - 29" },
                new QuestionModel() { ID = 30, TopicID = 8, Name = "Question - 30" },
                new QuestionModel() { ID = 31, TopicID = 20, Name = "Question - 31" },
                new QuestionModel() { ID = 32, TopicID = 20, Name = "Question - 32" },
                new QuestionModel() { ID = 33, TopicID = 20, Name = "Question - 33" },
            };
            var model = (TopicModel)((ListView)item).SelectedItem;
            foreach (var element in list)
            {
                if (element.TopicID == model.ID)
                {
                    finalList.Add(element);
                }
            }

            return finalList;
        }
    }
}
