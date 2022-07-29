using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_IBA_AG
{
    /// <summary>
    /// Reads data for channels from .csv and .txt files.
    /// </summary>
    public class CSVReader
    {
        BackgroundWorker _worker = new BackgroundWorker() { WorkerSupportsCancellation = true, WorkerReportsProgress = true };
        List<Channel> _channels;
        string _fileName;
        char _fieldSeparator;
        NumberFormatInfo _numberFormatInfo;
        Form1 _mainForm;
        FormProgress _formProgress;
        /// <summary>
        /// Creates new class instance.
        /// </summary>
        /// <param name="form1">Reference on parent form.</param>
        public CSVReader(Form1 form1)
        {
            _mainForm = form1;
            _worker.DoWork += new DoWorkEventHandler(_worker_DoWork);
            _worker.ProgressChanged += new ProgressChangedEventHandler(_worker_ProgressChanged);
            _worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(_worker_RunWorkerCompleted);
        }
        /// <summary>
        /// Opens openFileDialog to select file.
        /// </summary>
        /// <returns>A string with full path to the file or null if no file is selected.</returns>
        public string SelectFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.Reflection.Assembly.GetExecutingAssembly().Location;
            openFileDialog.Filter = "CSV files(*.csv; *.txt;)|*.csv; *.txt;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return null;
        }
        /// <summary>
        /// Stars asyncronous process of reading file.
        /// </summary>
        /// <param name="fileName">Full path to file.</param>
        public void Read(string fileName)
        {
            _fileName = fileName;
            _mainForm.SetStatus("Opening CSV file ‘" + _fileName + "’...");
            _channels = new List<Channel>();

            _formProgress = new FormProgress(Cancel);
            _formProgress.SetDescription("Opening file ‘" + _fileName + "’...");
            _formProgress.Show();

            _worker.RunWorkerAsync();
        }

        private void AddLineToData(string line)
        {
            string[] data = line.Split(_fieldSeparator);
            if (data.Length != _channels.Count) // if input line contains less or more numbers, than count of channels, then ignore this line
                return; 
            for (int i = 0; i < _channels.Count; i++)
            {
                double dataNumber;
                if (double.TryParse(data[i], NumberStyles.Any, _numberFormatInfo, out dataNumber))
                    _channels[i].Add(dataNumber);
                else
                    _channels[i].Add(double.NaN);
            }
        }
        /// <summary>
        /// Cancels opening.
        /// </summary>
        public void Cancel()
        {
            _mainForm.SetStatus("Cancelling...");
            _worker.CancelAsync();
        }

        private void _worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _mainForm.EndOpening(e.Cancelled, _channels);
            _formProgress.Close();
        }

        private void _worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _formProgress.SetPercents(e.ProgressPercentage);
        }

        private void _worker_DoWork(object sender, DoWorkEventArgs e)
        {
            using (StreamReader streamReader = new StreamReader(_fileName))
            {
                // read names of channels 
                string line = streamReader.ReadLine();
                _fieldSeparator = _mainForm.DefineFieldSeparator(line);
                string[] dataNames = line.Split(_fieldSeparator);
                for (int i = 0; i < dataNames.Length; i++)
                {
                    _channels.Add(new Channel(dataNames[i]));
                    if (i < 5)
                    {
                        _channels[i].IsActive = true;
                    }
                }
                // read data, while decimal delimiter is undefined
                char decimalDelimiter = '\0';
                while (decimalDelimiter == '\0' && (line = streamReader.ReadLine()) != null)
                {
                    if (_worker.CancellationPending)
                    { 
                        e.Cancel = true;
                        return;
                    }
                    decimalDelimiter = _mainForm.DefineDecimalDelimiter(line);
                    _numberFormatInfo = new NumberFormatInfo() { NumberDecimalSeparator = decimalDelimiter.ToString() };
                    AddLineToData(line);
                    _worker.ReportProgress((int)(100 * streamReader.BaseStream.Position / streamReader.BaseStream.Length), e.Argument);
                }
                // read other data
                long lastPosition = streamReader.BaseStream.Position;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (_worker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                    AddLineToData(line);

                    _worker.ReportProgress((int)(100 * streamReader.BaseStream.Position / streamReader.BaseStream.Length), e.Argument);
                    if ((streamReader.BaseStream.Position - lastPosition) > streamReader.BaseStream.Length / 25) // redraw graph every 4%
                    {
                        _mainForm.WriteGraph(_channels);
                        lastPosition = streamReader.BaseStream.Position;
                    }
                }
            }
        }
    }
}
