using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Test_IBA_AG
{
    /// <summary>
    /// Generates new channels and writes their to new .csv or .txt file.
    /// </summary>
    internal class CSVGenerator
    {
        BackgroundWorker _worker = new BackgroundWorker() { WorkerSupportsCancellation = true, WorkerReportsProgress = true };
        string _fileName;
        char _fieldSeparator = '\t';
        NumberFormatInfo _numberFormatInfo;
        Form1 _mainForm;
        FormProgress _formProgress;
        /// <summary>
        /// Creates new class instance.
        /// </summary>
        /// <param name="form1">Reference on parent form.</param>
        public CSVGenerator(Form1 form1)
        {
            _mainForm = form1;
            _worker.DoWork += new DoWorkEventHandler(_worker_DoWork);
            _worker.ProgressChanged += new ProgressChangedEventHandler(_worker_ProgressChanged);
            _worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(_worker_RunWorkerCompleted);
        }
        /// <summary>
        /// Opens saveFileDialog to write file name.
        /// </summary>
        /// <returns>A string with full path to the generating file or null if no file name is writed.</returns>
        public string CreateFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = System.Reflection.Assembly.GetExecutingAssembly().Location;
            saveFileDialog.Filter = "CSV files(*.csv; *.txt;)|*.csv; *.txt;";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }
            return null;
        }
        /// <summary>
        /// Stars asyncronous process of generating new file.
        /// </summary>
        /// <param name="fileName">Full path to file.</param>
        /// <param name="channelCount">Number of channels.</param>
        /// <param name="rowCount">Number of rows.</param>
        /// <param name="isWithNaNs">Flag indicating if it's necessary to make some values as NaN.</param>
        public void Write(string fileName, int channelCount, int rowCount, bool isWithNaNs)
        {
            _fileName = fileName;
            _mainForm.SetStatus("Generating CSV file ‘" + _fileName + "’...");

            _fieldSeparator = _mainForm.DefineFieldSeparator("");
            if (_fieldSeparator == '\0') 
                _fieldSeparator = '\t';
            char decimalDelimiter = _mainForm.DefineDecimalDelimiter("", '\0');
            if(decimalDelimiter == '\0') 
                decimalDelimiter = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            _numberFormatInfo = new NumberFormatInfo() { NumberDecimalSeparator = decimalDelimiter.ToString() };

             _formProgress = new FormProgress(Cancel);
            _formProgress.SetDescription("Generating file ‘" + _fileName + "’...");
            _formProgress.Show();

            _worker.RunWorkerAsync((channelCount, rowCount, isWithNaNs));
        }
        /// <summary>
        /// Cancels generating.
        /// </summary>
        public void Cancel()
        {
            _mainForm.SetStatus("Cancelling...");
            _worker.CancelAsync();
        }

        private void _worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _formProgress.Close();
            _mainForm.SetStatus("Completed successfully");
        }

        private void _worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _formProgress.SetPercents(e.ProgressPercentage);
        }

        void _worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int channelCount, rowCount;
            bool isWithNaNs;
            (channelCount, rowCount, isWithNaNs) = (((int, int, bool))e.Argument);
            List<object> functions = new List<object>() { new WriteX(), new WriteSin(), new WriteSqrt(), new WriteLog1(), new WriteZigzag() };
            Random random = new Random();

            using (StreamWriter streamWriter = new StreamWriter(_fileName))
            {
                // write names of channels 
                string line = "";
                for (int i = 0; i < channelCount; i++)
                {
                    line += "Graph" + (i + 1).ToString() + " " + ((FunctionToWrite)functions[i % 5]).Name;
                    if(i!=channelCount-1)
                        line += _fieldSeparator;
                }
                streamWriter.WriteLine(line);
                // write data
                for (int i = 0; i < rowCount; i++)
                {
                    if (_worker.CancellationPending)
                        return;
                    line = "";
                    for (int j = 0; j < channelCount; j++)
                    {
                        if(isWithNaNs && random.NextDouble() < 0.1)
                            line += "NaN";
                        else
                            line += ((FunctionToWrite)functions[j % 5]).Function(i).ToString(_numberFormatInfo);
                        if (j != channelCount - 1)
                            line += _fieldSeparator;
                    }
                    streamWriter.WriteLine(line);
                    if (i % 100 == 0) 
                        _worker.ReportProgress((int)(100*i/rowCount), e.Argument);
                }
            }
        }
    }

    /// <summary>
    /// Calculates new Y value from value X.
    /// </summary>
    abstract class FunctionToWrite
    {
        /// <summary>
        /// Creates new class instance.
        /// Generates random A and B parameters.
        /// </summary>
        public FunctionToWrite()
        {
            Random random = new Random();
            A = random.NextDouble() * 5;
            B = random.NextDouble() * 100;
        }
        /// <summary>
        /// Name of function.
        /// </summary>
        public string Name;
        /// <summary>
        /// Parameters for generate function.
        /// </summary>
        protected double A, B;
        /// <summary>
        /// Calculates new Y value from X value.
        /// </summary>
        /// <param name="x">X value.</param>
        /// <returns>Y value.</returns>
        public abstract double Function(int x);
    }

    class WriteX : FunctionToWrite
    {
        public WriteX()
        {
            Name = "X";
        }
        public override double Function(int x)
        {
            return A * x + B;
        }
    }

    class WriteSin : FunctionToWrite
    {
        public WriteSin()
        {
            Name = "SinusX";
            Random random = new Random();
            _k = random.NextDouble()/10;
        }
        private double _k;
        public override double Function(int x)
        {
            return A * Math.Sin(_k * x) + B;
        }
    }

    class WriteSqrt : FunctionToWrite
    {
        public WriteSqrt()
        {
            Name = "SqrtX";
        }
        public override double Function(int x)
        {
            return A * Math.Sqrt(x) + B;
        }
    }

    class WriteLog1 : FunctionToWrite
    {
        public WriteLog1()
        {
            Name = "Log(1+X)";
        }
        public override double Function(int x)
        {
            return A * Math.Log(1+x) + B;
        }
    }

    class WriteZigzag : FunctionToWrite
    {
        public WriteZigzag()
        {
            Name = "Zigzag";
            Random random  = new Random();
            _h = (int)Math.Round(1+random.NextDouble() * 100);
        }
        int _h;
        public override double Function(int x)
        {
            return A * (((x / _h) % 2 == 0) ? (x % _h) : (_h - x%_h)) + B;
        }
    }
}
