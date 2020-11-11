using System.Text;
using System.Linq;
using DO_AN_1.Utility;
using DO_AN_1.Presenation;
using DO_AN_1.DataAccessLayer;

namespace DO_AN_1.Business.BLL
{
    class Bsinhvien
    {
        DALsinhvien DALSV = new DALsinhvien();
        public list<Sinhvien> SV()
        {
            list<Sinhvien> sv = DALSV.readlist("Data/Sinhvien.txt");
            return sv;
        }
    }
}
