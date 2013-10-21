using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer
{
    /// <summary>
    /// Represents an edge in a our map
    /// </summary>
    public class Edge
    {
        private BatteryStation _from;
        private BatteryStation _to;

        public Edge(BatteryStation From, BatteryStation To)
        {
            this._from = From;
            this._to = To;
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
    }
}