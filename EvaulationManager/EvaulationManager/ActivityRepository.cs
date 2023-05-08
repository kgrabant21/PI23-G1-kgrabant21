using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaulationManager {
    public static class ActivityRepository {
        private static Activity CreateObject(SqlDataReader reader) {
            int id = int.Parse(reader["Id"].ToString());
            string name = reader["Name"].ToString();
            string description = reader["Description"].ToString();
            int maxPoints = int.Parse(reader["MaxPoints"].ToString());
            int minPointsForGrade =
            int.Parse(reader["MinPointsForGrade"].ToString());
            int minPointsForSignature =
           int.Parse(reader["MinPointsForSignature"].ToString());
            var activity = new Activity {
                Id = id,
                Name = name,
                Description = description,
                MaxPoints = maxPoints,
                MinPointsForGrade = minPointsForGrade,
                MinPointsForSignature = minPointsForSignature
            };
            return activity;
        }
        public static Activity GetActivity(int id) {
            Activity aktivnost = null;
            string sql = $"SELECT * FROM Activities WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows) {
                reader.Read();
                aktivnost = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return aktivnost;
        }
        public static List<Activity> GetActivities() {
            List<Activity> aktivnost = new List<Activity>();
            string sql = "SELECT * FROM Activities";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Activity student = CreateObject(reader);
                aktivnost.Add(student);
            }
            reader.Close();
            DB.CloseConnection();
            return aktivnost;
        }
    }
}
