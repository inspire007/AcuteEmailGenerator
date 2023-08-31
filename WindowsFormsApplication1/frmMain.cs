using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        string appPath = Application.StartupPath;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(appPath + "/database/");
            var directories = di.GetFiles("*firstnames*", SearchOption.TopDirectoryOnly);
            countryListBox.Items.Clear();
            countryListBox.Items.Add("Select a country");
            foreach (FileInfo d in directories)
            {
                string fname = d.Name.Replace("-firstnames.txt", "");
                countryListBox.Items.Add(fname);
            }
            countryListBox.Text = "Select a country";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string firstnames = appPath + "/database/" + countryListBox.Text + "-firstnames.txt";
            string surnames = appPath + "/database/" + countryListBox.Text + "-surnames.txt";

            string keywords = keywordsBox.Text;
            string emailProvider = emailProviderBox.Text;
            bool addDots = dots.Checked;
            bool addNumbers = numbers.Checked;

            if (countryListBox.Text == "Select a country")
            {
                MessageBox.Show("Select country first");
                return;
            }

            if (emailProvider == "") {
                MessageBox.Show("Email provider required");
                return;
            }

            string[] firstnameList = File.ReadAllLines(firstnames);
            string[] surnameList = File.ReadAllLines(surnames);
            string[] keywordsList = Regex.Split(keywords, ",");

            Random rnd = new Random();
            string[] randFirstnameList = firstnameList.OrderBy(x => rnd.Next()).ToArray();
            string[] randSurnameList = surnameList.OrderBy(x => rnd.Next()).ToArray();
            string[] randKeywordsList = keywordsList.OrderBy(x => rnd.Next()).ToArray();
        

            string output = appPath + "/emailList.txt";
            //File.WriteAllText(output, "");

            int ticks = rnd.Next(8000, 12000);
            ticks = Math.Min(ticks, randFirstnameList.Length);
            ticks = Math.Min(ticks, randSurnameList.Length);
            string email = "";
            int rndNum = 0;
            int kkList = randKeywordsList.Length;
            int dotAdded = 0;

            for (int i = 0; i < ticks; i++) {
                rndNum = rnd.Next(1, 9999);
                email = randFirstnameList[i];
                if (addDots) {
                    if (rndNum % 5 == 0) email += ".";
                    else if (rndNum % 8 == 0) email += "_";
                    dotAdded = 1;
                }
                if (kkList > 0 && rndNum % 6 == 0) {
                    randKeywordsList = keywordsList.OrderBy(x => rnd.Next()).ToArray();
                    if (dotAdded == 0) {
                        if (rndNum % 4 == 0) email += "_";
                        else email += ".";
                    }
                    email += randKeywordsList[0];
                }
                else email += randSurnameList[i];
                if (addNumbers)
                {
                    if (rndNum % 4 == 0) email += rndNum.ToString();
                }
                email += "@" + emailProvider;
                File.AppendAllText(output, email + "\r\n");
            }
            System.Diagnostics.Process.Start(output);
        }
    }
}
