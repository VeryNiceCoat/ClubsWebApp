using System.Collections.Generic;
using WebApplication1.Models;
using System.Data.SqlClient;

namespace WebApplication1.Data
{
    internal class ClubsDAO
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BxSciClubs;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //performs all database operations

        public List<ClubsModel> FetchAll()
        {
            List<ClubsModel> returnList = new List<ClubsModel>();
            //access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM dbo.ClubDetails";

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        //create a new club object. Add it to the list to return.
                        ClubsModel clubs = new ClubsModel();
                        clubs.ClubID = reader.GetInt32(0);
                        clubs.ClubName = reader.GetString(1);
                        clubs.MeetingDay = reader.GetString(2);
                        clubs.MeetLink = reader.GetString(3);
                        clubs.StartTime = reader.GetTimeSpan(4);
                        clubs.EndTime = reader.GetTimeSpan(5);
                        clubs.Advisor = reader.GetString(6);
                        clubs.AdvisorEmail = reader.GetString(7);
                        clubs.PresName = reader.GetString(8);
                        clubs.PresEmail = reader.GetString(9);
                        clubs.Descriptions = reader.GetString(10);
                        clubs.RoomNo = reader.GetInt32(11);

                        returnList.Add(clubs);
                    }
                }
            }

            return returnList;
        }

        public ClubsModel FetchOne(int Id)
        {
            //access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM dbo.ClubDetails WHERE ClubID = @Id";
                //associate @id with Id parameter

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = Id;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                ClubsModel clubs = new ClubsModel();
                if (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        clubs.ClubID = reader.GetInt32(0);
                        clubs.ClubName = reader.GetString(1);
                        clubs.MeetingDay = reader.GetString(2);
                        clubs.MeetLink = reader.GetString(3);
                        clubs.StartTime = reader.GetTimeSpan(4);
                        clubs.EndTime = reader.GetTimeSpan(5);
                        clubs.Advisor = reader.GetString(6);
                        clubs.AdvisorEmail = reader.GetString(7);
                        clubs.PresName = reader.GetString(8);
                        clubs.PresEmail = reader.GetString(9);
                        clubs.Descriptions = reader.GetString(10);
                        clubs.RoomNo = reader.GetInt32(11);

                    }
                }
                return clubs;
            }
        }

        //create new
        public int Create(ClubsModel clubModel)
        {
            //access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "INSERT INTO dbo.ClubDetails Values(@ClubName, @MeetingDay, @MeetLink, @StartTime, @EndTime, @Advisor, @AdvisorEmail, @PresName, @PresEmail, @Descriptions, @RoomNo)";
                //associate @id with Id parameter

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@ClubName", System.Data.SqlDbType.VarChar, 1000).Value = clubModel.ClubName;
                command.Parameters.Add("@MeetingDay", System.Data.SqlDbType.VarChar, 1000).Value = clubModel.MeetingDay;
                command.Parameters.Add("@MeetLink", System.Data.SqlDbType.VarChar, 1000).Value = clubModel.MeetLink;
                command.Parameters.Add("@StartTime", System.Data.SqlDbType.Time).Value = clubModel.StartTime;
                command.Parameters.Add("@EndTime", System.Data.SqlDbType.Time).Value = clubModel.EndTime;
                command.Parameters.Add("@Advisor", System.Data.SqlDbType.VarChar, 1000).Value = clubModel.Advisor;
                command.Parameters.Add("@AdvisorEmail", System.Data.SqlDbType.VarChar, 1000).Value = clubModel.AdvisorEmail;
                command.Parameters.Add("@PresName", System.Data.SqlDbType.VarChar, 1000).Value = clubModel.PresName;
                command.Parameters.Add("@PresEmail", System.Data.SqlDbType.VarChar, 1000).Value = clubModel.PresEmail;
                command.Parameters.Add("@Descriptions", System.Data.SqlDbType.VarChar, 1000).Value = clubModel.Descriptions;
                command.Parameters.Add("@RoomNo", System.Data.SqlDbType.Int).Value = clubModel.RoomNo;

                connection.Open();
                int newID = command.ExecuteNonQuery();

                ClubsModel clubs = new ClubsModel();

                return newID;
            }
        }
        //delete one

        //search name

        //search desc
    }
}