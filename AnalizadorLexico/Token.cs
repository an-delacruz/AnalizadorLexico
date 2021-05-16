using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    class Token
    {
        private string _strcat;

        public string CAT
        {
            get { return _strcat; }
            set { _strcat = value; }
        }

    }
}
