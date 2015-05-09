using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate
{
    interface ITextManager
    {
        private Dictionary<string, string> GetDictionary();
        string GetText();
    }
}
