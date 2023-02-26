using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework1
{
    class GlobalValues
    {
       
        public static bool IsAdmin;
        public static bool IsStaff;
        public static List<Visitor> RegisteredVisitorList = new List<Visitor>();
        public static List<Ticketpricerate> TicketList = new List<Ticketpricerate>();
        public static VisitorCollection VisitorRecordList;
        public static List<Ticketpricerate> UpdatedrateList = new List<Ticketpricerate>();
        public static List<VisitorReport> ReportList = new List<VisitorReport>();

    }
}
