using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate
{
    public class TranslateManager : ITranslateManager
    {
        public bool IsReady { get; private set; }
        private string path;

        public TranslateManager(string sourceJsonPath)
        {
            IsReady = true;
            path = sourceJsonPath;
        }

        public string GetString(string project, string key, string laguage)
        {

            return "";
        }


    }
}
