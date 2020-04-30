using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainStations.DAL;
using TrainStations.Models;

namespace TrainStation
{
    public partial class Form1 : Form
    {
        private DbAcess db = new DbAcess();
        List<tbStations> list;
        List<Tbdistances> listdistance;
        public Form1()
        {
            list = db.stations.ToList(); // load data from tbstations table
            listdistance = db.stationDistances.ToList();// load data from tbdistance
            InitializeComponent();
            loadComboData(); //load data to combobox
        }
        public void loadComboData()
        {


            var mlist = db.stations.ToList();
            var mlist2 = db.stations.ToList();
            var mlist3 = db.stations.ToList();

            loc1.DisplayMember = "Name";
            loc1.ValueMember = "id";
            loc1.DataSource = mlist;

            Loc2.DisplayMember = "Name";
            Loc2.ValueMember = "id";
            Loc2.DataSource = mlist2;

            loc3.DisplayMember = "Name";
            loc3.ValueMember = "id";
            loc3.DataSource = mlist3;
        }
        LinkedList<tbStations> stationslist = new LinkedList<tbStations>(); //this link list using for store the adding stations
        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();//create stopwoch object
            stopWatch.Start(); //start stopwatch
            tbStations add = new tbStations(); //create the table tbstation object
            add.id = 0;
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("please enter a station Name", "Missing details", MessageBoxButtons.OK);
                return;
            }
            add.Name = textBox1.Text; //add the textfield value to the created object
            stationslist.AddLast(add); // add the link list adding values
            stopWatch.Stop(); //after proces is over then stop the stopwatch
            TimeSpan ts = stopWatch.Elapsed;  //get the stopwatch timestamp
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10); //convert time stamp to normal  standed time
            lbl_time.Text="single add time " + elapsedTime; // set the timt to the lable
                        
            textBox1.Text = ""; // clear the textfield value
        }

        private void addall_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            foreach (tbStations addstations in stationslist) //read the link list value
            { 
                
                tbStations addstations1 = new tbStations(); //create the table tbstation object for store the data
                addstations1.Name = addstations.Name; // add the name to the created object
                db.stations.Add(addstations1); //add the data to database
                db.SaveChanges();

              
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            lbl_time.Text = "Multiple add time " + elapsedTime;
            list = db.stations.ToList(); //reload the tbstation  to the list
            listdistance = db.stationDistances.ToList(); //reload the Tbdistance to the listdistance
            loadComboData(); //reload the all comboboxes

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            //AddDesetance a = new AddDesetance();
            //a.Visible = true;
            //this.Hide();
        }
        private void popError(String msg)
        {
            MessageBox.Show("An error occured", msg, MessageBoxButtons.OK);
        }
        private void btn_search_sortest_Click(object sender, EventArgs e) // calculate the shortest path from dijiksar
        {
        	Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            LinkedList<int[]> graph = new LinkedList<int[]>(); // data store as metrics 
            List<DataResult> dataResults = new List<DataResult>();
            try
            {
                for (int yy = 0; yy < list.Count; yy++)
                { // this for loop useing to stations row one by one read

                    int[] xdata = new int[list.Count]; //this array used to store one station have distance combination ex xdata={0,2,0,0,4}
                    int stationy = list[yy].id; //this variable use to get current station id
                    for (int xx = 0; xx < list.Count; xx++)
                    { // this loop using to calulate one station have cobinations
                        int stationx = list[xx].id; //current station id for -> this side
                        var ss = db.stationDistances.Where(a => a.station1id == stationy && a.station2id == stationx).FirstOrDefault(); // find the value this combination from tbdistance table
                        if (ss != null)
                        {
                            xdata[xx] = Convert.ToInt32(ss.distance);
                        }
                        else
                        {
                            xdata[xx] = 0; //if value is null then assign the 0
                        }
                    }
                    graph.AddFirst(xdata); //add the link list as a 1d array

                }
            }catch(Exception ex)
            {
                popError("error while preparing data for to find shortestest path"+Environment.NewLine+ex.Message);
                return;
            }
            int selectpath = loc3.SelectedIndex; // get select station
            LinkedList<int[]> getdata = null;
            try
            {
                getdata = Dijkstra.DijkstraAlgo(graph, selectpath, list.Count);//this methed help find the shortest path from dijikstar
            }catch(Exception ex)
            {
                popError("Error occured while finding the shortest distance" + Environment.NewLine + ex.Message);
                return;
            }
            try
            {
                int co = 0;
                int[] arraypath = new int[list.Count]; //create array to store to shotest path from link list
                int[] ditance = new int[list.Count]; // create an arra for store distance from link list
                ;
                foreach (int[] ld in getdata)
                {

                    ditance[co] = ld[0];
                    arraypath[co] = ld[1]; // storing data

                    co++;
                }
                for (int j = 0; j < list.Count; j++)
                {
                    int stationname = -1; //add stationname index
                    string sname = " -> ";// add shortest path 
                    string ans = "yes"; // this using confirm in using first time
                    int index = -1;
                    while (true)
                    {
                        

                        if (selectpath == index)
                        {
                            ans = "no";
                            DataResult dr = new DataResult(); //create detset object
                            dr.Path =  sname + list[j].Name;// asign the shortest path
                            dr.Distance = ditance[j]; //asign the distance
                            dataResults.Add(dr);//add the object
                            //result = result + (list[selectpath].Name + sname + list[j].Name) + " = " + ditance[j] + "\n";
                            break;
                        }
                        else
                        {
                            int sid;
                            if (ans == "yes")
                            {
                                ans = "no";
                                sname = "";
                                sid = list[arraypath[j]].id;
                            }
                            else {
                                 sid = list[stationname].id;
                                //sid = list.FindIndex(a => a.id == temp);
                            }
                            
                            index = list.FindIndex(a => a.id == sid);
                            stationname = arraypath[index];
                            sname =   list[index].Name + " -> "+ sname;
                           


                        }
                       // counter++;
                    }

                }
            }catch(Exception ex)
            {
                popError("Error occured while delivering the results" + Environment.NewLine + ex.Message);
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            lbl_time.Text = "Calculated Time " + elapsedTime;
            dataGridView1.DataSource = dataResults; //add data to data grid
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch(); //create stopwoch object
            stopWatch.Start(); //start stopwatch
           
            
            int sid = Convert.ToInt32(txt_stationsearch.Text); //get search id from station search textfield
            var result = list.Where(a => a.id == sid).FirstOrDefault(); //find the station name from id;
            
            if (result == null) //if no result from the search id
            {
                MessageBox.Show("No Station found for given id");
                return;
            }
            stopWatch.Stop(); //after proces is over then stop the stopwatch
            TimeSpan ts = stopWatch.Elapsed; //get the stopwatch timestamp
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10); //convert time stamp to normal  standed
            lbl_time.Text = "search time " + elapsedTime; //set the time to the label
            textBox1.Text = result.Name; //set the resut of statin name on text field
        }
        LinkedList<tbStations> stationsupdatelist = new LinkedList<tbStations>(); //create link list for store updated values
        private void btn_update_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            tbStations add = new tbStations();
            if(txt_stationsearch.Text.Length==0 || textBox1.Text.Length == 0) // text field validations to integers
            {
                MessageBox.Show("please enter a station Name and its id...","Missing details",MessageBoxButtons.OK);
                return;
            }
            add.id = Convert.ToInt32(txt_stationsearch.Text);
            add.Name = textBox1.Text;
            stationsupdatelist.AddLast(add); // add the link list updated values
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            lbl_time.Text = "single update time " + elapsedTime;
            textBox1.Text = "";
            txt_stationsearch.Text = "";
        }

        private void btn_updateall_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            foreach (tbStations addstations in stationsupdatelist) //read the link list values
            {
                tbStations add = new tbStations(); //create the stations table object to update the updated data
                add = db.stations.Find(addstations.id); //find the update data id to update correct row (id get from link list)
                add.Name = addstations.Name; //update the station name(Name get from link list)
                db.Entry(add).State = EntityState.Modified;
                db.SaveChanges();
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            lbl_time.Text = "Multiple update time " + elapsedTime;
            list = db.stations.ToList(); //reload the statios data collection
            listdistance = db.stationDistances.ToList();//reload the statios distance data collection
            loadComboData(); //reload the all combo boxes

        }
        LinkedList<tbStations> stationsdeletelist = new LinkedList<tbStations>(); //create a link list for store deleted data
        private void btn_delete_Click(object sender, EventArgs e) //delete one by one
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            tbStations add = new tbStations(); //create the object for add to link list
            
            if (txt_stationsearch.Text.Length==0)
            {
                MessageBox.Show("Please enter a station ID", "missing details",MessageBoxButtons.OK);
                return;
            }
            add.id = Convert.ToInt32(txt_stationsearch.Text);
            add.Name = textBox1.Text;
            stationsdeletelist.AddLast(add); //add deleted data to  link list
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            lbl_time.Text = "single delete time " + elapsedTime;
            textBox1.Text = "";
            txt_stationsearch.Text = "";
        }

        private void btn_deleteall_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            foreach (tbStations addstations in stationsdeletelist)
            {
                tbStations removestations = db.stations.Find(addstations.id); // find the row what row will delete(id get from link list)
                db.stations.Remove(removestations); //delete the row from id
                db.SaveChanges();
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            lbl_time.Text = "Multiple delete time " + elapsedTime;
            list = db.stations.ToList();
            listdistance = db.stationDistances.ToList();
            loadComboData();
        }

        LinkedList<Tbdistances> addDes = new LinkedList<Tbdistances>(); // this is insert link list
        private void Add_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Tbdistances a = new Tbdistances(),b = new Tbdistances(); // create two tbsistance table objects
            a.station1id = Convert.ToInt32(loc1.SelectedValue); // get data from station1 cobobox and convert to integer
            a.station2id = Convert.ToInt32(Loc2.SelectedValue); // get data from station2 cobobox and convert to integer

            b.station1id = a.station2id;  //this logic use to ex if we store A->B distance 10, B-> A should be 10
            b.station2id = a.station1id;
            if (Text_distance.Text.Length == 0)
            {
                MessageBox.Show("Please enter distance");
                return;
            }
            a.distance = Convert.ToInt32(Text_distance.Text);
            b.distance = a.distance;
            addDes.AddLast(a); // add data to link list
            addDes.AddLast(b);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            lbl_time.Text = "single Add distance time " + elapsedTime;
            Text_distance.Text = "";
        }

        private void Add_All_Click(object sender, EventArgs e) //add all the distance
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            foreach (Tbdistances adddistance in addDes)
            {
 
                Tbdistances stationDistance = new Tbdistances();
                stationDistance.station1id = adddistance.station1id; //add data station1id
                stationDistance.station2id = adddistance.station2id; //add data station2id
                stationDistance.distance = adddistance.distance;  // add distance

                db.stationDistances.Add(stationDistance);
                db.SaveChanges();
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            lbl_time.Text = "Multiple Add Distance time " + elapsedTime;
            list = db.stations.ToList();
            listdistance = db.stationDistances.ToList();
            loadComboData();
        }
       
        private bool checkValidDistance(String no)
        {
            int result;
            if (!int.TryParse(no, out result) || result < 0)
            {
                MessageBox.Show("The distance needs to be a number and" + Environment.NewLine + "greater than -1");
                return false;
            }
            return true;
        }
        private bool checkValidID(String no)
        {
            int result;
            if (!int.TryParse(no, out result) || result < 0)
            {
                MessageBox.Show("Please enter a valid id");
                return false;
            }
            return true;
        }
        LinkedList<Tbdistances> updateDes = new LinkedList<Tbdistances>(); //create the link list for update distance values store
        private void btn_update_distance_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Tbdistances add = new Tbdistances(), add2 = new Tbdistances(); ; //create two objects to update values store
            if (txt_distance_search.Text.Length == 0)
            {
                MessageBox.Show("Please enter an ID");
                return;
            }
            if (Text_distance.Text.Length == 0)
            {
                MessageBox.Show("Please enter distance");
                return;
            }
            add.id = Convert.ToInt32(txt_distance_search.Text); // add object to search textfield value
            add.distance = Convert.ToInt32(Text_distance.Text); //distance add
            add.station1id = Convert.ToInt32(loc1.SelectedValue); //add station 1 id
            add.station2id = Convert.ToInt32(Loc2.SelectedValue); //add station 2 id

            add2.id = findAjacentIDEdge(add.id); // if we update A->B=15 then we should update B->A=15 this methed help to find
            add2.distance = add.distance;
            add2.station1id = add.station2id;
            add2.station2id = add.station1id;

            updateDes.AddLast(add); // add updated data to link list (ex: A->B=15)
            updateDes.AddLast(add2); // add updated data to link list (ex: B->A=15)
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            lbl_time.Text = "single update distance time " + elapsedTime;
            Text_distance.Text = "";
            txt_distance_search.Text = "";
        }

        private void btn_distance_search_Click(object sender, EventArgs e) // distance search from id
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int sid;
            try {
                sid = Convert.ToInt32(txt_distance_search.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a valid rail ID", "incorrect input", MessageBoxButtons.OK);
                return;
            }
            var result = listdistance.Where(a => a.id == sid).FirstOrDefault();
            if (result == null) {
                MessageBox.Show("No route/Railway found for given id");
                return;
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            lbl_time.Text = "search time " + elapsedTime;
            //textBox1.Text = result.distance.ToString();
            loc1.SelectedValue = result.station1id; // set the result to combobox station1id
            Loc2.SelectedValue = result.station2id; // set the result to combobox station2id
            Text_distance.Text = result.distance.ToString(); //set the distance to textfield
        }

        private void btn_update_distanceall_Click(object sender, EventArgs e) // update all distance
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            foreach (Tbdistances adddistance in updateDes) //read all updated data 
            {
                Tbdistances add = new Tbdistances();
                add = db.stationDistances.Find(adddistance.id);
                add.station1id = adddistance.station1id;
                add.station2id = adddistance.station2id;
                add.distance = adddistance.distance;
                db.Entry(add).State = EntityState.Modified;
                db.SaveChanges();
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            lbl_time.Text = "Multiple distance update time " + elapsedTime;
            list = db.stations.ToList();
            listdistance = db.stationDistances.ToList();
            loadComboData();
        }
       
        private int findAjacentIDEdge(int id)
        {
            //find the station A with id=id in the argument
            Tbdistances A = db.stationDistances.Find(id);
            //get station1 id and station2 id from the found edge...
            //find the edge with station ids matching vice versa...and return it's id
            return db.stationDistances.Single(d => d.station1id == A.station2id && d.station2id == A.station1id).id;
        }
        LinkedList<Tbdistances> deleteDes = new LinkedList<Tbdistances>(); // this using to deleted values store
        private void btn_distance_delete_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Tbdistances add = new Tbdistances(),add2=new Tbdistances(); //create two objects
            if (txt_distance_search.Text.Length == 0)
            {
                MessageBox.Show("Please enter an ID");
                return;
            }
            add.id = Convert.ToInt32(txt_distance_search.Text); //if we delete the A->B =15 from id

            add2.id = findAjacentIDEdge(add.id);  // we should delete the B->A =15 from id this methed help to find that id

            deleteDes.AddLast(add); //A->B id add the link list
            deleteDes.AddLast(add2);//B->A id add the link list
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            lbl_time.Text = "single delete distance time " + elapsedTime;
            Text_distance.Text = "";
            txt_distance_search.Text = "";
        }

        private void btn_distance_deleteall_Click(object sender, EventArgs e) // delete all values
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            foreach (Tbdistances deletedistance in deleteDes) //read all datas
            {
                Tbdistances removestations = db.stationDistances.Find(deletedistance.id);
                db.stationDistances.Remove(removestations);
                db.SaveChanges();
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            lbl_time.Text = "Multiple delete distance time " + elapsedTime;
            list = db.stations.ToList();
            listdistance = db.stationDistances.ToList();
            loadComboData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new MinimumConnectors(db).Show();
        }

        private void txt_stationsearch_TextChanged(object sender, EventArgs e)
        {
            if (txt_stationsearch.Text.Length == 0)
                return;
            if (!checkValidID(txt_stationsearch.Text))
            {
                txt_stationsearch.Text = "";
            }

        }

        private void txt_distance_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_distance_search.Text.Length == 0)
                return;
            if (!checkValidID(txt_distance_search.Text))
            {
                txt_distance_search.Text = "";
            }
        }

        private void Text_distance_TextChanged(object sender, EventArgs e)
        {
            if (Text_distance.Text.Length == 0)
                return;
            if (!checkValidDistance(Text_distance.Text))
            {
                Text_distance.Text = "";
            }
        }
    }
    public class DataResult // data set for datagridview
    {
        public String  Path { get; set; }
        public int Distance { get; set; }
    }
}
