using Newtonsoft.Json;

using ParserVyatsu.Models;

using System;
using System.IO;

namespace ParserVyatsu.Settings
{
    internal class SaveSettings
    {
        public void SaveSetting(SettingsModel settingsModel)
        {
            try
            {
                string nameFile = Path.Combine(Environment.CurrentDirectory, "Setting.txt");
                var text = JsonConvert.SerializeObject(settingsModel);

                File.WriteAllText(nameFile, text);
            }
            catch { }
        }
    }
}
