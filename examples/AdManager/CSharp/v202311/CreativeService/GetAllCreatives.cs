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
    /// This example gets all creatives.
    /// </summary>
    public class GetAllCreatives : SampleBase
    {
        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get { return "Gets all creatives from \"Google Ad Manager\" | NetworkCode: 142849901."; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        public static void Main()
        {
            GetAllCreatives codeExample = new GetAllCreatives();
            Console.WriteLine(codeExample.Description);
            try
            {
                codeExample.Run(new AdManagerUser());
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to get creatives. Exception says \"{0}\"", e.Message);
            }
        }

        /// <summary>
        /// Run the code example.
        /// </summary>
        public void Run(AdManagerUser user)
        {
            using (CreativeService creativeService = user.GetService<CreativeService>())
            {
                // Create a statement to select creatives.
                int pageSize = StatementBuilder.SUGGESTED_PAGE_LIMIT;
                StatementBuilder statementBuilder =
                    new StatementBuilder().OrderBy("id ASC").Limit(pageSize);

                // Retrieve a small amount of creatives at a time, paging through until all
                // creatives have been retrieved.
                int totalResultSetSize = 0;                
                do
                {
                    CreativePage page =
                        creativeService.getCreativesByStatement(statementBuilder.ToStatement());
                    
                    // Print out some information for each creative.
                    if (page.results != null)
                    {
                        totalResultSetSize = page.totalResultSetSize;
                        int i = page.startIndex;
                        foreach (Creative creative in page.results)
                        {
                            Console.WriteLine("{0}) Creative with ID {1} and name \"{2}\" | Type:{3} | was found.", i++,
                                creative.id, creative.name, creative.GetType());
                            if (!string.IsNullOrEmpty(creative.previewUrl)) { 
                               Console.WriteLine("  ***   previewUrl:{0} ", creative.previewUrl);
                            }
                        }
                        //=> v202311.GetAllCreatives.CreativeService.Creative.VastRedirectCreative
                    }

                    statementBuilder.IncreaseOffsetBy(pageSize);
                } while (statementBuilder.GetOffset() < totalResultSetSize);

                Console.WriteLine("Number of results found: {0}", totalResultSetSize);
                

                /*--------------------------------*/
                /* Console.WriteLine("*================== VideoCreative ======================*");
                do
                {
                    CreativePage page =
                        creativeService.getCreativesByStatement(statementBuilder.ToStatement());

                    // Print out some information for each creative.
                    if (page.results != null)
                    {
                        totalResultSetSize = page.totalResultSetSize;
                        Console.WriteLine("*VideoCreative: {0}",totalResultSetSize);
                        int i = page.startIndex;
                        foreach (VideoCreative creative in page.results)
                        {
                            Console.WriteLine("VideoCreative: {0}) Creative with ID {1} and name \"{2}\" was found.", i++,
                                creative.id, creative.name);
                            if (!string.IsNullOrEmpty(creative.previewUrl))
                            {
                                Console.WriteLine("***VideoCreative   previewUrl:{0} ", creative.previewUrl);
                            }
                            if (!string.IsNullOrEmpty(creative.vastPreviewUrl))
                            {
                                Console.WriteLine(" ***VideoCreative   vastPreviewUrl:{0} ", creative.vastPreviewUrl);
                            }

                        }
                        //=> v202311.GetAllCreatives.CreativeService.Creative.VastRedirectCreative
                    }

                    statementBuilder.IncreaseOffsetBy(pageSize);
                } while (statementBuilder.GetOffset() < totalResultSetSize);
                Console.WriteLine("Number of results found: {0}", totalResultSetSize);
                */


            }
        }
    }
}