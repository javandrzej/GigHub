﻿using System;
using GigHub.Models;

namespace GigHub.Dtos
{
    public class NotificationDto
    {
        public DateTime DateTime { get; set; }
        public NotificationType Type { get; set; }
        public DateTime? OrginalDateTime { get; set; }
        public string OrginalVenue { get; set; }
        public GigDto Gig { get; set; }
    }
}