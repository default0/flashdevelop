using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjectManager.Projects.AS3;

namespace ProjectManager.Controls.AS3
{
    public partial class AS3PropertiesDialog : ProjectManager.Controls.PropertiesDialog
    {
        // For Designer
        public AS3PropertiesDialog() { InitializeComponent(); }

        AS3Project project { get { return (AS3Project)BaseProject; } }
    }
}

