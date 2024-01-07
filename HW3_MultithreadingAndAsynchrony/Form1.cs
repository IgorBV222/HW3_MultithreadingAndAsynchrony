using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3_MultithreadingAndAsynchrony
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           tokenSourcePrimeNumbers = new CancellationTokenSource();
           tokenSourceFibonacciNumbers = new CancellationTokenSource();
        }

        Thread threadPrimeNumbers;
        Thread threadFibonacciNumbers;

        private CancellationTokenSource tokenSourcePrimeNumbers;
        private CancellationTokenSource tokenSourceFibonacciNumbers;

        private bool generationPrimeNumbers;
        private bool generationFibonacciNumbers;

        List<int> listPrimeNumbers = new List<int>();
        List<int> listFibonacciNumbers = new List<int>();

        //Метод проверки числа на простое
        private bool NumberIsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        //Метод генерации простых чисел
        private void PrimeNumberGenerator(int start, int end)
        {
            for (int i = start; i <= end && generationPrimeNumbers; i++)
            {
                if (NumberIsPrime(i))
                {
                    listPrimeNumbers.Add(i);
                }
            }
            generationPrimeNumbers = false;
        }
        //Метод вывода чисел на форму
        private void ShowNumbers(CancellationTokenSource tokenSource, ListBox listBox, List<int> numbers)
        {
            try
            {
                foreach (int num in numbers)
                {
                    if (tokenSource.IsCancellationRequested) 
                    {
                        break;
                    }
                    listBox.BeginInvoke((MethodInvoker)delegate
                    {
                        listBox.Items.Add(num);
                    });
                    Thread.Sleep(300);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //Старт генерации потока простых чисел
        private void btn_StartPrimeNumbers_Click(object sender, EventArgs e)
        {
            tokenSourcePrimeNumbers = new CancellationTokenSource();
            if (!generationPrimeNumbers)
            {
                int startNumber;
                int endNumber;              

                if (tbox_Start.Text == string.Empty)
                {
                    startNumber = 2;
                }
                else
                {
                    startNumber = Convert.ToInt32(tbox_Start.Text);
                }
                if (tbox_End.Text == string.Empty)
                {
                    endNumber = 1000; // 2147483647; // ВОПРОС как ограничить завершением потока?
                }
                else
                {
                    endNumber = Convert.ToInt32(tbox_End.Text);
                }
                generationPrimeNumbers = true;
                PrimeNumberGenerator(startNumber, endNumber);
                threadPrimeNumbers = new Thread(() => ShowNumbers(tokenSourcePrimeNumbers, lbox_PrimeNumbers, listPrimeNumbers));
                threadPrimeNumbers.Start();
            }
        }
        //================= FibonacciNumbers==================================
        //Метод формирует список чисел Фибоначчи, входящих в заданный диапазон
        private List<int> GetFibonacciNumbersInRange(int start, int end)
        {
            List<int> fibonacciNumbersInRange = new List<int>();
            int a = 0, b = 1;
            int temp = 0;
            while (temp <= end)
            {
                temp = a + b;
                a = b;
                b = temp;
                if (temp >= start && temp <= end)
                {
                    fibonacciNumbersInRange.Add(temp);
                }
            }
            return fibonacciNumbersInRange;
        }

        //метод генерации списка  чисел Фибоначчи и вывода на форму
        private void FibonacciNumbersGenerator(int start, int end)
        {
            List<int> fibonacciNumbersInRange = GetFibonacciNumbersInRange(start, end);    
            this.Invoke((MethodInvoker)delegate
            {
                foreach (int number in fibonacciNumbersInRange)
                {
                    listFibonacciNumbers.Add(number);
                }
            });
            generationFibonacciNumbers = false;
        }
        //Старт генерации потока чисел Фибоначчи
        private void btn_StartFibonacciNumbers_Click(object sender, EventArgs e)
        {
            tokenSourceFibonacciNumbers = new CancellationTokenSource();
            if (!generationFibonacciNumbers)
            {
                {
                    int startNumber;
                    int endNumber;

                    if (tbox_Start.Text == string.Empty)
                    {
                        startNumber = 2;
                    }
                    else
                    {
                        startNumber = Convert.ToInt32(tbox_Start.Text);
                    }
                    if (tbox_End.Text == string.Empty)
                    {
                        endNumber = 1000; // 2147483647; // ВОПРОС как ограничить завершением потока?
                    }
                    else
                    {
                        endNumber = Convert.ToInt32(tbox_End.Text);
                    }
                    generationFibonacciNumbers = true;
                    FibonacciNumbersGenerator(startNumber, endNumber);
                    threadFibonacciNumbers = new Thread(() => ShowNumbers(tokenSourceFibonacciNumbers, lbox_FibonacciNumbers, listFibonacciNumbers));
                    threadFibonacciNumbers.Start();
                }
            }
        }
        private void btn_StopPrimeNumbers_Click(object sender, EventArgs e)
        {
            tokenSourcePrimeNumbers.Cancel();
        }
        private void btn_StopFibonacciNumbers_Click(object sender, EventArgs e)
        {
            tokenSourceFibonacciNumbers.Cancel();
        }
        private void btn_PausePrimeNumbers_Click(object sender, EventArgs e)
        {
            if (threadPrimeNumbers != null && threadPrimeNumbers.IsAlive)
            {
                threadPrimeNumbers.Suspend();
            }
        }
        private void btn_PauseFibonacciNumbers_Click(object sender, EventArgs e)
        {
            if (threadFibonacciNumbers != null && threadFibonacciNumbers.IsAlive)
            {
                threadFibonacciNumbers.Suspend();
            }
        }

        private void btn_ResumePrimeNumbers_Click(object sender, EventArgs e)
        {
            if (threadPrimeNumbers != null && threadPrimeNumbers.ThreadState == ThreadState.Suspended)
            {
                threadPrimeNumbers.Resume();
            }
        }

        private void btn_ResumeFibonacciNumbers_Click(object sender, EventArgs e)
        {
            if (threadFibonacciNumbers != null && threadFibonacciNumbers.ThreadState == ThreadState.Suspended)
            {
                threadFibonacciNumbers.Resume();
            }
        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {       
            tokenSourcePrimeNumbers.Cancel();
            tokenSourceFibonacciNumbers.Cancel();        
            generationPrimeNumbers = false;
            generationFibonacciNumbers = false;
            lbox_PrimeNumbers.Items.Clear();
            lbox_FibonacciNumbers.Items.Clear();
            tbox_Start.Clear();
            tbox_End.Clear();
            listPrimeNumbers.Clear();
            listFibonacciNumbers.Clear();
            
        }
    }
}
