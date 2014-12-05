using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SoftEng
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MonsterGen());
        }
    }
    struct MonsterInfo
    {
        public string monsterName;
        public int challengeRating;
        public string monsterHealth;
        public string monsterSize;
        public string monsterType;
    }
    struct MonsterAttributes
    {
        public string monsterName;
        public string BAB;
        public string InitMod;
        public string DamageDice;
        public int NumHD;
        public string HealthDice;
        public string pictureLoc;
    }
    class MYSQLConn
    {
        private string sqlConnQr = @"server=r02mtjkwd.device.mst.edu;database=Software_Engineering;userid=AppUser;password=AppUser;";
        MySqlConnection sqlConn = null;
        MySqlDataReader sqlReader = null;
        public MYSQLConn()
        {
            // Default constructor for the SQL update class //
            sqlConn = new MySqlConnection(sqlConnQr);
            sqlConn.Open();
            

        }
        public List<MonsterInfo> getMonsterData()
        {
            List<MonsterInfo> MonsterList = new List<MonsterInfo>();
            string cmdText = "SELECT * FROM Software_Engineering.Monster";
            MySqlCommand cmd = new MySqlCommand(cmdText, sqlConn);
            sqlReader = cmd.ExecuteReader(); // executes the reader
            while (sqlReader.Read())
            {
                MonsterInfo temp;
                temp.monsterName = (sqlReader.GetString("Name"));
                temp.monsterHealth = sqlReader.GetString("Health");
                temp.challengeRating = sqlReader.GetInt32("Challenge Rating");
                temp.monsterHealth = sqlReader.GetString("Health");
                temp.monsterSize = sqlReader.GetString("Size Class");
                temp.monsterType = sqlReader.GetString("Type");
                MonsterList.Add(temp);
            }
            sqlReader.Close();
            return MonsterList;
        }

        public List<MonsterInfo> getMonsterData(string monsterName)
        {

            string cmdText = "SELECT * FROM Software_Engineering.Monster "
                + "WHERE Name ='" + monsterName.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(cmdText, sqlConn);
            sqlReader = cmd.ExecuteReader(); // executes the reader
            List<MonsterInfo> monster = new List<MonsterInfo>();
            while (sqlReader.Read())
            {
                MonsterInfo temp;
                temp.monsterName = (sqlReader.GetString("Name"));
                temp.monsterHealth = sqlReader.GetString("Health");
                temp.challengeRating = sqlReader.GetInt32("Challenge Rating");
                temp.monsterHealth = sqlReader.GetString("Health");
                temp.monsterSize = sqlReader.GetString("Size Class");
                temp.monsterType = sqlReader.GetString("Type");
                monster.Add(temp);
            }
            sqlReader.Close();
            return monster;
        }

        public string getMonsterImage(string monsterName)
        {
            // Function for getting the picture name / location data from the MonsterAttr table //
            string cmdText = "SELECT Picture FROM Software_Engineering.MonsterAttr "
                + "WHERE Name = '" + monsterName.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(cmdText, sqlConn);
            sqlReader = cmd.ExecuteReader(); // executes the reader
            string monsterImage = string.Empty;
            while (sqlReader.Read())
            {
                monsterImage = sqlReader.GetString("Picture");
            }
            sqlReader.Close();
            return ("./EncounterImages/" + monsterImage.ToString());
        }

        public List<MonsterAttributes> getMonsterAttributes(string monsterName)
        {
            List<MonsterAttributes> attributes = new List<MonsterAttributes>();
            string cmdText = "SELECT * FROM Software_Engineering.MonsterAttr"
                + " WHERE Name = " + "'" + monsterName.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(cmdText, sqlConn);
            sqlReader = cmd.ExecuteReader(); // executes the reader
            while (sqlReader.Read())
            {
                MonsterAttributes temp;
                temp.monsterName = monsterName;
                temp.BAB = sqlReader.GetString("BAB");
                temp.InitMod = sqlReader.GetInt32("InitMod").ToString();
                temp.DamageDice = sqlReader.GetString("DamageDice");
                temp.NumHD = sqlReader.GetInt32("NumHD");
                temp.HealthDice = sqlReader.GetString("HealthDice");
                temp.pictureLoc = ("./EncounterImages/" + sqlReader.GetString("Picture"));

                attributes.Add(temp);
            }
            sqlReader.Close();
            return attributes;
        }

        public List<MonsterAttributes> getRandomMonsterAttributes()
        {
            List<MonsterAttributes> attributes = new List<MonsterAttributes>();
            string cmdText = "SELECT * FROM Software_Engineering.MonsterAttr " +
            "ORDER BY RAND() LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(cmdText, sqlConn);
            sqlReader = cmd.ExecuteReader(); // executes the reader
            while (sqlReader.Read())
            {
                MonsterAttributes temp;
                temp.monsterName = sqlReader.GetString("Name");
                temp.BAB = sqlReader.GetString("BAB");
                temp.InitMod = sqlReader.GetInt32("InitMod").ToString();
                temp.DamageDice = sqlReader.GetString("DamageDice");
                temp.NumHD = sqlReader.GetInt32("NumHD");
                temp.HealthDice = sqlReader.GetString("HealthDice");
                temp.pictureLoc = ("./EncounterImages/" + sqlReader.GetString("Picture"));

                attributes.Add(temp);
            }
            sqlReader.Close();
            return attributes;
        }

        public int getNumMonsters()
        {
            int result = 0;
            string cmdText = "SELECT COUNT(Name) FROM Software_Engineering.Monster;";
            MySqlCommand cmd = new MySqlCommand(cmdText, sqlConn);
            sqlReader = cmd.ExecuteReader(); // executes the reader
            while (sqlReader.Read())
            {
                result = sqlReader.GetInt32(1);
            }
            sqlReader.Close();
            return result;
        }

        public void closeSQL()
        {
            sqlConn.Close();
        }
    }
}
