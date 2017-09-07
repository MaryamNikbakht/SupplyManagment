using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using FinalProject1.Business;
using System.IO;
using System.Windows.Forms;

namespace FinalProject1.DataAccess
{
    public static class ClientIO
    {
        const string dir = @"";
        const string myPath_client = dir + "client.dat";
        const string myPath_client_binary = dir + "clientBinary.dat";

        public static void serializationObject(Client client)
        {

            using (var fileStream = new FileStream(myPath_client, FileMode.OpenOrCreate))
            using (var sw = new BinaryWriter(fileStream))
            {

                BinaryFormatter bw = new BinaryFormatter();

                bw.Serialize(fileStream, client);
            }
            MessageBox.Show("Client saved!");

        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

     


        ///// <summary>
        ///// Writong binary file
        ///// </summary>
        public static void writeBinaryClient(Client client)
        {
            using (FileStream stream = new FileStream(myPath_client_binary, FileMode.Append, FileAccess.Write, FileShare.None))
            {

                using (BinaryWriter binaryOut = new BinaryWriter(stream))
                {

                    binaryOut.Write(client.Id);
                    binaryOut.Write(client.Name);
                    binaryOut.Write(client.FaxNum);
                    binaryOut.Write(client.Address);
                    binaryOut.Write(client.City);
                    binaryOut.Write(client.PostalCod);
                    binaryOut.Write(client.PhonNum);
                    binaryOut.Write(client.Email);
                    binaryOut.Write(client.Account);
                    binaryOut.Write(client.CreditLimit);


                }

            }

            
        }
        /// <summary>
        /// Reading binary file
        /// </summary>
        /// <returns></returns>
        public static List<Client> GetClients_binary()
        {
            List<Client> arrayClient = new List<Client>();

            if (File.Exists(myPath_client_binary))
            {
                BinaryReader binaryIn = new BinaryReader(new FileStream(myPath_client_binary, FileMode.Open));

                List<Client> arrayClient2 = new List<Client>();
                Client client = new Client();
                while (binaryIn.PeekChar() != -1)
                {
                  

                    client.Id = binaryIn.ReadInt32();
                    client.Name = binaryIn.ReadString();
                    client.FaxNum = binaryIn.ReadString();
                    client.Address = binaryIn.ReadString();
                    client.City = binaryIn.ReadString();
                    client.PostalCod = binaryIn.ReadString();
                    client.PhonNum = binaryIn.ReadString();
                    client.Email = binaryIn.ReadString();
                    client.Account = binaryIn.ReadString();
                    client.CreditLimit = binaryIn.ReadDouble();
                    arrayClient.Add(client);

                }
                binaryIn.Close();
                return arrayClient;

            }
            return null;
        }

        //====================================================================

        public static void saveRecord(Client client)
        {
            // create the output stream for a text file that exists
            using (StreamWriter textout = new StreamWriter(myPath_client, true))
            {

                // write the fields into text file
                textout.WriteLine(client.Id + "," + client.Name + "," + client.FaxNum + "," + client.Address + "," + client.City + "," + client.PostalCod + "," + client.PhonNum + "," + client.Email+","+client.account+","+client.creditLimit);
            }
            
        }

        public static List<Client> ListClient()
        {
            List<Client> emps = new List<Client>();
            try
            {
                if (File.Exists(myPath_client))
                {
                    FileStream fs = new FileStream(myPath_client, FileMode.Open, FileAccess.Read);
                    StreamReader sReader = new StreamReader(fs);
                    int recordCount = File.ReadLines(myPath_client).Count();
                    string currenRow = sReader.ReadLine();
                    while (currenRow != null)
                    {
                        string[] currentLineFields = currenRow.Split(',');
                        Client client = new Client();
                        client.Id = Convert.ToInt32(currentLineFields[0]);
                        client.Name = currentLineFields[1];
                        client.FaxNum = currentLineFields[2];
                        client.Address = currentLineFields[3];
                        client.City = currentLineFields[4];
                        client.PostalCod = currentLineFields[5];
                        client.PhonNum = currentLineFields[6];
                        client.Email = currentLineFields[7];
                        client.account = currentLineFields[8];
                        client.creditLimit = Convert.ToInt32(currentLineFields[9]);
                        emps.Add(client);
                        currenRow = sReader.ReadLine();
                    }
                    sReader.Close();
                    fs.Close();
                }

                return emps;
            }
            catch
            {
                return null;
            }
        }


        public static List<Client> SearchRecord(int id)
        {
            List<Client> listClient = new List<Client>();
            
            if (File.Exists(myPath_client))
            {
                //Creation of the object of StreamReader
                StreamReader sReader = new StreamReader(myPath_client);
                string line = sReader.ReadLine();               
                while (line != null)
                {
                    Client client = new Client();
                    string[] currentLine = line.Split(',');
                    if (currentLine[0] == id.ToString())
                    {
                        client.Id = Convert.ToInt32(currentLine[0]);
                        client.Name = currentLine[1];
                        client.FaxNum = currentLine[2];
                        client.Address = currentLine[3];
                        client.City = currentLine[4];
                        client.PostalCod = currentLine[5];
                        client.PhonNum = currentLine[6];
                        client.Email = currentLine[7];
                        client.account = currentLine[8];
                        client.creditLimit = Convert.ToInt32(currentLine[9]);

                        listClient.Add(client);
                        
                    }
                   
                    line = sReader.ReadLine();
                }

                sReader.Close();
                return listClient;
            }
            else
            {
                return null;
            }

        }


        public static List<Client> SearchRecord(string name)
        {
            List<Client> listClient = new List<Client>();
            
            if (File.Exists(myPath_client))
            {
                //Creation of the object of StreamReader
                StreamReader sReader = new StreamReader(myPath_client);
                string line = sReader.ReadLine();
               
                while (line != null)
                {
                    Client client = new Client();
                    string[] currentLine = line.Split(',');
                    if ((currentLine[1].Equals(name)) || (currentLine[2].Equals(name)) || (currentLine[6].Equals(name)) || (currentLine[7].Equals(name)))
                    {
                        client.Id = Convert.ToInt32(currentLine[0]);
                        client.Name = currentLine[1];
                        client.FaxNum = currentLine[2];
                        client.Address = currentLine[3];
                        client.City = currentLine[4];
                        client.PostalCod = currentLine[5];
                        client.PhonNum = currentLine[6];
                        client.Email = currentLine[7];
                        client.account = currentLine[8];
                        client.creditLimit = Convert.ToInt32(currentLine[9]);

                        //   sReader.Close();
                        listClient.Add(client);
                        
                    }
                   
                    line = sReader.ReadLine();
                }

                sReader.Close();
                return listClient;
            }
            else
            {
                MessageBox.Show("Data Not Found!");
                return null;
            }

        }


        public static void deletLine(string del)
        {
            string tempFile = Path.GetTempFileName();
           // StringBuilder sb = new StringBuilder();
            using (var sr = new StreamReader(myPath_client))
            {
                using (var sw = new StreamWriter(tempFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] currentLine = line.Split(',');
                        if (currentLine[0] != del)
                        {
                            sw.WriteLine(line);
                        }
                      
                    }
                }
            }

            File.Delete(myPath_client);
            File.Move(tempFile, myPath_client);
        }

        //=================================== delete Last Line
        public static void Delete_lastLine()
        {

            var lines = File.ReadAllLines(myPath_client);
            File.WriteAllLines(myPath_client, lines.Take(lines.Length - 1).ToArray());

        }

        //=========================== ID uniq

        public static bool ID_Validation_Uniq(int id)
        {
            bool idIsValid = false;

            if (File.Exists(myPath_client))
            {
                StreamReader sr = new StreamReader(myPath_client);
                string newLine = sr.ReadLine();
                while (sr.Peek() != -1)
                {
                    string[] userline = newLine.Split(',');
                    if (userline[0] == id.ToString())
                    {
                        idIsValid = true;
                        break;
                    }
                    newLine = sr.ReadLine();
                }
                sr.Close();
            }

            return idIsValid;
        }

        //=======================================End Of Method ====================================================


    }
}
