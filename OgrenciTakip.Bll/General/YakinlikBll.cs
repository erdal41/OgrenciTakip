﻿using OgrenciTakip.Bll.Base;
using OgrenciTakip.Bll.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Bll.General
{
    public class YakinlikBll : BaseGenelBll<Yakinlik>, IBaseGenelBll, IBaseCommonBll
    {
        public YakinlikBll() : base(KartTuru.Yakinlik) { }

        public YakinlikBll(Control ctrl) : base(ctrl, KartTuru.Yakinlik) { }
    }
}