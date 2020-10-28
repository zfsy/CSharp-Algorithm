using System;
using System.Collections.Generic;
using System.Text;

namespace DataSturctures.Graphs
{
    public interface IEdge<TVertex> : IComparable<IEdge<TVertex>> where TVertex : IComparable<TVertex>
    {
        bool IsWeighted { get; }

        TVertex Source { get; set; }

        TVertex Destination { get; set; }

        Int64 Weight { get; set; } 
    }
}
