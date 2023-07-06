using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanSach.Models
{
    public class NhaCungCap
    {
        private string mancc;
        public string MaNCC
        {
            get { return mancc; }
            set { mancc = value; }
        }

        private string tenncc;
        public string TenNCC
        {
            get { return tenncc; }
            set { tenncc = value; }
        }

        private string diachi;
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        private string sdt;
        public string SDT
        {
            get { return sdt; }
            set
            {
                sdt = value;
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }
    }
}
