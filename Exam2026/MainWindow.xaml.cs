using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exam2026
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadMembers();
        }

        private void LoadMembers()
        {
            using (ClubData db = new ClubData())
            {
                var members = db.Members
                    .OrderBy(m => m.Surname)
                    .ThenBy(m => m.FirstName)
                    .ToList();

                lbxMembers.ItemsSource = members;
            }
        }

        private void lbxMembers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedMember = lbxMembers.SelectedItem as Member;
            if (selectedMember == null) // ← null means nothing selected, so bail out
                return;

            lbxID.Text = selectedMember.MemberId.ToString();
            lbxFName.Text = selectedMember.FirstName;
            lbxLName.Text = selectedMember.Surname;
            lbxNumber.Text = selectedMember.ContactNumber;
            lbxMembershipType.Text = selectedMember.MembershipType;
            lbxDOB.Text = selectedMember.DateOfBirth.ToShortDateString();

            using (ClubData db = new ClubData())
            {
                var sessions = db.TrainingSessions
                    .Where(s => s.MemberId == selectedMember.MemberId)
                    .OrderByDescending(s => s.SessionDate)
                    .ToList();
                lbxSessions.ItemsSource = sessions;
            }
        }
    }
}
