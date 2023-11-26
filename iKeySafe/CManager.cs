using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Security.Cryptography;
using System.Collections;
using System.Linq;

namespace BankPunk
{


    public static class CManager
    {
       
        #region CONSTANTS

        public const int FONT_METALLIC = 3;
        public const int NO_DEFINIT = -1;
        public const int ATRIBUIBLE_TOTHOM = 0;

        #endregion

        #region FIELDS
        private const string DIR_FILES = "Data";
        private const string FILE_EXTENSION = ".xml";
        public static readonly string PATH_DIR_FIELS = Path.Combine(Environment.CurrentDirectory, DIR_FILES);

        public static long INIT_MinimSaldo = 500;

        public static DataProject  dataPrj ;
        #endregion

        #region PROPERTIES

        public static string FileSource
        {
            get;
            set;
        }

        //public static Conf Params
        //{
        //    get;
        //    set;
        //}

        //public static Macros MacroActions
        //{
        //    get;
        //    set;
        //}
        #endregion

        #region METHODS PUBLICS

        public static void CreateFirstFile()
        {
            string NameFile = Path.GetRandomFileName() + FILE_EXTENSION;
            string PathFile = Path.Combine(PATH_DIR_FIELS, NameFile);

            FileSource = PathFile;            
        }

        public static void SaveDocument()
        {            
            
            byte[] XmlData = SerializeDataFile();

            int remainer = XmlData.Length % 32;
            int mult = XmlData.Length / 32;
            if (remainer > 0)
                mult += 1;

            Array.Resize(ref XmlData, mult*32);


            FileMode FM = FileMode.OpenOrCreate;
            if (File.Exists(FileSource))
                FM = FileMode.Truncate;

            using (FileStream stream = new FileStream(FileSource, FM, FileAccess.Write))
                stream.Write(XmlData, 0, XmlData.Length);
            
        }

        public static Boolean LoadDocument()
        {
            byte[] XmlByte = null;
            using (FileStream stream = new FileStream(FileSource, FileMode.Open, FileAccess.Read))
            {
                XmlByte = new byte[stream.Length - stream.Position];
                int bytesRead = stream.Read(XmlByte, 0, XmlByte.Length);

                if (XmlByte == null)
                    return false;
            }

            DeserializeDataFile(XmlByte);

            return true;
        }

        public static void InitDocument()
        {
            dataPrj = new DataProject();
            dataPrj.Configuration = new Conf();

            dataPrj.Configuration.MinimSaldo = 900;
            dataPrj.Configuration.ListBanks = new List<Banks>(){
                                                                { new Banks( 0, "El meu banc",true)},                                                                
                                                                { new Banks( 3, "Metal·lic", true)}
                                                            };
            dataPrj.Configuration.ListAtribuibles = new List<Atribuibles>() {
                                                                { new Atribuibles( -1, "No Definit") },
                                                                { new Atribuibles(0, "Tothom") },
                                                                { new Atribuibles(1, "Marta") },
                                                                { new Atribuibles(2, "Martí") },
                                                                { new Atribuibles(3, "Natura Sólida") },
                                                                { new Atribuibles(4, "MSC-Soft.com") },
                                                            };
            dataPrj.Configuration.ListSectors =    new List<Sectors>() {
                                                                { new Sectors(-1, "No Definit") },
                                                                { new Sectors(0, "<CAP>") },
                                                                { new Sectors(1, "Habitatge, aigua, electricitat, gas i altres combustibles") },
                                                                { new Sectors(2, "Aliments i begudes no alcohòliques" )},
                                                                { new Sectors(3, "Sanitat") },
                                                                { new Sectors(4, "Comunicacions") },
                                                                { new Sectors(5, "Vestit i calçat") },
                                                                { new Sectors(6, "Transport") },
                                                                { new Sectors(7, "Mobles, parament de la llar i articles per al manteniment corrent de la llar") },
                                                                { new Sectors(8, "Oci i cultura") },
                                                                { new Sectors(9, "Educació") },
                                                                { new Sectors(10, "Restaurants i hotels") },
                                                                { new Sectors(11, "Begudes alcohòliques i tabac" )},
                                                                { new Sectors(12, "Altres béns i serveis") },
                                                                { new Sectors(13, "Impostos") }
                                                            };            
            dataPrj.Elements = new List<AssetElement>();
        }

        public static string GetElemntHash(AssetElement ElemetTOCheck)
        {
            string mHash = string.Empty;
            string inputString = string.Format("{0}{1}{2}{3}", ElemetTOCheck.Data_Moviment.ToString(), ElemetTOCheck.Concepte, ElemetTOCheck.Import.ToString(), ElemetTOCheck.Saldo.ToString());

            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
        
        public static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }
        #endregion

        #region METHODS PRIVATES
        
        private static byte[] SerializeDataFile()
        {                        
            MemoryStream memSteam = new MemoryStream();            
            using (StreamWriter writer = new StreamWriter(memSteam))
            {

                XmlSerializer x = new XmlSerializer(dataPrj.GetType());
                x.Serialize(writer, dataPrj);
                writer.Flush();                
                memSteam.Position = 0;
                return memSteam.ToArray();
            }
        }

        private static Boolean DeserializeDataFile( byte[] XmlData)
        {
            try
            {
                dataPrj = new DataProject();
                XmlSerializer serializer = new XmlSerializer(dataPrj.GetType());
                using (Stream stream = new MemoryStream(XmlData))
                    dataPrj = (DataProject)serializer.Deserialize(stream);
                                
                return true;
            }
            catch { }
            return false;
        }
        #endregion
    }
}
