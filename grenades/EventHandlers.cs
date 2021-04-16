using Qurre;
using Qurre.API.Events;
using System.Collections.Generic;
using RemoteAdmin;

namespace grenades
{
    public class EventHandlers
    {
        private readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;

        private static bool CheckPerms(string __)
        {
            string[] strArray = ((YamlConfig)Plugin.Config).GetString("grenades_access_userid", "SERVER CONSOLE").Split(',');
            List<string> stringList = new List<string>();
            foreach (string str in strArray)
                stringList.Add(str.Trim());
            return stringList.Contains(__);
        }

        public static void RemoteAdminCommandEvent(SendingRAEvent ev)
        {

        }
    }
}

