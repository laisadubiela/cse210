using System;

 public class Job
    {
        public string _jobTitle { get; set; }
        public string _company { get; set; }
        public int _startYear { get; set; }
        public int _endYear { get; set; }

        public void DisplayJob()
        {
            Console.WriteLine($"{_jobTitle}  ({_company}) {_startYear}-{_endYear}");
        }
    }

    