using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ClassLibraryHatem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFHatem" in both code and config file together.
    public class WCFHatem : IWCFHatem
    {
   

        public string GetMessage(string name)
        {
            return "Hello" + name;
        }
    }
}
