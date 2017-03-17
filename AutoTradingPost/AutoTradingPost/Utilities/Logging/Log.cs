using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace AutoTradingPost.Utilities.Logging
{
    public class Log
    {
        #region Constructors

        public Log()
        {
            this.Items = new ObservableCollection<LogItem>();
        }

        #endregion

        #region Fields

        public ObservableCollection<LogItem> Items { get; set; }

        #endregion

        #region Events

        public event LogChangedHandler LogChanged;

        #endregion

        #region Delegates

        public delegate void LogChangedHandler(Log Sender);

        #endregion

        #region Methods

        public void AddLogItem(LogItem LogItem)
        {
            Items.Add(LogItem);

            if (this.LogChanged != null)
            {
                this.LogChanged(this);
            }
        }

        #endregion
    }
}
