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
using Nishain_2d_array_prim;

namespace WindowsFormsApp3
{
    public partial class Form11 : Form
    {
        private static readonly int NO_PARENT = -1;
        public Form11()
        {
            InitializeComponent();
            
        }

        void startAlgorithm()
        {
            //int selectedValue = Convert.ToInt32(cmbValues.ValueMember);

            //get the selected station from the combobox
            int selectedValueRetrive = (int)cmbValues.SelectedValue;
            int selectedValue = selectedValueRetrive - 1;
            DboTrainsEntities1 entit = new DboTrainsEntities1();
           //get station Id's from database
            var cc = (from p in entit.TbStations
                      select new
                      {
                          id = p.id,
                  

                      });
             //convert station id to list
            var vv = cc.ToList();
            //get station count
            var rowcount = cc.Count();
            //initialize the 2d array
            int[,] arr = new int[rowcount, rowcount];

            int row = 0;
            int column = 0;
            //arrary row data 
            foreach (var val in vv)
            {
                column = 0;
                int id = val.id;
                //array column data
                for (int i = 1; i <= rowcount; i++)
                {
                    //get distances from database
                    var Distance = (from p in entit.Tbdistances
                                    where p.station1Id == id && p.station2id == i
                                    select new
                                    {
                                        distances = p.distance,


                                    });
                    //convert to list
                    var vv2 = Distance.ToList();
                    //check distances value 
                    foreach (var val2 in vv2)
                    {
                        if(val2.distances == null)
                        {
                            
                                arr[row, column] = 0;
                            
                           
                        }
                        else
                        {
                                //set station details to array
                                arr[row, column] = Convert.ToInt32(val2.distances);
                            
                        }
                        
                    }
                    
                      column++;
                    
                    

                }
                    row++;

                   
            }



                int[,] adjacencyMatrix = { { 0, 4},
                                    { 5, 0 },
                                    

        };
            //send the 2d array and startvertex to the algorithm function
            dijkstra(arr, selectedValue);
        }


         void dijkstra(int[,] adjacencyMatrix,
                                            int startVertex)
        {
            //get the no of stations/vertices
            int nVertices = adjacencyMatrix.GetLength(0);

            // shortestDistances[i] will hold the  
            // shortest distance from src to i  
            int[] shortestDistances = new int[nVertices];

            
            bool[] added = new bool[nVertices];

            //initialize all vertices as infinite and added vertices to false
            for (int vertexIndex = 0; vertexIndex < nVertices;
                                                vertexIndex++)
            {
                shortestDistances[vertexIndex] = int.MaxValue;
                added[vertexIndex] = false;
            }

            //set distance from startvertex to iteself to 0
            shortestDistances[startVertex] = 0;

            //array to store shortest path tree
            int[] parents = new int[nVertices];

            //set the startvertex as it does not have parents
            parents[startVertex] = NO_PARENT;

            //find shortest path from startvertex to all vertices/other stations
            for (int i = 1; i < nVertices; i++)
            {

                //pick the vertex with minimum distance from the vertices not yet processed
                int nearestVertex = -1;
                //set Infinity  value for all vertex
                int shortestDistance = int.MaxValue;
                for (int vertexIndex = 0;
                        vertexIndex < nVertices;
                        vertexIndex++)
                {
                    if (!added[vertexIndex] &&
                        shortestDistances[vertexIndex] <
                        shortestDistance)
                    {
                        nearestVertex = vertexIndex;
                        shortestDistance = shortestDistances[vertexIndex];
                    }
                }

              //set the picked vertex as processed
              added[nearestVertex] = true;

                //update the distances of the adjecent vertices of the picked vertex
                for (int vertexIndex = 0;
                        vertexIndex < nVertices;
                        vertexIndex++)
                {
                    int edgeDistance = adjacencyMatrix[nearestVertex, vertexIndex];

                    if (edgeDistance > 0
                        && ((shortestDistance + edgeDistance) <
                            shortestDistances[vertexIndex]))
                    {
                        parents[vertexIndex] = nearestVertex;
                        shortestDistances[vertexIndex] = shortestDistance +
                                                        edgeDistance;
                    }
                }
            }

            printSolution(startVertex, shortestDistances, parents);
        }

