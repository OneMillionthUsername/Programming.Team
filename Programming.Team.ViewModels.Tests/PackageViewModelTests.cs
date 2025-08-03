using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using Moq;
using Programming.Team.Business.Core;
using Programming.Team.Core;
using Programming.Team.Data.Core;
using Programming.Team.PurchaseManager.Core;
using Programming.Team.ViewModels.Purchase;
using P = Programming.Team.Core.Purchase;

namespace Programming.Team.ViewModels.Tests;

[TestClass]
public class PackageViewModelTests
{
    private Mock<IServiceProvider>? serviceProvider;
    private Mock<IBusinessRepositoryFacade<Package, Guid>>? facade;
    private Mock<ILogger<EntitiesViewModel<Guid, Package, PackageViewModel, IBusinessRepositoryFacade<Package, Guid>>>>? logger;
    private Mock<IPurchaseManager<Package, P>>? purchaseManager;
    private Mock<NavigationManager>? navigationManager;
    private Mock<AddPackageViewModel>? addViewModel;


	[TestInitialize]
    public void TestInitialize()
    {
        serviceProvider = new Mock<IServiceProvider>();
        facade = new Mock<IBusinessRepositoryFacade<Package, Guid>>();
        logger = new Mock<ILogger<EntitiesViewModel<Guid, Package, PackageViewModel, IBusinessRepositoryFacade<Package, Guid>>>>();
        purchaseManager = new Mock<IPurchaseManager<Package, P>>();
        navigationManager = new Mock<NavigationManager>();
        addViewModel = new Mock<AddPackageViewModel>(facade.Object, logger.Object);

		facade.Setup(f => f.Add(It.IsAny<Package>(),It.IsAny<IUnitOfWork>(), It.IsAny<CancellationToken>()))
            .Returns((Package p, IUnitOfWork uow, CancellationToken token) => p);

	}
	[TestMethod]
    public void TestMethod1()
    {
    }
}
