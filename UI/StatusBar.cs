using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.UI
{
    static class StatusBar
    {
        private static readonly List<ToolStripStatusLabel> _statusLabels = [];
        private static string _status = string.Empty;
        public static string Status {
            get
            {
                return _status;
            }
            set
            {
                foreach (ToolStripStatusLabel label in _statusLabels)
                {
                    label.Text = value;
                }
                _status = value;
            }
        }

        public static void AddStatusBar(ToolStripStatusLabel statusBar)
        {
            _statusLabels.Add(statusBar);
            statusBar.Text = _status;
        }
    }
}
