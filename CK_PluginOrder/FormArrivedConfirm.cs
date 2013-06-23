using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rock.Base;
using Rock.Interface;

namespace CK_PluginOrder
{
    public partial class FormArrivedConfirm : FormBase
    {
        public FormArrivedConfirm(IApplication iapp,IDataService _ids)
        {
            InitializeComponent();
            _iapplication = iapp;
            ids = _ids;
        }
    }
}
