using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainStations.DAL;
using TrainStations.Models;

namespace TrainStation
{

    public partial class AddDesetance : Form
    {
        private DbAcess db = new DbAcess();
        public AddDesetance()
        {
            InitializeComponent();
            loadComboData();
        }
        public void loadComboData()
        {
           

            var mlist = db.stations.ToList();
            var mlist2 = db.stations.ToList();

            loc1.DisplayMember = "Name";
            loc1.ValueMember = "id";
            loc1.DataSource = mlist;

            Loc2.DisplayMember = "Name";
            Loc2.ValueMember = "id";
            Loc2.DataSource = mlist2;
        }
        Queue<AddDistance> addDes = new Queue<AddDistance>();
        private void Add_Click(object sender, EventArgs e)
        {
            AddDistance a = new AddDistance();
            a.stationone = Convert.ToInt32(loc1.SelectedValue);
            a.stationtwo = Convert.ToInt32(Loc2.SelectedValue);
            a.distance = Convert.ToInt32(Text_distance.Text);
            addDes.Enqueue(a);
            Text_distance.Text = "";
        }

        private void Add_All_Click(object sender, EventArgs e)
        {
            while (addDes.Count > 0)
            {
                AddDistance a = new AddDistance();
                a = addDes.Dequeue();
                Tbdistances stationDistance = new Tbdistances();
                stationDistance.station1id = a.stationone;
                stationDistance.station2id = a.stationtwo;
                stationDistance.distance = a.distance;
               
                db.stationDistances.Add(stationDistance);
                db.SaveChanges();
                
            }

        }
        
        private void btn_search_Click(object sender, EventArgs e)
        {
            LinkedList<int[]> graph = new LinkedList<int[]>();

            
            

            var list = db.stations.ToList();

            
            for(int yy=0;yy<list.Count;yy++)
            {

                int[] xdata = new int[list.Count];
                int stationy = list[yy].id;
                for (int xx=0;xx<list.Count;xx++)
                {
                    int stationx = list[xx].id;
                    var ss = db.stationDistances.Where(a=>a.station1id== stationy && a.station2id== stationx).FirstOrDefault();
                    if (ss !=null)
                    {
                        xdata[xx] = Convert.ToInt32(ss.distance);
                    }
                    else {
                        xdata[xx] = 0;
                    }
                }
                graph.AddFirst(xdata);
                
            }

            int selectpath = loc1.SelectedIndex;
            LinkedList<int []> getdata = Dijkstra.DijkstraAlgo(graph, selectpath, list.Count);
            int co = 0;
            int[] arraypath = new int[list.Count];
            int[] ditance = new int[list.Count];
            string result = "";
            foreach (int[] ld in getdata)
            {
               
                ditance[co]= ld[0];
               arraypath[co] = ld[1];

                co++;
            }
            for (int j=0;j<list.Count;j++)
            {
                int stationname = -1;
                string sname=" -> ";
                string ans = "yes";
                while (true)
                {
                    
                    if (selectpath == arraypath[j] || stationname== arraypath[j])
                    {
                        ans = "no";
                        result=result + (list[selectpath].Name  + sname  + list[j].Name)+" = "+ ditance[j] + "\n";
                        break;
                    }
                    else
                    {
                        if (ans=="yes")
                        {
                            ans = "no";
                            sname = "";
                        }
                        int sid = list[arraypath[j]].id;
                        int index=list.FindIndex(a => a.id == sid);
                        stationname = index;
                        sname = sname +" -> "+ list[index].Name+" -> ";

                      
                    }
                }

            }
            lbl_result.Text = result;
        }
    }
}
