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
    public partial class Distances : Form
    {
        public Distances()
        {
            InitializeComponent();
        }
        //load data section
        private void Distances_Load(object sender, EventArgs e)
        {
            DboTrainsEntities1 entit = new DboTrainsEntities1();
            var StationStart = (from p in entit.TbStations

                                select new
                                {
                                    name = p.Name,
                                    id = p.id


                                });

            var vv2 = StationStart.ToList();


            cmbs1.DataSource = vv2;
            cmbs1.DisplayMember = "name";
            cmbs1.ValueMember = "id";


           

            showstation();
            cmb2Load();
        }
        //station combo box 
        private void cmb2Load()
        {
            DboTrainsEntities1 entit = new DboTrainsEntities1();
            var StationStart = (from p in entit.TbStations

                                select new
                                {
                                    name = p.Name,
                                    id = p.id


                                });

            var vv2 = StationStart.ToList();


           
            //set station data to combo box
            cmbs2.DataSource = vv2;
            cmbs2.DisplayMember = "name";
            cmbs2.ValueMember = "id";
        }


        //show station
        public void showstation()
        {
            DboTrainsEntities1 entit = new DboTrainsEntities1();
            //get data from database
            var cc = (from p in entit.Tbdistances
                      join e in entit.TbStations on p.station1Id equals e.id
                      join y in entit.TbStations on p.station2id equals y.id
                      select new
                      {
                          id = p.id,
                          station1name = e.Name,
                          station2name = y.Name,
                          distances = p.distance


                      });
            //convert to list
            var vv = cc.ToList();
            var rowcount = cc.Count();
            //create array
            string[,] arr = new string[rowcount, 4];
            int index = 0;
            //add database data to array
            foreach (var val in vv)
            {
                arr[index, 0] = val.id.ToString();
                arr[index, 1] = val.station1name;
                arr[index, 2] = val.station2name;
                arr[index, 3] = val.distances.ToString();
                index++;
            }

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Thread.Sleep(5000);
            //retrive data from array
            for (int i = 0; i < arr.GetLength(0); i++)
            {


                string[] row = new string[arr.GetLength(1)];

                for (int J = 0; J < arr.GetLength(1); J++)
                {
                    row[J] = arr[i, J];
                }

                dgvdistances.Rows.Add(row);
            }

            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            //show spending time
            lblLoadEx.Text = " Data Load Time: " + stopwatch.ElapsedMilliseconds + " Ms";
        }

        //data save section
        private void btnsave_Click(object sender, EventArgs e)
        {
            DboTrainsEntities1 entit = new DboTrainsEntities1();
            int station1 = (int)cmbs1.SelectedValue;
            int station2 = (int)cmbs2.SelectedValue;
            //query for check data avalibility
            var remove = (from aremove in entit.Tbdistances
                          where aremove.station1Id == station1 && aremove.station2id == station2
                          select aremove).FirstOrDefault();
            //check data avalible or not
            if (remove != null)
            {
                MessageBox.Show("Existing Data");
            }
            else
            {
                //get station1 data to variable
                string station1String = station1.ToString();
                //get station2 data to variable
                string station2String = station2.ToString();
                //get distance data to variable
                string distances = txtdistance.Text.ToString();
                //create array
                string[,] stationDistances = new string[1, 3];
                //add data to array
                stationDistances[0, 0] = station1String;
                stationDistances[0, 1] = station2String;
                stationDistances[0, 2] = distances;
                //start stop watch
                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();
                Thread.Sleep(5000);
                //retrive data from array and insert data to database
                for (int J = 0; J < stationDistances.GetLength(0); J++)
                {
                    Tbdistance PTE = new Tbdistance();
                    PTE.station1Id = Convert.ToInt32( stationDistances[J, 0]);
                    PTE.station2id = Convert.ToInt32(stationDistances[J, 1]);
                    PTE.distance = Convert.ToInt32(stationDistances[J, 2]);
                    entit.Tbdistances.Add(PTE);
                    entit.SaveChanges();

                    Tbdistance PTE2 = new Tbdistance();
                    PTE2.station1Id = Convert.ToInt32(stationDistances[J, 1]);
                    PTE2.station2id = Convert.ToInt32(stationDistances[J, 0]);
                    PTE2.distance = Convert.ToInt32(stationDistances[J, 2]);
                    entit.Tbdistances.Add(PTE2);
                    entit.SaveChanges();
                }
                //end stop watch
                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;
                //show spending times
                lblInsert.Text = " Data Insert Time: " + stopwatch.ElapsedMilliseconds + " Ms";
                
                dgvdistances.Rows.Clear();
                showstation();



            }



        }
        //update section
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DboTrainsEntities1 entit = new DboTrainsEntities1();
            int station1 = (int)cmbs1.SelectedValue;
            int station2 = (int)cmbs2.SelectedValue;
            string station1String = station1.ToString();
            string station2String = station2.ToString();
            string distances = txtdistance.Text.ToString();

            //query for data avalibility
            var remove = (from aremove in entit.Tbdistances
                          where aremove.station1Id == station1 && aremove.station2id == station2
                          select aremove).FirstOrDefault();
            //create array
            string[,] stationDistances = new string[1, 3];
            //set data to array
            stationDistances[0, 0] = station1String;
            stationDistances[0, 1] = station2String;
            stationDistances[0, 2] = distances;
            //check data avalible or not
            if (remove != null)
            {
                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();
                Thread.Sleep(5000);
                //retrive data from array and update data
                for (int J = 0; J < stationDistances.GetLength(0); J++)
                {
                    
                    int station1Id = Convert.ToInt32(stationDistances[J, 0]);
                    int station2Id = Convert.ToInt32(stationDistances[J, 1]);
                    int distances2 = Convert.ToInt32(stationDistances[J, 2]);

                    //a to b = 10KM
                    var UpdateDeTable = (from id1 in entit.Tbdistances where id1.station1Id == station1Id && id1.station2id == station2Id select id1).FirstOrDefault();
                    UpdateDeTable.distance = distances2;
                    entit.SaveChanges();
                    //b to a = 10KM
                    var UpdateDeTable2 = (from id11 in entit.Tbdistances where id11.station1Id == station2Id && id11.station2id == station1Id select id11).FirstOrDefault();
                    UpdateDeTable2.distance = distances2;
                    entit.SaveChanges();
                }

                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;
                //display spending time to update 
                lblUp.Text = " Data Update Time: " + stopwatch.ElapsedMilliseconds + " Ms";

                dgvdistances.Rows.Clear();
                showstation();
            }
            else
            {
                MessageBox.Show("Not Avalible Data");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //data delete section
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DboTrainsEntities1 entit = new DboTrainsEntities1();
            //create array
            int[] DeleteArray = new int[1];
            //set data to array
            DeleteArray[0] = Convert.ToInt32(txtdeleteid.Text);
            
            Stopwatch stopwatch = new Stopwatch();
            //start stop watch
            stopwatch.Start();
            Thread.Sleep(5000);
            //retrive data from array and delete data
            for (int J = 0; J < DeleteArray.Length; J++)
            {
                int idx = DeleteArray[J];
                var remove = (from aremove in entit.Tbdistances
                              where aremove.id == idx
                              select aremove).FirstOrDefault();
                //check data avalibility
                if (remove != null)
                {
                    int stationid1 = Convert.ToInt32(remove.station1Id);
                    int stationid2 = Convert.ToInt32(remove.station2id);


                    entit.Tbdistances.Remove(remove);
                    entit.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Not Avalible Data");
                }
            }
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            //display spending times to delete
            lbldeleteex.Text = " Data Delete Time: " + stopwatch.ElapsedMilliseconds + " Ms";

            txtdeleteid.Text = "";
            dgvdistances.Rows.Clear();
            showstation();



        }
    }
}
