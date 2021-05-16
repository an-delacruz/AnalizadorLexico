using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    class Error
    {
        private string _catError;

        public string CatError
        {
            get { return _catError; }
            set { _catError = value; }
        }

    }
}
