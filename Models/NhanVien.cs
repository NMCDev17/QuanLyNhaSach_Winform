using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanSach.Models
{
    public class NhanVien
    {
        private string manv;
        public string MaNV
        {
            get { return manv; }
            set { manv = value; }
        }

        private string tennv;
        public string TenNV
        {
            get { return tennv; }
            set { tennv = value; }
        }

        private string gioitinh;
        public string GioiTinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }

        private DateTime namsinh;
        public DateTime NamSinh
        {
            get { return namsinh; }
            set { namsinh = value; }
        }

        private string sdt;
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        private string quequan;
        public string QueQuan
        {
            get { return quequan; }
            set { quequan = value; }
        }
    }
}
