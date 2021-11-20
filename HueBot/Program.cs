using System.Text.Json;

namespace HueBot
{
    internal class Configuration
    {
        public string? BridgeIp { get; set; }
        public string? ApplicationId { get; set; }
    }

    public class Program
    {
        internal static string JsonConfigurationFile = "huebot.json";

        // command /bridgeIp=xxx.xxx.xxx.xxx
        // command /serializeIp
        // command /forceDiscovery

        private static int Main(string[] args)
        {
            Console.WriteLine("HueBot v0.0.0.0\ndev: Talos - GPL-2.0 License\n");

            // use json input for bridge ip or use argument override
            string configurationJson = File.ReadAllText(JsonConfigurationFile);
            Configuration? config = JsonSerializer.Deserialize<Configuration>(configurationJson);

            if (config == null)
            {
                Console.WriteLine($"[ERROR] Could not load {JsonConfigurationFile}");
                return -1;
            }

            // if neither available or if force discover specified discover it w/ mDNS

            // store discovery bridge ip in json

            // request discovery button press

            // store application id in json

            // send test command
            return 0;
        }
    }
}
