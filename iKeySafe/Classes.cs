using System;
using System.Collections.Generic;

namespace BankPunk
{
    #region STRUCTURES

    public struct DataProject
    {
        public Conf Configuration;        
        public List<AssetElement> Elements;
    }

    #endregion
    public class Conf
    {
        #region FIELS

        public List<Sectors> ListSectors = new List<Sectors>();

        public List<Atribuibles> ListAtribuibles = new List<Atribuibles>();

        public List<Banks> ListBanks = new List<Banks>();

        public List<Macros> ListMacros = new List<Macros>();

        #endregion

        #region PROPERTIES
        public long MinimSaldo
        {
            get;
            set;
        }

        #endregion
    }

    public class Banks
    {
        #region PROPERTIES
        public int ID { get; set; }

        public string Name { get; set; }

        public Boolean Enable { get; set; }
        #endregion


        #region CONSTRUCTORS
        public Banks()
        {

        }

        public Banks(int mID, string mName, Boolean mEnable)
        {
            ID      = mID;
            Name    = mName;
            Enable  = mEnable;
        }

        #endregion
    }

    public class Atribuibles
    {
        #region PROPERTIES
        public int ID { get; set; }

        public string Name { get; set; }

        #endregion

        #region  CONSTRUCTORS

        public Atribuibles()
        {

        }

        public Atribuibles(int mID, string mName)
        {
            ID = mID;
            Name = mName;
        }
        
        #endregion
    }

    public class Sectors
    {
        #region PROPERTIES
        public int ID
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        #endregion

        #region CONSTRUCTORS
        
        public Sectors()
        {

        }
        public Sectors(int mID, string mName)
        {
            ID = mID;
            Name = mName;
        }
        
        #endregion
    }
    
    public class AssetElement
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
        public AssetElement()
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
