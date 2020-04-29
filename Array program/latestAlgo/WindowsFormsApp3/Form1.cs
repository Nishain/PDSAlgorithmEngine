using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;



namespace Nishain_2d_array_prim
{
    public partial class Form1 : Form
    {
        public Form1(List<Tbdistance> edges, List<TbStation> stations)
        {
            //In the constructor send distances and station directly from db onject like db.station.ToList() to this constructor
            //stationPool and routePool are variables to maintain an array of information station and connected edges/routes
            stationPool = stations.ToArray();
            routePool = edges.ToArray();
            InitializeComponent();
            
            //intitialize the combobox for user to select a station...
            selectedStationCombo.DisplayMember = "Name";
            selectedStationCombo.ValueMember = "id";
            selectedStationCombo.DataSource = stationPool;
        }

        private Tbdistance[] possibleRoutes;
        private Tbdistance[] routePool;
        private TbStation[] stationPool;
        private String selectedStationList = "";
        private String checkIfValid(int selectedStationID)
        {
            Tbdistance result;
            if (possibleRoutes == null){ //the user select the first station to be considered to find minimum spanning tree..

                /*possibleRoutes variable hold a list of edges/routes which are possible for the given user selected
                 stations this variable list grow in size when user add more stations as more connected routes are
                 discovered..*/
                possibleRoutes = routePool.Where(r => r.station1Id==selectedStationID).ToArray();
                if(possibleRoutes.Length==0){
                    //if first selected station has no connection with other route then operation will aborted list
                    //will be reseted and user is forced to select a another connected station.Isolated stations can lead to
                    //error in the algorithm
                	possibleRoutes=null;
                	return "Isolated station inserted!";
                }
                //the first station is added...
                selectedStationList=possibleRoutes[0].station1Id.ToString();
                return null;
            }
            //check if the user selected station is already selected previously..
            if (possibleRoutes.FirstOrDefault(r => r.station1Id == selectedStationID) != null)
                return "selected station is already selected!";
            //check if any of the routes lead to station id equals to id of user selected station
            result = possibleRoutes.FirstOrDefault(r => r.station2id == selectedStationID);
            if (result != null)
            {
                //the connected routes of the newly added station will be concatenated to possibleRoutes lsit
                possibleRoutes = possibleRoutes.Concat(routePool.Where(r => r.station1Id == selectedStationID)).ToArray();
                //the id of newly selected station will added to selectedStationList comma seperated..
                selectedStationList += "," + selectedStationID.ToString();
                return null;
            }
            //if result variable is null means no routes has found with destination station id = userSelectedStaionID
            //so the station user trying add is not connect to any stations user previously added..
            return "selected station is not connected to any station you previously selected";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //check if user has selected any station before proceeding to run the algorithm
            if (selectedStationContainer.Items.Count == 0)
                popNoSelectionError();
            else
                primAlgo();
        }
        private void popNoSelectionError()
        {
            MessageBox.Show("Select a station first!","Error", MessageBoxButtons.OK);
        }

        //this function is used during development phase to automatically select data..
        //this function as no effect now.
        private void dummySelect()
        {
            checkIfValid(1);
            checkIfValid(2);
            checkIfValid(3);
            checkIfValid(4);
            checkIfValid(5);
            checkIfValid(6);
        }
        private void primAlgo()
        {
            
            output.Text = "";//the output to be returned and the end of the function

            /*since it is diificult to push a element dynamicaly to a fixed array the variable selectedStationList
             maintains a list of user selected stations as string comma seperated and after collections split the string
             as an array to access each element by given index*/
            String[] stationsIdsToBeConnected = selectedStationList.Split(',');


            String[] visitedStationIds = new String[stationsIdsToBeConnected.Length];

            //the first station is visited intitially, variable visitedStationIds maintains arrays of visited
            //stations
            visitedStationIds[0] = stationsIdsToBeConnected[0];
            Tbdistance[] stageData=null;
            int count = 1;//since one station is visited initially the count starts from 1
            int totalWeight = 0;
            while (count < stationsIdsToBeConnected.Length)//iterate until all the stations are connected/visited..
            {
               /*from list of all the interconnect (include both directional edges) routes 
                * connected to user given station, find set of routes where each edge's starting station is already visited
                but destination station is unvisited and a station which user has already defined*/
                stageData = possibleRoutes.Where(
                    //check if any of ids of visited station match/not matching
                    r => visitedStationIds.Contains(r.station1Id.ToString()) &&
                !visitedStationIds.Contains(r.station2id.ToString()) &&
                stationsIdsToBeConnected.Contains(r.station1Id.ToString())).ToArray();
                
                Tbdistance EdgeWithMinWeight = null;
                int minWeight = int.MaxValue;//minWeight is set to int defined possible infinite
                /*From resultant set edges find an edge with minimum distance/weight*/
                foreach (Tbdistance d in stageData)
                {
                    if (d.distance < minWeight)
                    {
                        EdgeWithMinWeight = d;
                        minWeight = d.distance.Value;
                    }
                }
                //mark the destination/connected station of edge with min weight to be visited
                visitedStationIds[count] = EdgeWithMinWeight.station2id.ToString();
                count++;
                //increment the tota; weight of minimum spanning tree with discovered min weight
                totalWeight += minWeight;
                //In each iterartion display the edge with min weight...
                output.Text += findStationName(EdgeWithMinWeight.station1Id.Value) + "<-->" + findStationName(EdgeWithMinWeight.station2id.Value)+" "+EdgeWithMinWeight.distance + Environment.NewLine;
            }
            output.Text += "Total weight " + totalWeight;
            }
        private String findStationName(int id)
        {
            //map and find the name of the staion when the id is given
            return stationPool.Single(s=>s.id == id).Name;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //when user add a station to be considered in prim's algorithm check wether the station
            //is elegible to be added..
            TbStation selectedItem=((TbStation)selectedStationCombo.SelectedItem);
            String errMsg;
            if ((errMsg=checkIfValid(selectedItem.id))!=null)//iif error message is null it means successfully
                //station is selected
                popInvalidSelectionError(errMsg);
            else
                selectedStationContainer.Items.Add(selectedItem.Name);
        }

        private void popInvalidSelectionError(string errMsg)
        {
            string title = "Invalid Station selected";
            string message = errMsg;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
        }
        private void addEdge(int src,int dst,int weight)
        {
            Tbdistance a = new Tbdistance(), b = new Tbdistance();
            a.distance = b.distance = weight;
            a.station1Id = b.station2id = src;
            a.station2id = b.station1Id = dst;
            routePool = routePool.Concat(new Tbdistance[] { a, b }).ToArray();
        }
        private void insertDummy()
        {
            stationPool = new TbStation[0];
            routePool = new Tbdistance[0];

            insertStation("a", 1);
            insertStation("b", 2);
            insertStation("c", 3);
            insertStation("d", 4);
            insertStation("e", 5);
            insertStation("f", 6);

            addEdge(1, 2, 3);
            addEdge(2, 3, 5);
            addEdge(3, 4, 4);
            addEdge(4, 5, 2);
            addEdge(5, 1, 4);

            addEdge(1, 6, 7);
            addEdge(2, 6, 8);
            addEdge(3, 6, 6);
            addEdge(4, 6, 8);
            addEdge(5, 6, 5);
        }
        private void insertStation(String name,int id)
        {
            TbStation s = new TbStation();
            s.id = id;
            s.Name = name;
            stationPool = stationPool.Concat(new TbStation[] { s }).ToArray();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            possibleRoutes = null;
            selectedStationList = "";
            selectedStationContainer.Clear();
        }

        
    }
    }

