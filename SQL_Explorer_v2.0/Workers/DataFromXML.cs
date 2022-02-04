using System.Xml.Linq;
using System.Text;
using System.IO;

namespace SQL_Explorer_v2._0.Workers
{
    class DataFromXML
    {
        public string serverIP { get; set; }
        public string serverName { get; set; }
        public string dbName { get; set; }
        public string userID { get; set; }
        public string userPWD { get; set; }
        public string connectionString { get; set; }

        public void GetConfigFromXML(string configFilePath)
        {
            if (File.Exists("Config.xml"))
            {
                XDocument xml = XDocument.Load("Config.xml");
                var config = xml.Root.Elements();
                foreach (XElement xElement in config)
                {
                    if (xElement.Name == "IP")
                    {
                        this.serverIP = xElement.Value.ToString();
                    }
                    if (xElement.Name == "ServerName")
                    {
                        this.serverName = xElement.Value.ToString();
                    }
                    if (xElement.Name == "DBName")
                    {
                        this.dbName = xElement.Value.ToString();
                    }
                    if (xElement.Name == "UserID")
                    {
                        this.userID = xElement.Value.ToString();
                    }
                    if (xElement.Name == "UserPWD")
                    {
                        this.userPWD = xElement.Value.ToString();
                    }

                    this.connectionString = BuildConnString();
                }
            }
        }

        public string BuildConnString()
        {
            StringBuilder connString = new StringBuilder();

            connString.Append("Server = ");
            connString.Append(this.serverIP);
            connString.Append(@"\");
            connString.Append(this.serverName);
            connString.Append("; Database = ");
            connString.Append(this.dbName);
            connString.Append("; UID = ");
            connString.Append(this.userID);
            connString.Append("; PWD = ");
            connString.Append(this.userPWD);

            return connString.ToString();
        }

    }
}
