using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer
{
    public class Edge
    {
        private BatteryStation _from;
        private BatteryStation _to;
        private double _distance;

        public Edge(BatteryStation From, BatteryStation To, double distance)
        {
            this._from = From;
            this._to = To;
            this._distance = distance;
        }

        public BatteryStation From
        {
            get
            {
                return _from;
            }
        }

        public BatteryStation To
        {
            get
            {
                return _to;
            }
        }

        public double Distance
        {
            get
            {
                return _distance;
            }
        }
    }
}