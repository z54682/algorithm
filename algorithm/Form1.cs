﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            UInt64 nNumber = Convert.ToUInt32(txtNumber.Text);
            UInt64 nResult = 1;

            if(nNumber > 1)
            {
                UInt64 nTemp = 0;
                UInt64 a = 0;
                for(UInt64 i = 2;i <= nNumber;i++)
                {
                    nTemp = nResult;
                    nResult += a;
                    a = nTemp;
                }
            }

            labResult.Text = nResult.ToString();
        }

        private void btnPrime_Click(object sender, EventArgs e)
        {
            int nNumber1 = Convert.ToInt32(txtNumber.Text);
            if (nNumber1 >= 2) labResult.Text = "None";
            while (nNumber1 > 2)
            {
                bool bFlag = true;
                for (int i = 2;i < nNumber1; i++)
                {
                    if (nNumber1 % i == 0)
                    {
                        bFlag = false;
                        break;
                    }
                }
                if (bFlag)
                {
                    labResult.Text = nNumber1.ToString();
                    break;
                }
                nNumber1--;
            }
        }
    }
}
