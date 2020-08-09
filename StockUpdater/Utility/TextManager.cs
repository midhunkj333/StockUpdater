using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace StockUpdater.UtilityText
{
    public class TextManager
    {
        struct FileDetails
        {
            public string name;
            public string path;
        }
        public void Log(string msg)
        {

        }
        /// <summary>
        /// To Save the stock file location
        /// </summary>
        public void UpdateStockFileLocation(string path)
        {
            List<FileDetails> _data = new List<FileDetails>();
            _data.Add(new FileDetails()
            {
                name = "StockBook",
                path = path,
            });

            string json = JsonConvert.SerializeObject(_data.ToArray());

            string FullFilePath = $@"{GetProjectLocation()}\Data\StockFileDetails.txt";
            //write string to file
            System.IO.File.WriteAllText(FullFilePath, json);
        }

        /// <summary>
        /// To get stock file location from JSON
        /// </summary>
        public string GetStockFileLocation()
        {
            string location = string.Empty;
            List<FileDetails> _data = new List<FileDetails>();
            string fullPath = $@"{GetProjectLocation()}\Data\StockFileDetails.txt";

            var jsonText = File.ReadAllText(fullPath);
            var FileDetails = JsonConvert.DeserializeObject<IList<FileDetails>>(jsonText);
            if(FileDetails!=null && FileDetails.Count > 0)
            {
                location = FileDetails.ElementAt(0).path;
            }
            
            return location;
        }

        private string GetProjectLocation()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            return projectDirectory;
        }
    }
}
