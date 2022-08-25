using Newtonsoft.Json;

using ParserVyatsu.Models;

using System;
using System.IO;

namespace ParserVyatsu.Settings
{
    internal class OpenSaveSettings
    {
        public SettingsModel OpenSetting()
        {
            try
            {
                string filename = Path.Combine(Environment.CurrentDirectory, "Setting.txt");
                var text = File.ReadAllText(filename);

                return JsonConvert.DeserializeObject<SettingsModel>(text);
            }
            catch
            {
                return new SettingsModel();
            }
        }
    }
}
