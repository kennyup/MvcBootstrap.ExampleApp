﻿namespace MvcBootstrap.ExampleApp.Web.ViewModels
{
    using MvcBootstrap.ViewModels.Accounts;

    public class ExampleUserProfileViewModel : UserProfileViewModel
    {
        public string Nickname { get; set; }

        public override string ToString()
        {
            return this.Username;
        }
    }
}