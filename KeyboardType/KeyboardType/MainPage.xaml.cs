using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KeyboardType
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void entryUsername_Completed(object sender, EventArgs e)
        {
            entryPassword.Focus();
        }

        private void entryPassword_Completed(object sender, EventArgs e)
        {

        }
    }
}
