using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace JointAngle_combine
{
    public partial class Picture : Form
    {
        public Picture(string filePath)
        {
            InitializeComponent();
            pictureBox.Load(filePath);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
