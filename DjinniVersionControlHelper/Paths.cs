using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DjinniVersionControlHelper
{
    class Paths
    {
        private string editorModPath;

        private string gitModPath;
        public string GitModPath
        {
            get { return gitModPath; }
            set { gitModPath = value; }
        }
    }
}
