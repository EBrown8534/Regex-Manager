using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_Manager
{
    public class Configuration
    {
        public Size WindowSize { get; set; }
        public bool Maximized { get; set; }
        public bool OpenMostRecentByDefault { get; set; }
        public bool SaveAddDeleteImmediately { get; set; }
        public bool AllowDuplicateNames { get; set; }
    }
}
