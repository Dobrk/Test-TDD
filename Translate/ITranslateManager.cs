using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate
{
    interface ITranslateManager
    {
        string GetString(string project, string key, string laguage);
    }
}
