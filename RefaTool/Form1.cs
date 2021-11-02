using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmniLib;
using UtilLib;

namespace RefaTool
{
    public partial class Form1 : Form
    {
        sSER_SETS m_sSerSets;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Com.Deserialize("Sets.xml", ref m_sSerSets);

            cmniCtrlUc1.AddCmniPort(m_sSerSets.m_sCmniPort1);

            cmniEditUc1.SetPortSets(cmniCtrlUc1, m_sSerSets.m_sCmniPort1);
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Com.Serialize("Sets.xml", m_sSerSets);
        }
    }

    public class sSER_SETS
    {
        public sCMNI_PORT m_sCmniPort1;
        public sCMNI_PORT m_sCmniPort2;

        public sSER_SETS()
        {
            Com.InitData(this);
            m_sCmniPort1 = new sCMNI_PORT();
            m_sCmniPort2 = new sCMNI_PORT();
        }

    }

}
