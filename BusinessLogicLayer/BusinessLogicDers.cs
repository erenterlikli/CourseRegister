using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BusinessLogicDers
    {
        public static List<EntityDers> BLLListe()
        {
            return DataAccessDers.DersListesi();
        }

        public static int DersTalebiBLL(EntityBasvuru p1)
        {
            if(p1.OgrId1!=null && p1.DersId1!=null)
            {
                return DataAccessDers.DersTalebi(p1);
            }

            return -1;
        }
    }
}
