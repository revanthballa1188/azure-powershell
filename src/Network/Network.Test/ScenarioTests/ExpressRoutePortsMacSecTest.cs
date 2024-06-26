﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Network.Test.ScenarioTests;
using Microsoft.Azure.Test.HttpRecorder;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Newtonsoft.Json;
using System;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace Commands.Network.Test.ScenarioTests
{
    public class ExpressRoutePortsMacSecTest : NetworkTestRunner
    {
        public ExpressRoutePortsMacSecTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact(Skip = "Skip as current test framework does not support recording generated cmdlets.")]
        [Trait(Category.AcceptanceType, Category.LiveOnly)]
        [Trait(Category.Owner, NrpTeamAlias.exrdev)]
        public void TestExpressRoutePortMacSecConfigCRUD()
        { 
            TestRunner.RunTestScript("Test-ExpressRoutePortMacSecConfigCRUD");
        }
    }
}
