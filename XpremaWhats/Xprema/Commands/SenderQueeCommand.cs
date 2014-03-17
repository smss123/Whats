using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xprema.Data;

namespace Xprema.Commands
{
public     class SenderQueeCommand
    {

    public bool AddSenderQuee(int AdvertiseID, string SerialNumberm, bool Status)
    {
        try
        {
            XpremaFileManager cmd = new XpremaFileManager();
            Xdb.SenderQueeRow row = cmd.DB.SenderQuee.NewSenderQueeRow();
            row.AdvertismentID = AdvertiseID;
            row.SerialNumber = SerialNumberm;
            row.Status = Status;
            cmd.DB.SenderQuee.AddSenderQueeRow(row);
            cmd.CommitData();
            return true;
        }
        catch (Exception ex)
        {

            throw ex;
        }

    }

    public bool EditSenderQuee(int AdvertiseID, string SerialNumberm, bool Status , int ID)
    {
        XpremaFileManager cmd = new XpremaFileManager();
        foreach (Xdb.SenderQueeRow  item in cmd.DB.SenderQuee.Rows)
        {
            if (item.ID==ID)
            {
                item.AdvertismentID = AdvertiseID;
                item.SerialNumber = SerialNumberm;
                item.Status = Status;
                cmd.CommitData();
                cmd.Dispose();
                return true;
            }
        }
        return false;
    }

    public bool DeleteSenderQuee(int ID)
    {
        XpremaFileManager cmd = new XpremaFileManager();
        foreach (Xdb.SenderQueeRow item in cmd.DB.SenderQuee.Rows)
        {
            if (item.ID == ID)
            {
                item.Delete();
                cmd.CommitData();
                cmd.Dispose();
                return true;
            }
        }
        return false;
    }

    public List<Data.Xdb.SenderQueeRow> GetAll()
    {
        XpremaFileManager cmd = new XpremaFileManager();
        var q = (from i in cmd.DB.SenderQuee.AsQueryable() select i).ToList();
        cmd.Dispose();
        return q;

    }

    public Data.Xdb.SenderQueeRow GetByID(int ID)
    {
        XpremaFileManager cmd = new XpremaFileManager();
        var q = (from i in cmd.DB.SenderQuee.AsQueryable() where i.ID ==ID select i).Take(1).SingleOrDefault();
        cmd.Dispose();
        return q;
    }


    }
}
