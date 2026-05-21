using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2026
{
    public class Member
    {
        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ContactNumber { get; set; }
        public string MembershipStyle { get; set; }
    }

    public class TrainingSession
    {
        public int SessionID { get; set; }
        public DateTime SessionDate { get; set; }
        public string SessionType { get; set; }
        public int DurationMinutes { get; set; }
        public string CoachNotes { get; set; }
    }
}
