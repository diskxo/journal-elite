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
using Form = System.Windows.Forms.Form;

namespace Journal_Elite
{
    public partial class AggiungiEvento : Form
    {
        //Classi Google Calendar
        static string[] Scopes = { CalendarService.Scope.Calendar };
        static string ApplicationName = "Google Calendar API .NET Journal Elite";

        public AggiungiEvento()
        {
            InitializeComponent();
            
            
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {

        }
        //Connect to Google Calendar
        private void GoogleAPI()
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

            // Create Google Calendar API service.
            var calendarService = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            //Email
            
            //Create event
            if (calendarService != null)
            {

                var list = calendarService.CalendarList.List().Execute();
                var calendar = list.Items.SingleOrDefault(c => c.Summary == txtGmail.Text.Trim());
                Google.Apis.Calendar.v3.Data.Event calendarEvent = new Google.Apis.Calendar.v3.Data.Event();
                if (calendar != null)
                {
                    //.Text converte la textbox in stringa
                    calendarEvent.Summary = Name.Text;
                    calendarEvent.Description = Descrizione.Text;
                    calendarEvent.Location = Location.Text;
                    calendarEvent.Start = new Google.Apis.Calendar.v3.Data.EventDateTime
                    {
                        DateTime = DateTime.Now.AddDays(1).AddHours(2)
                    };
                    calendarEvent.End = new Google.Apis.Calendar.v3.Data.EventDateTime
                    {
                        DateTime = DateTime.Now.AddDays(1).AddHours(10)
                    };
                    calendarEvent.Recurrence = new List<string>();

                    //Set Remainder
                    calendarEvent.Reminders = new Google.Apis.Calendar.v3.Data.Event.RemindersData()
                    {
                        UseDefault = false,
                        Overrides = new Google.Apis.Calendar.v3.Data.EventReminder[]
                        {
                        new Google.Apis.Calendar.v3.Data.EventReminder() {Method = "email", Minutes = 24 * 60},
                        new Google.Apis.Calendar.v3.Data.EventReminder() {Method = "popup", Minutes = 24 * 60}
                        }
                    };
                    

                    var newEventRequest = calendarService.Events.Insert(calendarEvent, calendar.Id);
                    var EventResult = newEventRequest.Execute();
                    
                    //insertedEventId = EventResult.Id;
                    //Session["EventId"] = invertedEventId;
                 
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            GoogleAPI();
            if(txtGmail.TextLength > 5)
            {
                MessageBox.Show("Evento creato!");
            }
            else
            {
                MessageBox.Show("Nel campo'Email' è richiesta la mail dove vuoi salvare il promemoria. Hai inserito meno di 5 caratteri!");
            }
            
        }

        private void Da_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
