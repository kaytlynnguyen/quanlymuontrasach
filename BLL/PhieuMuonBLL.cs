using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class PhieuMuonBLL
    {
        private CuonSachDAL MaSachDAL = new CuonSachDAL();
        private DocgiaDAL docGiaDAL = new DocgiaDAL();
        private PhieuMuonDAL phieuMuonDAL = new PhieuMuonDAL();

        public TuaSach GetCuonSach(string maCuonSach)
        {
            return MaSachDAL.GetCuonSachById(maCuonSach);
        }

        public DocGia GetDocGia(string maDocGia)
        {
            return docGiaDAL.GetDocGiaById(maDocGia);
        }

        public bool CreatePhieuMuon(PhieuMuon phieuMuon)
        {
            return phieuMuonDAL.AddPhieuMuon(phieuMuon);
        }
    }
}

