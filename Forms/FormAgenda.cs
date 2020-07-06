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
using Google.Apis.Classroom.v1;
using Google.Apis.Classroom.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;

namespace Journal_Elite.Forms
{
    public partial class FormAgenda : System.Windows.Forms.Form
    {
        //Classi Google Calendar
        static string[] Scopes = { CalendarService.Scope.Calendar };
        static string ApplicationName = "Google Calendar API .NET Journal Elite";


        // Classi Google Classroom
        static string[] ScopesClassroom = { ClassroomService.Scope.ClassroomCoursesReadonly };
        static string ApplicationNameClassroom = "Classroom API .NET Journal Elite";
        public FormAgenda()
        {
            InitializeComponent();;
            GoogleAPI();
    
        }
        
        private void GoogleClassroomAPI()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentialsclassroom.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "tokenclassroom.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    ScopesClassroom,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                
            }

            // Create Classroom API service.
            var service = new ClassroomService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationNameClassroom,
            });

            // Define request parameters.
            CoursesResource.ListRequest request = service.Courses.List();
            request.PageSize = 10;

            // List courses.
            ListCoursesResponse response = request.Execute();

            if (response.Courses != null && response.Courses.Count > 0)
            {

                ClassroomEvents.Text = "";
                foreach (var course in response.Courses)
                {
                    ClassroomEvents.Text += "- " + course.Name + "\n";
                    
                }
            }
            else
            {
                ClassroomEvents.Text = "Nessun corso";
            }

        }
        //Google Calendar API
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

            // Define parameters of request.
            EventsResource.ListRequest request = calendarService.Events.List("primary");
            request.TimeMin = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 6;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            // List events.
            Events events = request.Execute();

            if (events.Items != null && events.Items.Count > 0)
            {
                Events_button.Text = "";
                foreach (var eventItem in events.Items)
                {
                    Events1_button.Text += "- " + eventItem.Summary;
                    Events2_button.Text += "- " + eventItem.Summary;
                    Events3_button.Text += "- " + eventItem.Summary;
                    Events4_button.Text += "- " + eventItem.Summary;
                    Events5_button.Text += "- " + eventItem.Summary;
                    Events6_button.Text += "- " + eventItem.Summary;
                    Events_button.Visible = false;
                }
            }
            else
            {
                Events1_button.Visible = false;
                Events2_button.Visible = false;
                Events3_button.Visible = false;
                Events4_button.Visible = false;
                Events5_button.Visible = false;
                Events6_button.Visible = false;
                Events_button.Text = "Nessun evento imminente" + "\n" + "in Google Calendar";

            }



        }

        private void FormAgenda_Load(object sender, EventArgs e)
        {
            

        }

        private void lblAgendaTitle_Click(object sender, EventArgs e)
        {

        }

        private void GetEvents_Tick(object sender, EventArgs e)
        {
            //Load Google Classroom in 1900 ticks
            GoogleClassroomAPI();
            GoogleAPI();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(173, 14, 22);
        }

        private void ClassroomEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://classroom.google.com/u/2/");

        }



        private void TimerClassroom_Tick(object sender, EventArgs e)
        {
            GoogleClassroomAPI();
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            AggiungiEvento f2 = new AggiungiEvento();
            f2.Show();
           
        }

        private void Events1_button_Click(object sender, EventArgs e)
        {
            ModificaEvento f2 = new ModificaEvento();
            f2.Show();
        }

        private void Events2_button_Click(object sender, EventArgs e)
        {
            ModificaEvento f2 = new ModificaEvento();
            f2.Show();
        }

        private void Events3_button_Click(object sender, EventArgs e)
        {
            ModificaEvento f2 = new ModificaEvento();
            f2.Show();
        }

        private void Events4_button_Click(object sender, EventArgs e)
        {
            ModificaEvento f2 = new ModificaEvento();
            f2.Show();
        }

        private void Events5_button_Click(object sender, EventArgs e)
        {
            ModificaEvento f2 = new ModificaEvento();
            f2.Show();
        }

        private void Events6_button_Click(object sender, EventArgs e)
        {
            ModificaEvento f2 = new ModificaEvento();
            f2.Show();
        }

        private void Events_button_Click(object sender, EventArgs e)
        {

        }
    }
}
