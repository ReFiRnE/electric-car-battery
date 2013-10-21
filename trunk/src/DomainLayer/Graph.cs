using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    class Graph
    {
        private IList<BatteryStation> stations;

        public Graph()
        {
            stations = new List<BatteryStation>();
        }

        public bool IsEmpty()
        {
            return stations.Count == 0;
        }

        public void AddStation(BatteryStation station)
        {
            if (!stations.Contains(station))
                stations.Add(station);
        }

        public void AddEdge(BatteryStation from, BatteryStation to)
        {
            if (FindEdge(from, to) == null)
                from.AddEdge(to);
        }

        public bool ContainsVertex(BatteryStation station)
        {
            return stations.Contains(station);
        }

        public bool IsAdjacent(BatteryStation startStation, BatteryStation endStation)
        {
            return (FindEdge(startStation, endStation) != null);
        }

        public IList<BatteryStation> GetAdjacencies(BatteryStation station)
        {
            List<BatteryStation> adjStations = new List<BatteryStation>();
            IEnumerator ien = station.EdgeList().GetEnumerator();

            while (ien.MoveNext())
            {
                Edge e = (Edge)ien.Current;
                adjStations.Add(e.To);
            }

            return adjStations;
        }

        public IEnumerator<BatteryStation> BatteryStations()
        {
            return stations.GetEnumerator();
        }

        public int GetNoOfVertices()
        {
            return stations.Count();
        }

        public int GetNoOfEdges()
        {
            int noOfEdges = 0;

            foreach (BatteryStation station in stations)
                noOfEdges += station.OutDegree();

            return noOfEdges;
        }

        public void Clear()
        {
            stations.Clear();
        }

        public void RemoveEdge(BatteryStation from, BatteryStation to)
        {
            Edge e = FindEdge(from, to);

            if (e != null)
                e.From.RemoveEdge(e);
        }


        public void RemoveBatteryStation(BatteryStation station)
        {
            stations.Remove(station);

            IEnumerator ien = stations.GetEnumerator();

            while (ien.MoveNext())
            {
                BatteryStation bs = (BatteryStation)ien.Current;
                IList<Edge> stationEdges = bs.EdgeList();

                for (int i = 0; i < stationEdges.Count; i++)
                {
                    Edge e = stationEdges[i];

                    if (e.To.Equals(station))
                        stationEdges.Remove(e);
                }
            }
        }

        public Edge FindEdge(BatteryStation from, BatteryStation to)
        {
            Edge edge = null;
            IEnumerator ienum = from.EdgeList().GetEnumerator();

            while ((edge != null) && ienum.MoveNext())
            {
                if (ienum.Current.Equals(to))
                    edge = (Edge)ienum.Current;
            }

            return edge;
        }

        #region Traversing
        public void Bfs(BatteryStation v)
        {
            throw new System.NotImplementedException();
        }

        public void Dfs(BatteryStation v)
        {
            throw new System.NotImplementedException();
        }

        public void Unmark()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}