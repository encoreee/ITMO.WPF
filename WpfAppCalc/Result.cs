using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        public string result
        {
            set { label1.Text = value; }
        }
    }
}
