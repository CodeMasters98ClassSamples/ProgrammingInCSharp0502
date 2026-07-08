using Newtonsoft.Json;
using ProgrammingInCSharp0502.Domain.Contracts;
using System.Diagnostics;

namespace ProgrammingInCSharp0502.Domain;

//rich domain VS anemic domain

[DebuggerDisplay("Student {Id}: {FirstName} {LastName} with Code= {Code} .")]
public class Student : IFullEntity<long>
{
    void TestAccess()
    {

    }

    public Student() { }

    //public Student(string firstName, string lastName, string nationalCode, string phone)
    //{

    //    //Business Rule
    //    if (nationalCode.Length != 10)
    //        throw new Exception(message: "کد مدلی را درست وارد نمایید.");

    //    if (string.IsNullOrEmpty(firstName) || firstName.Length <= 2)
    //        throw new Exception(message: "نام را درست وارد نمایید.");

    //    if (string.IsNullOrEmpty(lastName) || lastName.Length <= 2)
    //        throw new Exception(message: "نام خانوادگی را درست وارد نمایید.");

    //    if (string.IsNullOrEmpty(phone) || phone.Length != 11)
    //        throw new Exception(message: "شماره همراه را درست وارد نمایید.");

    //    NationalCode = nationalCode;
    //    FirstName = firstName;
    //    LastName = lastName;
    //    Phone = phone;
    //}

    //auto generated
    public long Id { get; set; }

    [JsonProperty]
    public string FirstName { get; private set; }

    [JsonProperty]
    public string LastName { get; private set; }

    [JsonProperty]
    public string Phone { get; private set; }
    public string NationalCode { get; private set; }
    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
    public string FullName { get {
            return FirstName + " " + LastName;    
        } 
    }

    //auto generated
    public string Code { get; set; }    
    public Address Address { get; set; }

    public void UpdateFirstName(string firstName)
    {
        if (string.IsNullOrEmpty(firstName) || firstName.Length <= 2)
            throw new Exception(message: "نام را درست وارد نمایید.");

        FirstName = firstName;
    }

    public void UpdateLastName(string lastName)
    {
        TestAccess();
        if (string.IsNullOrEmpty(lastName) || lastName.Length <= 2)
            throw new Exception(message: "نام را درست وارد نمایید.");

        LastName = lastName;
    }

    public static Student RegisterUser(string firstName, string lastName, string nationalCode, string phone)
    {
        //Business Rule
        if (nationalCode.Length != 10)
            throw new Exception(message: "کد مدلی را درست وارد نمایید.");

        if (string.IsNullOrEmpty(firstName) || firstName.Length <= 2)
            throw new Exception(message: "نام را درست وارد نمایید.");

        if (string.IsNullOrEmpty(lastName) || lastName.Length <= 2)
            throw new Exception(message: "نام خانوادگی را درست وارد نمایید.");

        if (string.IsNullOrEmpty(phone) || phone.Length != 11)
            throw new Exception(message: "شماره همراه را درست وارد نمایید.");

        //var rnd = new Random();
        //var rndId = rnd.Next(100, 10000);

        return new Student
        {
            Id = new Random().Next(100, 10000),
            Code = Guid.NewGuid().ToString().Substring(0,10),
            NationalCode = nationalCode,
            FirstName = firstName,
            LastName = lastName,
            Phone = phone
        };
    }


}
