using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIFEA
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Blue, ButtonBorderStyle.Solid);
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCyclic_Click(object sender, EventArgs e)
        {
            openChildForm(new Cyclic());
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            openChildForm(new Square());
        }

        private void btnImpedance_Click(object sender, EventArgs e)
        {
            openChildForm(new Impedance());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDifferential_Click(object sender, EventArgs e)
        {
            openChildForm(new Differential());
        }
    }
}
