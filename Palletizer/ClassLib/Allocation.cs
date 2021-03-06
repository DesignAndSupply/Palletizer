﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Palletizer.Class
{
    class Allocation
    {
        public string _dept { get; set; }

        public int _getFreePallet
        {
            get
            {
                SqlConnection conn = new SqlConnection(connection.ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 id from dbo.palletizer where free_or_not ='Free' order by id", conn);
                //cmd.Parameters.AddWithValue("@dept", _dept);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }

        }


        public static string _getManualPallet { get; set; }
        public static string _getAllocationType { get; set; }

        public Allocation(string dept)
        {
            _dept = dept;
        }

    }
}
