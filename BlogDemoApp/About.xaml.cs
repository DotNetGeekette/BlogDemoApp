using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using Microsoft.Phone.Tasks;

namespace BlogDemoApp
{
    public partial class About : PhoneApplicationPage
    {
        public About()
        {
            InitializeComponent();
        }

        public void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        /*

        public void EmailBtn_Click(object sender, RoutedEventArgs e)
        {
            var emailer = new EmailComposeTask();
            emailer.To = "jamie@dotnetgeekette.com";
            emailer.Subject = "Sample App Inquiry";
            emailer.Show();
        }

        public void ReviewBtn_Click(object sender, RoutedEventArgs e)
        {
            var reviewer = new MarketplaceReviewTask();
            reviewer.Show();
        }

        public void OtherAppsBtn_Click(object sender, RoutedEventArgs e)
        {
            var searcher = new MarketplaceSearchTask();
            searcher.SearchTerms = "Jerrel Blankenship";
            searcher.Show();
        }
         * 
         */

    
    }
}