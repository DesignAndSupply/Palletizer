using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Palletizer.Class
{
    class Pallet
    {

        public const int maxPalletMass = 16;

        public int _palletID { get; set; }
        public double _palletMass
        {
            get
            {
                SqlConnection conn = new SqlConnection(connection.ConnectionString);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT totalMass FROM dbo.c_view_palletized_pallet_mass WHERE pallet_id =@palletID", conn);
                cmd.Parameters.AddWithValue("@palletID", _palletID);
                return Convert.ToDouble(cmd.ExecuteScalar());

            }

        }


        public void updatePalletStatus()
        {

        }

        public bool isPalletEmpty()
        {
            SqlConnection conn = new SqlConnection(connection.ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT pallet_id from dbo.palletizer_order where pallet_id = @id", conn);
            cmd.Parameters.AddWithValue("@id", _palletID);

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                return false;
            }
            else
            {

                return true;
 
            }

        }


        public void emptyPallet()
        {
            SqlConnection conn = new SqlConnection(connection.ConnectionString);
            conn.Open();
            SqlCommand cmdWrite = new SqlCommand("UPDATE dbo.palletizer set free_or_not = 'Free' where id=@id", conn);
            cmdWrite.Parameters.AddWithValue("@id", _palletID);
            cmdWrite.ExecuteNonQuery();
            conn.Close();
        }

        public Pallet(int palletID)
        {
            _palletID = palletID;
        }


    }
}
