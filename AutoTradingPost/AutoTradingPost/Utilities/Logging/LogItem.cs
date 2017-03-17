using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoTradingPost.Entities;

namespace AutoTradingPost.Utilities.Logging
{
    public class LogItem
    {
        #region Constructors

        public LogItem(string Message)
        {
            this.Message = Message;
        }

        public LogItem(Character Character, LogItem.TypeCodes TypeCode, LogItem.SeverityCodes Severity = LogItem.SeverityCodes.Unknow)
        {
            this.Character = Character;
            this.TypeCode = TypeCode;
        }

        public LogItem(Item Item, LogItem.TypeCodes TypeCode, LogItem.SeverityCodes Severity = LogItem.SeverityCodes.Unknow)
        {
            this.Item = Item;
            this.TypeCode = TypeCode;
        }

        public LogItem(Character Character, Item Item, LogItem.TypeCodes TypeCode, LogItem.SeverityCodes Severity = LogItem.SeverityCodes.Unknow)
        {
            this.Character = Character;
            this.Item = Item;
            this.TypeCode = TypeCode;
        }

        #endregion

        #region Fields

        public string Message { get; set; }
        public Character Character { get; set; }
        public Item Item { get; set; }
        public DateTime Time { get; set; }
        //public BitmapImage Image;
        public LogItem.SeverityCodes Severity { get; set; }
        public LogItem.TypeCodes TypeCode { get; set; }

        #endregion

        #region Methods

        //public override string ToString()
        //{

        //}

        #endregion

        #region Enums

        public enum SeverityCodes
        {
            Low = 0,
            Medium = 1,
            High = 2,
            Unknow = 3,
        }

        public enum TypeCodes
        {
            Success = 0,
            Status = 1,
            Warning = 2,
            Error = 3,
        }

        #endregion
    }
}
