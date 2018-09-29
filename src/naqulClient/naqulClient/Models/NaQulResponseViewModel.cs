using System;
using System.Collections.Generic;
using System.Data;

namespace naqulClient.Models
{
    public class NaQulResponseViewModel
    {
        public NaQulResponseViewModel()
        {
            Results = new List<Result>();
        }

        public string Message { get; set; }

        public string Text { get; set; }

        public List<Result> Results{get;set;}
    }

    public class Result { 

        public Result(string query , DataTable data)
        {
            Query = query;
            Data = data;
        }

        public string Query { get; set; }

        public DataTable Data { get; set; }

    }
}
