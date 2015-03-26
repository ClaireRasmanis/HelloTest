using System.Configuration;
using System.IO;

namespace Hello.Data
{
    public class FileDataSource : IDataSource
    {
        private readonly string _filePath;

        public FileDataSource(string filePath)
        {
            _filePath = filePath;
        }

        public FileDataSource()
            : this(ConfigurationManager.AppSettings["databasefile"])
        {
            
        }

        public string Read()
        {
            var blah = File.ReadAllText(_filePath);
            return blah;
            
        }
    }
}