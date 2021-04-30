using System;
using System.IO;
using Microsoft.Win32;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastSearchLibrary;

namespace AutoupdaterProgreso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Identyz/Progreso/archive/refs/heads/Yeah.zip");
            //Task.WaitAny(25000);
            //Task<List<FileInfo>> Zipq = FileSearcher.GetFilesFastAsync(@"C:\", "Yeah.zip");
            //string dir = @"..\";
            //File.Move(Zipq, dir);
        }
    }
}
