using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIP.API.Models
{
    public class CIPModel
    {
        public string CaseNo { get; set; }
        public int SSN { get; set; }
        public string DOB { get; set; }
        public string CaseFirst { get; set; }
        public string CaseLast { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string TextPhone { get; set; }
        public string Email { get; set; }
        public string BCW { get; set; }
        public string ARFirst { get; set; }
        public string ARLast { get; set; }
        public List<CaseIndicators> Indicators { get; set; }
        public Status CaseStatus { get; set; }
        public List<ToDoList> ToDoList { get; set; }
        public List<ActiveIndividuals> CaseIndividuals { get; set; }
        public List<IndividualDetails> IndivDetails { get; set; }
        public List<CaseActivity> CaseActivity { get; set; }
        public List<CaseComments> CaseComments { get; set; }
        public CaseActivityDetails CaseActivityDetails { get; set; }
        public string NotFound { get; set; }
    }
    public class CaseActivityDetails
    {
        public List<Tasks> Tasks { get; set; }
        public int TasksID = 1;

        public List<DocumentsReceived> DocRec { get; set; }
        public int DocRecID = 2;

        public List<DocumentsMailed> DocMailed { get; set; }
        public int DocMailedID = 3;

        public List<Appointment> Appointment { get; set; }
        public int AppointmentID = 4;

        public List<Lobby> Lobby { get; set; }
        public int LobbyID = 5;

        public List<Calls> Calls { get; set; }
        public int CallsID = 6;

        public List<ESActivities> ESActivities { get; set; }
        public int ESActivitiesID = 7;

        public List<ChildCare> ChildCare { get; set; }
        public int ChildCareID = 8;

        public List<KinGAP> KinGAP { get; set; }
        public int KinGAPID = 9;

    }
    public class CaseIndicators
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
    public class Status
    {
        public string EBT { get; set; }
        public bool Homeless { get; set; }
        public string ABC { get; set; }
        public string XYZ { get; set; }
    }
    public class ToDoList 
    {
        public string ActionDescription { get; set; }
    }
    public class ActiveIndividuals
    {
        public int IndivID { get; set; }
        public string Name { get; set; }
        public string Relation { get; set; }
        public string DOB { get; set; }
        public string CWIN { get; set; }
        public int SSN { get; set; }
    }
    public class IndividualDetails
    {
        public int IndivID { get; set; }
        public string Program { get; set; }
        public string Status { get; set; }
        public string RRDueDate { get; set; }
        public int TOAWeeks { get; set; }
        public string GrantAmount { get; set; }
        public string WorkerCode { get; set; }
    }
    public class CaseActivity
    {
        public int ActivityID { get; set; }
        public string Name { get; set; }
        public int ActivityCount { get; set; }
    }
    public class CaseComments
    {
        public string CommentDate { get; set; }
        public string Priority { get; set; }
        public string Program { get; set; }
        public string User { get; set; }
        public string Description { get; set; }
    }
    public class Tasks
    {
        public int ActivityID { get; set; }
        public string CreateDate { get; set; }
        public string Priority { get; set; }
        public string Type { get; set; }
        public string FormNo { get; set; }
        public string FormCat { get; set; }
        public string WorkerCode { get; set; }
        public string Status { get; set; }
        public string AssignedTo { get; set; }
        public string CompletedBy { get; set; }
        public string CompletedDate { get; set; }
        public string Description { get; set; }
    }
    public class DocumentsReceived
    {
        public int ActivityID { get; set; }
        public string DateAdded { get; set; }
        public string FormNo { get; set; }
        public string Category { get; set; }
        public string Source { get; set; }
        public string TaskCreationStatus { get; set; }
        public string FileNetLink { get; set; }
    }
    public class DocumentsMailed
    {
        public int ActivityID { get; set; }
        public string DateMailed { get; set; }
        public string FormNo { get; set; }
        public string Category { get; set; }
        public string Source { get; set; }
    }
    public class Appointment
    {
        public int ActivityID { get; set; }
        public string Date { get; set; }
        public string StartTime { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public string AssignedTo { get; set; }
        public string CompletedBy { get; set; }
        public string Reminder { get; set; }
        public string LimsNote { get; set; }
        public string LimsLink { get; set; }
    }
    public class Lobby
    {
        public int ActivityID { get; set; }
        public string Date { get; set; }
        public string KioskTime { get; set; }
        public string Reason { get; set; }
        public string Location { get; set; }
        public string LimsLink { get; set; }
        public int SSN { get; set; }
    }
    public class Calls
    {
        public int ActivityID { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Duration { get; set; }
        public string FromClientPhone { get; set; }
        public string ToCountyPhone { get; set; }
        public string ReceiveWKCD { get; set; }
        public string ToClientPhone { get; set; }
        public string FromCountyPhone { get; set; }
        public string CallingWKCD { get; set; }
        public bool IsServiceCenter { get; set; }
    }
    public class ESActivities
    {
        public int ActivityID { get; set; }
        public string Activity { get; set; }
        public string Status { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int ExpHours { get; set; }
        public string Unit { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string ActivityLink { get; set; }
    }
    public class ChildCare
    {
        public int ActivityID { get; set; }
        public string DateMailed { get; set; }
        public string FormNo { get; set; }
        public string Category { get; set; }
        public string Source { get; set; }
    }
    public class KinGAP
    {
        public int ActivityID { get; set; }
        public string DateMailed { get; set; }
        public string FormNo { get; set; }
        public string Category { get; set; }
        public string Source { get; set; }
    }
}
