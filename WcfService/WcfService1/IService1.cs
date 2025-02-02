﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int register(string username,string password,string email);

        [OperationContract]
        int login(string username, string password,string adres,string sipariş);

        [OperationContract]
        int şifre_değiştir(string username, string password, string yeni_şifre);

        // TODO: Add your service operations here
    }
   
}
