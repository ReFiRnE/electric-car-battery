using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class BatteryStation
    {
        public int StationID { get; set; }
        public string Name { get; set; }
        public DateTime TimeOpen { get; set; }
        public DateTime TimeClose { get; set; }

        public bool Mark { get; set; }
        IList<Edge> edges;

        public BatteryStation(int StationID, string Name, DateTime TimeOpen, DateTime TimeClose)
        {
            this.StationID = StationID;
            this.Name = Name;
            this.TimeOpen = TimeOpen;
            this.TimeClose = TimeClose;

            Mark = false;
            edges = new List<Edge>();
        }

        public void AddEdge(BatteryStation station, double distance, bool twoWay)
        {
            Edge newEdge = new Edge(this, station, distance);
            edges.Add(newEdge);

            if (twoWay)
                station.AddEdge(this, distance, false);
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