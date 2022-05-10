using DevExpress.Utils.Extensions;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.GenelForms;
using OgrenciTakip.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.UI.Win.Forms.HizmetForms
{
    public partial class HizmetListForm : BaseListForm
    {
        #region Variables

        private readonly Expression<Func<Hizmet, bool>> _filter;

        #endregion

        public HizmetListForm()
        {
            InitializeComponent();
            Bll = new HizmetBll();
            _filter = x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.DonemParametreleri.SubeId && x.DonemId == AnaForm.DonemParametreleri.DonemId;
        }

        public HizmetListForm(params object[] prm) : this()
        {
            if (prm != null)
            {
                var panelGoster = (bool)prm[0];
                ustPanel.Visible = DateTime.Now.Date > AnaForm.DonemParametreleri.EgitimBaslamaTarihi && panelGoster;
            }

            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.SubeId == AnaForm.DonemParametreleri.SubeId && x.DonemId == AnaForm.DonemParametreleri.DonemId && x.Durum == AktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = view;
            BaseKartTuru = KartTuru.Hizmet;
            FormShow = new ShowEditForms<HizmetEditForm>();
            Navigator = longNavigator.Navigator;
            TarihAyarla();
        }

        protected override void Listele()
        {
            var list = ((HizmetBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())  //list te değer veya kayıt var ise
            {
                EklenebilecekEntityVar = true;
            }
            else
            {
                Messages.KartBulunamadiMesaji("Kart");
            }
        }

        private void TarihAyarla()
        {
            //(:)else if --- (?) ise
            //GunTarihininOncesineHizmetBaslamaTarihiGirilebilir true ise EgitimBaslamaTarihini ata. False ise ve şimdiki tarih EgitimBaslamaTarihinden küçük ise yine EgitimBaslamaTarihini ata. Hiçbiri değilse şimdiki tarihi ver.
            txtHizmetBaslamaTarihi.Properties.MinValue = AnaForm.DonemParametreleri.GunTarihininOncesineHizmetBaslamaTarihiGirilebilir ? AnaForm.DonemParametreleri.EgitimBaslamaTarihi : DateTime.Now.Date < AnaForm.DonemParametreleri.EgitimBaslamaTarihi ? AnaForm.DonemParametreleri.EgitimBaslamaTarihi : DateTime.Now.Date;
            txtHizmetBaslamaTarihi.Properties.MaxValue = AnaForm.DonemParametreleri.GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir ? AnaForm.DonemParametreleri.DonemBitisTarihi : DateTime.Now.Date < AnaForm.DonemParametreleri.EgitimBaslamaTarihi ? AnaForm.DonemParametreleri.EgitimBaslamaTarihi : DateTime.Now.Date > AnaForm.DonemParametreleri.DonemBitisTarihi ? AnaForm.DonemParametreleri.DonemBitisTarihi : DateTime.Now.Date;
            txtHizmetBaslamaTarihi.DateTime = DateTime.Now.Date <= AnaForm.DonemParametreleri.EgitimBaslamaTarihi ? AnaForm.DonemParametreleri.EgitimBaslamaTarihi : DateTime.Now.Date > AnaForm.DonemParametreleri.EgitimBaslamaTarihi && DateTime.Now.Date <= AnaForm.DonemParametreleri.DonemBitisTarihi ? DateTime.Now.Date : DateTime.Now.Date > AnaForm.DonemParametreleri.DonemBitisTarihi ? AnaForm.DonemParametreleri.DonemBitisTarihi : DateTime.Now.Date;
        }

        protected override void EntitySelect()
        {
            base.EntitySelect();

            if (MultiSelect)
            {
                SelectedEntities.ForEach(x => ((HizmetList)x).BaslamaTarihi = txtHizmetBaslamaTarihi.DateTime.Date);
            }
        }
    }
}