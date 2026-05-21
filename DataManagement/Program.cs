using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam2026;

namespace DataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClubData db = new ClubData();
            try
            {
                using (db)
                {
                    Member member1 = new Member
                    {
                        FirstName = "Niamh",
                        Surname = "Kelly",
                        DateOfBirth = new DateTime(1998, 3, 14),
                        ContactNumber = "087 333 4455",
                        MembershipType = "Senior"
                    };

                    Member member2 = new Member
                    {
                        FirstName = "Ciarán",
                        Surname = "Murphy",
                        DateOfBirth = new DateTime(2005, 7, 22),
                        ContactNumber = "083 444 5566",
                        MembershipType = "Junior"
                    };

                    Member member3 = new Member
                    {
                        FirstName = "Fiona",
                        Surname = "Walsh",
                        DateOfBirth = new DateTime(1975, 11, 5),
                        ContactNumber = "089 555 6677",
                        MembershipType = "Veteran"
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
