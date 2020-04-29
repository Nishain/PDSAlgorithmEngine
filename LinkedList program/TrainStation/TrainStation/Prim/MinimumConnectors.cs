using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainStations;
using TrainStations.Models;

namespace TrainStation
{
    public partial class MinimumConnectors : Form
    {
        private Prim prim;
        public MinimumConnectors(TrainStations.DAL.DbAcess db)
        {
            prim = new Prim(db.stations.ToList());
            InitializeComponent();
            //inititalizing the combobox for user to select a station..
            selectStationComboBox.DisplayMember = "Name";
            selectStationComboBox.ValueMember = "id";
            selectStationComboBox.DataSource = db.stations.ToList();
        }

        private void addEdge(Queue<AddDistance> queue, int src, int dst, int weight)
        {
            AddDistance a = new AddDistance(), b = new AddDistance();

            a.stationone = b.stationtwo = src;
            a.stationtwo = b.stationone = dst;
            a.distance = b.distance = weight;
            queue.Enqueue(a);
            queue.Enqueue(b);
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            String err;
            if ((err=prim.checkIfValid(Convert.ToInt32(selectStationComboBox.SelectedValue)))!=null)
            {
                popSelectionError(err);
                return;
            }
            selectedStationContainer.Items.Add(((tbStations)selectStationComboBox.SelectedItem).Name);
        }
        private void popSelectionError(string err)
        {
            string title = "Invalid Station selected";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(err, title, buttons, MessageBoxIcon.Warning);
        }
        private void popNoStationSelectedError()
        {
            string title = "Error";
            string message = "Please select a station first";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            output.Clear();
            if (selectedStationContainer.Items.Count == 0)
                popNoStationSelectedError();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            output.Text = prim.primAlgo();
            stopWatch.Stop();
            output.Text += Environment.NewLine + "Took " + stopWatch.ElapsedMilliseconds + " milliseconds to proccess";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            prim.clearSelection();
            selectedStationContainer.Clear();

        }
    }
}