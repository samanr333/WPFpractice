using Notification.Wpf;

namespace EFcrud.Services
{
    public class NotificationClass
    {
        private readonly NotificationManager _notificationManager = new NotificationManager();
        public void ShowAddNotification(string? Name, string? Email, int? RollNo)
        {
            var content = new NotificationContent
            {
                Title = "New Detail Recorded",
                Message = $"Name: {Name} \nEmail: {Email} \nRoll No: {RollNo}",
                Type = NotificationType.Success
            };
            _notificationManager.Show(content);
        }
        public void ShowRemoveNotification()
        {
            var content = new NotificationContent
            {
                Title = "Detail Removed",
                Type = NotificationType.Success
            };
            _notificationManager.Show(content);
        }
        public void ShowUpdateNotification(string? Name, string? Email, int? RollNo)
        {
            var content = new NotificationContent
            {
                Title = "Detail Updated \nUpdated info:",
                Message = $"Name: {Name} \nEmail: {Email} \nRoll No: {RollNo}",
                Type = NotificationType.Success
            };
            _notificationManager.Show(content);
        }
    }
}
