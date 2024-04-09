using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHPOrganizer
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public string FileName
        {
            get { return Lbl_NombreArchivos.Text; }
            set { Lbl_NombreArchivos.Text = value; }
        }
    }
}
