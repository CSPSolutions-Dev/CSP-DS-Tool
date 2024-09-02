using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.DataScience.Tool
{
    internal class DataManager
    {

        public static DataTable ReadCsvToDataTable(string filePath, bool hasHeaders = true, char delimiter = ',')
        {
            DataTable table = new DataTable();

            using (StreamReader reader = new StreamReader(filePath))
            {
                // Read the first line to get the column headers or to infer columns
                string[] headers = reader.ReadLine().Split(delimiter);

                // Set up the columns based on the first row or headers
                for (int i = 0; i < headers.Length; i++)
                {
                    string columnName = hasHeaders ? headers[i] : $"Column{i + 1}";
                    table.Columns.Add(columnName);
                }

                // If the first line is not headers, reprocess it as a data row
                if (!hasHeaders)
                {
                    DataRow firstRow = table.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        firstRow[i] = headers[i];
                    }
                    table.Rows.Add(firstRow);
                }

                // Read the remaining lines as data rows
                while (!reader.EndOfStream)
                {
                    string[] fields = reader.ReadLine().Split(delimiter);
                    DataRow row = table.NewRow();
                    for (int i = 0; i < fields.Length; i++)
                    {
                        row[i] = fields[i];
                    }
                    table.Rows.Add(row);
                }
            }

            return table;
        }

        public static void SaveDataTableToCsv(DataTable table, string filePath, bool includeHeaders = true, char delimiter = ',')
        {
            // Ensure the DataTable is not null
            if (table == null)
            {
                throw new ArgumentNullException(nameof(table), "The DataTable cannot be null.");
            }

            // Use a StringBuilder to collect CSV lines
            StringBuilder csvData = new StringBuilder();

            // Optionally include headers
            if (includeHeaders)
            {
                string[] columnNames = Array.ConvertAll(table.Columns.Cast<DataColumn>().ToArray(), col => col.ColumnName);
                csvData.AppendLine(string.Join(delimiter.ToString(), columnNames));
            }

            // Iterate through the rows and columns to build CSV data
            foreach (DataRow row in table.Rows)
            {
                string[] fields = row.ItemArray.Select(field => QuoteField(field?.ToString(), delimiter)).ToArray();
                csvData.AppendLine(string.Join(delimiter.ToString(), fields));
            }

            // Write the CSV data to the specified file
            File.WriteAllText(filePath, csvData.ToString(), System.Text.ASCIIEncoding.UTF8);
        }

        private static string QuoteField(string field, char delimiter)
        {
            if (field.Contains(delimiter) || field.Contains("\"") || field.Contains("\n"))
            {
                // Escape double quotes by doubling them
                field = field.Replace("\"", "\"\"");
                // Enclose the field in double quotes
                return $"\"{field}\"";
            }
            return field;
        }
    }
}
