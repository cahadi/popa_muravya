using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсовая_T_T.DTO;
using Курсовая_T_T.Tools;

namespace Курсовая_T_T.Model
{
    public class SqlModel
    {
        private SqlModel() { }
        static SqlModel sqlModel;
        public static SqlModel GetInstance()
        {
            if (sqlModel == null)
                sqlModel = new SqlModel();
            return sqlModel;
        }

        public List<Lobby> SelectLobbyRange(int skip, int count)
        {
            var lobby = new List<Lobby>();
            var mySqlDB = MySqlDB.GetDB();
            string query = $"SELECT * FROM `lobby` LIMIT {skip},{count}";
            if (mySqlDB.OpenConnection())
            {
                using (MySqlCommand mc = new MySqlCommand(query, mySqlDB.sqlConnection));            }
            return lobby;
        }
        internal int SelectCountUsersInLobby(Lobby lobby)
        {
            int result = 0;
            var mySqlDB = MySqlDB.GetDB();
            string query = $"SELECT count(*) FROM user WHERE id lobby = " + lobby.ID;
            if (mySqlDB.OpenConnection())
            {
                using (MySqlCommand mc = new MySqlCommand(query, mySqlDB.sqlConnection))
                using (MySqlDataReader dr = mc.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        result = dr.GetInt32(0);
                    }
                }
                mySqlDB.CloseConnection();
            }
            return result;
        }

