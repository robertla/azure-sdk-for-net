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
    public class CollectionTests : RemoteAppTestBase
    {
        [Fact]
        public void GetCollectionListTest()
        {
            RemoteAppManagementClient raClient = null;
            ListCollectionOperationResult collections = null;

            using (var undoContext = UndoContext.Current)
            {
                undoContext.Start();
                raClient = GetClient();

                collections = raClient.Collection.List("Microsoft.RemoteApp");

                Assert.NotNull(collections);
                Assert.Equal(HttpStatusCode.OK, collections.StatusCode);
                Assert.NotEmpty(collections.Collections);

                foreach (Collection col in collections.Collections)
                {
                    Assert.Equal("collections", col.Type);
                }
            }
        }

        //[Fact]
        //public void GetCollectionTest()
        //{
        //    RemoteAppManagementClient raClient = null;
        //    GetCollectionOperationResult collection = null;

        //    using (var undoContext = UndoContext.Current)
        //    {
        //        undoContext.Start();
        //        raClient = GetClient();

        //        collection = raClient.Collection.Get("Microsoft.RemoteApp", "testcol2");

        //        Assert.NotNull(collection);
        //        Assert.Equal(HttpStatusCode.OK, collection.StatusCode);
        //        Assert.NotNull(collection.Collection);
        //        Assert.NotNull(collection.Collection.Properties);
        //        Assert.Equal("collections", collection.Collection.Type);
        //        Assert.Equal("testcol1", collection.Collection.Properties.Name);
        //    }
        //}
    }
}
