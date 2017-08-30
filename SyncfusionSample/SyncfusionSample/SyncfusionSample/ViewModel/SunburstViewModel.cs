using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncfusionSample
{
    public class SunburstViewModel
    {
        public ObservableCollection<SunburstModel> Data { get; set; }

        public SunburstViewModel()
        {
            Data = new ObservableCollection<SunburstModel>
        {
            new SunburstModel
            {
                Country = "America", JobDescription = "Sales",
                EmployeesCount = 70
            },
            new SunburstModel
            {
                Country = "America", JobDescription = "Technical",
                JobGroup = "Testers", EmployeesCount = 35
            },
            new SunburstModel
            {
                Country = "America", JobDescription = "Technical",
                JobGroup = "Developers", JobRole = "Windows", EmployeesCount = 105
            },
            new SunburstModel
            {
                Country = "America", JobDescription = "Technical",
                JobGroup = "Developers", JobRole = "Web", EmployeesCount = 40
            },
            new SunburstModel
            {
                Country = "America", JobDescription = "Management",
                EmployeesCount = 40
            },
            new SunburstModel
            {
                Country = "America", JobDescription = "Accounts",
                EmployeesCount = 60
            },
            new SunburstModel
            {
                Country = "India", JobDescription = "Technical",
                JobGroup = "Testers", EmployeesCount = 25
            },
            new SunburstModel
            {
                Country = "India", JobDescription = "Technical", JobGroup = "Developers",
            JobRole = "Windows", EmployeesCount = 155
            },
            new SunburstModel
            {
                Country = "India", JobDescription = "Technical", JobGroup = "Developers",
                JobRole = "Web", EmployeesCount = 60
            },
            new SunburstModel
            {
                Country = "Germany", JobDescription = "Sales", JobGroup = "Executive",
                EmployeesCount = 30
            },
            new SunburstModel
            {
                Country = "Germany", JobDescription = "Sales", JobGroup = "Analyst",
                EmployeesCount = 40
            },
            new SunburstModel
            {
                Country = "UK", JobDescription = "Technical", JobGroup = "Developers",
                JobRole = "Windows", EmployeesCount = 100
            },
            new SunburstModel
            {
                Country = "UK", JobDescription = "Technical", JobGroup = "Developers",
                JobRole = "Web", EmployeesCount = 30
            },
            new SunburstModel
            {
                Country = "UK", JobDescription = "HR Executives", EmployeesCount = 60
            },
            new SunburstModel
            {
                Country = "UK", JobDescription = "Marketing", EmployeesCount = 40
            }
        };
        }
    }
}
