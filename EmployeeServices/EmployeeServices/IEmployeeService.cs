﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeService
    {

        [OperationContract]
        string GetData(int value);
        //MVC PART


        [OperationContract]
        DataSet GetAllUser();


        [OperationContract]
        int Insert(string _name, string _email, string _phone, string _gender);








        //MVC END
        [OperationContract]
        string AddEmployyeeRecord(Employee emp);

        [OperationContract]
        DataSet GetEmployeeRecords();

        [OperationContract]
        string DeleteRecords(Employee emp);

        [OperationContract]
        DataSet SearchEmployeeRecord(Employee emp);

        [OperationContract]
        string UpdateEmployeeContact(Employee emp);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Employee
    {

        int _empID;
        string _name = "";
        string _email = "";
        string _phone = "";
        string _gender = "";

        [DataMember]
        public int EmpID
        {
            get { return _empID; }
            set { _empID = value; }
        }

        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        [DataMember]
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        [DataMember]
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
    }
}
