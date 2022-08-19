using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z80NavBarControl.Z80NavBar;
using Z80NavBarControl.Z80NavBar.Themes;

namespace app
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();

            z80_Navigation1.Initialize(
                new List<NavBarItem> {
                    new NavBarItem { ID = 1, Text = "Item1" },
                    new NavBarItem { ID = 2, Text = "Item2" }
                },
                new ThemeSelector(Theme.Blue).CurrentTheme
            );
        }
    }
}
