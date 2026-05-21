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
                    .Select(m => new
                    {
                        m.FirstName,
                        m.Surname,
                        m.ContactNumber
                    })
                    .ToList();

                lbxMembers.Items.Clear();
                foreach (var member in members)
                {
                    lbxMembers.Items.Add($"{member.FirstName} {member.Surname} - {member.ContactNumber}");
                }
            }
        }

    }
}
