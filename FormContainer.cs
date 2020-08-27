using MSIDesk.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSIDesk
{
    public partial class FormContainer : Form
    {
        public FormContainer()
        {
            InitializeComponent();
        }

        private void changeComponent<T>(T component) where T: UserControl
        {
            if (component == null) return;

            component.Dock = DockStyle.Fill;

            if (!pnlContainer.Controls.OfType<T>().Any())
            {
                pnlContainer.Controls.Add(component);
            }
        }

        private void menuHome_Click(object sender, EventArgs e)
        {
            var newHomeComponent = new HomeComponent();
            changeComponent(newHomeComponent);
        }
    }
}
