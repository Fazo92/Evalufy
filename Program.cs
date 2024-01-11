using System;
using EvalSource;
using Newtonsoft;
using Newtonsoft.Json;
using System.Collections;
static string [] SplitJsonString (string jsonString, int chunkSize)
{
    int length = jsonString.Length;
    int numChunks = (int)Math.Ceiling ((double)length / chunkSize);

    string [] chunks = new string [numChunks];

    for (int i = 0; i < numChunks; i++)
    {
        int startIndex = i * chunkSize;
        int endIndex = Math.Min (startIndex + chunkSize, length);

        chunks [i] = jsonString.Substring (startIndex, endIndex - startIndex);
    }

    return chunks;
}
String APIKEY = "5479a0f57aee3383b7c682ff3920eb0d";

String sJsonDir = "C:\\Users\\Farzad.Moshref\\Downloads\\Vollständige JSON Files";
String sPathToFinancialStatement = Path.Combine (sJsonDir, "AllCashFlowStatements.json");

//WriteInFiles (jsonString, "AllCashFlowStatements");
var financialStatement = JsonConvert.DeserializeObject<List<FinancialStatement>> (File.ReadAllText ("chunk_1.json"));
var cashFlowInfo = JsonConvert.DeserializeObject<List<CashFlowInfo>> (File.ReadAllText ("AlLCashFlowStatements_1.json"));
var balanceSheetInfo = JsonConvert.DeserializeObject<List<BalanceSheetInfo>> (File.ReadAllText ("BalanceSheet_1.json"));

String sTest = financialStatement.First ().Symbol;

static void WriteInFiles (string jsonString, String x_sPreFix)
{
    // Split the JSON string into chunks
    int chunkSize = jsonString.Length / 10;

    string [] chunks = SplitJsonString (jsonString, chunkSize);

    // Write each chunk into separate files
    for (int i = 0; i < chunks.Length; i++)
    {
        string chunkFilePath = $"{x_sPreFix}_{i + 1}.json";
        File.WriteAllText (chunkFilePath, chunks [i]);
    }
}