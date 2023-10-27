using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfAboutDal : GenericRepository<About>, IAboutDal //İlerleyen aşamalarda CRUD operasyonların dışında ayrı bir işlem gerçekleştirmek gerekirse ve bu işlem sadece ilgili entitye ait olursa onun içi burda doldurulacak. imzası aboutdal'da atıcaz içini burda doldurucağız. IAboutDal için açıklama//
    {
    }
}
