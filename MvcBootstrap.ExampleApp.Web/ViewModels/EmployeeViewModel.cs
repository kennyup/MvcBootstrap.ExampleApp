﻿namespace MvcBootstrap.ExampleApp.Web.ViewModels
{
    using MvcBootstrap.ViewModels;
    using MvcBootstrap.ViewModels.Attributes;
    using MvcBootstrap.Web.Mvc.Controllers;

    public class EmployeeViewModel : EntityViewModelBase
    {
        public EmployeeViewModel()
        {
            this.Roles = new Choices<RoleViewModel>();
            this.Supervisor = new Choice<EmployeeViewModel>();
        }

        public string Name { get; set; }

        public string Quest { get; set; }

        public Choice<EmployeeViewModel> Supervisor { get; set; }

        [HideIn(BootstrapAction.List)]
        public Choices<RoleViewModel> Roles { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}