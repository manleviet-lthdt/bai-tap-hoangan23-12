using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2lon
{
    class Grid
    {
        public Duyet KieuDuyet;
        private int cot;
        private int hang;
        public int Hang
        { get { retrun hang; }

          set { hang = value; }
            {
         public int Cot
        {
            get { return cot; }
            set { cot = value; }
         public Gird( int hang, int cot, Duyet Kieu)
        {
            KieuDuyet = Kieu;
            Hang = hang;
            Cot = cot;
        }
        public static void GanTacTu(ref Grid luoi, int kieuluoi, double chisohp, int X, int O)
        {
            Cell o;
            if (kieuluoi == 1)
            {
                o = new SingleCell();
            }
            else
            {
                o = new MultCell();
            }
            Random random = new Random();
            int dem;
            if (o is SingleCell)
            {
                int chieudai = luoi.Hang; int chieurong = luoi.Cot;
                int hang; int cot;
                List<int> list = new List<int>();
                for (int i = 0; i < luoi.Hang; i++)
                {
                    for (int j = 0; j < luoi.Cot; j++)
                    {
                        luoi[i, j] = new SingleCell();
                    }
                }
                dem = 0;
                while (dem < O)
                {
                    hang = random.Next(chieudai);
                    cot = random.Next(chieurong);
                    Agent b = luoi[hang, cot].DemTacTuDon();
                    if (b == null)
                    {
                        luoi[hang, cot].TaoTacTu(new TacTuO(chisohp)); dem++;
                    }

                }
                dem = 0;
                while (dem < X)
                {
                    hang = random.Next(chieudai);
                    cot = random.Next(chieurong);
                    Agent b = luoi[hang, cot].DemTacTuDon();
                    if (b == null)
                    {
                        luoi[hang, cot].TaoTacTu(new TacTuX(chisohp)); dem++;
                    }
                }
            }
            if (o is MultCell)
            {
                for (int i = 0; i < luoi.Hang; i++)
                {
                    for (int j = 0; j < luoi.Cot; j++)
                    {
                        luoi[i, j] = new MultCell();
                    }
                }
                dem = 0;
                while (dem < O)
                {
                    int hang = random.Next(luoi.Hang);
                    int cot = random.Next(luoi.Cot);
                    luoi[hang, cot].TaoTacTu(new TacTuO(chisohp)); dem++;
                }
                dem = 0;
                while (dem < X)
                {
                    int hang = random.Next(luoi.Hang);
                    int cot = random.Next(luoi.Cot);
                    luoi[hang, cot].TaoTacTu(new TacTuX(chisohp)); dem++;
                }
            }
        }
    }
}

