using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FuelEconomyLogWPF.mvvm.view;
namespace FuelEconomyLogWPF.mvvm.model
{
    public static class MpgLogService
    {
        public static List<MpgLog> ReadFile(string filepath) 
        {
            if (!File.Exists(filepath))
            {
                const string sep = ",";

                string csvFileHeaders = "Purchase Date" + sep
                    + "Gallons" + sep
                    + "Miles" + sep
                    + "Price" + sep
                    + "Notes";
                File.AppendAllText(filepath, csvFileHeaders);
            }

            var lines = File.ReadAllLines(filepath);
      
            var data = from line in lines.Skip(1)
                       let split = line.Split(',')
                       select new MpgLog
                       {
                           PurchaseDate = DateTime.Parse(split[0], System.Globalization.CultureInfo.InvariantCulture),
                           Gallons = decimal.Parse(split[1]),
                           Miles = decimal.Parse(split[2]),
                           Cost = decimal.Parse(split[3]),
                           Notes = split[4]
                       };

            return data.ToList();
        }
    }
}
