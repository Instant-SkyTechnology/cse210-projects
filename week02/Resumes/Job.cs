using System;
public class Job
{
    public string _companyName;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public Job()
    {
        _companyName = "UnknownCampany";
        _jobTitle = "UnknownTitle";
        _startYear = 0000;
        _endYear = 0000;
    }

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear} - {_endYear}");
    }
}