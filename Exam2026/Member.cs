using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2026
{
    public class Member
    {
        //Properties
        [Key]
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ContactNumber { get; set; }
        public string MembershipType { get; set; }

        //Navigation property
        //A member can have multiple training sessions, so we use a list to represent this relationship.
        public virtual List<TrainingSession> TrainingSessions { get; set; }

        //Constructor to initialize the list of training sessions
        public Member()
        {
            TrainingSessions = new List<TrainingSession>();
        }

        public override string ToString() => $"{Surname}, {FirstName} - {ContactNumber}";
    }

    public class TrainingSession
    {
        //Properties
        [Key]
        public int SessionId { get; set; }
        public DateTime SessionDate { get; set; }
        public string SessionType { get; set; }
        public int DurationMinutes { get; set; }
        public string CoachNotes { get; set; }

        //Navigation property
        //Each training session is associated with one member, so we use a reference to represent this relationship.
        public int MemberId { get; set; } // Foreign key to link to the Member
        public virtual Member Member { get; set; }

        public override string ToString() => $"{SessionDate.ToShortDateString()} - {SessionType} ({DurationMinutes} mins). {CoachNotes}";

    }

    public class ClubData : DbContext
    {
        //the name of the database
        public ClubData() : base("OODExam_YelyzavetaKareieva") { }

        //DbSet properties to represent the collections of members and training sessions in the database.
        public DbSet<Member> Members { get; set; }
        public DbSet<TrainingSession> TrainingSessions { get; set; }
    }
}
