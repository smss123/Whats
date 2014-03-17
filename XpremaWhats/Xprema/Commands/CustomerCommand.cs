using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xprema.XdataType;
using Xprema.Data;
using System.Windows.Forms;

namespace Xprema.Commands
{
public     class CustomerCommand
    {

    public bool AddNewCustomer(Name CustomerName, PhoneNumber CustomerPhone, Email CustomerEmail)
    {
        try
        {
            XpremaFileManager cmd = new XpremaFileManager();
            Xdb.CustomersRow row = cmd.DB.Customers.NewCustomersRow();
            row.CustomerName = CustomerName.FullName;
            row.CreatedDate = DateTime.Now;
            row.CustomerEmail = CustomerEmail.FullEmail;
            row.CustomerPhone = CustomerPhone.FullPhoneNumber;
            cmd.DB.Customers.AddCustomersRow(row);
            cmd.CommitData();
            cmd.Dispose();
            return true;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }


    public bool EditCustomer(Name CustomerName, PhoneNumber CustomerPhone, Email CustomerEmail, int ID)
    {
        XpremaFileManager cmd = new XpremaFileManager();
        foreach (Data.Xdb.CustomersRow  item in cmd.DB.Customers.Rows)
        {
            if (item.ID==ID)
            {
                item.CustomerEmail = CustomerEmail.FullEmail;
                item.CustomerName = CustomerName.FullName;
                item.CustomerPhone = CustomerPhone.FullPhoneNumber;
                cmd.CommitData();
                Application.DoEvents();
                cmd.Dispose();
                return true;
            } 
        }
        return false;
    }

    public bool DeleteCustomer(int ID)
    {
        XpremaFileManager cmd = new XpremaFileManager();
        foreach (Data.Xdb.CustomersRow item in cmd.DB.Customers.Rows)
        {
            if (item.ID == ID)
            {
                item.Delete();
                cmd.CommitData();
                Application.DoEvents();
                cmd.Dispose();
                return true;
            }
        }
        return false;
    }

    public List<Data.Xdb.CustomersRow> GetAll()
    {
       XpremaFileManager cmd = new XpremaFileManager();
       var q = (from i  in cmd.DB.Customers.AsQueryable() select i).ToList();
       cmd.Dispose();
       return q;
        
    }


    public Data.Xdb.CustomersRow GetCustomerByID(int ID)
    {
        XpremaFileManager cmd = new XpremaFileManager();
        var q = (from i in cmd.DB.Customers where i.ID == ID select i).SingleOrDefault();
        cmd.Dispose();
        return q;

    }


    }
}
