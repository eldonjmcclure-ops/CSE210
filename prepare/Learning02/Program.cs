using System;

class Program
{
    static void Main(string[] args)
    {
        Job newJob = new Job();
        newJob._jobTitle = "Head Engineer";
        newJob._company = "Endfield Industries";
        newJob._startYear = 2040;
        newJob._endYear = 2498;

        Job newJob2 = new Job();
        newJob2._jobTitle = "Evil Scientist";
        newJob2._company = "Doofenschmirtz Evil Inc.";
        newJob2._startYear = 2020;
        newJob2._endYear = 2034;

        Resume newResume = new Resume();
        newResume._name = "Allison";
        newResume._jobList.Add(newJob);
        newResume._jobList.Add(newJob2);
        
        newResume.DisplayList();
    }
}