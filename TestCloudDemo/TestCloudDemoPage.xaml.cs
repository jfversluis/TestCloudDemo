using Xamarin.Forms;

namespace TestCloudDemo
{
    public partial class TestCloudDemoPage : ContentPage
    {
        public TestCloudDemoPage ()
        {
            InitializeComponent ();
        }

        void Succeed_Clicked (object sender, System.EventArgs e)
        {
            ResultLabel.Text = "Hooray!";
            ResultLabel.TextColor = Color.Green;
        }

        void Failed_Clicked (object sender, System.EventArgs e)
        {
            ResultLabel.Text = "Whoops, that is embarrassing";
            ResultLabel.TextColor = Color.Red;
        }
    }
}