        internal Dictionary<Tour, List<Lobby>> SelectLobbyByTour(List<Tour> tours, int month, int year)
        {
            Dictionary<Tour, List<Lobby>> result = new Dictionary<Tour, List<Lobby>>();
            var mySqlDB = MySqlDB.GetDB();
            DateTime startDate = new DateTime(year, month, 1);
            DateTime endDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            string tourIds = string.Join(",", tours.Select(u => u.ID));
            string query = $"SELECT * FROM lobby l, user u WHERE l.id_tour IN ({tourIds}) and l.day >= '{startDate.ToShortDateString()}' and l.day <= '{endDate.ToShortDateString()}' AND l.id_user = u.id";
            if (mySqlDB.OpenConnection())
            {
                foreach (var tour in tours)
                {
                    List<Lobby> eTour = new List<Lobby>();
                    result.Add(tour, eTour);
                }
                using (MySqlCommand mc = new MySqlCommand(query, mySqlDB.sqlConnection))
                using (MySqlDataReader dr = mc.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int tourId = dr.GetInt32("id_tour");
                        var tExcursion = result.First(u => u.Key.ID == tourId);
                        tExcursion.Value.Add(new Lobby
                        {
                            IdTour = tourId,
                            IdUser = dr.GetInt32("id_user"),
                            Day = dr.GetDateTime("day")
                        });
                    }
                }
                mySqlDB.CloseConnection();
            }
            return result;
        }

        internal List<User> SelectUserByLobby(Lobby selectedLobby)
        {
            int id = selectedLobby?.ID ?? 0;
            var user = new List<User>();
            var mySqlDB = MySqlDB.GetDB();
            string query = $"SELECT * FROM `user` WHERE id_user = {id}";
            if (mySqlDB.OpenConnection())
            {
                using (MySqlCommand mc = new MySqlCommand(query, mySqlDB.sqlConnection))
                using (MySqlDataReader dr = mc.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        user.Add(new User
                        {
                            ID = dr.GetInt32("id_user"),
                            Name = dr.GetString("name"),
                            LastName = dr.GetString("lastName")
                        });
                    }
                }
                mySqlDB.CloseConnection();
            }
            return user;
        }

        internal List<Tea> TeaList()
        {
            var mySqlDB = MySqlDB.GetDB();
            var result = new List<Tea>();
            string sql = "select * from tea";
            if (mySqlDB.OpenConnection())
            {
                using (MySqlCommand mc = new MySqlCommand(sql, mySqlDB.sqlConnection))
                using (MySqlDataReader dr = mc.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        result.Add(new Tea
                        {
                            IdTea = dr.GetInt32("id_tea"),
                            Types_Of_Tea = dr.GetString("types_of_tea"),
                            Kinds_Of_Tea = dr.GetString("kinds_of_tea"),
                            Sorts_Of_Tea = dr.GetString("sorts_of_tea")
                        });
                    }
                }
                mySqlDB.CloseConnection();
            }
            return result;
        }
        internal List<User> SelectUser()
        {
            var mySqlDB = MySqlDB.GetDB();
            var result = new List<User>();
            string sql = "select * from user";
            if (mySqlDB.OpenConnection())
            {
                using (MySqlCommand mc = new MySqlCommand(sql, mySqlDB.sqlConnection))
                using (MySqlDataReader dr = mc.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        result.Add(new User
                        {
                            UserID = dr.GetInt32("id_user"),
                            Name = dr.GetString("name"),
                            LastName = dr.GetString("lastname")
                        });
                    }
                }
                mySqlDB.CloseConnection();
            }
            return result;
        }

        internal List<Tour> SelectTours()
        {
            var mySqlDB = MySqlDB.GetDB();
            var result = new List<Tour>();
            string sql = "select id_tour, tipe_of_tour from tour";
            if (mySqlDB.OpenConnection())
            {
                using (MySqlCommand mc = new MySqlCommand(sql, mySqlDB.sqlConnection))
                using (MySqlDataReader dr = mc.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        result.Add(new Tour
                        {
                            IdTour = dr.GetInt32("id_tour"),
                            TypeOfTour = dr.GetString("tipe_of_tour")
                        });
                    }
                }
                mySqlDB.CloseConnection();
            }
            return result;
        }

        public int Insert<T>(T value)
        {
            string table;
            List<(string, object)> values;
            GetMetaData(value, out table, out values);
            var query = CreateInsertQuery(table, values);
            var db = MySqlDB.GetDB();
            int id = db.GetNextID(table);
            db.ExecuteNonQuery(query.Item1, query.Item2);
            return id;
        }
        public void Update<T>(T value) where T : BaseDTO
        {
            string table;
            List<(string, object)> values;
            GetMetaData(value, out table, out values);
            var query = CreateUpdateQuery(table, values, value.ID);
            var db = MySqlDB.GetDB();
            db.ExecuteNonQuery(query.Item1, query.Item2);
        }

        public void Delete<T>(T value) where T : BaseDTO
        {
            var type = value.GetType();
            string table = GetTableName(type);
            var db = MySqlDB.GetDB();
            string query = $"delete from `{table}` where id = {value.ID}";
            db.ExecuteNonQuery(query);
        }

        public int GetNumRows(Type type)
        {
            string table = GetTableName(type);
            return MySqlDB.GetDB().GetRowsCount(table);
        }

        private static string GetTableName(Type type)
        {
            var tableAtrributes = type.GetCustomAttributes(typeof(TableAttribute), false);
            return ((TableAttribute)tableAtrributes.First()).Table;
        }


        private static (string, MySqlParameter[]) CreateInsertQuery(string table, List<(string, object)> values)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"INSERT INTO `{table}` set ");
            List<MySqlParameter> parameters = InitParameters(values, stringBuilder);
            return (stringBuilder.ToString(), parameters.ToArray());
        }

        private static (string, MySqlParameter[]) CreateUpdateQuery(string table, List<(string, object)> values, int id)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"UPDATE `{table}` set ");
            List<MySqlParameter> parameters = InitParameters(values, stringBuilder);
            stringBuilder.Append($" WHERE id = {id}");
            return (stringBuilder.ToString(), parameters.ToArray());
        }

        private static List<MySqlParameter> InitParameters(List<(string, object)> values, StringBuilder stringBuilder)
        {
            var parameters = new List<MySqlParameter>();
            int count = 1;
            var rows = values.Select(s =>
            {
                parameters.Add(new MySqlParameter($"p{count}", s.Item2));
                return $"{s.Item1} = @p{count++}";
            });
            stringBuilder.Append(string.Join(',', rows));
            return parameters;
        }

        private static void GetMetaData<T>(T value, out string table, out List<(string, object)> values)
        {
            var type = value.GetType();
            var tableAtrributes = type.GetCustomAttributes(typeof(TableAttribute), false);
            table = ((TableAttribute)tableAtrributes.First()).Table;
            values = new List<(string, object)>();
            var props = type.GetProperties();
            foreach (var prop in props)
            {
                var columnAttributes = prop.GetCustomAttributes(typeof(ColumnAttribute), false);
                if (columnAttributes.Length > 0)
                {
                    string column = ((ColumnAttribute)columnAttributes.First()).Column;
                    values.Add(new(column, prop.GetValue(value)));
                }
            }
        }
    }
}
