using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Palletizer.Class;
using Palletizer.ClassLib;
using System.Data.SqlClient;


namespace Palletizer
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string dept = cmbDepartment.Text;
            int freePalletID;


            switch (dept)
            {
                case "Weld ":

                    Door d = new Door(Convert.ToDouble(txtDoorNumber.Text));
                    Order o = new Order(d._orderID);
                    Pallet p = new Pallet(o._belongsToPallet);
                    Allocation a = new Allocation(cmbDepartment.Text);

                    //Get free pallet
                    
                    
                  

                    if (o._orderMass > 2)
                    {
                        //RUN THE PALLET ALLOCATION CODE

                        MessageBox.Show("This door belongs to an order with a mass of " + o._orderMass);
                        MessageBox.Show("This door has a mass of " + d._doorMass);
                        MessageBox.Show("This door belongs to an order that is palleted to pallet " + o._belongsToPallet + " Current pallet mass: " + p._palletMass);

                        if (o._belongsToPallet == 0)
                        {

                            freePalletID = a._getFreePallet;
                            //INSERT DOOR RECORD
                            addDoorToPallet(d._doorID, o._orderID, freePalletID);

                            //UPDATE PALLET NUMBER
                            updatePalletStatus(freePalletID);


                        }
                        else
                        {
                            if (p._palletMass + d._doorMass <= Pallet.maxPalletMass)
                            {
                                //ADD TO EXISTING PALLET o._belongsToPallet
                                addDoorToPallet(d._doorID, o._orderID, o._belongsToPallet);
                            }
                            else
                            {
                                freePalletID = a._getFreePallet;
                                //INSERT DOOR RECORD
                                addDoorToPallet(d._doorID, o._orderID, freePalletID);

                                //UPDATE PALLET NUMBER
                                updatePalletStatus(freePalletID);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("This door can be placed in the racking.", "Place in racking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    break;
                case "Buff":
                    break;
                case "Paint":
                    break;

                default:
                    break;
            }


            //Allocation a = new Allocation();
            //MessageBox.Show(a.getFreePallet(cmbDepartment.Text).ToString());
            
        }


        private void addDoorToPallet(double doorID, double orderID, double palletID)
        {
            SqlConnection conn = new SqlConnection(connection.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.palletizer_order(pallet_id, order_id, door_id) VALUES(@palletID,@orderID,@doorID);", conn);
            cmd.Parameters.AddWithValue("@palletID", palletID);
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@doorID", doorID);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void updatePalletStatus(double palletID)
        {
            SqlConnection conn = new SqlConnection(connection.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE dbo.palletizer SET free_or_not = @fn , date_updated = @now WHERE id = @id;", conn);
            cmd.Parameters.AddWithValue("@fn", "Not");
            cmd.Parameters.AddWithValue("@now", DateTime.Now);
            cmd.Parameters.AddWithValue("@id", palletID );
            cmd.ExecuteNonQuery();
            conn.Close();
        }




    }
}
