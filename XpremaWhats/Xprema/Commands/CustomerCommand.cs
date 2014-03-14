using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xprema.XdataType;

namespace Xprema.Commands
{
public     class CustomerCommand
    {

    public bool AddNewCustomer(Name CustomerName, PhoneNumber CustomerPhone, Email CustomerEmail)
    {
        throw new NotImplementedException();
    }


    public bool EditCustomer(Name CustomerName, PhoneNumber CustomerPhone, Email CustomerEmail, int ID)
    {
        throw new NotImplementedException();
    }

    public bool DeleteCustomer(int ID)
    {
        throw new NotImplementedException();
    }

    public List<Data.Xdb.CustomersRow> GetAll()
    {
        throw new NotImplementedException();
    }


    public Data.Xdb.CustomersRow GetCustomerByID(int ID)
    {
        throw new NotImplementedException();
    }


    }
}
