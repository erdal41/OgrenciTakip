using DevExpress.XtraGrid.Views.Base;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Forms.FaturaForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System;
using System.Linq;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.FaturaEditFormTable
{
    public partial class FaturaPlaniTable : BaseTablo
    {
        public FaturaPlaniTable()
        {
            InitializeComponent();
            Bll = new FaturaBll();
            Tablo = view;
            EventsLoad();
        }

        #region Functions

        protected internal override void Listele()
        {
            //gelen listeyi tobindingliste dönüştürdük.
            view.GridControl.DataSource = ((FaturaBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<FaturaPlaniList>();
        }

        protected override void HareketEkle()
        {
            var alinanHizmetlerSource = ((FaturaPlaniEditForm)OwnerForm).view.DataController.ListSource.Cast<FaturaAlinanHizmetlerList>().ToList();
            var faturaPlaniSource = view.DataController.ListSource;

            if (!ShowEditForms<TopluFaturaPlaniEditForm>.ShowDialogEditForm(KartTuru.Fatura, alinanHizmetlerSource, faturaPlaniSource)) return;

            view.Focus();
            view.RefreshDataSource();
            view.FocusedRowHandle = view.DataRowCount - 1;
            view.FocusedColumn = colAciklama;
            ButtonEnabledDurumu(true);
        }

        protected override void HareketSil()
        {
            var entity = view.GetRow<FaturaPlaniList>();
            if (entity == null) return;

            if (!colPlanTarih.OptionsColumn.AllowEdit)
            {
                Messages.HataMesaji("Hareket görmüş fatura planları silinemez.");
                return;
            }

            base.HareketSil();
        }

        protected override void RowCellAllowEdit()
        {
            if (view.DataRowCount == 0) return;
            var entity = view.GetRow<FaturaPlaniList>();
            if (entity == null) return;

            colAciklama.OptionsColumn.AllowEdit = entity.TahakkukTarih == null;
            colPlanTarih.OptionsColumn.AllowEdit = entity.TahakkukTarih == null;
            colPlanTutari.OptionsColumn.AllowEdit = entity.TahakkukTarih == null;
            colPlanIndirimTutari.OptionsColumn.AllowEdit = entity.TahakkukTarih == null;
        }

        #endregion

        #region Events

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var entity = view.GetRow<FaturaPlaniList>();
            if (entity == null) return;

            if (e.Column == colPlanTutari || e.Column == colPlanIndirimTutari)
            {
                entity.PlanNetTutar = entity.PlanTutari - entity.PlanIndirimTutari;
            }

            entity.Update = true;
            ButtonEnabledDurumu(true);
        }

        protected override void Tablo_RowCountChanged(object sender, EventArgs e)
        {
            OwnerForm.btnSil.Enabled = view.DataController.ListSource.Cast<FaturaPlaniList>().Where(x => !x.Delete).ToList().Any();
        }

        #endregion
    }
}