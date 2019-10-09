using Syncfusion.UI.Xaml.Schedule;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace RecurrenceAppointment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Creating instance for custom appointment class
            Meeting meeting = new Meeting();
            // Setting start time of an event
            meeting.From = new DateTime(2017, 06, 11, 10, 0, 0);
            // Setting end time of an event
            meeting.To = meeting.From.AddHours(2);
            // Setting start time for an event
            meeting.EventName = "Client Meeting";
            // Setting color for an event
            meeting.Color = Brushes.Green;
            meeting.IsRecursive = true;

            // Creating recurrence rule
            RecurrenceProperties recurrenceProperties = new RecurrenceProperties();
            recurrenceProperties.RecurrenceType = RecurrenceType.Weekly;
            recurrenceProperties.IsWeeklyTuesday = true;
            recurrenceProperties.IsWeeklyWednesday = true;
            recurrenceProperties.IsWeeklyThursday = true;
            recurrenceProperties.RangeRecurrenceCount = 10;
            recurrenceProperties.RecurrenceRule = ScheduleHelper.RRuleGenerator(recurrenceProperties, meeting.From, meeting.To);

            // Setting recursive rule for an event
            meeting.RecurrenceRule = recurrenceProperties.RecurrenceRule;

            // Creating instance for collection of custom appointments
            var Meetings = new ObservableCollection<Meeting>();
            // Adding a custom appointment in CustomAppointmentCollection
            Meetings.Add(meeting);
            this.schedule.ItemsSource = Meetings;
            schedule.MoveToDate(meeting.From);
        }
    }
}
