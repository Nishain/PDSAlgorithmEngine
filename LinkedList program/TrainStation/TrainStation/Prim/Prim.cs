using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStations.Models;

namespace TrainStations
{
    class Prim
    {
        LinkedList<tbStations> selectedStations;
        private LinkedList<tbStations> data;
        public Prim(List<tbStations> input)
        {
            data = new LinkedList<tbStations>();
            foreach (tbStations s in input)
            {
                data.AddFirst(s);
            }
        }
        public String checkIfValid(int selectedStation)
        {
            tbStations firstStation;
            if (selectedStations == null)
            {
                selectedStations = new LinkedList<tbStations>();
                //if the first selected station is not connected to any other stations abort the operation
                //imedietly 
                firstStation = data.Single(d => d.id == selectedStation);
                if (firstStation.StationDistances1 == null)
                {
                    selectedStations = null;
                    return "Cannot select a isolated station";
                }
                selectedStations.AddFirst(firstStation);
                return null;
            }
            if (selectedStations.SingleOrDefault(s => s.id == selectedStation) != null)
                return "Station is already selected";

            foreach (tbStations s in selectedStations)
            {
                foreach (Tbdistances d in s.StationDistances1)
                {
                    if (d.Stations2.id == selectedStation)
                    {
                        selectedStations.AddFirst(d.Stations2);
                        return null;
                    }
                }
            }
            return "You must select a station which is already connected to previosly selected stations";
        }
        public String primAlgo()
        {
            
            if (selectedStations == null || selectedStations.Count == 0)
                return "Station not selected";
            String output = "";
            double totalWeight = 0;
            LinkedList<int> selectedStationIDs = new LinkedList<int>();
            foreach (tbStations s in selectedStations)
            {
                selectedStationIDs.AddFirst(s.id);
            }

            LinkedList<tbStations> markedtbStations = new LinkedList<tbStations>();
            LinkedList<Tbdistances> comparingEdges = new LinkedList<Tbdistances>();
            markedtbStations.AddFirst(selectedStations.First.Value);
            while (markedtbStations.Count < selectedStations.Count)
            {
                foreach (tbStations s in markedtbStations)
                {
                    foreach (Tbdistances d in s.StationDistances1)
                    {
                        if (selectedStationIDs.Contains(d.Stations2.id) && !markedtbStations.Contains(d.Stations2))
                            comparingEdges.AddFirst(d);
                    }
                }
                double minWeight = int.MaxValue;
                Tbdistances minWeightEdge = null;
                foreach (Tbdistances d in comparingEdges)
                {
                    if (d.distance < minWeight)
                    {
                        minWeight = d.distance;
                        minWeightEdge = d;
                    }
                }
                comparingEdges.Clear();
                output += minWeight.ToString() + " " + minWeightEdge.Stations1.Name + "->" + minWeightEdge.Stations2.Name + Environment.NewLine;
                totalWeight += minWeight;
                markedtbStations.AddFirst(minWeightEdge.Stations2);

            }
            output += "Total weight " + totalWeight;
            return output;
        }

        internal void clearSelection()
        {
            selectedStations = null;
        }
    }
}