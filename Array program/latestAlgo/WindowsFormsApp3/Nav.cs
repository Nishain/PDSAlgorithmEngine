using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Nav : Form
    {
        public Nav()
        {
            InitializeComponent();
        }
        //data insert section
        private void btntsave_Click(object sender, EventArgs e)
        {   

            DboTrainsEntities1 entit = new DboTrainsEntities1();
            string stationName = textBox1.Text.ToString();
            //array created
            string[] InsertArray = new string[1];
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            
            //set value to array
            InsertArray[0] = stationName;

            //retrive data from array and insert to database
            for (int J = 0; J < InsertArray.Length; J++)
            {
                TbStation PTE = new TbStation();
                PTE.Name= InsertArray[J];
                entit.TbStations.Add(PTE);
                entit.SaveChanges();
            }
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            //show spending times
            Lblinsert.Text = " Data Insert Time: " + stopwatch.ElapsedMilliseconds + " Ms";
            textBox1.Text="";
          
            
        }

        //data load section
        public void showstation()
        {
            DboTrainsEntities1 entit = new DboTrainsEntities1();
            //get data from database
            var cc = (from p in entit.TbStations
                      select new
                      {
                          id = p.id,
                          name = p.Name


                      });

            var vv = cc.ToList();
            dgvstation.DataSource = vv;
            //var rowcount = cc.Count();
            //created array
            //string[,] arr = new string[rowcount, 2];
            //int index = 0;
            //load data to array from database when start the application
            //foreach (var val in vv)
            //{
            //arr[index, 0] = val.id.ToString();
            // arr[index, 1] = val.name;
            //index++;
            //}

            //Stopwatch stopwatch = new Stopwatch();

            //stopwatch.Start();
            //
            //display data in gridView from array
            //for (int i = 0; i<arr.GetLength(0);i++)
            //{


            // string [] row = new string [arr.GetLength(1)];

            //for (int J = 0; J < arr.GetLength(1); J++)
            //{
            //row[J] = arr[i, J]; 
            //}

            //dgvstation.Rows.Add(row);
            //}

            //stopwatch.Stop();
            //TimeSpan ts = stopwatch.Elapsed;
            // show data retrive time from array
            //lblshowtime.Text = " Data Load Time: "+ stopwatch.ElapsedMilliseconds+" Ms";

            //dgvstation.Rows.Add(vv);
            //vstation.DataBind();
        }

        private void Nav_Load(object sender, EventArgs e)
        {
            showstation();
            txtid.Hide();
        }

        private void dgvstation_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get data to textbox when click data grid view cell
            foreach (DataGridViewRow row in dgvstation.SelectedRows)
            {
                txtid.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                //...
            }
        }
        //update section
        private void btntupdate_Click(object sender, EventArgs e)
        {
            string stationName = textBox1.Text.ToString();
            string id = txtid.Text.ToString();

            if(id=="")
            {
                MessageBox.Show("Please Select cell from grid before update", "warning");

            }
            else
            {

                DboTrainsEntities1 entit = new DboTrainsEntities1();
                //create array for update
                string[,] station = new string[1, 2];
                //set  value to array
                station[0, 0] = id;
                station[0, 1] = stationName;
                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();
               
                //get data from array and update data
                for (int J = 0; J < station.GetLength(0); J++)
                {
                    int sId = Convert.ToInt32(station[J, 0]);
                    var UpdateDeTable = (from id1 in entit.TbStations where id1.id == sId select id1).FirstOrDefault();
                    UpdateDeTable.Name = station[J, 1];
                    entit.SaveChanges();
                }

                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;
                // display spending time for update task
                lblupex.Text = " Data Update Time: " + stopwatch.ElapsedMilliseconds + " Ms";
                textBox1.Text = "";
           
              


            }
        }
        //delete section
        private void btntdelete_Click(object sender, EventArgs e)
        {

            string id = txtid.Text.ToString();

            if (id == "")
            {
                MessageBox.Show("Please Select cell from grid before Delete", "warning");

            }
            else
            {
                DboTrainsEntities1 entit = new DboTrainsEntities1();
                //create array
                int[] DeleteArray = new int[1];
                //add array data
                DeleteArray[0] = Convert.ToInt32(id);

                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();
                
                //retrive data from array and delete data
                for (int J = 0; J < DeleteArray.Length; J++)
                {
                    int idx = DeleteArray[J];
                    var remove = (from aremove in entit.TbStations
                                  where aremove.id == idx
                                  select aremove).FirstOrDefault();
                    if (remove != null)
                    {
                        entit.TbStations.Remove(remove);
                        entit.SaveChanges();
                    }
                }
                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;
                //display spending time for delete task
                lbldeex.Text = " Data Delete Time: " + stopwatch.ElapsedMilliseconds + " Ms";

                textBox1.Text = "";
              
               


            }

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            showstation();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
