using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AutoFileReplacer
{
    public partial class ProcessOps
    {
        static string SettingsFileNm = "processes.json";
        public static Settings settingsJson = new Settings();
        public static void OpenSettingsFile()
        {
            if (File.Exists(SettingsFileNm))
            {
                string jsonString = File.ReadAllText(SettingsFileNm);
                settingsJson = JsonSerializer.Deserialize<Settings>(jsonString);
                Console.WriteLine("Opened Settings File: " + settingsJson.Interval);
            }
            else
            {
                IntSettingsFile();
            }

        }
        public static string Interval()
        {

            string intervalCheck = settingsJson.Interval.ToString();
            return intervalCheck;
        }
        public static void SetInterval(int newInterval)
        {
            settingsJson.Interval = newInterval;
        }

        public static void EditProcess(string Name, string replaced, string replacer)
        {
            Process np = new Process { Name = Name, ReplaceThis = replaced, ReplaceWith = replacer };
            settingsJson.Processes.Add(np);
            File.WriteAllText(SettingsFileNm, JsonSerializer.Serialize(settingsJson).ToString());
        }

        public static void RemoveProcess(int index)
        {
            settingsJson.Processes.RemoveAt(index);
            File.WriteAllText(SettingsFileNm, JsonSerializer.Serialize(settingsJson).ToString());
        }

        public static void IntSettingsFile()
        {
            settingsJson.Interval = 5;
            settingsJson.Processes = new List<Process>();
            settingsJson.Processes.Add(new Process
            {
                Name = "example",
                ReplaceThis = "Select a file to be replaced",
                ReplaceWith = "Select a file to replace with"
            });
            File.WriteAllText(SettingsFileNm, JsonSerializer.Serialize(settingsJson).ToString());
            Console.WriteLine("Created Settings File with: " + SettingsFileNm + JsonSerializer.Serialize(settingsJson).ToString());
        }

        public static void updateInterval(int interval)
        {
            settingsJson.Interval = Convert.ToInt16(interval);
            File.WriteAllText(SettingsFileNm, JsonSerializer.Serialize(settingsJson).ToString());
        }
        public static List<Process> getProcesses()
        {
            return settingsJson.Processes;
        }

        public class Settings
        {
            [JsonPropertyName("Interval")]
            public int Interval { get; set; }
            [JsonPropertyName("Processes")]
            public List<Process>? Processes { get; set; }
        }
        public class Process
        {
            //public int Id { get; set; }
            [JsonPropertyName("Name")]
            public string? Name { get; set; }
            [JsonPropertyName("ReplaceThis")]
            public string? ReplaceThis { get; set; }
            [JsonPropertyName("ReplaceWith")]
            public string? ReplaceWith { get; set; }
        }
    }
}
