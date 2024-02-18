using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactBookService.CommonComponents
{
    public class VisitSummary
    {
        public string VisitCode { get; set; }
        public string Customer { get; set; }
        public string Effectivedate { get; set; }
        public int LocationId { get; set; }
        public string Location { get; set; }
        public string Industry { get; set; }
        public string VisitType { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PersonAttended { get; set; }
        public string OtherAttended { get; set; }
        public string SharedWith { get; set; }
        public string Comments { get; set; }
        public string Compition { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public ArrayList Attachments { get; set; }
        public ArrayList PeopleMetList { get; set; }
        public ArrayList ActionReqList { get; set; }
    }

    public class PeopleMet
    {
        public string ContactPerson { get; set; }
        public string EmailId { get; set; }
        public string ContactNo { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public string ActualFileName { get; set; }
        public string VirtualFileName { get; set; }
    }

    public class ActionReq
    {
        public string Department { get; set; }
        public string ActionRemark { get; set; }
        public string ExpCompletionDate { get; set; }
        public string EmailCompleteVisitInfo { get; set; }
        public string CCEmailTo { get; set; }
        public ArrayList Attachments { get; set; }
    }

    public class FileAttachment
    {
        public string ActualFileName { get; set; }
        public string VirtualFileName { get; set; }
    }

}