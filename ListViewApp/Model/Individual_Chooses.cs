using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ListViewApp.Model
{
    [Table("Cache")]
    public class Individual_Chooses
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [MaxLength(250)]
        public int TopicID { get; set; }
        [MaxLength(250)]
        public int QuestinID { get; set; }
        [MaxLength(250)]
        public string Text { get; set; }
        [MaxLength(250)]
        public string Number { get; set; }
        [MaxLength(250)]
        public string RadioButtonChoose { get; set; }
        [MaxLength(250)]
        public string ChackBoxChoose { get; set; }
    }
}
