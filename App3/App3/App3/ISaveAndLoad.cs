using System;
using System.Collections.Generic;
using System.Text;

namespace App3
{
    public interface ISaveAndLoad
    {
        void SaveText(string filename, string text);
        string LoadText(string filename);
    }
}
