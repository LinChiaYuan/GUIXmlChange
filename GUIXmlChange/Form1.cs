using INIToXmlLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GUIXmlChange
{
    public partial class Form1 : Form
    {
        private INIToXml iNIToXml;
        private bool ReadLock = false, SwapLock = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form.CheckForIllegalCrossThreadCalls = false;
        }

        private void BtnINI_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "INI|*.INI";
            openFileDialog.Title = "Open INI File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                TBINI.Text = openFileDialog.FileName;
                
        }

        private void BtnXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Title = "Save Xml File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                TBXml.Text = saveFileDialog.FileName;
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            if (!ReadLock && !TBINI.Text.Equals("") && !TBXml.Text.Equals(""))
            {
                ReadLock = true;
                Thread t = new Thread(() =>
                {
                    ReadINI();
                    ReadLock = false;
                });
                t.IsBackground = true;
                t.Start();
            }
            else
                MessageBox.Show("INI or Xml not null", "error");
                
        }

        private void BtnSwap_Click(object sender, EventArgs e)
        {
            if (!SwapLock && iNIToXml != null)
            {
                if (MessageBox.Show("Change INI to XML?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    SwapLock = true;
                    Thread t = new Thread(() =>
                    {
                        Swap();
                        SwapLock = false;
                    });
                    t.IsBackground = true;
                    t.Start();
                }
            }
        }

        private void ReadINI()
        {
            try
            {
                if (iNIToXml != null)
                    iNIToXml.Dispose();
                iNIToXml = new INIToXml(TBINI.Text, TBXml.Text);
                iNIToXml.INIStreamReader();
                PrintINI();
                Thread.Sleep(1000);
                LBMsg.Items.Add("Read End");
            }
            catch (Exception e)
            {
                LBMsg.Items.Add("Read Error");
            }
            
        }

        private void PrintINI()
        {
            LBINI.Items.Clear();
            foreach (Section section in iNIToXml.GetSectionList())
            {
                LBINI.Items.Add("Section Name : " + section.GetName());
                foreach (SectionKey sectionKey in section.GetSectionKeyList())
                {
                    LBINI.Items.Add("Key : " + sectionKey.GetKey() + ", Value : " + sectionKey.GetValue());
                }
            }
            LBMsg.Items.Add("Show End");
        }

        private void Swap()
        {
            try
            {
                iNIToXml.INISwap();
                Thread.Sleep(1000);
                LBMsg.Items.Add("Swap End");
            }
            catch (Exception e)
            {
                LBMsg.Items.Add("Swap Error");
            }
        }
        
    }
}
