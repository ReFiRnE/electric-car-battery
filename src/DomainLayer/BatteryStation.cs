using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class BatteryStation
    {
        // what we need for the battery station itself
        private int stationID { get; set; }
        private string name { get; set; }
        private DateTime timeOpen { get; set; }
        private DateTime timeClose { get; set; }

        // what we need for the graph + the name
        private bool mark { get; set; }
        private IList<Edge> edges;

        public BatteryStation(int stationID, string name, DateTime timeOpen, DateTime timeClose)
        {
            this.stationID = stationID;
            this.name = name;
            this.timeOpen = timeOpen;
            this.timeClose = timeClose;

            mark = false;
            edges = new List<Edge>();
        }

        public void AddEdge(BatteryStation station)
        {
            Edge newEdge = new Edge(this, station);
            edges.Add(newEdge);
        }

        public int OutDegree()
        {
            return edges.Count;
        }

        public void RemoveEdge(Edge edge)
        {
            edges.Remove(edge);
        }

        public IList<Edge> EdgeList()
        { 
            return edges; 
        }
    }
}