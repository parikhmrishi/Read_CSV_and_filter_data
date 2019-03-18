using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace read_csv
{
    public class Csv
    {
        List<String> data = null;

        public void Filter_location(string location)
        {
            data = File.ReadAllLines(@"..\..\..\records.csv").ToList();

            var records = from record in data
                          let rec = record.Split(',')
                          select new
                          {
                              Name = rec[1] + rec[2] + " " + rec[3] + " " + rec[4],
                              DOB = rec[10],
                              Location = rec[30],
                              Designation = rec[34]
                          };

            int flag = 0;

            foreach (var record in records)
            {
                if (string.Equals(record.Location, location, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(record.Name + "|" + record.DOB + "|" + record.Location + "|" + record.Designation);
                    flag = 1;
                }
            }
            Console.Read();

            if (flag == 0)
            {
                Console.WriteLine("No record exists");
                Console.Read();
            }
        }


        public void Filter_designation(string designation)
        {
            data = File.ReadAllLines(@"..\..\..\records.csv").ToList();

            var records = from record in data
                          let rec = record.Split(',')
                          select new
                          {
                              Name = rec[1] + rec[2] + " " + rec[3] + " " + rec[4],
                              DOB = rec[10],
                              Location = rec[30],
                              Designation = rec[34]
                          };

            int flag = 0;

            foreach (var record in records)
            {
                if (string.Equals(record.Designation, designation, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(record.Name + "|" + record.DOB + "|" + record.Location + "|" + record.Designation);
                    flag = 1;
                }
            }
            Console.Read();

            if (flag == 0)
            {
                Console.WriteLine("No record exists");
                Console.Read();
            }
        }


        public void Filter_date(String dob)
        {
            data = File.ReadAllLines(@"..\..\..\records.csv").ToList();

            var records = from record in data
                          let rec = record.Split(',')
                          select new
                          {
                              Name = rec[1] + rec[2] + " " + rec[3] + " " + rec[4],
                              DOB = rec[10],
                              Location = rec[30],
                              Designation = rec[34]
                          };

            int flag = 0;

            foreach (var record in records)
            {
                if (DateTime.Compare(DateTime.Parse(record.DOB),DateTime.Parse(dob))<=0)
                {
                    Console.WriteLine(record.Name + "|" + record.DOB + "|" + record.Location + "|" + record.Designation);
                    flag = 1;
                }
            }
            Console.Read();
            if (flag == 0)
            {
                Console.WriteLine("No record exists");
                Console.Read();
            }
        }
    }
}
