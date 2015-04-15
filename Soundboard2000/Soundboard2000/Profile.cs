using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soundboard2000
{
    class Profile
    {
        public string Name;
        public List<string> SoundPathList;

        public Profile(string name, List<string> soundPathList)
        {
            Name = name;
            SoundPathList = soundPathList;
        }

        public void Save()
        {
            //savestuff
        }
    }
}
