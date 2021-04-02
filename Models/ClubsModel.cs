using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ClubsModel
    {
        public int ClubID { get; set; }
        public string ClubName { get; set; }
        public string MeetingDay { get; set; }
        public string MeetLink { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Advisor { get; set; }
        public string AdvisorEmail { get; set; }
        public string PresName { get; set; }
        public string PresEmail { get; set; }
        public string Descriptions { get; set; }
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
