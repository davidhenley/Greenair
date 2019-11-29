using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ApplicationCore.Interfaces;
using System;
namespace ApplicationCore.Entities
{
    public class Employer : Person, IAggregateRoot
    {
        public Employer() : base() { }

        public Employer(string id, string lastName, string firstName, DateTime birthDate, string phone, Address address,
                STATUS status, Account account, double salary, string jobId) : base(id, lastName, firstName, birthDate, phone, address, status, account)
        {
            this.Salary = salary;
            this.JobId = jobId; ;
        }

        public Employer(string id, string lastName, string firstName, DateTime birthDate, string phone, Address address, Account account,
                double salary, string jobId) : base(id, lastName, firstName, birthDate, phone, address, account)
        {
            this.Salary = salary;
            this.JobId = jobId; ;
        }
        public double Salary { get; set; }

        public string JobId { get; set; }
        public Job Job { get; set; }


    }
}