using EFileApp.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFileApp.Popups
{
    public partial class frmAddOptionalService : Form
    {
        frmAddFiling _frm;
        OptionalServiceDTO _optional;
        public frmAddOptionalService(OptionalServiceDTO optional, frmAddFiling frm)
        {
            InitializeComponent();
            txtOptional.Text = optional.Name;
            txtQuantity.Value = optional.Quantity;
            _optional = optional;
            _frm = frm;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _optional.Quantity = int.Parse(txtQuantity.Value.ToString());
            if (_optional.IsEdit == false)
            {
                _optional.IsEdit = true;
                _frm.AddService(_optional);
            }
            else
            {
                _frm.UpdateService(_optional);
            }
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
