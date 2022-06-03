using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewApp.Model
{
    public class QuestionListModel
    {
        public List<QuestionModel> Source { get; set; }
        public QuestionListModel(object item)
        {
            QuestionModel question = new QuestionModel();
            this.Source = question.GetQuesstionList(item);
        }
    }
}
