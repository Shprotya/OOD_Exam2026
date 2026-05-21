using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2026
{
    public class Member
    {
        //Properties
        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ContactNumber { get; set; }
        public string MembershipStyle { get; set; }

        //Navigation property
        //A member can have multiple training sessions, so we use a list to represent this relationship.
        public List<TrainingSession> TrainingSessions { get; set; }
    }

    public class TrainingSession
    {
        //Properties
        public int SessionID { get; set; }
        public DateTime SessionDate { get; set; }
        public string SessionType { get; set; }
        public int DurationMinutes { get; set; }
        public string CoachNotes { get; set; }

        //Navigation property
        //Each training session is associated with one member, so we use a reference to represent this relationship.
        public Member Member { get; set; }
    }
}
