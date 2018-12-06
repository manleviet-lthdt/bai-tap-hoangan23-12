using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2lon
{
    class Cell
    {
        public Cell() { }
        public virtual void TaoTacTu(Agent a) { }
        public virtual void ThemTacTu(Agent a) { }
        public virtual void XoaTacTu(Agent a) { }
    }
}
