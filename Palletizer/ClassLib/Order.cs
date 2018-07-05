using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Palletizer.Class;

namespace Palletizer.ClassLib
{
    class Order
    {
        public double _orderID { get; set; }
        public int _doorsOnOrder { get
            {

                SqlConnection conn = new SqlConnection(connection.ConnectionString);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT sum(quantity_same) FROM dbo.door WHERE order_id=@orderID and (status_id = 1 or status_id = 2)", conn);
                cmd.Parameters.AddWithValue("@orderID", _orderID);

                return Convert.ToInt32(cmd.ExecuteScalar());

            }
        }


        public Order(double orderID)
        {
            _orderID = orderID;
        }

        public double _orderMass
        {
            get
            {
                SqlConnection conn = new SqlConnection(connection.ConnectionString);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT totalMass FROM dbo.c_view_palletized_order_mass WHERE order_id =@orderID", conn);
                cmd.Parameters.AddWithValue("@orderID", _orderID);
                return Convert.ToDouble(cmd.ExecuteScalar());

            }

        }

        public int _belongsToPallet
        {
            get
            {
                SqlConnection conn = new SqlConnection(connection.ConnectionString);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT pallet_id from dbo.palletizer_order WHERE order_id =@orderID", conn);
                cmd.Parameters.AddWithValue("@orderID", _orderID);
                return Convert.ToInt32(cmd.ExecuteScalar());

            }

        }







    }
}
