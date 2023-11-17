﻿namespace Altairis.ReP.Web;

public class AppSettings {

    public string Database { get; set; } = "Sqlite";

    public FeaturesConfig Features { get; set; } = new FeaturesConfig();

    public class FeaturesConfig {
        public bool UseAttachments { get; set; } = true;
        public bool UseCalendarEntries { get; set; } = true;
        public bool UseJournal { get; set; } = true;
        public bool UseMemberDirectory { get; set; } = true;
        public bool UseNews { get; set; } = true;
        public bool UseOpeningHours { get; set; } = true;
    }

    public DesignConfig Design { get; set; } = new DesignConfig();

    public class DesignConfig {
        public string ApplicationName { get; set; } = "ReP";
        public string CalendarEntryBgColor { get; set; } = "#090";
        public string CalendarEntryFgColor { get; set; } = "#fff";
        public string HeaderImageUrl { get; set; } = "~/Content/Images/rep-logo.svg";
        public string StylesheetUrl { get; set; } = "~/Content/Styles/site.min.css";
    }

    public SecurityConfig Security { get; set; } = new SecurityConfig();

    public class SecurityConfig {
        public int DefaultPasswordLength { get; set; } = 14;
        public int LoginCookieExpirationDays { get; set; } = 30;
        public int MinimumPasswordLength { get; set; } = 12;
    }

    public MailingConfig Mailing { get; set; } = new MailingConfig();

    public class MailingConfig {
        public string PickupFolder { get; set; } = @"C:\InetPub\MailRoot\pickup";
        public string SenderAddress { get; set; } = "example@example.com";
        public string SenderName { get; set; } = "ReP";
        public string? SendGridApiKey { get; set; }
    }

    public OpeningHoursConfig[] OpeningHours { get; set; } = [];

    public class OpeningHoursConfig {
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSpan ClosingTime { get; set; }
        public TimeSpan OpeningTime { get; set; }
    }

    public AttachmentsConfig Attachments { get; set; } = new AttachmentsConfig();

    public class AttachmentsConfig {
        public long MaximumFileSize { get; set; } = 104_857_600; // 100 MB
    }

    public IcsExportConfig IcsExport { get; set; } = new IcsExportConfig();

    public class IcsExportConfig {
        public TimeSpan BackDays { get; set; } = TimeSpan.FromDays(90);
    }

    public JournalConfig Journal { get; set; } = new JournalConfig();

    public class JournalConfig {
        public bool OnlyMastersCanWrite { get; set; } = false;
    }

}
