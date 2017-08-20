using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TvtoAutomation.Components
{
    public partial class RexaGrid : DataGridView
    {
        public RexaGrid()
        {
            InitializeComponent();
        }

        public RexaGrid(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
