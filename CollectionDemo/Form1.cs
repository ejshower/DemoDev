using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Hashtable GetHashtable() 
        {
            Hashtable ht= new Hashtable();
            ht.Add(1, "Good");
            ht.Add(2, "Morning");
            ht.Add(3, "Afternoon");
            ht.Add(4, "Evening");
            //ht.Add(1, "so so");
            return ht;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strFirst = string.Empty;

            StringBuilder sb = new StringBuilder();
            Hashtable     ht = GetHashtable();

            foreach (int key in ht.Keys)
            {
                if (ht.ContainsKey(key))
                {
                    if(key == 1)
                    {
                        strFirst = ht[key] as string;
                        continue;
                    }
                    sb.AppendLine(strFirst +" "+ ht[key] as string);
                }
            }

            rtbGreeting.Text = sb.ToString();
        }
    }
}
