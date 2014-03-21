using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xprema.XdataType;
using Xprema.Data;
namespace Xprema.Commands
{
public     class SenderNumberCommand
    {


    public bool AddSender( PhoneNumber phone , string Password, int numberOfMessageInDay ,bool status, int counter )
    {
        try
        {
            XpremaFileManager cmd = new XpremaFileManager();
            Xdb.SenderNumberRow row = cmd.DB.SenderNumber.NewSenderNumberRow();
            row.SenderNumber = phone.FullPhoneNumber;
            row.Password = Password;
            row.NumberOfMessageInDay = numberOfMessageInDay.ToString();
            row.Counter = counter;
            row.Status = status;
            cmd.CommitData();
            return true;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public bool EditSender( PhoneNumber phone , string Password, int numberOfMessageInDay ,bool status, int ID, int counter)
    {
        XpremaFileManager cmd = new XpremaFileManager();
        foreach (Xdb.SenderNumberRow  item in cmd.DB.SenderNumber.Rows) 
        {
            if (item.ID==ID.ToString())
            {
                item.SenderNumber = phone.FullPhoneNumber;
                item.Password = Password;
                item.NumberOfMessageInDay = numberOfMessageInDay.ToString();
                item.Status = status;
                item.Counter = counter;
                cmd.CommitData();
                cmd.Dispose();
                return true;
            }
        }
        return false;
    }

    public bool DeleteSender(int ID)
    {
        XpremaFileManager cmd = new XpremaFileManager();
        foreach (Xdb.SenderNumberRow item in cmd.DB.SenderNumber.Rows)
        {
            if (item.ID == ID.ToString())
            {
                item.Delete();
                cmd.CommitData();
                cmd.Dispose();
                return true;
            }
        }
        return false;
    }

    public List<Data.Xdb.SenderNumberRow> GetAll()
    {
        XpremaFileManager cmd = new XpremaFileManager();
        var q = (from i in cmd.DB.SenderNumber.AsQueryable() select i).ToList();
        return q;
    }

    public Data.Xdb.SenderNumberRow GetById(int ID)
    {
        XpremaFileManager cmd = new XpremaFileManager();
        var q = (from i in cmd.DB.SenderNumber.AsQueryable() where i.ID ==ID.ToString() select i).Take(1).SingleOrDefault();
        return q;
    }
    

    }
}
