using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ribbon_theme
{
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            InitializeComponent();

            //Apply the theme for RibbonControlAdv
            ribbonControlAdv1.ThemeName = "Office2019Colorful";
        }
    }
}
