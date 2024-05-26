using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using YGate.Shared.Concretes;
namespace YGate.Client
{
    public class StaticInformation
    {
        public IJSRuntime jsRuntime { get; set; }
        public StaticInformation(IJSRuntime _jsRuntime)
        {
            jsRuntime = _jsRuntime;
        }

        public async void MesajGoster(string Mesajiniz)
        {
            jsRuntime.InvokeAsync<string>("MesajKutusuGoster", new object[] { Mesajiniz });
        }

        public NavigationMenuSettings ActiveMenuSettings { get; set; } = new NavigationMenuSettings();
        public PosPageSettings AcivePosSettings { get; set; } = new PosPageSettings();

        public void ShowAlert(string mesa)
        {
            this.Mesajiniz = mesa;
            this.ActiveMenuSettings.LayoutStateHasChange.Invoke();
        }

        public void HideAlert()
        {
            this.Mesajiniz = "";
            this.ActiveMenuSettings.LayoutStateHasChange.Invoke();
        }

        public string Mesajiniz { get; set; } = "";
        public ProcessToken MyToken { get; set; }
    }
    public class PosPageSettings
    {
        public int LastRegionID { get; set; } = -1;
    }
    public class NavigationMenuSettings
    {
        private double _price { get; set; } = 0;
        public double Price { get { return _price; } set { _price = value; LayoutAndNavmenuStateHasChangeInvok(); } }

        private double _discount { get; set; } = 0;
        public double Discount { get { return _discount; } set { _discount = value; LayoutAndNavmenuStateHasChangeInvok(); } }

        private double _payed { get; set; } = 0;
        public double Payed { get { return _payed; } set { _payed = value; LayoutAndNavmenuStateHasChangeInvok(); } }


        private int _selectedsalesItem = -1;
        public int SelectedSalesItem { get { return _selectedsalesItem; } set { _selectedsalesItem = value; NavMenuStateHasChangeInvoke(); } }

        public int TransferItem { get; set; } = -1;
        public int TransferPoint { get; set; } = -1;
        public bool TransferOperation { get; set; } = false;

        public Action LayoutStateHasChange { get; set; }
        public Action NavMenuStateHasChange { get; set; }

        public NavigationMenuType MenuType { get; set; }

        private void LayoutAndNavmenuStateHasChangeInvok() {
            NavMenuStateHasChangeInvoke();
            LayoutStateHashChange();
        }


        private void LayoutStateHashChange()
        {
            if (LayoutStateHasChange == null)
                return;

            LayoutStateHasChange.Invoke();
        }

        private void NavMenuStateHasChangeInvoke()
        {
            if (NavMenuStateHasChange == null)
                return;

            NavMenuStateHasChange.Invoke();
        }
    }
    public enum NavigationMenuType { 
        PosPage,
        PosDetail,
        PayPage
    }
}
