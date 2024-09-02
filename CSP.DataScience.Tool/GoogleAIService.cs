using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Translate.v2;
using Google.Apis.Translate.v2.Data;
using Google.Cloud.Language.V1;
using Grpc.Core;
using static Google.Cloud.Language.V1.LanguageService;
using LanguageServiceClient = Google.Cloud.Language.V1.LanguageServiceClient;

namespace CSP.DataScience.Tool
{
    internal class GoogleAIService
    {
        TranslateService _translateService;
        private LanguageServiceClient _languageServiceClient;
        const string ColumnName_NLPLabel = "NLP Label";
        const string ColumnName_TranslatedText = "Translated Text";

        public GoogleAIService(string apiKey)
        { 
            _translateService = new TranslateService(new BaseClientService.Initializer
            {
                ApiKey = apiKey
            });

            LanguageServiceClient client = new LanguageServiceClientBuilder
            {
                ApiKey = apiKey
            }.Build();

            _languageServiceClient = client;
        }

       

        public DataTable TranslateDataTable(DataTable sourceTable, string targetLanguageCode,string sourceColName)
        {
            DataTable result = null;

            if (sourceTable != null)
            {
                result = sourceTable.Copy();

                if (!result.Columns.Contains(ColumnName_TranslatedText))
                {
                    result.Columns.Add(ColumnName_TranslatedText);
                }

                foreach (DataRow row in result.Rows)
                {
                    string originalText = row[sourceColName].ToString();

                    string translatedText = TranslateTextAsync(originalText, targetLanguageCode);

                    row[ColumnName_TranslatedText] = translatedText;
                }
 
            }

            return result;
        }



        public string TranslateTextAsync(string text, string targetLanguageCode)
        {
 
            var request = _translateService.Translations.List(new[] { text }, targetLanguageCode); // Change to your target language code

            var response = request.Execute();

            return response.Translations[0].TranslatedText;

        }

        /// <summary>
        ///  run NLP on and match with one of the label that are closet in meaning
        /// </summary>
        /// <param name="table"></param>
        /// <param name="columnName"> Column to run NLP on and match with one of the label that are closet in meaning</param>
        /// <param name="labels"></param>
        /// <returns></returns>
        public DataTable MapColumnToClosetLabel(DataTable table, string columnName, string currentCategoryColName, string[] labels)
        {
            DataTable resultTable = null;

            if (table == null)
            {
                throw new ArgumentNullException("DataTable.");
            }

            // Ensure the column exists in the DataTable
            if (!table.Columns.Contains(columnName))
            {
               throw new ArgumentException($"Column '{columnName}' does not exist in the DataTable.");
          
            } 
            resultTable = table.Copy();

            if (!resultTable.Columns.Contains(ColumnName_NLPLabel))
            {
                resultTable.Columns.Add(ColumnName_NLPLabel);
            }

            foreach (DataRow row in resultTable.Rows)
            {
                string originalText = row[ColumnName_TranslatedText].ToString();

                if (originalText.Split().Length > 3)
                {
                    string mappedValue = MapToClosestStringAsync(originalText, labels);

                    Console.WriteLine($"Original: {originalText} => Mapped: {mappedValue}");

                    if (!string.IsNullOrWhiteSpace(mappedValue))
                    {
                        row[ColumnName_NLPLabel] = mappedValue;
                    }
                    else
                    {
                        row[ColumnName_NLPLabel] = row[currentCategoryColName];
                    }
                }
                else
                {
                    row[ColumnName_NLPLabel] = row[currentCategoryColName];
                }
            }

            return resultTable;
        }


        public string MapToClosestStringAsync(string text, string[] labels)
        {
            // Analyze the text using Google Cloud NLP API
            var document = Document.FromPlainText(text);
            var response = _languageServiceClient.AnalyzeEntities(document);

            // Extract keywords/entities from the text
            var entities = response.Entities.Select(entity => entity.Name).ToList();

            if (entities.Count > 0)
            {
                // Find the closest string from the list based on keyword matching
                string closestMatch = labels.OrderByDescending(item => GetSimilarityScore(entities, item)) 
                    .FirstOrDefault();

             
                return closestMatch ?? string.Empty;
            }
            else
            {
                return string.Empty;
            }
        }

        public int GetSimilarityScore(System.Collections.Generic.List<string> entities, string item)
        {
            int score = 0;
            foreach (var entity in entities)
            {
                if (item.Contains(entity, StringComparison.OrdinalIgnoreCase))
                {
                    score++;
                }
            }
            return score;
        }
    }
}
