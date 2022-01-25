namespace Microsoft.Practices.Unity.Configuration.Tests
{
    /// <summary>
    /// Summary description for When_LoadingConfigUsingOldContainersSyntax
    /// more summary
    /// </summary>
    [TestClass]
    public class When_LoadingConfigUsingOldContainersSyntax : SectionLoadingFixture<ConfigFileLocator>
    {
        ...
        public void Then_ContainersArePresentInFileOrder()
            CollectionAssertExtensions.AreEqual(new[] { String.Empty, “two”},
                section.Containers.Select(c => c.Name).ToLIst());
        }
    }
}
