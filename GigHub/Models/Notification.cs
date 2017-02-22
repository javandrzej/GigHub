using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Notification
    {
        public int Id { get; private set; }
        public DateTime DateTime { get; private set; }
        public NotificationType Type { get; private set; }
        public DateTime? OrginalDateTime { get; private set; }
        public string OrginalVenue { get; private set; }

        [Required]
        public Gig Gig { get; private set; }

        public Notification()
        {

        }

        private Notification(NotificationType type, Gig gig)
        {
            if (gig == null) throw new ArgumentNullException();

            Type = type;
            Gig = gig;
            DateTime = DateTime.Now;
        }

        public static Notification GigCreated(Gig gig)
        {
            return new Notification(NotificationType.GigCreated, gig);
        }

        public static Notification GigUpdated(Gig newGig, DateTime orgiginalDateTime, string originalVenue)
        {
            var notification = new Notification(NotificationType.GigUpdated, newGig);
            notification.OrginalDateTime = orgiginalDateTime;
            notification.OrginalVenue = originalVenue;
            return notification;
        }

        public static Notification GigCanceled(Gig gig)
        {

        }
    }
}