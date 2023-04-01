using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPunk
{
    #region STRUCTURES

    public struct DataProject
    {
        public Conf Configuration;        
        public List<settlements> Elements;
    }

    #endregion
    public class Conf
    {

        #region PROPERTIES
        public long MinimSaldo
        {
            get;
            set;
        }

        #endregion

        public List<Sectors> ListSectors = new List<Sectors>();

        public List<Atribuibles> ListAtribuibles = new List<Atribuibles>();

        public List<Banks> ListBanks = new List<Banks>();
        
        public List<Macros> ListMacros = new List<Macros>();

    }


    public class Banks
    {
        #region PROPERTIES
        public int ID { get; set; }

        public string Name { get; set; }

        #endregion

        public Banks()
        {

        }

        public Banks(int mID , string mName)
        {
            ID = mID;
            Name = mName;
        }    
    }

    public class Atribuibles
    { 
        public int ID { get; set; }

        public string Name { get; set; }

        public Atribuibles()
        {

        }

        public Atribuibles(int mID, string mName)
        { 
            ID = mID;
            Name = mName;
        }
    }

    public class Sectors
    {
        public int ID
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }

        public Sectors()
        {

        }
        public Sectors(int mID, string mName)
        {
            ID = mID;
            Name = mName;
        }

    }
    
    public class  settlements
    {

        #region FIELDS

        /// <summary>
        /// Unique identifier
        /// </summary>
        public string Hash;
        
        #endregion

        #region PROPERTIES

        public DateTime Data_Moviment
        {
            get;
            set;
        }

        public DateTime Data_Valor_Moviment
        {
            get;
            set;
        }

        public string Concepte
        {
            get;
            set;
        }

        public double Import
        {
            get;
            set;
        }

        public double Saldo
        {
            get;
            set;
        }
        
        public int Sector
        {
            get;
            set;
        }

        public int Atribuible
        {
            get;
            set;
        }


        public int Font
        {
            get;
            set;
        }

        
        #endregion

        #region CONSTRUCTOR
        public settlements()
        {
            this.Hash = string.Empty;
        }
        #endregion

        #region METHODS
        





        #endregion
    }

    public class Macros
    {
        #region PROPERTIES
        
        public int ID
        {
            set;
            get;
        }

        public string StrToFind
        {
            get;
            set;
        }
        
        public int sendType
        {
            get;
            set;
        }
        
        public int Target
        {
            get;
            set;

        }

        #endregion

        #region CONSTRUCTOR
        
        public Macros()
        {
        }

        public Macros( int mId, string mStrToFind, int mSendType, int mTarge)
        {
            ID = mId;
            StrToFind = mStrToFind;
            sendType = mSendType;
            Target = mTarge;
        }
        #endregion
    }


}
