using OgrenciTakip.Bll.Base;
using OgrenciTakip.Bll.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Bll.General
{
    public class BankaSubeBll : BaseGenelBll<BankaSube>, IBaseCommonBll
    {
        public BankaSubeBll() : base(KartTuru.BankaSube) { }

        public BankaSubeBll(Control ctrl) : base(ctrl, KartTuru.BankaSube) { }
    }
}