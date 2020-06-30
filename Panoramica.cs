using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
using Google.Apis.Classroom.v1;
using Google.Apis.Classroom.v1.Data;
using Form = System.Windows.Forms.Form;

namespace Journal_Elite
{
    public partial class Panoramica : Form
    {

        //Classi  Google Classroom
        static string[] ScopesClassroom = { ClassroomService.Scope.ClassroomCourses};
        static string ApplicationNameClassroom = "Classroom API .NET Journal Elite";

        //Classi Google Calendar
        static string[] Scopes = { CalendarService.Scope.Calendar };

        static string ApplicationName = "Google Calendar API .NET Journal Elite";

        //Classi
        private Button currentbutton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
     
        public int myVar { get; private set; }
        
        public Panoramica()
        {
            InitializeComponent();
            random = new Random();
            
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //Avvia Google Classroom
            GoogleClassroomAPI();

            //Esegue Google Calendar
            GoogleAPI();

            


        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Google Classroom
        private void GoogleClassroomAPI()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentialsclassroom.json", FileMode.Open, FileAccess.Read))
            {

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
                ApplicationName = ApplicationName,
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
                ClassroomEvents.Text = "Nessun corso presente in Google Classroom";
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
            request.MaxResults = 7;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            // List events.
            Events events = request.Execute();
            
            if (events.Items != null && events.Items.Count > 0)
            {
                CalendarEvents.Text = "";
                foreach (var eventItem in events.Items)
                {
                    CalendarEvents.Text += "- " + eventItem.Summary + Environment.NewLine;
                }
            }
            else
            {
                CalendarEvents.Text = "Nessun evento imminente in Google Calendar";
            }
         
            
            
        }

        
        //Methods


        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if(currentbutton != (Button)btnSender)
                {
                       
                    currentbutton = (Button)btnSender;
                    
                    

                }
            }
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelLogo.BackColor = Color.FromArgb(0, 81, 0);
            panelTitleBar.BackColor = Color.FromArgb(0, 108, 0);
            panelMenu.BackColor = Color.FromArgb(0, 108, 0);
            btnCalendario.BackColor = Color.FromArgb(0, 108, 0);
            btnAgenda.BackColor = Color.FromArgb(0, 108, 0);
            btnOrario.BackColor = Color.FromArgb(0, 108, 0);
            btnProfilo.BackColor = Color.FromArgb(0, 108, 0);
            btnValutazioni.BackColor = Color.FromArgb(0, 108, 0);

            OpenChildForm(new Forms.FormOrario(), sender);
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            panelLogo.BackColor = Color.FromArgb(10, 41, 126);
            panelTitleBar.BackColor = Color.FromArgb(12, 50, 126);
            panelMenu.BackColor = Color.FromArgb(12, 50, 126);
            btnCalendario.BackColor = Color.FromArgb(12, 50, 126);
            btnAgenda.BackColor = Color.FromArgb(12, 50, 126);
            btnOrario.BackColor = Color.FromArgb(12, 50, 126);
            btnProfilo.BackColor = Color.FromArgb(12, 50, 126);
            btnValutazioni.BackColor = Color.FromArgb(12, 50, 126);
            OpenChildForm(new Forms.FormCalendario(), sender);
            
        }

        private void btnValutazioni_Click(object sender, EventArgs e)
        {
            panelLogo.BackColor = Color.FromArgb(140, 140, 0);
            panelTitleBar.BackColor = Color.FromArgb(168, 168, 0);
            panelMenu.BackColor = Color.FromArgb(168, 168, 0);
            btnCalendario.BackColor = Color.FromArgb(168, 168, 0);
            btnAgenda.BackColor = Color.FromArgb(168, 168, 0);
            btnOrario.BackColor = Color.FromArgb(168, 168, 0);
            btnProfilo.BackColor = Color.FromArgb(168, 168, 0);
            btnValutazioni.BackColor = Color.FromArgb(168, 168, 0);
            OpenChildForm(new Forms.FormValutazioni(), sender);
        }

        private void btnProfilo_Click(object sender, EventArgs e)
        {
            panelLogo.BackColor = Color.DarkCyan;
            panelTitleBar.BackColor = Color.FromArgb(0, 170, 170);
            panelMenu.BackColor = Color.FromArgb(0, 170, 170);
            btnCalendario.BackColor = Color.FromArgb(0, 170, 170);
            btnAgenda.BackColor = Color.FromArgb(0, 170, 170);
            btnOrario.BackColor = Color.FromArgb(0, 170, 170);
            btnProfilo.BackColor = Color.FromArgb(0, 170, 170);
            btnValutazioni.BackColor = Color.FromArgb(0, 170, 170);
            OpenChildForm(new Forms.FormProfilo(), sender);
        }
        public event EventHandler Click;
        
        private void btnAgenda_Click(object sender, EventArgs e)
        {
            panelLogo.BackColor = Color.DarkRed;
            panelTitleBar.BackColor = Color.FromArgb(173, 14, 22);
            panelMenu.BackColor = Color.FromArgb(173, 14, 22);
            btnCalendario.BackColor = Color.FromArgb(173, 14, 22);
            btnAgenda.BackColor = Color.FromArgb(173, 14, 22);
            btnOrario.BackColor = Color.FromArgb(173, 14, 22);
            btnProfilo.BackColor = Color.FromArgb(173, 14, 22);
            btnValutazioni.BackColor = Color.FromArgb(173, 14, 22);
            
           
            OpenChildForm(new Forms.FormAgenda(), sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(51, 51, 76);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentbutton = null;
            


        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
            {
                btnMaximize.Visible = false;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                btnMaximize.Visible = false;
                this.WindowState = FormWindowState.Normal;
            }
                
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void GetEvents_Tick(object sender, EventArgs e)
        {
            //Load Google Calendar in 1000tick
            GoogleAPI();
            //Load Google Classroom in 1000tick
            GoogleClassroomAPI();

        }

        private void CalendarEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://calendar.google.com/calendar/r?pli=1");
        }

        private void ClassroomEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://classroom.google.com/u/2/");
        }

        private void ptbxLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void ptbxLogo_Click_1(object sender, EventArgs e)
        {                       
            
            

            if (activeForm != null)
                activeForm.Close();
            Reset();
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void lblGoogleCalendarTitle_Click(object sender, EventArgs e)
        {

        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
