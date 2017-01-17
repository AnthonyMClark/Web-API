using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace CIP.API.Models
{
    public class CIPRepository : ICIPRepository
    {
        private static ConcurrentDictionary<string, CIPModel> _todos = new ConcurrentDictionary<string, CIPModel>();

        public CIPModel GetCaseInfo(CIPModel item)
        {
            item.CaseNo = "1b23456";
            item.SSN = 123456789;
            item.DOB = "12/01/1980";
            item.CaseFirst = "Some";
            item.CaseLast = "Person";
            item.Street = "My Street";
            item.City = "Sacramento";
            item.State = "CA";
            item.Zip = 95816;
            item.HomePhone = "916-123-45678";
            item.MobilePhone = "916-987-6543";
            item.TextPhone = "916-123-4444";
            item.Email = "MyEmail@Internet.com";
            item.BCW = "BCWInfo";
            item.ARFirst = "Another";
            item.ARLast = "Person";
            return item;
        }
        public List<ToDoList> GetToDoList()
        {
            var toDoList = new List<ToDoList>();

            var toDo = new ToDoList();
            toDo.ActionDescription = "Suggest Apply for MA";
            toDoList.Add(toDo);

            var toDo2 = new ToDoList();
            toDo2.ActionDescription = "TASK Case Pending";
            toDoList.Add(toDo2);

            var toDo3 = new ToDoList();
            toDo3.ActionDescription = "Serenity Now";
            toDoList.Add(toDo3);
            return toDoList;
        }
        public Status GetCaseStatuses()
        {
            var status = new Status();
            status.EBT = "CF, CW";
            status.Homeless = true;
            status.ABC = "123";
            status.XYZ = "Zipper";
            return status;
        }
        public List<CaseIndicators> GetCaseIndicators()
        {
            var indicators = new List<CaseIndicators>();

            var indicator = new CaseIndicators();
            indicator.Name = "Minor Consent";
            indicator.IsActive = false;
            indicators.Add(indicator);

            var indicator2 = new CaseIndicators();
            indicator2.Name = "Family Violence";
            indicator2.IsActive = false;
            indicators.Add(indicator2);

            var indicator3 = new CaseIndicators();
            indicator3.Name = "AAP";
            indicator3.IsActive = true;
            indicators.Add(indicator3);
            return indicators;
        }
        public List<CaseActivity> GetCaseActivity()
        {
            var activities = new List<CaseActivity>();
            var activity = new CaseActivity();
            activity.Name = "Open Tasks";
            activity.ActivityCount = 2;
            activity.ActivityID = 1;
            activities.Add(activity);

            var activity2 = new CaseActivity();
            activity2.Name = "Documents Received";
            activity2.ActivityCount = 3;
            activity2.ActivityID = 2;
            activities.Add(activity2);

            var activity3 = new CaseActivity();
            activity3.Name = "Documents Sent";
            activity3.ActivityCount = 4;
            activity3.ActivityID = 3;
            activities.Add(activity3);

            var activity4 = new CaseActivity();
            activity4.Name = "Appointments";
            activity4.ActivityCount = 5;
            activity4.ActivityID = 4;
            activities.Add(activity4);

            var activity5 = new CaseActivity();
            activity5.Name = "Lobby Activity";
            activity5.ActivityCount = 5;
            activity5.ActivityID = 5;
            activities.Add(activity5);

            var activity6 = new CaseActivity();
            activity6.Name = "Calls";
            activity6.ActivityCount = 2;
            activity6.ActivityID = 6;
            activities.Add(activity6);

            var activity7 = new CaseActivity();
            activity7.Name = "ES Activities";
            activity7.ActivityCount = 5;
            activity7.ActivityID = 7;
            activities.Add(activity7);

            var activity8 = new CaseActivity();
            activity8.Name = "Child Care";
            activity8.ActivityCount = 2;
            activity8.ActivityID = 8;
            activities.Add(activity8);

            var activity9 = new CaseActivity();
            activity9.Name = "KinGap";
            activity9.ActivityCount = 2;
            activity9.ActivityID = 9;
            activities.Add(activity9);
            return activities;
        }

        public CaseActivityDetails GetActivityDetails()
        {
            var cad = new CaseActivityDetails();
            cad.Tasks = GetTasks();
            cad.DocRec = GetDocumentsReceived();
            cad.DocMailed = GetDocumentsMailed();
            cad.Appointment = GetAppointment();
            cad.Lobby = GetLobby();
            cad.Calls = GetCalls();
            cad.ESActivities = GetESActivities();
            cad.ChildCare = GetChildCare();
            cad.KinGAP = GetKinGAP();
            
            return cad;
        }

        public List<ESActivities> GetESActivities()
        {
            var esList = new List<ESActivities>();
            var es = new ESActivities();
            es.Activity = "Act Name";
            es.Status = "End Soon";
            es.LastName = "Clark";
            es.FirstName = "Anthony";
            es.ExpHours = 3;
            es.Unit = "Hours";
            es.StartDate = "12/15/2015";
            es.EndDate = "1/1/2016";
            es.ActivityLink = "KinGap Link";
            esList.Add(es);

            var es2 = new ESActivities();
            es2.Activity = "Next Name";
            es2.Status = "End Next";
            es2.LastName = "NextClark";
            es2.FirstName = "AnthonyNext";
            es2.ExpHours = 5;
            es2.Unit = "Day";
            es2.StartDate = "8/22/2014";
            es2.EndDate = "11/15/2015";
            es2.ActivityLink = "KinGap Link 2";
            esList.Add(es2);

            return esList;
        }

        public List<Calls> GetCalls()
        {
            var callList = new List<Calls>();
            var call = new Calls();
            call.Date = "4/12/2016";
            call.Time = "7:15am";
            call.Duration = 15;
            call.FromClientPhone = "9169990000";
            call.ToCountyPhone = "9168881111";
            call.ReceiveWKCD = "KMP1";
            call.ToClientPhone = "91612345678";
            call.FromCountyPhone = "9163221411";
            call.CallingWKCD = "KMP4";
            call.IsServiceCenter = true;
            callList.Add(call);

            var call2 = new Calls();
            call2.Date = "11/10/2015";
            call2.Time = "10:15am";
            call2.Duration = 2;
            call2.FromClientPhone = "9161110000";
            call2.ToCountyPhone = "9168222111";
            call2.ReceiveWKCD = "KMP0";
            call2.ToClientPhone = "9164545678";
            call2.FromCountyPhone = "9166621411";
            call2.CallingWKCD = "KMP2";
            call2.IsServiceCenter = false;
            callList.Add(call2);

            return callList;
        }

        public List<ChildCare> GetChildCare()
        {
            var childList = new List<ChildCare>();
            var child = new ChildCare();
            child.DateMailed = "1/5/2017";
            child.Category = "Cat Name";
            child.FormNo = "5";
            child.Source = "A Source Here";
            childList.Add(child);

            var child2 = new ChildCare();
            child2.DateMailed = "11/15/2016";
            child2.Category = "Cat Name 2";
            child2.FormNo = "58";
            child2.Source = "A Source Again 2";
            childList.Add(child2);

            return childList;
        }

        public List<KinGAP> GetKinGAP()
        {
            var kinList = new List<KinGAP>();
            var kin = new KinGAP();
            kin.DateMailed = "10/14/2016";
            kin.Category = "Cat Name 22";
            kin.FormNo = "65";
            kin.Source = "Another 2";
            kinList.Add(kin);

            var kin2 = new KinGAP();
            kin2.DateMailed = "9/16/2016";
            kin2.Category = "Cat Next 22";
            kin2.FormNo = "44";
            kin2.Source = "This 1";
            kinList.Add(kin2);

            return kinList;
        }

        public List<Tasks> GetTasks()
        {
            var taskList = new List<Tasks>();
            var task = new Tasks();
            task.CreateDate = "02/12/2016";
            task.Priority = "Urgent";
            task.Type = "Hearings";
            task.FormNo = "SAR 7";
            task.FormCat = "REPT";
            task.WorkerCode = "KMP0";
            task.Status = "Open";
            task.AssignedTo = "ClarkAn";
            task.CompletedDate = "08/10/2016";
            task.CompletedBy = "KMP4";
            task.Description = "FileNet Created";
            taskList.Add(task);

            var task2 = new Tasks();
            task2.CreateDate = "12/12/2016";
            task2.Priority = "Urgent";
            task2.Type = "Potatoes";
            task2.FormNo = "SC106";
            task2.FormCat = "PVER";
            task2.WorkerCode = "KMP1";
            task2.Status = "Complete";
            task2.AssignedTo = "MedranoJ";
            task2.CompletedBy = "KMP2";
            task2.CompletedDate = "05/10/2016";
            task2.Description = "Description";
            taskList.Add(task2);

            return taskList;
        }

        public List<DocumentsReceived> GetDocumentsReceived()
        {
            var docList = new List<DocumentsReceived>();
            var doc = new DocumentsReceived();
            doc.DateAdded = "01/01/2017";
            doc.FormNo = "SAC123";
            doc.Category = "CVER";
            doc.Source = "myBCW";
            doc.TaskCreationStatus = "Pending";
            doc.FileNetLink = "FileNet Link";
            docList.Add(doc);

            var doc2 = new DocumentsReceived();
            doc2.DateAdded = "11/14/2016";
            doc2.FormNo = "SAC321";
            doc2.Category = "MNOP";
            doc2.Source = "Mail CTR";
            doc2.TaskCreationStatus = "YES";
            doc2.FileNetLink = "FileNet Link";
            docList.Add(doc2);

            return docList;
        }

        public List<DocumentsMailed> GetDocumentsMailed()
        {
            var docList = new List<DocumentsMailed>();
            var doc = new DocumentsMailed();
            doc.DateMailed = "09/02/2016";
            doc.FormNo = "SAR 7";
            doc.Category = "REPT";
            doc.Source = "Batch";
            docList.Add(doc);

            var doc2 = new DocumentsMailed();
            doc2.DateMailed = "10/04/2016";
            doc2.FormNo = "V100";
            doc2.Category = "CVER";
            doc2.Source = "Batch";
            docList.Add(doc2);

            return docList;
        }

        public List<Appointment> GetAppointment()
        {
            var appList = new List<Appointment>();
            var app = new Appointment();
            app.Date = "11/04/2015";
            app.StartTime = "11:15 am";
            app.Type = "CF RR FTF";
            app.Location = "Bowling Green";
            app.Status = "No-Show";
            app.AssignedTo = "ClarkAn";
            app.CompletedBy = "KMP4";
            app.Reminder = "Text";
            app.LimsNote = "lims notes";
            app.LimsLink = "Link to LIMS";
            appList.Add(app);

            var app2 = new Appointment();
            app2.Date = "10/04/2017";
            app2.StartTime = "11:30 am";
            app2.Type = "CF";
            app2.Location = "Suzie Gaines";
            app2.Status = "Scheduled";
            app2.AssignedTo = "MedranoJ";
            app2.CompletedBy = "KMP3";
            app2.Reminder = "T / E";
            app2.LimsNote = "More LIMS notes";
            app2.LimsLink = "Link to LIMS";
            appList.Add(app2);

            return appList;
        }

        public List<Lobby> GetLobby()
        {
            var lobbyList = new List<Lobby>();
            var lobby = new Lobby();
            lobby.Date = "01/31/2017";
            lobby.KioskTime = "9:23 am";
            lobby.Reason = "Doc Submit";
            lobby.Location = "Bowling Green";
            lobby.LimsLink = "Link to LIMS";
            lobby.SSN = 123456744;
            lobbyList.Add(lobby);

            var lobby2 = new Lobby();
            lobby2.Date = "10/31/2016";
            lobby2.KioskTime = "12:20 am";
            lobby2.Reason = "Doc Submit";
            lobby2.Location = "Suzie Gaines";
            lobby2.LimsLink = "Link to LIMS";
            lobby2.SSN = 955846523;
            lobbyList.Add(lobby2);

            return lobbyList;
        }

        public List<CaseComments> GetCaseComments()
        {
            var comments = new List<CaseComments>();
            var comment = new CaseComments();
            comment.CommentDate = "12/01/2015";
            comment.Priority = "High";
            comment.Program = "MA";
            comment.User = "ClarkA";
            comment.Description = "Some kind of important description";
            comments.Add(comment);

            var comment2 = new CaseComments();
            comment2.CommentDate = "11/21/2013";
            comment2.Priority = "Low";
            comment2.Program = "CF";
            comment2.User = "KruegerT";
            comment2.Description = "More descriptions here!";
            comments.Add(comment2);

            var comment3 = new CaseComments();
            comment3.CommentDate = "01/15/2014";
            comment3.Priority = "High";
            comment3.Program = "CR";
            comment3.User = "MedranoJ";
            comment3.Description = "So many descriptions!";
            comments.Add(comment3);
            return comments;
        }
        public List<ActiveIndividuals> GetActiveIndividuals()
        {
            var individuals = new List<ActiveIndividuals>();

            var individual = new ActiveIndividuals();
            individual.IndivID = 1;
            individual.Name = "Evans, Mike";
            individual.Relation = "Father";
            individual.DOB = "10/10/1990";
            individual.CWIN = "12345678";
            individual.SSN = 123456789;
            individuals.Add(individual);

            var individual2 = new ActiveIndividuals();
            individual2.IndivID = 2;
            individual2.Name = "Jones, Julio";
            individual2.Relation = "Brother";
            individual2.DOB = "11/12/1992";
            individual2.CWIN = "33335678";
            individual2.SSN = 14446789;
            individuals.Add(individual2);

            var individual3 = new ActiveIndividuals();
            individual3.IndivID = 3;
            individual3.Name = "Brown, Antonio";
            individual3.Relation = "Son";
            individual3.DOB = "08/20/1991";
            individual3.CWIN = "44445678";
            individual3.SSN = 16666789;
            individuals.Add(individual3);

            var individual4 = new ActiveIndividuals();
            individual4.IndivID = 4;
            individual4.Name = "Edelman, Julian";
            individual4.Relation = "Brother";
            individual4.DOB = "09/26/1988";
            individual4.CWIN = "87456218";
            individual4.SSN = 656239999;
            individuals.Add(individual4);
            return individuals;
        }
        public List<IndividualDetails> GetIndivDetails()
        {
            var details = new List<IndividualDetails>();

            var detail = new IndividualDetails();
            detail.IndivID = 1;
            detail.Program = "CalWORKs";
            detail.Status = "Active";
            detail.RRDueDate = "12/17/2016";
            detail.TOAWeeks = 5;
            detail.GrantAmount = "$150.47";
            detail.WorkerCode = "KMP4";
            details.Add(detail);

            var detail1x = new IndividualDetails();
            detail1x.IndivID = 1;
            detail1x.Program = "CalFresh";
            detail1x.Status = "Active";
            detail1x.RRDueDate = "12/12/2015";
            detail1x.TOAWeeks = 3;
            detail1x.GrantAmount = "$1560.47";
            detail1x.WorkerCode = "KMP3";
            details.Add(detail1x);

            var detail1y = new IndividualDetails();
            detail1y.IndivID = 1;
            detail1y.Program = "FSET";
            detail1y.Status = "Active";
            detail1y.RRDueDate = "01/11/2017";
            detail1y.TOAWeeks = 8;
            detail1y.GrantAmount = "$980.47";
            detail1y.WorkerCode = "KMP4";
            details.Add(detail1y);

            var detail2 = new IndividualDetails();
            detail2.IndivID = 2;
            detail2.Program = "CalFresh";
            detail2.Status = "Active";
            detail2.RRDueDate = "02/04/2016";
            detail2.TOAWeeks = 8;
            detail2.GrantAmount = "$195.22";
            detail2.WorkerCode = "KMP0";
            details.Add(detail2);

            var detail2x = new IndividualDetails();
            detail2x.IndivID = 2;
            detail2x.Program = "GA";
            detail2x.Status = "Active";
            detail2x.RRDueDate = "12/14/2016";
            detail2x.TOAWeeks = 4;
            detail2x.GrantAmount = "$289.22";
            detail2x.WorkerCode = "KMP4";
            details.Add(detail2x);

            var detail3 = new IndividualDetails();
            detail3.IndivID = 3;
            detail3.Program = "General Assistance";
            detail3.Status = "Inactive";
            detail3.RRDueDate = "01/15/2015";
            detail3.TOAWeeks = 7;
            detail3.GrantAmount = "$58.63";
            detail3.WorkerCode = "KMP2";
            details.Add(detail3);

            var detail4 = new IndividualDetails();
            detail4.IndivID = 4;
            detail4.Program = "MediCal";
            detail4.Status = "Active";
            detail4.RRDueDate = "04/22/2014";
            detail4.TOAWeeks = 6;
            detail4.GrantAmount = "$452.33";
            detail4.WorkerCode = "KMP1";
            details.Add(detail4);

            var detail4x = new IndividualDetails();
            detail4x.IndivID = 4;
            detail4x.Program = "CalFresh";
            detail4x.Status = "Active";
            detail4x.RRDueDate = "07/02/2015";
            detail4x.TOAWeeks = 8;
            detail4x.GrantAmount = "$754.63";
            detail4x.WorkerCode = "KMP0";
            details.Add(detail4x);

            var detail4y = new IndividualDetails();
            detail4y.IndivID = 4;
            detail4y.Program = "GA";
            detail4y.Status = "Active";
            detail4y.RRDueDate = "11/25/2015";
            detail4y.TOAWeeks = 3;
            detail4y.GrantAmount = "$212.33";
            detail4y.WorkerCode = "KMP2";
            details.Add(detail4y);

            var detail4z = new IndividualDetails();
            detail4z.IndivID = 4;
            detail4z.Program = "FSET";
            detail4z.Status = "Active";
            detail4z.RRDueDate = "09/08/2016";
            detail4z.TOAWeeks = 10;
            detail4z.GrantAmount = "$962.97";
            detail4z.WorkerCode = "KMP4";
            details.Add(detail4z);

            return details;
        }
        public IEnumerable<CIPModel> GetAll()
        {
            return _todos.Values;
        }

        public CIPModel Find(string key)
        {
            CIPModel item;
            _todos.TryGetValue(key, out item);
            return item;
        }
    }
}
