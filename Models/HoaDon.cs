using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanSach.Models
{
    public class HoaDon
    {
        private string tensach;
        public string TenSach
        {
            get { return tensach; }
            set { tensach = value; }
        }
        private int giaban;
        public int GiaBan
        {
            get { return giaban; }
            set { giaban = value; }
        }
        private int soluong;
        public int SoLuong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        private int thanhtien;
        public int ThanhTien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
    }
}
