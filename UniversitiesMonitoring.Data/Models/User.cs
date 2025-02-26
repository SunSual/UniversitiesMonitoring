﻿namespace UniversityMonitoring.Data.Models
{
    public class User
    {
        public User()
        {
            UniversityServiceReports = new HashSet<UniversityServiceReport>();
            UserRateOfServices = new HashSet<UserRateOfService>();
            UserSubscribeToServices = new HashSet<UserSubscribeToService>();
        }

        public ulong Id { get; set; }
        public string Username { get; set; } = null!;
        public byte[] PasswordSha256hash { get; set; } = null!;
        public string? Email { get; set; }
        public string? TelegramTag { get; set; }
        public bool SendEmailNotification { get; set; }
        public bool SendTelegramNotification { get; set; }

        public ICollection<UniversityServiceReport> UniversityServiceReports { get; set; }
        public ICollection<UserRateOfService> UserRateOfServices { get; set; }
        public ICollection<UserSubscribeToService> UserSubscribeToServices { get; set; }
    }
}
