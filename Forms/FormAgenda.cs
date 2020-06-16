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


namespace Journal_Elite.Forms
{
    public partial class FormAgenda : System.Windows.Forms.Form
    {
        // Classi Google Classroom
        static string[] Scopes = { ClassroomService.Scope.ClassroomCoursesReadonly };
        static string ApplicationName = "Classroom API .NET Journal Elite";
        public FormAgenda()
        {
            InitializeComponent();;

    
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
                    Scopes,
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
                ClassroomEvents.Text = "Nessun corso";
            }

        }
        private void GoogleClassroomHomework()
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
                    Scopes,
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

                lblHomework.Text = "";
                foreach (var course in response.Courses)
                {
                    lblHomework.Text += "- " + course.Name + "\n";

                }
            }
            else
            {
                lblHomework.Text = "Nessun corso";
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
            //Load homework in 1900 ticks
            GoogleClassroomHomework();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(173, 14, 22);
        }

        private void ClassroomEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://classroom.google.com/u/2/");

        }

        private void CompitiTitle_Click(object sender, EventArgs e)
        {
            CompitiTitle.ForeColor = Color.FromArgb(173, 14, 22);
        }

        private void TimerClassroom_Tick(object sender, EventArgs e)
        {
            GoogleClassroomAPI();
        }
    }
}
