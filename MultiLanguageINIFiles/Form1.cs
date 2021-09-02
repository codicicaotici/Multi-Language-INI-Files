using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MultiLanguageINIFiles
{
    public partial class Form1 : Form
    {
        readLngFile lng = new readLngFile();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //the system language
            string sysLanguage = System.Globalization.CultureInfo.CurrentCulture.Name;
            
            //the current folder
            string path = Directory.GetCurrentDirectory();
            
            //find the language file
            string myfile;
            string default_file = path + "/en-EN.lng";
            string lngfile = path + "/" + sysLanguage + ".lng";
            if (File.Exists(lngfile))
            {
                myfile = lngfile;
            }
            else
            {
                myfile = default_file;
            }

            //load items
            buildmenus(myfile);

        }

        public void buildmenus(string myfile)
        {
            fileToolStripMenuItem.Text = lng.getValue(myfile, "mn_file", "menu_1");
            apriToolStripMenuItem.Text = lng.getValue(myfile, "mn_file", "menu_2");
            nuovoToolStripMenuItem.Text = lng.getValue(myfile, "mn_file", "menu_3");
            salvaToolStripMenuItem.Text = lng.getValue(myfile, "mn_file", "menu_4");
            salvaComeToolStripMenuItem.Text = lng.getValue(myfile, "mn_file", "menu_5");
            esciToolStripMenuItem.Text = lng.getValue(myfile, "mn_file", "menu_6");

            modificaToolStripMenuItem.Text = lng.getValue(myfile, "mn_insert", "menu_1");
            immagineToolStripMenuItem.Text = lng.getValue(myfile, "mn_insert", "menu_2");
            disegnoToolStripMenuItem.Text = lng.getValue(myfile, "mn_insert", "menu_3");
            graficoToolStripMenuItem.Text = lng.getValue(myfile, "mn_insert", "menu_4");
        }
    }
}
