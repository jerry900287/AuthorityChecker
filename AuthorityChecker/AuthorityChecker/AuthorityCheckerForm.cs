using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;

namespace AuthorityChecker
{
    public partial class AuthorityCheckerForm : Form
    {
        public AuthorityCheckerForm()
        {
            InitializeComponent();
        }

        private void AuthorityCheckerForm_Load(object sender, EventArgs e)
        {
            bool isElevated;
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                isElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            this.isAdminLabel.Text = "Is Administrator:" + isElevated.ToString();
            this.workstationIDLabel.Text = "Workstation ID:" + System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            this.machineNameLabel.Text = "Machine Name:" + Environment.MachineName.ToString();
        }
    }
}
