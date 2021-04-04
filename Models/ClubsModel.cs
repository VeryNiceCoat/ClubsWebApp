using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ClubsModel
    {
        public int ClubID { get; set; }

        [Required]
        [DisplayName ("Club Name")]
        public string ClubName { get; set; }
        [Required]
        [DisplayName ("Meeting Day")]
        public string MeetingDay { get; set; }
        [Required]
        [DisplayName  ("Remote Meeting Link")]
        public string MeetLink { get; set; }
        [Required]
        [DisplayName ("Start Time")]
        public TimeSpan StartTime { get; set; }
        [Required]
        [DisplayName ("End Time")]
        public TimeSpan EndTime { get; set; }
        [Required]
        [DisplayName ("Name of Club Advisor")]
        public string Advisor { get; set; }
        [Required]
        [DisplayName ("Club Advisor's Email")]
        public string AdvisorEmail { get; set; }
        [Required]
        [DisplayName ("Club President's Name")]
        public string PresName { get; set; }
        [Required]
        [DisplayName ("Club President's Email")]
        public string PresEmail { get; set; }
        [Required]
        [DisplayName ("Club Description")]
        public string Descriptions { get; set; }
        [Required]
        [DisplayName ("Club Room Number")]
        public int RoomNo { get; set; }

        public ClubsModel()
        {
            ClubID = -1;
            ClubName = "None";
            MeetingDay = "None";
            MeetLink = "None";
            StartTime = new TimeSpan(0, 0, 0, 0);
            EndTime = new TimeSpan(0, 0, 0, 0);
            Advisor = "None";
            AdvisorEmail = "None";
            PresName = "None";
            PresEmail = "None";
            Descriptions = "None";
            RoomNo = 0;

        }

        public ClubsModel(int id, string clubName, string meetingDay, string meetLink, TimeSpan startTime, 
                          TimeSpan endTime, string advisor, string advisorEmail, string presName, string presEmail, string desc, int roomNo)
        {
            ClubID = id;
            ClubName = clubName;
            MeetingDay = meetingDay;
            MeetLink = meetLink;
            StartTime = startTime;
            EndTime = endTime;
            Advisor = advisor;
            AdvisorEmail = advisorEmail;
            PresName = presName;
            PresEmail = presEmail;
            Descriptions = desc;
            RoomNo = roomNo;
        }
    }
}
