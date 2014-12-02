using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            Application.Run(new Form1());
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
                temp.monsterName = (sqlReader.GetString("Health"));
                temp.challengeRating = sqlReader.GetInt32("Challenge Rating");
                temp.monsterHealth = sqlReader.GetString("Health");
                temp.monsterSize = sqlReader.GetString("Size Class");
                temp.monsterType = sqlReader.GetString("Type");
                MonsterList.Add(temp);
            }
            sqlReader.Close();
            return MonsterList;
        }

    }
}
