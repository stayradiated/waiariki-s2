using System;
using System.Collections.Generic;
using System.Text;

namespace ITravelerNamespace
{
    public interface ITraveler
    {
        string GetDestination();
        string GetStartLocation();
        double DetermineMiles();
    }
}
