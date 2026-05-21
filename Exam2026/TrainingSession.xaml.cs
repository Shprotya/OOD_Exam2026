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
using System.Windows.Shapes;

namespace Exam2026
{
    /// <summary>
    /// Interaction logic for TrainingSession.xaml
    /// </summary>
    public partial class TrainingSession : Window
    {
        public TrainingSession()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            using (ClubData db = new ClubData())
            {
                var session = new TrainingSession
                {
                    SessionDate = datePick.SelectedDate.Value,
                    DurationMinutes = int.Parse(timePick.Text),
                    SessionType = Type.Text,
                    CoachNotes = tbxNotes.Text
                };
                db.TrainingSessions.Add(session);
                db.SaveChanges();
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            datePick.SelectedDate = null;
            timePick.Value = 0;
            Type.Text = string.Empty;
            tbxNotes.Text = string.Empty;
        }
    }
}
