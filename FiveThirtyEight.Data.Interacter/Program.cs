using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;

namespace FiveThirtyEightData.Interacter
{
    public class CollegeMajor
    {
        //Major_code,Major,Major_category,Total,Employed,Employed_full_time_year_round,Unemployed,Unemployment_rate,Median,P25th,P75th
    }



    class Program
    {
        static void Main(string[] args)
        {
            var csvFile = @"c:\users\nick\source\repos\FiveThirtyEight.Data.Interacter\FiveThirtyEight.Data.Interacter\Data\all-ages.csv";
            var textReader = new StreamReader(csvFile);
            var csvReader = new CsvReader(textReader);
            var records = csvReader.GetRecords<CollegeMajor>();

            foreach (CollegeMajor cm in records)
            {
                // do things
            }
        }
    }
}
