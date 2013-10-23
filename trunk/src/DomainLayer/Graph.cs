using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Graph
    {
        private IList<BatteryStation> stations;

        public Graph()
        {
            stations = new List<BatteryStation>();
        }

        public IList<BatteryStation> GetStations()
        {
            return stations;
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

        public void AddEdge(BatteryStation from, BatteryStation to, double distance, bool twoWay)
        {
            if (FindEdge(from, to) == null)
                from.AddEdge(to, distance, twoWay);
        }

        public bool ContainsStation(BatteryStation station)
        {
            return stations.Contains(station);
        }

        public bool IsAdjacent(BatteryStation startStation, BatteryStation endStation)
        {
            return (FindEdge(startStation, endStation) != null);
        }

        public IEnumerator<BatteryStation> BatteryStations()
        {
            return stations.GetEnumerator();
        }

        public IList<Edge> GetAllEdges()
        {
            List<Edge> edgeList = new List<Edge>();

            foreach (BatteryStation bs in stations)
                edgeList.AddRange(bs.EdgeList());

            return edgeList;
        }

        public IList<BatteryStation> GetAdjacencies(BatteryStation station)
        {
            IList<BatteryStation> adjStations = new List<BatteryStation>();
            IEnumerator ien = station.EdgeList().GetEnumerator();

            while (ien.MoveNext())
            {
                Edge e = (Edge)ien.Current;
                adjStations.Add(e.To);
            }

            return adjStations;
        }

        public int GetNoOfStations()
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

        public Edge FindEdge(BatteryStation from, BatteryStation to)
        {
            Edge edge = null;

            foreach (Edge e in from.EdgeList())
            {
                if (e.To.Equals(to))
                    edge = e;
            }

            return edge;
        }

        public void RemoveEdge(BatteryStation from, BatteryStation to)
        {
            Edge e_from = FindEdge(from, to);
            Edge e_to = FindEdge(to, from);

            if (e_from != null)
                e_from.From.RemoveEdge(e_from);

            if (e_to != null)
                e_to.From.RemoveEdge(e_to);
        }

        public void RemoveBatteryStation(BatteryStation station)
        {
            stations.Remove(station);

            IList<BatteryStation> adjList = GetAdjacencies(station);

            foreach (BatteryStation bs_adj in adjList)
                RemoveEdge(station, bs_adj);
        }

        #region Traversing
        public void BreathFirstSearch(BatteryStation v)
        {
            throw new System.NotImplementedException();
        }

        public IList DepthFirstSearch(BatteryStation st)
        {
            UnmarkAll();

            IList l = new ArrayList();
            Stack<BatteryStation> s = new Stack<BatteryStation>();

            s.Push(st);
            l.Add(st);
            st.Mark = true;

            while (s.Count != 0)
            {
                BatteryStation n = GetNextUnMarked(GetAdjacencies(s.Peek()));

                if (n != null)
                {
                    n.Mark = true;
                    l.Add(n);
                    s.Push(n);
                }
                else
                {
                    s.Pop();
                }
            }

            return l;
        }

        public IList BreadthFirstSearch(BatteryStation s)
        {
            UnmarkAll();

            IList l = new ArrayList();
            Queue<BatteryStation> q = new Queue<BatteryStation>();

            q.Enqueue(s);
            l.Add(s);
            s.Mark = true;

            while (q.Count > 0)
            {
                BatteryStation n = q.Dequeue();
                BatteryStation c = null;

                while ((c = GetNextUnMarked(GetAdjacencies(n))) != null)
                {
                    c.Mark = true;
                    q.Enqueue(c);
                    l.Add(c);
                }
            }

            return l;
        }

        private BatteryStation GetNextUnMarked(IList<BatteryStation> list)
        {
            bool found = false;
            int i = 0;
            BatteryStation bs = null;

            while (!found && i < list.Count)
            {
                bs = list[i];

                if (!bs.Mark)
                    found = true;

                i++;
            }

            return found ? bs : null;
        }

        public void UnmarkAll()
        {
            foreach (BatteryStation bs in stations)
                bs.Mark = false;
        }
        #endregion
    }
}