﻿using OgrenciTakip.Bll.Base;
using OgrenciTakip.Bll.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Bll.General
{
    public class GorevBll : BaseGenelBll<Gorev>, IBaseGenelBll, IBaseCommonBll
    {
        public GorevBll() : base(KartTuru.Gorev) { }

        public GorevBll(Control ctrl) : base(ctrl, KartTuru.Gorev) { }
    }
}