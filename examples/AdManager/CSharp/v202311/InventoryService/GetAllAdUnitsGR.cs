// Copyright 2019 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Ads.AdManager.Lib;
using Google.Api.Ads.AdManager.Util.v202311;
using Google.Api.Ads.AdManager.v202311;

using System;

namespace Google.Api.Ads.AdManager.Examples.CSharp.v202311
{
    /// <summary>
    /// This example gets all ad units.
    /// </summary>
    public class GetAllAdUnitsGR : SampleBase
    {
        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get { return "Getting all AdUnits GR."; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        public static void Main()
        {
            GetAllAdUnitsGR codeExample = new GetAllAdUnitsGR();
            Console.WriteLine(codeExample.Description);
            try
            {
                codeExample.Run(new AdManagerUser());
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to get ad units. Exception says \"{0}\"", e.Message);
            }
        }

        /// <summary>
        /// Run the code example.
        /// </summary>
        public void Run(AdManagerUser user)
        {
            using (InventoryService inventoryService = user.GetService<InventoryService>())
            {
                // Create a statement to select ad units.
                int pageSize = StatementBuilder.SUGGESTED_PAGE_LIMIT;
                StatementBuilder statementBuilder =
                    new StatementBuilder().OrderBy("id ASC").Limit(pageSize);

                // Retrieve a small amount of ad units at a time, paging through until all
                // ad units have been retrieved.
                int totalResultSetSize = 0;
                int counterAdUnits = 0;
                do
                {
                    AdUnitPage page =
                        inventoryService.getAdUnitsByStatement(statementBuilder.ToStatement());

                    // Print out some information for each ad unit.
                    if (page.results != null)
                    {
                        totalResultSetSize = page.totalResultSetSize;
                        int i = page.startIndex;
                        foreach (AdUnit adUnit in page.results)
                        {
                            if(adUnit.name.ToLower().StartsWith("elnorte") || adUnit.name.ToLower().StartsWith("reforma") || adUnit.name.ToLower().StartsWith("mural"))
                            {
                                //Console.WriteLine("{0}) Ad unit with ID \"{1}\" and name \"{2}\" was found.", i++, adUnit.id, adUnit.name);
                                Console.WriteLine("{0}) Ad unit ID: \"{1}\" | name: \"{2}\" | adUnitCode: \"{3}\"", i++, adUnit.id, adUnit.name, adUnit.adUnitCode);
                                counterAdUnits++;
                            }
                        }
                    }

                    statementBuilder.IncreaseOffsetBy(pageSize);
                } while (statementBuilder.GetOffset() < totalResultSetSize);

                Console.WriteLine("Number of total results found: {0} | number of AdUnits GR: {1}", totalResultSetSize,counterAdUnits);
            }
        }
    }
}
