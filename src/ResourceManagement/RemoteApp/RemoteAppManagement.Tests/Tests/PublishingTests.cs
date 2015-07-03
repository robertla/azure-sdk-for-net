using Microsoft.Azure.Management.RemoteApp;
using Microsoft.Azure.Management.RemoteApp.Model;
using Microsoft.Azure.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Microsoft.Azure.Management.RemoteApp.Tests
{
    public class PublishingTests : RemoteAppTestBase
    {
        string location = "WestUs";
        string groupName = "Default-RemoteApp-WestUs";
        string collectionName = "myCollection";

        [Fact]
        public void GetStartMenuListTest()
        {
            RemoteAppManagementClient raClient = null;
            GetStartMenuApplicationListResult startMenuList = null;

            using (var undoContext = UndoContext.Current)
            {
                undoContext.Start();
                raClient = GetClient();
                System.Console.WriteLine("groupname = {0};", groupName);

                startMenuList = raClient.Collection.ListStartMenu(groupName, collectionName);

                Assert.NotNull(startMenuList);
                Assert.Equal(HttpStatusCode.OK, startMenuList.StatusCode);
                Assert.NotEmpty(startMenuList.ResultList);

                foreach (StartMenuApplication sa in startMenuList.ResultList)
                {
                    Assert.Equal("collections", sa.Type);
                    Assert.Equal(location, sa.Location);
                    Assert.Equal(location, sa.Name);
                    Assert.Equal(location, sa.Id);
                    Assert.NotNull(sa.Properties);
                    Assert.NotNull(sa.Properties.Name);
                    Assert.NotNull(sa.Properties.StartMenuAppId);
                }
            }
        }

        [Fact]
        public void GetStartMenuTest()
        {
            RemoteAppManagementClient raClient = null;
            GetStartMenuApplicationResult startMenu = null;
            string appId = null;

            using (var undoContext = UndoContext.Current)
            {
                undoContext.Start();
                raClient = GetClient();

                startMenu = raClient.Collection.GetStartMenu(groupName, collectionName, appId);

                Assert.NotNull(startMenu);
                Assert.Equal(HttpStatusCode.OK, startMenu.StatusCode);
                Assert.Equal("collections", startMenu.Result.Type);
                Assert.Equal(location, startMenu.Result.Location);
                Assert.Equal(location, startMenu.Result.Name);
                Assert.Equal(location, startMenu.Result.Id);
                Assert.NotNull(startMenu.Result.Properties);
            }
        }

        [Fact]
        public void GetPublishedAppListTest()
        {
            RemoteAppManagementClient raClient = null;
            GetPublishedApplicationListResult pubApps = null;

            using (var undoContext = UndoContext.Current)
            {
                undoContext.Start();
                raClient = GetClient();

                pubApps = raClient.Collection.ListPublishedApp(groupName, collectionName);

                Assert.NotNull(pubApps);
                Assert.Equal(HttpStatusCode.OK, pubApps.StatusCode);
                Assert.NotEmpty(pubApps.ResultList);

                foreach (PublishedApplicationDetails app in pubApps.ResultList)
                {
                    Assert.Equal("collections", app.Type);
                    Assert.Equal(location, app.Location);
                    Assert.Equal(location, app.Name);
                    Assert.Equal(location, app.Id);
                    Assert.NotNull(app.Properties);
                    Assert.NotNull(app.Properties.Name);
                    Assert.NotNull(app.Properties.Alias);
                }
            }
        }

        [Fact]
        public void GetPublishedAppTest()
        {
            RemoteAppManagementClient raClient = null;
            GetPublishedApplicationResult pubApp = null;
            string alias = "1";

            using (var undoContext = UndoContext.Current)
            {
                undoContext.Start();
                raClient = GetClient();

                pubApp = raClient.Collection.GetPublishedApp(groupName, collectionName, alias);

                Assert.NotNull(pubApp);
                Assert.Equal(HttpStatusCode.OK, pubApp.StatusCode);
                Assert.Equal("collections", pubApp.Result.Type);
                Assert.Equal(location, pubApp.Result.Location);
                Assert.Equal(location, pubApp.Result.Name);
                Assert.Equal(location, pubApp.Result.Id);
                Assert.NotNull(pubApp.Result.Properties);
            }
        }

        [Fact]
        public void PublishedAppTest()
        {
            RemoteAppManagementClient raClient = null;
            PublishApplicationsResult pubApp = null;
            ApplicationDetailsListParameter details = null;

            using (var undoContext = UndoContext.Current)
            {
                undoContext.Start();
                raClient = GetClient();
                details = new ApplicationDetailsListParameter()
                {
                    DetailsList = new List<ApplicationDetails>()
                    {
                        new ApplicationDetails()
                        {
                            Alias = "test",
                            Name = "test"
                        },
                    },
                };

                pubApp = raClient.Collection.PublishApplications(groupName, collectionName, details);

                Assert.NotNull(pubApp);
                Assert.Equal(HttpStatusCode.OK, pubApp.StatusCode);

                foreach (PublishingOperationResult result in pubApp.ResultList)
                {
                    Assert.NotNull(result.ApplicationAlias);
                    Assert.NotNull(result.ApplicationVirtualPath);
                    Assert.Null(result.ErrorMessage);
                    Assert.True(result.Success);
                }
            }
        }

        [Fact]
        public void ModifyAppTest()
        {
            RemoteAppManagementClient raClient = null;
            ModifyApplicationResult pubApp = null;
            ApplicationDetailsParameter details = null;
            string alias = null;

            using (var undoContext = UndoContext.Current)
            {
                undoContext.Start();
                raClient = GetClient();
                details = new ApplicationDetailsParameter()
                {
                     Alias = "test",
                     Name = "test"
                };

                pubApp = raClient.Collection.ModifyApplication(groupName, collectionName, alias,  details);

                Assert.NotNull(pubApp);
                Assert.Equal(HttpStatusCode.OK, pubApp.StatusCode);
                Assert.Equal(details.Alias, pubApp.Result.ApplicationAlias);
                Assert.Null(pubApp.Result.ErrorMessage);
                Assert.True(pubApp.Result.Success);
            }
        }


        [Fact]
        public void DeleteAllAppTest()
        {
            RemoteAppManagementClient raClient = null;
            UnpublishApplicationsResult unPubApp = null;

            using (var undoContext = UndoContext.Current)
            {
                undoContext.Start();
                raClient = GetClient();

                unPubApp = raClient.Collection.UnpublishAll(groupName, collectionName);

                Assert.NotNull(unPubApp);
                Assert.Equal(HttpStatusCode.OK, unPubApp.StatusCode);
                Assert.NotEmpty(unPubApp.ResultList);
                foreach (PublishingOperationResult op in unPubApp.ResultList)
                {
                    Assert.Null(op.ErrorMessage);
                    Assert.Null(op.Success);
                }
            }
        }

        [Fact]
        public void DeleteAppTest()
        {
            RemoteAppManagementClient raClient = null;
            UnpublishApplicationsResult unPubApp = null;
            AliasesListParameter aliases = null;

            using (var undoContext = UndoContext.Current)
            {
                undoContext.Start();
                raClient = GetClient();

                unPubApp = raClient.Collection.Unpublish(groupName, collectionName, aliases);

                Assert.NotNull(unPubApp);
                Assert.Equal(HttpStatusCode.OK, unPubApp.StatusCode);
                Assert.NotEmpty(unPubApp.ResultList);
                foreach (PublishingOperationResult op in unPubApp.ResultList)
                {
                    Assert.Null(op.ErrorMessage);
                    Assert.Null(op.Success);
                }
            }
        }

    }
}
/*
 
 

            Name = name;
            Location = location;
            Tags = new Dictionary<string, string>();
            Type = enclosingType;
            Properties = resource;
            ETag = Guid.NewGuid().ToString();

            sb.Append(subscriptionId);
            sb.Append("/resourceGroups/");
            sb.Append(System.Web.HttpUtility.UrlEncode(groupName));
            sb.Append("/providers/");
            sb.Append(providerNamespace);
            sb.Append("/");
            sb.Append(enclosingType);
            sb.Append("/");
            sb.Append(collectionName);

            foreach (string entity in Entities)
            {
                sb.Append('/');
                sb.Append(entity);
            }
 
 */