//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Monitoring2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MonitoringSite
    {
        public int MonitoringSiteId { get; set; }
        public string Url { get; set; }
        public Nullable<int> Interval { get; set; }
        public string VerifyWord { get; set; }
        public bool Active { get; set; }
        public Nullable<System.DateTime> LastRun { get; set; }
        public bool SendEmail { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserNameTextInputName { get; set; }
        public string PasswordTextInputName { get; set; }
        public string LoginSubmitButtonName { get; set; }
        public string ReportSubmitButtonName { get; set; }
        public int NbFail { get; set; }
        public Nullable<int> IntervalSec { get; set; }
    }
}