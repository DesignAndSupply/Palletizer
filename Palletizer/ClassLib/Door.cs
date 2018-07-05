using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Palletizer.Class;


namespace Palletizer.ClassLib
{
    class Door
    {
        public double _doorID { get; set; }

        public double _orderID
        { get
            {
                SqlConnection conn = new SqlConnection(connection.ConnectionString);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT order_id FROM dbo.door WHERE id =@doorID", conn);
                cmd.Parameters.AddWithValue("@doorID", _doorID);
                return Convert.ToDouble(cmd.ExecuteScalar());

            }

        }

        public double _doorMass
        {
            get
            {
                SqlConnection conn = new SqlConnection(connection.ConnectionString);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT totalMass FROM dbo.c_view_palletized_door_mass WHERE id =@doorID", conn);
                cmd.Parameters.AddWithValue("@doorID", _doorID);
                return Convert.ToDouble(cmd.ExecuteScalar());

            }

        }


        public Door(double doorID)
        {
            _doorID = doorID;
        }

       





    }
}
