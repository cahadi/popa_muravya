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

        public List<User> SelectUsersRange(int skip, int count)
        {
            var user = new List<User>();
            var mySqlDB = MySqlDB.GetDB();
            string query = $"SELECT * FROM `user` LIMIT {skip},{count}";
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
                            LastName = dr.GetString("lastname"),
                            Number = dr.GetInt32("number"),
                            Login = dr.GetString("login"),
                            Password = dr.GetString("password")
                        });
                    }
                }
                mySqlDB.CloseConnection();
            }
            return user;
        }

        public List<Gids> SelectGidsRange(int skip, int count)
        {
            var gids = new List<Gids>();
            var mySqlDB = MySqlDB.GetDB();
            string query = $"SELECT * FROM `gids` LIMIT {skip},{count}";
            if (mySqlDB.OpenConnection())
            {
                using (MySqlCommand mc = new MySqlCommand(query, mySqlDB.sqlConnection))
                using (MySqlDataReader dr = mc.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        gids.Add(new Gids
                        {
                            IdGids = dr.GetInt32("id_gids"),
                            Name = dr.GetString("name"),
                            LastName = dr.GetString("lastname"),
                            Email = dr.GetString("email"),
                            Number = dr.GetInt32("number"),
                            Login = dr.GetString("login"),
                            Password = dr.GetString("password")
                        });
                    }
                }
                mySqlDB.CloseConnection();
            }
            return gids;
        }

        internal List<Gids> GidsEnter(Gids SelectGids)
        {
            var login = SelectGids.Login;
            var password = SelectGids.Password;
            var gids = new List<Gids>();
            var mySqlDB = MySqlDB.GetDB();
            string query = $"SELECT * FROM `gids` WHERE gids.login = `{login}` and gids.password = `{password}`";
            if (mySqlDB.OpenConnection())
            {
                using (MySqlCommand mc = new MySqlCommand(query, mySqlDB.sqlConnection))
                using (MySqlDataReader dr = mc.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        gids.Add(new Gids
                        {
                            IdGids = dr.GetInt32("id_gids"),
                            Name = dr.GetString("name"),
                            LastName = dr.GetString("lastname"),
                            Email = dr.GetString("email"),
                            Number = dr.GetInt32("number"),
                            Login = dr.GetString("login"),
                            Password = dr.GetString("password")
                        });
                    }
                }
                mySqlDB.CloseConnection();
            }
            return gids;
        }

        internal List<Admin> AdminEnter(Admin SelectAdmin)
        {
            var login = SelectAdmin.Login;
            var password = SelectAdmin.Password;
            var admin = new List<Admin>();
            var mySqlDB = MySqlDB.GetDB();
            string query = $"SELECT * FROM `admin` WHERE admin.login = `{login}` and admin.password = `{password}`";
            if (mySqlDB.OpenConnection())
            {
                using (MySqlCommand mc = new MySqlCommand(query, mySqlDB.sqlConnection))
                using (MySqlDataReader dr = mc.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        admin.Add(new Admin
                        {
                            Name = dr.GetString("name"),
                            LastName = dr.GetString("lastname"),
                            Login = dr.GetString("login"),
                            Password = dr.GetString("password")
                        });
                    }
                }
                mySqlDB.CloseConnection();
            }
            return admin;
        }

        internal List<Group> AddGroup()
        {
            var mySqlDB = MySqlDB.GetDB();
            var addgroup = new List<Group>();
            string sql = $"INSERT INTO `group` (`login_gid`, `login_user`) VALUES";
            if (mySqlDB.OpenConnection())
            {
                using (MySqlCommand mc = new MySqlCommand(sql, mySqlDB.sqlConnection))
                using (MySqlDataReader dr = mc.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        addgroup.Add(new Group
                        {
                            IdGroup = dr.GetInt32("id_group"),
                            LoginGid = dr.GetString("login_gid"),
                            LoginUser = dr.GetString("login_user")
                        });
                    }
                }
                mySqlDB.CloseConnection();
            }
            return addgroup;
        }


        internal List<Gids> GidsList()
        {
            var mySqlDB = MySqlDB.GetDB();
            var result = new List<Gids>(); 
            string sql = "SELECT * FROM `gids`";
            if (mySqlDB.OpenConnection())
            {
                using (MySqlCommand mc = new MySqlCommand(sql, mySqlDB.sqlConnection))
                using (MySqlDataReader dr = mc.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        result.Add(new Gids
                        {
                            IdGids = dr.GetInt32("id_gids"),
                            Name = dr.GetString("name"),
                            LastName = dr.GetString("lastname"),
                            Email = dr.GetString("email"),
                            Number = dr.GetInt32("number"),
                            Login = dr.GetString("login"),
                            Password = dr.GetString("password")
                        });
                    }
                }
                mySqlDB.CloseConnection();
            }
            return result;
        }

        internal List<Tea> TeaList()
        {
            var mySqlDB = MySqlDB.GetDB();
            var result = new List<Tea>();
            string sql = "select * from `tea` order by sorts_of_tea";
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

        internal List<Group> GroupList()
        {
            var mySqlDB = MySqlDB.GetDB();
            var result = new List<Group>();
            string sql = "select * from `group`";
            if (mySqlDB.OpenConnection())
            {
                using (MySqlCommand mc = new MySqlCommand(sql, mySqlDB.sqlConnection))
                using (MySqlDataReader dr = mc.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        result.Add(new Group
                        {
                            IdGroup = dr.GetInt32("id_group"),
                            LoginGid = dr.GetString("login_gid"),
                            LoginUser = dr.GetString("login_user")
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
