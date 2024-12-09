using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.Mail.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.Api.Models;
using UiPath.Testing.Activities.Models;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using UsingCodedWorkflow.ObjectRepository;

namespace UsingCodedWorkflow
{
    public class CodedEmailWorkflow : CodedWorkflow
    {
        [Workflow]
        public (bool assetValueWasChanged, string assetValue) Execute (string assetName, string assetValue)
        {
            // To start using services, use IntelliSense (CTRL + Space) to discover the available services:
            // e.g. system.GetAsset(...)

            // For accessing UI Elements from Object Repository, you can use the Descriptors class e.g:
            // var screen = uiAutomation.Open(Descriptors.MyApp.FirstScreen);
            // screen.Click(Descriptors.MyApp.FirstScreen.SettingsButton);
            var previousAssetValue = system.GetAsset(assetName).ToString();
            if (previousAssetValue.Equals(assetValue))
                {
                    return ( false,  assetValue);
                }
            else
               {
                   system.SetAsset(assetValue, assetName);
                   return ( true, previousAssetValue);
                }
        }
    }
}