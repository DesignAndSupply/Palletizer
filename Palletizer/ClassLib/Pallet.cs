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


        public Pallet(int palletID)
        {
            _palletID = palletID;
        }


    }
}
