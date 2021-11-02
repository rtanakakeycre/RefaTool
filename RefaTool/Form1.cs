using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefaTool
{
    public partial class Form1 : Form
    {
        CmniLib.sCMNI_PORT m_sCmniPort1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_sCmniPort1 = new CmniLib.sCMNI_PORT();


            cmniCtrlUc1.AddCmniPort("1", m_sCmniPort1.m_sPortSets);

            cmniEditUc1.SetPortSets(cmniCtrlUc1, m_sCmniPort1);
        }

        private void cmniEditUc1_Load(object sender, EventArgs e)
        {
            
        }

        private void cmniCtrlUc1_m_dgRcvData(CmniLib.sCMNI_PORT sCmniPort1, byte[] adtCmd1, int ctCmd1)
        {

        }

        private void cmniCtrlUc1_m_dgPrsListUpd(string txCmd1)
        {

        }
    }
}
