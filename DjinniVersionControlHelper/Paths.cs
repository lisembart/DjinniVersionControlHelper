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
    [Serializable]
    class Paths
    {
        private string editorModPath = @"C:\Users\lisem\AppData\Local\The Witcher\temp\__ResourcesUnpackTmp";

        public string EditorModPath
        {
            get { return editorModPath; }
        }

        private string gitModPath;
        public string GitModPath
        {
            get { return gitModPath; }
            set { gitModPath = value; }
        }
    }
}
