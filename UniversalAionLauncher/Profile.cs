using System.Collections.Generic;

namespace UniversalAionLauncher {
    public class Profile {
        public string name;
        public string version;
        public string language;
        public string ip;
        public ushort port;
        public byte cc;
        public Dictionary<string, bool> parameters = new Dictionary<string, bool>();
    }
}
