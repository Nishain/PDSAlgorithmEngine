using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStations.DAL;

namespace TrainStation
{
     
    class Dijkstra
    {
        private DbAcess db = new DbAcess();
        private static int MinimumDistance(int[] distance, bool[] shortestPathTreeSet, int verticesCount)
        {
            int min = int.MaxValue; // all datas are now alfa min value shuld be alfa
            int minIndex = 0; //store minimum index selected row

            for (int v = 0; v < verticesCount; ++v)
            {
                if (shortestPathTreeSet[v] == false && distance[v] <= min)
                {
                    min = distance[v]; 
                    minIndex = v;
                }
            }

            return minIndex;
        }


        public static LinkedList<int[]> DijkstraAlgo(LinkedList<int[]> graph, int source, int verticesCount) //souese mean calculate shortest parth fro which station // verticescount mean station count
        {
            int[] distance = new int[verticesCount]; // distance using store the 1d array get  from link list
            int[] path = new int[verticesCount]; // shortest path from stations
           bool[] shortestPathTreeSet = new bool[verticesCount]; // if we select the station veryfy
            path[source] = source; // 1st node should be selected station

            for (int i = 0; i < verticesCount; ++i) //asign the value to create the logic
            {
                distance[i] = int.MaxValue; //  dont know how much distance then it shuld be alfa then asign the integer max value
               
                shortestPathTreeSet[i] = false; //stil didnt select the station then every one are false 
            }

            distance[source] = 0; //selected should be start the 0 (if select A station ex: A->A=0)
            int[] myarr = null;
            for (int count = 0; count < verticesCount - 1; ++count)
            {
                int u = MinimumDistance(distance, shortestPathTreeSet, verticesCount);// help to find minimum distance index
                shortestPathTreeSet[u] = true; //selected index should be true now because already selected
                int count2 = 0;

                foreach (int[] ld in graph)
                {
                    if ((verticesCount - 1) - u == count2)
                    {
                        myarr = ld;//selected 1d array asign to analyse
                    }
                    count2++;
                }

                for (int v = 0; v < verticesCount; ++v)
                    // int val = myarr[v];
                    if (!shortestPathTreeSet[v] && Convert.ToBoolean(myarr[v]) && distance[u] != int.MaxValue && distance[u] + myarr[v] < distance[v]) //check the path is minimum
                    {
                        distance[v] = distance[u] + myarr[v]; //asign the shortest path
                        path[v] = u;// asign the previuos path
                    }
            }
            LinkedList<int[]> addnode = new LinkedList<int[]>(); //create the link list to pass the data
            for (int an = 0; an < verticesCount; ++an)
            {
                int[] addelements = new int[2]; // add data as an array to link list
                addelements[0] = distance[an]; // add shortest distance
                addelements[1] = path[an];// shortest path
                addnode.AddLast(addelements);
            }
            return addnode;

        }

    }
}
