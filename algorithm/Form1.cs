using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algorithm
{
    public partial class Form1 : Form
    {
        int nBigIntArray = 8;  //大數陣列數
        public Form1()
        {
            InitializeComponent();
        }

        private UInt64[] getTextBoxBigInt(TextBox tb)
        {
            UInt64[] nInt = new UInt64[nBigIntArray];
            string strNumber = tb.Text;
            return nInt;
        }

        private void printLabelResult(UInt64[] nNumber)
        {
            string strResult = "";
            for(int i = 0;i< nNumber.Length - 1;i++)
            {
                strResult = nNumber[i].ToString().PadLeft(60, '0') + strResult;
            }
            strResult.TrimStart('0');
            if (nNumber[nNumber.Length - 1] == 9999)
                strResult = "-" + strResult;
            labResult.Text = strResult;
        }

        #region ClickEvent
        private void btnBigAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            UInt64 nNumber = Convert.ToUInt32(txtNumber1.Text);
            UInt64 nResult = 1;

            if (nNumber > 1)
            {
                UInt64 nTemp = 0;
                UInt64 a = 0;
                for (UInt64 i = 2; i <= nNumber; i++)
                {
                    nTemp = nResult;
                    nResult += a;
                    a = nTemp;
                }
            }
            else
                nResult = nNumber;
            labResult.Text = nResult.ToString();
        }

        private void btnPrime_Click(object sender, EventArgs e)
        {
            int nNumber1 = Convert.ToInt32(txtNumber1.Text);
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

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            UInt32 nNumber1 = Convert.ToUInt32(txtNumber1.Text);
            UInt64 nResult = 1;
            for (UInt32 i = 2;i <= nNumber1;i++)
            {
                nResult *= i;
            }
            labResult.Text = nResult.ToString();
        }
        #endregion
    }
}
