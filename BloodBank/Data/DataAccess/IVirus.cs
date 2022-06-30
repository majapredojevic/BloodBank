﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBank.Data.Model;
namespace BloodBank.Data.DataAccess
{
   public interface IVirus
    {
        List<Virus> GetViruses(string filter);
        void InsertVirus(Virus virus);
        void UpdateVirus(Virus virus);
        void DeleteVirusById(int id);
    }
}


