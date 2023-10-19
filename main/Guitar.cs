using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiNote
{
    public class Guitar : Instrument
    {
        public Guitar(string id, string desc, string folderPath) : base(id, desc, folderPath) { }
    }
}
