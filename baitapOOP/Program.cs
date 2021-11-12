using System;

namespace baitapOOP
{
    class Phanso
    {
        public int tuso;
        public int mauso;
        public Phanso() //ham khoi tao khong tham so
        {
            tuso = 0;
            mauso = 1;
        }
        public Phanso(int t, int m) //khoi tao hai tham so
        {
            tuso = t;
            mauso = m;
        }
        ~Phanso() { }//ham huy
        public void nhap()
        {
            Console.WriteLine("nhap tu: ");
            tuso = Int32.Parse(Console.ReadLine());
            Console.WriteLine("nhap mau: ");
            mauso = Int32.Parse(Console.ReadLine());
        }
        public void xuat() 
        {
            Console.WriteLine("{0}/{1}", tuso, mauso);
        }
        public Phanso Cong(Phanso ps10) 
        {
            int ts = tuso * ps10.mauso + mauso * ps10.tuso;
            int ms = mauso * ps10.mauso;
            Phanso ketqua = new Phanso(ts, ms);
            return (ketqua);
        }
        public Phanso Tru(Phanso ps1)
        {
            int ts = tuso * ps1.mauso - mauso * ps1.tuso;
            int ms = mauso * ps1.mauso;
            Phanso ketqua = new Phanso(ts, ms);
            return (ketqua);
        }
        public Phanso Nhan(Phanso ps1)
        {
            int ts = tuso * ps1.tuso;
            int ms = mauso * ps1.mauso;
            Phanso ketqua = new Phanso(ts, ms);
            return (ketqua);
        }
        public Phanso Chia(Phanso ps1)
        {
            int ts = tuso * ps1.mauso;
            int ms = mauso * ps1.tuso;
            Phanso ketqua = new Phanso(ts, ms);
            return (ketqua);
        }
        public Phanso RutGon()
        {
            int ts = tuso;
            int ms = mauso;
            while (tuso != mauso)
                if (tuso > mauso) tuso = tuso - mauso;
                else mauso = mauso - tuso;
            ts = ts / tuso; 
            ms = ms / tuso;
            Phanso ketqua = new Phanso(ts, ms);
            return (ketqua);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Phanso ps = new Phanso();

            //khoi tao 2 phan so
            Phanso obj1 = new Phanso();
            Phanso obj2 = new Phanso();

            //nhap phan so
            obj1.nhap();
            obj2.nhap();

            //xuat phan so
            Console.Write("Phan so thu nhat = ");
            obj1.xuat();
            Console.Write("Phan so thu hai = ");
            obj2.xuat();

            //cong phan so
            ps = obj1.Cong(obj2);
            Console.Write("Tong cua hai phan so : ");
            //ps.RutGon();
            ps.xuat();

            //tru phan so
            ps = obj1.Tru(obj2);
            Console.Write("hieu cua hai phan so : ");
            //ps.RutGon();
            ps.xuat();

            //nhan phan so
            ps = obj1.Nhan(obj2);
            Console.Write("tich cua hai phan so : ");
            ps.RutGon();
            ps.xuat();

            //chia phan so
            ps = obj1.Chia(obj2);
            Console.Write("thuong cua hai phan so : ");
            ps.RutGon();
            ps.xuat();
        }
    }
}
