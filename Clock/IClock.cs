using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    /// <summary>
    /// This is the IDigital interface. Conteins base properties for clock
    /// </summary>
    public interface IClock
    {
        int Hour { get; set; }
        int Minute { get; set; }
        int Second { get; set; }
    }
}
