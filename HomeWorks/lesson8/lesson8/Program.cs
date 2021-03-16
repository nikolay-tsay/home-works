using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using System.Text;

namespace lesson8
{
    internal class Program
    {
        private static void ReadSetting(string name)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                var result = appSettings[name];
                Console.WriteLine(result);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }

        private static void AddUpdateAppSettings(string name, string value)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings[name] == null)
                settings.Add(name, value);
            else
                settings[name].Value = value;
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }

        public static void Main(string[] args)
        {
            ReadSetting("Default");
            if (ConfigurationManager.AppSettings.Get("User") == "")
            {
                StringBuilder userInfo = new StringBuilder();
                string[] info = {"ваше имя", "ваш возраст", "ваш род деятельности"};
                for (var i = 0; i < info.Length; i++)
                {
                    Console.Write($"Введите {info[i]}: ");
                    userInfo.Append(Console.ReadLine() + "\n");
                }
                Console.WriteLine("Данные были записаны и появятся при следующем запуске.");

                AddUpdateAppSettings("User", userInfo.ToString());
                var version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                AddUpdateAppSettings("Version", version);
                ReadSetting("Version");
                ReadSetting("Description");
            }
            else
            {
                ReadSetting("User");
                ReadSetting("Version");
                ReadSetting("Description");
            }

            Console.ReadLine();
        }
    }
}