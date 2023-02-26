using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework1
{
    [Serializable]
    public class Visitor
    {
        public int Visitor_Id { get; set; }
        public string Visitor_Category { get; set; }
        public int Visitor_Count { get; set; }
        public DateTime Entry_Time { get; set; }
        public DateTime Exit_Time { get; set; }
        public TimeSpan Stay_time { get; set; }
        public float Pay_amount { get; set; }
    }
}
