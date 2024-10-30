//{ 
//  "refresh": {
//    "type": „dataOnly",
//    "applyRefreshPolicy": true,
//    "effectiveDate": "02/01/2007",
//    "objects": [
//      {
//        "database": "Simple Incremental refresh - data", 
//        "table": "FactOnlineSales" 
//      }
//    ]
//  }
//}

//{
//  "refresh": {
//    "type": "calculate",
//    "objects": [
//      {
//        "database": "Simple Incremental refresh - data",
//        "table": "FactOnlineSales"
//      }
//    ]
//  }
//}


//because this is performing the initial load, the refresh type dataOnly is selected :-)
//do not forget to run a "calculate" AFTER the iteration across all effectiveDate(s), Calculated Columns and Partitions will be created
var type = "dataOnly";
var database = Model.Database.Name;
var table = "FactOnlineSales";
var effectiveDate = "02/01/2007"; //MM/DD/YYYY
var tmsl = "{ \"refresh\": { \"type\": \"%type%\", \"applyRefreshPolicy\": true,\"effectiveDate\": \"%effectiveDate%\" ,\"objects\": [ { \"database\": \"%db%\", \"table\": \"%table%\" } ] } }"
    .Replace("%type%", type)
    .Replace("%db%", database)
    .Replace("%table%", table)
    .Replace("%effectiveDate%", effectiveDate);

ExecuteCommand(tmsl);