using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_InpuOutput
    {

        public List<InputOutputEntity> InpuOutputList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }

        public void CreateInpuOutput(InputOutputEntity oInOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Add(oInOutput);
                db.SaveChanges();
            }
        }

        public void UpdateInpuOutput(InputOutputEntity oInOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Update(oInOutput);
                db.SaveChanges();
            }
        }

        public void DeleteInpuOutput(InputOutputEntity oInOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Remove(oInOutput);
                db.SaveChanges();
            }
        }

    }
}
