using System;
using System.Collections.Generic;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions
{
    public class Report
    {
        public string name { get; set; }
        public string url { get; set; }
        public bool in_black_list { get; set; }
    }

    public class BlacklistsReportInfo
    {
        public string result { get; set; }
        public string domain { get; set; }
        public string ip { get; set; }
        public List<Report> report { get; set; }
    }

    public class SmtpInformation
    {
        public bool ok { get; set; }
    }

    public class Message
    {
        public long id { get; set; }
        public int inbox_id { get; set; }
        public string subject { get; set; }
        public DateTime sent_at { get; set; }
        public string from_email { get; set; }
        public string from_name { get; set; }
        public string to_email { get; set; }
        public string to_name { get; set; }
        public int email_size { get; set; }
        public bool is_read { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public int html_body_size { get; set; }
        public int text_body_size { get; set; }
        public string human_size { get; set; }
        public string html_path { get; set; }
        public string txt_path { get; set; }
        public string raw_path { get; set; }
        public string download_path { get; set; }
        public string html_source_path { get; set; }
        public BlacklistsReportInfo blacklists_report_info { get; set; }
        public SmtpInformation smtp_information { get; set; }
    }
}
