using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace CSP.DataScience.Tool
{
    public partial class MainFormNew : Form
    {
        string _selectedFilePath = null, _outputFilePath = null;
        GoogleAIService _googleAIService = null;
        string _apiKey = "";
        DataTable _inputData = new DataTable();

        public MainFormNew()
        {
            InitializeComponent();

            this.Initialize();
        }

        private void Initialize()
        {
            this.groupBox_NLP.Enabled = false;
            this.toolStripProgressBar1.Visible = false;

            this._apiKey = CSP.DataScience.Tool.Properties.Settings.Default.GoogleAPIKey;

            if (!string.IsNullOrWhiteSpace(this._apiKey))
            {
                this._googleAIService = new GoogleAIService(this._apiKey);
            }

            this.btn_Convert.Enabled = false;
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.openFileDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    this.tb_FileName.Text = this.openFileDialog1.FileName;

                    this._selectedFilePath = this.openFileDialog1.FileName;

                    this.btn_Convert.Enabled = true;

                    this._inputData = DataManager.ReadCsvToDataTable(this._selectedFilePath);

                    PopulateColumns(_inputData);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(this.cb_NLPColumns.Text))
                {
                    this.TranslateCSV(this.cb_TargetLanguage.Text?.Split()?.First()?.Trim(), this.cb_NLPColumns.Text);
                }
                else
                {
                    MessageBox.Show(this, "Select Source Column to translate");
                }
                
            }
            catch (Exception ex)
            {

            }

        }
        string _sourceColName;
        private void TranslateCSV(string targetLanguage, string sourceColName)
        {
            try
            {
                this.toolStripProgressBar1.Visible = true;
                _sourceColName = sourceColName;
                backgroundWorker1.RunWorkerAsync(targetLanguage);
            }
            catch (Exception ex)
            {

            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {

                e.Result = _googleAIService.TranslateDataTable(this._inputData, (string)e.Argument, _sourceColName);
            }
            catch (Exception ex)
            {

            }

        }

        DataTable _translatedDataTable = null;

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Result != null)
                {
                    _translatedDataTable = e.Result as DataTable;

                    //  DataManager.SaveDataTableToCsv(_translatedDataTable, this._outputFilePath);


                  
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                this.toolStripProgressBar1.Visible = false;
                this.groupBox_NLP.Enabled = true;
            }
        }


        private void PopulateColumns(DataTable dataTable)
        {

            if (dataTable != null)
            {
                List<string> columnsList = new List<string>(), columnsListb = new List<string>();

                foreach (DataColumn column in dataTable.Columns)
                {
                    columnsList.Add(column.ColumnName);
                    columnsListb.Add(column.ColumnName);
                }

                this.cb_NLPColumns.DataSource = columnsList;
                this.cb_CategoryColns.DataSource = columnsListb;

            }

        }

        private DataTable GetBestMapping(string nlpAnalyzeColumn, string labelColumn, DataTable inputData, string targetFilePath)
        {
            var labels = GetColumnUniqueValues(inputData, labelColumn);

            return this._googleAIService.MapColumnToClosetLabel(inputData, nlpAnalyzeColumn, labelColumn, labels);
        }

        string _mappedFilePath = null;

        private async void btn_GenerateCorrectLabeling_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.cb_NLPColumns.Text) && !string.IsNullOrWhiteSpace(this.cb_CategoryColns.Text))
                {
                    if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
                    {
                        _mappedFilePath = this.saveFileDialog1.FileName;

                        var input = new NLPInputModel(this.cb_NLPColumns.Text, this.cb_CategoryColns.Text, _translatedDataTable, _mappedFilePath);

                        this.toolStripProgressBar1.Visible = true;
                        backgroundWorker2.RunWorkerAsync(input);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Select Columns");
                }
            }
            catch (Exception ex)
            {

            }
        }


        public static string[] GetColumnUniqueValues(DataTable table, string columnName)
        {
            // Check if the DataTable contains the specified column
            if (!table.Columns.Contains(columnName))
            {
                throw new ArgumentException($"Column '{columnName}' does not exist in the DataTable.");
            }

            // Extract, trim, and remove duplicates with case-insensitivity
            string[] columnValues = table.AsEnumerable()
                                         .Select(row => row[columnName].ToString().Trim())
                                         .Where(value => !string.IsNullOrEmpty(value))
                                         .Distinct(StringComparer.OrdinalIgnoreCase)
                                         .ToArray();

            return columnValues;
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                NLPInputModel inputModel = e.Argument as NLPInputModel;

                e.Result = this.GetBestMapping(inputModel.NLPAnalyzeColumn, inputModel.LabelColumn, inputModel.InputData, inputModel.TargetFilePath);

            }
            catch (Exception ex)
            {

            }
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Result != null)
                {

                    DataManager.SaveDataTableToCsv(e.Result as DataTable, _mappedFilePath);

                    MessageBox.Show(this, "File cleansed and saved Successfully");
                }
                else
                {
                    MessageBox.Show(this, "Error happened");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error happened");
            }
            finally
            {
                this.toolStripProgressBar1.Visible = false;
            }
        }
    }
}
