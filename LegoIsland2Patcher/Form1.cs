using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegoIsland2Patcher
{

    public partial class Form1 : Form
    {
        static string exeName = "LEGO Island 2.exe";

        byte[] virtualFile;
        byte[] defaultFile;

        byte[] patch = { 0x00 };
        int offset = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Search for LegoIsland2.exe in the current directory
            if (File.Exists(exeName))
            {
                virtualFile = File.ReadAllBytes(exeName);

                if (!File.Exists(exeName + ".backup")) {
                    File.WriteAllBytes(exeName + ".backup", virtualFile);
                }

                defaultFile = File.ReadAllBytes(exeName + ".backup");

                updateCheckBoxes();
            }
            else
            {
                MessageBox.Show(exeName + " was not found. Please place this program in your Lego Island 2 installation folder and try again.");
                Application.Exit();
            }
        }

        private void lblFoundExe_Click(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //No LEGO Software logo
            {
                byte[] newPatch = { 0x90, 0x90, 0x90, 0x90, 0x90 };
                patch = newPatch;
            }
            offset = 0x00002AEA;

            applyPatch(cbLegoLogo.Checked);

            //Make LEGO Software logo skippable
            {
                byte[] newPatch = { 0x01 };
                patch = newPatch;
            }
            offset = 0x00002ADB;

            applyPatch(cbLegoSkippable.Checked);

            //No Silicon Dreams Logo
            {
                byte[] newPatch = { 0x90, 0x90, 0x90, 0x90, 0x90 };
                patch = newPatch;
            }
            offset = 0x00002B20;

            applyPatch(cbSiliconLogo.Checked);

            //No Intro Video
            {
                byte[] newPatch = { 0x90, 0x90, 0x90, 0x90, 0x90 };
                patch = newPatch;
            }
            offset = 0x00002B56;

            applyPatch(cbNoIntro.Checked);

            //Load Time Fix
            {
                byte[] newPatch = { 0xC3, 0x90, 0x90, 0x90, 0x90, 0x90 };
                patch = newPatch;
            }
            offset = 0x0002A870;

            applyPatch(cbLoadTimes.Checked);

            //Windowed mode
            { 
                byte[] newPatch = { 0x01 };
                patch = newPatch;
            }
            offset = 0x000029B2;

            applyPatch(cbWindowedMode.Checked);

            //Debug Level Select in place of Credits
            {
                byte[] newPatch = { 0x01, 0x00, 0x00, 0x00, 0x11 };
                patch = newPatch;
            }
            offset = 0x00572704;

            applyPatch(cbLevelSelect.Checked);

            {
                byte[] newPatch = { 0x44, 0x45, 0x42, 0x55, 0x47, 0x00, 0x00 };
                patch = newPatch;
            }
            offset = 0x005726C5;

            applyPatch(cbLevelSelect.Checked);

            //Force /force command line (unknown)
            {
                byte[] newPatch = { 0x01 };
                patch = newPatch;
            }
            offset = 0x000029B9;

            applyPatch(cbForce.Checked);
            

            File.WriteAllBytes(exeName, virtualFile);

            MessageBox.Show("Patching completed!");
        }

        public void applyPatch(bool checkBox)
        {
            if (checkBox == true)
            {
                for (int i = 0; i < patch.Length; i++)
                {
                    virtualFile[offset + i] = patch[i];
                }
            }
            else
            {
                for (int i = 0; i < patch.Length; i++)
                {
                    virtualFile[offset + i] = defaultFile[offset + i];
                }
            }
        }

        //Scans the loaded exe file for already applied patches
        //And then automatcially checks boxes
        private void updateCheckBoxes()
        {
            //No LEGO Software Logo
            {
                byte[] newPatch = { 0x90, 0x90, 0x90, 0x90, 0x90 };
                patch = newPatch;
            }
            offset = 0x00002AEA;
            cbLegoLogo.Checked = scanForPatch();

            //Make LEGO Software logo skippable
            {
                byte[] newPatch = { 0x01 };
                patch = newPatch;
            }
            offset = 0x00002ADB;
            cbLegoSkippable.Checked = scanForPatch();

            //No Silicon Dreams Logo
            {
                byte[] newPatch = { 0x90, 0x90, 0x90, 0x90, 0x90 };
                patch = newPatch;
            }
            offset = 0x00002B20;
            cbSiliconLogo.Checked = scanForPatch();

            //No Intro Video
            {
                byte[] newPatch = { 0x90, 0x90, 0x90, 0x90, 0x90 };
                patch = newPatch;
            }
            offset = 0x00002B56;
            cbNoIntro.Checked = scanForPatch();

            //Load Time Fix
            {
                byte[] newPatch = { 0xC3, 0x90, 0x90, 0x90, 0x90, 0x90 };
                patch = newPatch;
            }
            offset = 0x0002A870;
            cbLoadTimes.Checked = scanForPatch();

            //Windowed mode
            {
                byte[] newPatch = { 0x01 };
                patch = newPatch;
            }
            offset = 0x000029B2;
            cbWindowedMode.Checked = scanForPatch();

            //Debug Level Select in place of Credits
            {
                byte[] newPatch = { 0x01, 0x00, 0x00, 0x00, 0x11 };
                patch = newPatch;
            }
            offset = 0x00572704;

            if (scanForPatch())
            {
                {
                    byte[] newPatch = { 0x44, 0x45, 0x42, 0x55, 0x47, 0x00, 0x00 };
                    patch = newPatch;
                }
                offset = 0x005726C5;
                cbLevelSelect.Checked = scanForPatch();
            }

            //Force /force command line (unknown)
            {
                byte[] newPatch = { 0x01 };
                patch = newPatch;
            }
            offset = 0x000029B9;
            cbForce.Checked = scanForPatch();
        }

        private bool scanForPatch()
        {
            bool result = true;

            for (int i = 0; i < patch.Length; i++)
            {
                if (virtualFile[offset + i] != patch[i]) {
                    result = false;
                }
            }

            return result;
        }

    }
}
