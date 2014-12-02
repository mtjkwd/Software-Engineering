﻿using System;
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
    struct MonsterAttributes
    {
        public string monsterName;
        public string BAB;
        public string InitMod;
        public string DamageDice;
        public int NumHD;
        public string HealthDice;
        // put the picture here somehow...
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
                
                // Test code for pictures //
                

                attributes.Add(temp);
            }
            sqlReader.Close();
            return attributes;
        }

    }
}
