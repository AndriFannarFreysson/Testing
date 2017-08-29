using Testing.Views;
using Xamarin.Forms;

namespace Testing
{
    public partial class TestingPage : MasterDetailPage
    {
        //Andri Fannar
        public TestingPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new Page1());

            IsPresented = false;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Page1());
			IsPresented = false;
        }

		void Handle_Clicked2(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage(new Page2());
			IsPresented = false;
		}
    }
}
