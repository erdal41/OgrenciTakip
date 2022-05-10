using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BankaForms;
using OgrenciTakip.UI.Win.Forms.BankaHesapForms;
using OgrenciTakip.UI.Win.Forms.BankaSubeForms;
using OgrenciTakip.UI.Win.Forms.IptalNedeniForms;
using OgrenciTakip.UI.Win.Forms.KasaForms;
using OgrenciTakip.UI.Win.Forms.OkulForms;
using OgrenciTakip.UI.Win.Forms.YakinlikForms;
using OgrenciTakip.UI.Win.Show;
using System;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.Functions
{
    public static class SelectRepositoryFunctions
    {
        #region Variables

        private static GridView _tablo;
        private static ControlNavigator _navigator;
        private static RepositoryItemButtonEdit _buttonEdit;
        private static GridColumn _idColumn;
        private static GridColumn _nameColumn;
        private static GridColumn _prmIdColumn;
        private static GridColumn _prmNameColumn;

        #endregion

        #region Functions

        private static void RemoveEvent()
        {
            if (_buttonEdit == null) return;

            _buttonEdit.ButtonClick -= ButtonEdit_ButtonClick;
            _buttonEdit.KeyDown -= ButtonEdit_KeyDown;
            _buttonEdit.DoubleClick -= ButtonEdit_DoubleClick;
            _tablo.KeyDown -= Tablo_KeyDown;
        }

        public static void Sec(this GridColumn nameColumn, GridView tablo, ControlNavigator navigator, RepositoryItemButtonEdit buttonEdit, GridColumn idColumn)
        {
            RemoveEvent();

            _tablo = tablo;
            _navigator = navigator;
            _buttonEdit = buttonEdit;
            _idColumn = idColumn;
            _nameColumn = nameColumn;

            _buttonEdit.ButtonClick += ButtonEdit_ButtonClick;
            _buttonEdit.KeyDown += ButtonEdit_KeyDown;
            _buttonEdit.DoubleClick += ButtonEdit_DoubleClick;
            _tablo.KeyDown += Tablo_KeyDown;
        }

        public static void Sec(this GridColumn nameColumn, GridView tablo, ControlNavigator navigator, RepositoryItemButtonEdit buttonEdit, GridColumn idColumn, GridColumn prmIdColumn, GridColumn prmNameColumn)
        {
            RemoveEvent();

            _tablo = tablo;
            _navigator = navigator;
            _buttonEdit = buttonEdit;
            _idColumn = idColumn;
            _nameColumn = nameColumn;
            _prmIdColumn = prmIdColumn;
            _prmNameColumn = prmNameColumn;

            _buttonEdit.ButtonClick += ButtonEdit_ButtonClick;
            _buttonEdit.KeyDown += ButtonEdit_KeyDown;
            _buttonEdit.DoubleClick += ButtonEdit_DoubleClick;
            _tablo.KeyDown += Tablo_KeyDown;
        }

        private static void SecimYap()
        {
            switch (_buttonEdit.Name)
            {
                case "repositoryItemYakinlik":
                    {
                        var id = _tablo.GetRowCellId(_idColumn);
                        var entity = (Yakinlik)ShowListForms<YakinlikListForm>.ShowDialogListForm(KartTuru.Yakinlik, id);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.YakinlikAdi);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                        }
                    }
                    break;
                case "repositoryItemBanka":
                    {
                        if (!_nameColumn.OptionsColumn.AllowEdit) return;
                        var id = _tablo.GetRowCellId(_idColumn);
                        var entity = (BankaList)ShowListForms<BankaListForm>.ShowDialogListForm(KartTuru.Banka, id);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.BankaAdi);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                        }
                    }
                    break;
                case "repositoryItemBankaSube":
                    {
                        if (!_nameColumn.OptionsColumn.AllowEdit) return;
                        var id = _tablo.GetRowCellId(_idColumn);
                        var bankaId = _tablo.GetRowCellId(_prmIdColumn);
                        var bankaAdi = _tablo.GetFocusedRowCellValue(_prmNameColumn).ToString();
                        var entity = (BankaSube)ShowListForms<BankaSubeListForm>.ShowDialogListForm(KartTuru.BankaSube, id, bankaId, bankaAdi);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.BankaSubeAdi);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                        }
                    }
                    break;
                case "repositoryItemBankaHesap":
                    {
                        if (!_nameColumn.OptionsColumn.AllowEdit) return;
                        var id = _tablo.GetRowCellId(_idColumn);
                        var odemeTipi = _tablo.GetFocusedRowCellValue("OdemeTipi").ToString().GetEnum<OdemeTipi>();
                        var entity = (BankaHesapList)ShowListForms<BankaHesapListForm>.ShowDialogListForm(KartTuru.BankaHesap, id, odemeTipi);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.HesapAdi);
                            _tablo.SetFocusedRowCellValue("BlokeGunSayisi", entity.BlokeGunSayisi);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                        }
                    }
                    break;
                case "repositoryItemIptalNedeni":
                    {
                        if (!_nameColumn.OptionsColumn.AllowEdit) return;
                        var id = _tablo.GetRowCellId(_idColumn);
                        var entity = (IptalNedeni)ShowListForms<IptalNedeniListForm>.ShowDialogListForm(KartTuru.IptalNedeni, id);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.IptalNedeniAdi);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                        }
                    }
                    break;
                case "repositoryItemGittigiOkul":
                    {
                        if (!_nameColumn.OptionsColumn.AllowEdit) return;
                        var id = _tablo.GetRowCellId(_idColumn);
                        var entity = (OkulList)ShowListForms<OkulListForm>.ShowDialogListForm(KartTuru.Okul, id);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.OkulAdi);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                        }
                    }
                    break;
                case "repositoryItemHesap":
                    {
                        var id = _tablo.GetRowCellId(_idColumn);

                        switch (_tablo.GetRow<GeriOdemeBilgileriList>().HesapTuru)
                        {
                            case GeriOdemeHesapTuru.Banka:
                                var bankaHesapEntity = (BankaHesapList)ShowListForms<BankaHesapListForm>.ShowDialogListForm(KartTuru.BankaHesap, id, OdemeTipi.Elden);
                                if (bankaHesapEntity != null)
                                {
                                    _tablo.SetFocusedRowCellValue(_idColumn, bankaHesapEntity.Id);
                                    _tablo.SetFocusedRowCellValue(_nameColumn, bankaHesapEntity.HesapAdi);
                                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                                }
                                break;
                            case GeriOdemeHesapTuru.Kasa:
                                var kasaEntity = (KasaList)ShowListForms<KasaListForm>.ShowDialogListForm(KartTuru.Kasa, id);
                                if (kasaEntity != null)
                                {
                                    _tablo.SetFocusedRowCellValue(_idColumn, kasaEntity.Id);
                                    _tablo.SetFocusedRowCellValue(_nameColumn, kasaEntity.KasaAdi);
                                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                                }
                                break;
                        }
                    }
                    break;
            }
        }

        #endregion

        #region Events

        private static void ButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            SecimYap();
        }

        private static void ButtonEdit_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete when e.Control && e.Shift: //Ctrl+Shift+Delete yapınca aşağıdaki kolonlar boşalacak.
                    _tablo.SetFocusedRowCellValue(_idColumn, null);
                    _tablo.SetFocusedRowCellValue(_nameColumn, null);
                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                    break;
                case Keys.F4:
                case Keys.Down when e.Alt:
                    SecimYap();
                    break;
            }
        }

        private static void ButtonEdit_DoubleClick(object sender, EventArgs e)
        {
            SecimYap();
        }

        private static void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            if (_tablo.FocusedColumn.ColumnEdit == null) return;

            var type = _tablo.FocusedColumn.ColumnEdit.GetType();
            if (type != typeof(RepositoryItemButtonEdit)) return;

            switch (e.KeyCode)
            {
                case Keys.Delete when e.Control && e.Shift: //Ctrl+Shift+Delete yapınca aşağıdaki kolonlar boşalacak.
                    _tablo.SetFocusedRowCellValue(_idColumn, null);
                    _tablo.SetFocusedRowCellValue(_nameColumn, null);
                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                    break;
                case Keys.F4:
                case Keys.Down when e.Alt:
                    SecimYap();
                    break;
            }
        }

        #endregion

    }
}