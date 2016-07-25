using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace C_CUDA_Integration
{  
    public partial class Form1 : Form
    {
        [DllImport("Project1.dll", CallingConvention = CallingConvention.Cdecl)]
        unsafe public extern static System.Int32 Main(double* a, double* b, double* c, int length, int type);

        CalcType[] CalcTypeList;

        enum CalcType
        {
            CUDA, C, CSharp
        }        
        
        public Form1()
        {            
            InitializeComponent();
            radioButton1.Tag = CalcType.CSharp;
            radioButton2.Tag = CalcType.C;
            radioButton3.Tag = CalcType.CUDA;
            
            Calculations(CalcType.CUDA); //UpLoad the DLL

            CalcTypeList = new CalcType[3];
            CalcTypeList[0] = CalcType.CUDA;
            CalcTypeList[1] = CalcType.C;
            CalcTypeList[2] = CalcType.CSharp;            
        }

        private void ThreadStarting()
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }

        private void InputValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void InputValue_KeyDown(object sender, KeyEventArgs e)
        {
            keyDown();
        }

        private void InputValue2_TextChanged(object sender, EventArgs e)
        {
            keyDown();
        }

        private double Comparison(bool absolute)
        {
            int length = Int32.Parse(ArrayLength.Text);
            Random rn = new Random();

            double[] A = new double[length];
            double[] B = new double[length];
            double[] C1 = new double[length];
            double[] C2 = new double[length];
            double[] C3 = new double[length];

            for (int i = 0; i < length; i++) A[i] = rn.Next();
            for (int i = 0; i < length; i++) B[i] = rn.Next();

            foreach (CalcType type in CalcTypeList)
            {
                switch (type)
                {
                    case CalcType.CUDA:
                        unsafe
                        {
                            fixed (double* aL = A, bL = B, cL = C1)
                                OutputValue.Text = Main(aL, bL, cL, length, 3).ToString();
                        }
                        break;
                    case CalcType.C:
                        unsafe
                        {
                            fixed (double* aL = A, bL = B, cL = C2)
                                OutputValue.Text = Main(aL, bL, cL, length, 1).ToString();
                        }
                        break;
                    case CalcType.CSharp:
                        for (int i = 0; i < length; i++)
                        {
                            C3[i] = Math.Sin(A[i]) + Math.Sin(B[i]);
                        }
                        break;
                    default:
                        break;
                }
            }

            String answer = "";
            double inaccuracy = 0.0;
            double inaccuracyCSharp_C = 0.0;
            double inaccuracyCSharp_CUDA = 0.0;
            double inaccuracyC_CUDA = 0.0;
            double maxinaccuracy = 0.0;
            double mininaccuracy = sizeof(double);

            if (C1.Length == C2.Length && C1.Length == C3.Length) inaccuracy = 0.0;
            else return 228.228;
            for (int i = 0; i < C1.Length; i++)
            {
                double thisInac = Math.Abs(C1[i] + C2[i])/2 + Math.Abs(C1[i] + C3[i])/2 + Math.Abs(C2[i] + C3[i])/2;
                inaccuracy += thisInac;
                inaccuracyC_CUDA += Math.Abs(C1[i] + C2[i])/2;
                inaccuracyCSharp_C += Math.Abs(C3[i] + C2[i])/2;
                inaccuracyCSharp_CUDA += Math.Abs(C3[i] + C2[i])/2;

                if (mininaccuracy > thisInac) mininaccuracy = thisInac;
                if (maxinaccuracy < thisInac) maxinaccuracy = thisInac;
            }

            MaxInaccuracy.Text = mininaccuracy.ToString();
            MinInaccuracy.Text = maxinaccuracy.ToString();

            if (absolute)
            {
                inaccuracyC_CUDA = inaccuracyC_CUDA / length;
                inaccuracyCSharp_C = inaccuracyCSharp_C / length;
                inaccuracyCSharp_CUDA = inaccuracyCSharp_CUDA / length;

                                 
            }
            if (ShowBiggestInac.Checked)
            {
                string C1maxinac = "";
                int C1i = 0;
                string C2maxinac = "";
                int C2i = 0;
                string C3maxinac = "";
                int C3i = 0;

                double coff = 1.0;
                if (comboBox1.SelectedIndex == 0) coff = 0.3;
                if (comboBox1.SelectedIndex == 1) coff = 0.4;
                if (comboBox1.SelectedIndex == 2) coff = 0.5;
                for (int i = 0; i < length; i++)
                {
                    if (C1[i] >= maxinaccuracy * coff)
                    {
                        C1maxinac += C1[i].ToString() + " [" + i + "]";
                        C1i++;
                    }
                    if (C2[i] >= maxinaccuracy * coff)
                    {
                        C2maxinac += C2[i].ToString() + " [" + i + "]";
                        C2i++;
                    }
                    if (C3[i] >= maxinaccuracy * coff)
                    {
                        C3maxinac += C3[i].ToString() + " [" + i + "]";
                        C3i++;
                    }
                }                
                CSharp_C.Text = "ALL: " + C1i + "\n " + C1maxinac;
                CSharp_CUDA.Text = "ALL: " + C2i + "\n " + C2maxinac;
                CUDA_C.Text = "ALL: " + C3i + "\n " + C3maxinac;
            }
            else
            {
                CSharp_C.Text += inaccuracyCSharp_C.ToString() + "\n";
                CSharp_CUDA.Text += inaccuracyCSharp_CUDA.ToString() + "\n";
                CUDA_C.Text += inaccuracyC_CUDA.ToString() + "\n";
            }
            return inaccuracy;
        }

        private double Calculations(CalcType type)
        {
            int length = Int32.Parse(ArrayLength.Text);
            Random rn = new Random();

            double[] A = new double[length];
            double[] B = new double[length];
            double[] C = new double[length];

            for (int i = 0; i < length; i++) A[i] = rn.Next();
            for (int i = 0; i < length; i++) B[i] = rn.Next();

            DateTime dt1, dt2;
            double spendTime;

            switch (type)
            {
                case CalcType.CUDA:
                    unsafe
                    {
                        dt1 = DateTime.Now;
                        fixed (double* aL = A, bL = B, cL = C)
                            OutputValue.Text = Main(aL, bL, cL, length, 3).ToString();
                        dt2 = DateTime.Now;
                        spendTime = (dt2 - dt1).TotalMilliseconds;
                        return spendTime;
                    }
                    break;
                case CalcType.C:
                    unsafe
                    {
                        dt1 = DateTime.Now;
                        fixed (double* aL = A, bL = B, cL = C)
                            OutputValue.Text = Main(aL, bL, cL, length, 1).ToString();
                        dt2 = DateTime.Now;
                        spendTime = (dt2 - dt1).TotalMilliseconds;
                        return spendTime;
                    }
                    break;
                case CalcType.CSharp:
                        dt1 = DateTime.Now;
                        for (int i = 0; i < length; i++)
                        {
                            C[i] = Math.Sin(A[i]) + Math.Sin(B[i]);
                        }
                        dt2 = DateTime.Now;
                        spendTime = (dt2 - dt1).TotalMilliseconds;
                        return spendTime;
                    break;
                default:
                    return 0.0;
                    break;
            }
        }

        private void keyDown()
        {
            foreach (RadioButton rb in groupBox1.Controls) if (rb.Checked)
                {
                    switch ((CalcType)rb.Tag)
                    {
                        case CalcType.CUDA:
                            SpendingTime.Text = Calculations((CalcType)rb.Tag).ToString();
                            break;
                        case CalcType.C:
                            SpendingTime.Text = Calculations((CalcType)rb.Tag).ToString();
                            break;
                        case CalcType.CSharp:
                            SpendingTime.Text = Calculations((CalcType)rb.Tag).ToString();
                            break;
                    }
                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            keyDown();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Application.Exit();
            MessageBox.Show(e.KeyCode.ToString());
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            C.Items.Clear();
            CSharp.Items.Clear();
            CUDA.Items.Clear();

            double average = 0.0;

            for (int i = 0; i < Int32.Parse(CalcCount.Text); i++)
            {
                C.Items.Add(Calculations(CalcType.C).ToString());                
                CSharp.Items.Add(Calculations(CalcType.CSharp).ToString());
                CUDA.Items.Add(Calculations(CalcType.CUDA).ToString());
            }
            for (int ii = 0; ii < C.Items.Count; ii++)
            {
                double value = Double.Parse(C.Items[ii].ToString());
                average += value;
                CAverage.Text = (average / (ii + 1)).ToString();
            }
            average = 0.0;
            for (int ii = 0; ii < CSharp.Items.Count; ii++)
            {
                double value = Double.Parse(CSharp.Items[ii].ToString());
                average += value;
                CSharpAverage.Text = (average / (ii + 1)).ToString();
            }
            average = 0.0;
            for (int ii = 0; ii < CUDA.Items.Count; ii++)
            {
                double value = Double.Parse(CUDA.Items[ii].ToString());
                average += value;
                CUDAAverage.Text = (average / (ii + 1)).ToString();
            }           
        }

        private void button3_Click(object sender, EventArgs e)
        {            
            CSharp_C.Text = "";
            CSharp_CUDA.Text = "";
            CUDA_C.Text = "";
            for (int a = 10000; a <= 100000; a += 10000)
            {
                ArrayLength.Text = a.ToString();
                if (AbsoluteInac.Checked) Comparison(true);
                if (AverageInac.Checked) Comparison(false);
            }
            ArrayLength.Text = "10000";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
