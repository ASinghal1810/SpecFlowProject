using SpecflowProject1.Pages.MasterPage;
using SpecflowProject1.Pages.MasterPage.Login;
using System;
using TechTalk.SpecFlow;

namespace SpecflowProject1.Pages.HomePage.Components.Dashboard
{
    [Binding]
    public class NotificationFeatureStepDefinitions
    {
        MarsMasterPage MarsMasterPageObj;
        MarsHomePage MarsHomePageObj;
        LoginMethodPassword LoginMethodPassObj;
        LoginMethodUsername LoginMethodUserObj;
        Notification NotificationObj;
        public NotificationFeatureStepDefinitions()
        {
            MarsHomePageObj = new MarsHomePage();
            MarsMasterPageObj = new MarsMasterPage();
            LoginMethodPassObj = new LoginMethodPassword();
            LoginMethodUserObj = new LoginMethodUsername();
            NotificationObj = new Notification();
        }

     

        
        [Given(@"I logged on to Portal Successfully")]
        public void GivenILoggedOnToPortalSuccessfully()
        {
            MarsMasterPageObj.MarsMasterPageNavigateToSignInForm();

            MarsMasterPageObj.MarsMasterPageLoginUser(LoginMethodUserObj.userUsername(0), LoginMethodPassObj.userPassword(0));
        }

        [When(@"User Clicks on Dashboard Componenet Button")]
        public void WhenUserClicksOnDashboardComponenetButton()
        {
            MarsHomePageObj.manageDashboardComponentButton();
        }

        [When(@"User Clicks on delete \(x\) icon")]
        public void WhenUserClicksOnDeleteXIcon()
        {
            NotificationObj.marsNotificationDelete();
        }

        [Then(@"Notification is deleted succfully")]
        public void ThenNotificationIsDeletedSuccfully()
        {
            throw new PendingStepException();
        }

    }
}
