using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xprema.XdataType;

namespace Xprema.Commands
{
public     class SenderNumberCommand
    {


    public bool AddSender( PhoneNumber phone , string Password, int numberOfMessageInDay ,bool status )
    {
        throw  new NotImplementedException();
    }

    public bool EditSender( PhoneNumber phone , string Password, int numberOfMessageInDay ,bool status)
    {
        throw new NotImplementedException();
    }

    public bool DeleteSender(int ID)
    {

    }

    public List<Data.Xdb.SenderNumberRow> GetAll()
    {
        throw new NotImplementedException();
    }

    public Data.Xdb.SenderNumberRow GetById(int ID)
    {
        throw new NotImplementedException();
    }


    }
}