        //function to print shortest path distance,path
         void printSolution(int startVertex,
                                        int[] distances,
                                        int[] parents)
        {
            int nVertices = distances.Length;

            showLbl.Text = "";
            for (int vertexIndex = 0;
                    vertexIndex < nVertices;
                    vertexIndex++)
            {
                
                if (vertexIndex != startVertex)
                {
                    String StationName = "";
                    String StationEndName = "";
                    DboTrainsEntities1 entit = new DboTrainsEntities1();
                    //identify start station name according to selected vertex
                    var StationStart = (from p in entit.TbStations
                                    where p.id == startVertex+1 
                                    select new
                                    {
                                        name = p.Name,


                                    });

                    var vv2 = StationStart.ToList();

                    foreach (var val2 in vv2)
                    {
                         StationName = val2.name;

                    }
                    //identify end station name according to selected vertex
                    var EndStation = (from p in entit.TbStations
                                        where p.id == vertexIndex+1 
                                        select new
                                        {
                                            name = p.Name,


                                        });

                    var vv22 = EndStation.ToList();

                    foreach (var val21 in vv22)
                    {
                        StationEndName = val21.name;

                    }
                    //set user input data to display
                    showLbl.Text +=  "\n\n"+ StationName + " to "+ StationEndName + "               "+ distances[vertexIndex] +"                  ";


                    printPath(vertexIndex, parents);
                }
                
            }
        }

        //print the shortest paths
         void printPath(int currentVertex,
                                    int[] parents)
        {

            String StationName = "";
            if (currentVertex == NO_PARENT)
            {
                return;
            }

            DboTrainsEntities1 entit = new DboTrainsEntities1();
            var StationStart = (from p in entit.TbStations
                                where p.id == currentVertex + 1
                                select new
                                {
                                    name = p.Name,


                                });

            var vv2 = StationStart.ToList();

            foreach (var val2 in vv2)
            {
                StationName = val2.name;

            }


            printPath(parents[currentVertex], parents);
            showLbl.Text += StationName + "-->" ;
            
        }
        //algorithem start event
        private void btnStart_Click(object sender, EventArgs e)
        {

            startAlgorithm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        //open crud app of train stations
        private void btntrainstation_Click(object sender, EventArgs e)
        {
            Nav n = new Nav();
            n.Show();
            
        }

        //open crud app of distances
        private void button1_Click(object sender, EventArgs e)
        {
            Distances d = new Distances();
            d.Show();
        }
        //open minimum connecters algorithm app
        private void btnmincon_Click(object sender, EventArgs e)
        {
            DboTrainsEntities1 entit = new DboTrainsEntities1();
            var cc = (from p in entit.TbStations
                      select new
                      {
                          id = p.id,
                          name = p.Name

                      });

            var vv = cc.ToList();
            List<TbStation> v = new List<TbStation>();
            foreach (var val in vv)
            {
                 TbStation s = new TbStation();
                s.id = val.id;
                s.Name = val.name;
                v.Add(s);

            }

            var cc2 = (from p in entit.Tbdistances
                      select new
                      {
                          id = p.id,
                          station1 = p.station1Id,
                          station2 = p.station2id,
                          distance = p.distance

                      });

            var vv2 = cc2.ToList();
            List<Tbdistance> v1 = new List<Tbdistance>();
            foreach (var val in vv2)
            {
                Tbdistance s1 = new Tbdistance();
                s1.id = val.id;
                s1.station1Id = val.station1;
                s1.station2id = val.station2;
                s1.distance = val.distance;
                v1.Add(s1);

            }


            Form1 f = new Form1(v1, v);
                f.Show();
            
        }

        //refresh the combo box
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        //load stations to combo box
        void loadData()
        {
            DboTrainsEntities1 entit = new DboTrainsEntities1();
            var StationStart = (from p in entit.TbStations

                                select new
                                {
                                    name = p.Name,
                                    id = p.id


                                });

            var vv2 = StationStart.ToList();


            cmbValues.DataSource = vv2;
            cmbValues.DisplayMember = "name";
            cmbValues.ValueMember = "id";
        }
    }
}
