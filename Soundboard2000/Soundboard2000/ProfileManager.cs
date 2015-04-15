using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Soundboard2000
{
    public static class ProfileManager
    {
        private static List<string> profilePathList;
        public static Profile CurrentProfile;

        public static void Init()
        {
            FileStream stream = new FileStream("profiles.sav", FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(stream);
            string profilePath;
            if (reader.EndOfStream)
            {
                reader.Dispose();
                stream.Dispose();
                CreateProfile("Default");
                stream = new FileStream("profiles.sav", FileMode.OpenOrCreate);
                reader = new StreamReader(stream);
            }
        }

        public static void CreateProfile(string filename)
        {
            FileStream stream = new FileStream("profiles.sav", FileMode.Open);
            StreamWriter writer = new StreamWriter(stream);

            writer.Write("{0}\n", filename);
        }
    }
}
