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
            string[] args = Environment.GetCommandLineArgs();


            if (args.Length > 1)
            {
                cmbDepartment.Text = args[1];
                txtDoorNumber.Text = args[2];
            }

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string dept = cmbDepartment.Text;
            int freePalletID;
            int oldPalletID;
            double doorNum = Convert.ToDouble(txtDoorNumber.Text);

            Door d = new Door(doorNum);
            Order o = new Order(d._orderID, dept);
            Pallet p = new Pallet(o._belongsToPallet);
            Allocation a = new Allocation(cmbDepartment.Text);

            switch (dept)
            {
                case "Weld":

                    if (o._orderMass > 2)
                    {
                       
                        if (o._belongsToPallet == 0)
                        {
                            freePalletID = a._getFreePallet;
                            //INSERT DOOR RECORD
                            addDoorToPallet(d._doorID, o._orderID, freePalletID,dept);

                            //UPDATE PALLET NUMBER
                            updatePalletStatus(freePalletID);
                            MessageBox.Show("Please add this door number to pallet: " + freePalletID, "Pallet Allocation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            if (p._palletMass + d._doorMass <= Pallet.maxPalletMass)
                            {
                                //ADD TO EXISTING PALLET o._belongsToPallet
                                addDoorToPallet(d._doorID, o._orderID, o._belongsToPallet, dept);

                                MessageBox.Show("Please add this door number to pallet: " + o._belongsToPallet , "Pallet Allocation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                //sets the pallet as not free in buffing as it has doors on it
                                //updatePalletDepartment(o._belongsToPallet, "Buff");

                                freePalletID = a._getFreePallet;
                                //INSERT DOOR RECORD
                                addDoorToPallet(d._doorID, o._orderID, freePalletID, dept);

                                //UPDATE PALLET NUMBER
                                updatePalletStatus(freePalletID);


                                MessageBox.Show("Please add this door number to pallet: " + freePalletID, "Pallet Allocation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("This door can be placed in the racking.", "Place in racking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    break;
                case "Buff":

                    //UPDATES THE PALLET TO THE BUFFING DEPARTMENT
                    o._dept = "Weld";
                    oldPalletID = d._belongsToPallet;
                    updatePalletDepartment(d._belongsToPallet, o._dept);
                    //DELETE DOOR FROM PREVIOUS OPERATION PALLET
                    d.removeFromExistingPallet();
                    //CHECK IF PALLET IS NOW FREE
                    p._palletID = oldPalletID;


                    //ONLY RUN IF THE PALLET IS EMPTY
                    if (p.isPalletEmpty() == true)
                    {
                        p.emptyPallet();
                        updatePalletDepartment(p._palletID, "Weld");

                    }

                    o._dept = "Buff";
                    p._palletID = o._belongsToPallet;

                    if (o._orderMass > 2)
                    {

                        if (o._belongsToPallet == 0)
                        {
                            freePalletID = a._getFreePallet;
                            //INSERT DOOR RECORD
                            addDoorToPallet(d._doorID, o._orderID, freePalletID, dept);

                            //UPDATE PALLET NUMBER
                            updatePalletStatus(freePalletID);
                            MessageBox.Show("Please add this door number to pallet: " + freePalletID, "Pallet Allocation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            if (p._palletMass + d._doorMass <= Pallet.maxPalletMass)
                            {
                                //ADD TO EXISTING PALLET o._belongsToPallet
                                addDoorToPallet(d._doorID, o._orderID, o._belongsToPallet, dept);

                                MessageBox.Show("Please add this door number to pallet: " + o._belongsToPallet, "Pallet Allocation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                //sets the pallet as not free in buffing as it has doors on it
                                //updatePalletDepartment(o._belongsToPallet, "Buff");

                                freePalletID = a._getFreePallet;
                                //INSERT DOOR RECORD
                                addDoorToPallet(d._doorID, o._orderID, freePalletID, dept);

                                //UPDATE PALLET NUMBER
                                updatePalletStatus(freePalletID);


                                MessageBox.Show("Please add this door number to pallet: " + freePalletID, "Pallet Allocation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("This door can be placed in the racking.", "Place in racking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }



                    break;
                case "Paint":


                    //UPDATES THE PALLET TO THE Painting DEPARTMENT
                    o._dept = "Buff";
                    oldPalletID = d._belongsToPallet;
                    o._dept = "Paint";
                    updatePalletDepartment(d._belongsToPallet, o._dept);
                    o._dept = "Buff";
                    //DELETE DOOR FROM PREVIOUS OPERATION PALLET
                    d.removeFromExistingPallet();
                    //CHECK IF PALLET IS NOW FREE
                    p._palletID = oldPalletID;

                    //ONLY RUN IF THE PALLET IS EMPTY
                    if(p.isPalletEmpty()== true)
                    {
                        p.emptyPallet();
                        //updatePalletDepartment(p._palletID,"Weld");

                    }


                    break;

                default:
                    break;
            }
            

            this.c_view_palletizer_visual_doorTableAdapter.Fill(this.order_databaseDataSet.c_view_palletizer_visual_door);
            this.c_view_palletizer_visualTableAdapter.Fill(this.order_databaseDataSet.c_view_palletizer_visual);
            dgVisual.Refresh();
            dgVisualDoor.Refresh();
            //Allocation a = new Allocation();
            //MessageBox.Show(a.getFreePallet(cmbDepartment.Text).ToString());
            
        }


        private void addDoorToPallet(double doorID, double orderID, double palletID ,string dept)
        {
            SqlConnection conn = new SqlConnection(connection.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.palletizer_order(pallet_id, order_id, door_id,dept) VALUES(@palletID,@orderID,@doorID,@dept);", conn);
            cmd.Parameters.AddWithValue("@palletID", palletID);
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@doorID", doorID);
            cmd.Parameters.AddWithValue("@dept", dept);
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

        private void updatePalletDepartment(double palletID, string dept)
        {
            SqlConnection conn = new SqlConnection(connection.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE dbo.palletizer SET current_dept = @dept , date_updated = @now WHERE id = @id;", conn);

            switch(dept)
            {
                case "Weld":
                    cmd.Parameters.AddWithValue("@dept", "Buff");
                    break;
                case "Buff":
                    cmd.Parameters.AddWithValue("@dept", "Paint");
                    break;
                case "Paint":
                    cmd.Parameters.AddWithValue("@dept", "Weld");
                    break;
            }

            
            cmd.Parameters.AddWithValue("@now", DateTime.Now);
            cmd.Parameters.AddWithValue("@id", palletID);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'order_databaseDataSet.c_view_palletizer_visual_door' table. You can move, or remove it, as needed.
            this.c_view_palletizer_visual_doorTableAdapter.Fill(this.order_databaseDataSet.c_view_palletizer_visual_door);
            // TODO: This line of code loads data into the 'order_databaseDataSet.c_view_palletizer_visual' table. You can move, or remove it, as needed.
            this.c_view_palletizer_visualTableAdapter.Fill(this.order_databaseDataSet.c_view_palletizer_visual);

        }
    }
}
