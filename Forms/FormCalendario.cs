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


namespace Journal_Elite.Forms
{
    public partial class FormCalendario : Form
    {


        //Classi Google Calendar
        static string[] Scopes = { CalendarService.Scope.Calendar};
        static string ApplicationName = "Google Calendar API .NET Quickstart";
        public FormCalendario()
        {
            InitializeComponent();
            LoadTheme();
            //Load Google Calendar
            GoogleAPI();

        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    
                    btn.ForeColor = Color.White;                   ;
                }
            }
            
            
        }
        private void FormCalendario_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void lblCalendarioTitle_Click(object sender, EventArgs e)
        {
           ForeColor = Color.FromArgb(128, 128, 255);
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
        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            AggiungiEvento f2 = new AggiungiEvento();
            f2.Show();

            
        }


        private void TimerCalendar_Tick(object sender, EventArgs e)
        {
            GoogleAPI();
            
        }

        private void CalendarEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://calendar.google.com/calendar/r?pli=1");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClassroomEvents_button_Click(object sender, EventArgs e)
        {
            
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RefreshDate_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd MMMM yyyy" + ",");
            lblDay.Text = DateTime.Now.ToString("dddd");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void lblDay_Click(object sender, EventArgs e)
        {

        }
    }
}
