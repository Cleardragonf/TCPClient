using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPClient.Templates
{
    public partial class InventorySlot : UserControl
    {
        public InventorySlot()
        {
            InitializeComponent();
            label1.Left = (this.Width - label1.Width) / 2;
            
        }
    }
}
