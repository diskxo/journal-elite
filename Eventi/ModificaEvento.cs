using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using System.Globalization;
using Journal_Elite.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics.Eventing.Reader;
using Google.Apis.Upload;


namespace Journal_Elite.Forms
{
    public partial class ModificaEvento : Form
    {

        
        //Classi Google Calendar
        static string[] Scopes = { CalendarService.Scope.Calendar };
        static string ApplicationName = "Google Calendar API .NET Journal Elite";
        public ModificaEvento()
        {
            InitializeComponent();
        }
        //Connect to Google Calendar
        private void GoogleEdit()
        {
            

            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }
            if (credential != null)
            {
                // Create Google Calendar API service.
                var calendarService = new CalendarService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });
                if (calendarService != null)
                {
                    string emailAddress = string.Empty;
                    var list = calendarService.CalendarList.List().Execute();
                    var calendar = list.Items.SingleOrDefault(c => c.Summary == emailAddress);
                    if (calendar != null)
                    {
                        //Define parameters of request 
                        EventsResource.ListRequest request = calendarService.Events.List("primary");
                        request.TimeMin = DateTime.Now;
                        request.ShowDeleted = false;
                        request.SingleEvents = true;
                        request.MaxResults = 10;
                        request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

                        //Get selected items
                        Google.Apis.Calendar.v3.Data.Events events = request.Execute();
                        string eventId = string.Empty;
                        var selectedEvent = events.Items.FirstOrDefault(c => c.Id == eventId);
                        if (selectedEvent != null)
                        {
                            selectedEvent.Summary = Nome.Text;
                            selectedEvent.Description = Descrizione.Text;
                            selectedEvent.Location = Location.Text;
                            selectedEvent.Start = new Google.Apis.Calendar.v3.Data.EventDateTime

                            {

                                DateTime = DateTime.Now.AddDays(5).AddHours(2)
                            };
                            selectedEvent.End = new Google.Apis.Calendar.v3.Data.EventDateTime
                            {
                                DateTime = DateTime.Now.AddDays(5).AddHours(10)
                            };
                            selectedEvent.Recurrence = new List<string>();

                            //Set Remainder
                            selectedEvent.Reminders = new Google.Apis.Calendar.v3.Data.Event.RemindersData()
                            {
                                UseDefault = false,
                                Overrides = new Google.Apis.Calendar.v3.Data.EventReminder[]
                                {
                                    new Google.Apis.Calendar.v3.Data.EventReminder() { Method = "email", Minutes = 12 * 60 },
                                    new Google.Apis.Calendar.v3.Data.EventReminder() { Method = "popup", Minutes = 12 * 60 }
                                }
                            };
                            //Set Attendees
                            selectedEvent.Attendees = new Google.Apis.Calendar.v3.Data.EventAttendee[]
                            {
                                new Google.Apis.Calendar.v3.Data.EventAttendee() { Email = Email.Text }
                            };
                        }
                        var updateEventRequest = calendarService.Events.Update(selectedEvent, calendar.Id, eventId);
                        updateEventRequest.SendNotifications = true;
                        Event eventResult = updateEventRequest.Execute();
                    }
                }
            }
            
        }
        private void DeleteEvent_Click(object sender, EventArgs e)
        {
            
        }

        private void ModificaEvento_Load(object sender, EventArgs e)
        {
            
        }

        private void Giorni_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Giorni.Text))
            {

                int number = Convert.ToInt32(Giorni.Text);
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Ore.Text))
            {

                int number = Convert.ToInt32(Ore.Text);
            }
            

        }

        private void EditEvent_Click(object sender, EventArgs e)
        {
            GoogleEdit();
            if(Email.TextLength < 5)
            {
                MessageBox.Show("Devi inserire il tuo indirizzo mail per poter modificare un evento!");
            }
            else 
            {
                MessageBox.Show("Il tuo evento è stato modificato con successo!");
            }

        }

        private void Nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
