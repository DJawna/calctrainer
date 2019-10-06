using CalcTrainer.Core.ViewModels;
using CalctrainerContracts.repositories;
using Moq;
using System;
using Xunit;

namespace CalcTrainer.Core.Tests
{
    public class EditSingleProfileViewModelTests
    {

        [Fact]
        public void WhenInstantiatedShouldNotBeModified()
        {
            var persistencyService = new Mock<IProfileRepository>();
            var singleProfileEditVM = new EditSingleProfileViewModel(persistencyService.Object, new CalctrainerContracts.models.Profile("test"));

            Assert.False(singleProfileEditVM.Modified);

        }

        [Fact]
        public void WhenNameChangedShouldBeModified()
        {
            var persistencyService = new Mock<IProfileRepository>();
            var singleProfileEditVM = new EditSingleProfileViewModel(persistencyService.Object, new CalctrainerContracts.models.Profile("test"));
            singleProfileEditVM.ProfileName = singleProfileEditVM.ProfileName + "Test";
            Assert.True(singleProfileEditVM.Modified);
        }

        [Fact]
        public void WhenNotModifiedShouldNotBeAbleToSave()
        {
            var persistencyService = new Mock<IProfileRepository>();
            var singleProfileEditVM = new EditSingleProfileViewModel(persistencyService.Object, new CalctrainerContracts.models.Profile("test"));

            Assert.False(singleProfileEditVM.SaveModified.CanExecute(null));
        }

        [Fact]
        public void WhenModifiedShouldBeAbleToSave()
        {
            var persistencyService = new Mock<IProfileRepository>();
            var singleProfileEditVM = new EditSingleProfileViewModel(persistencyService.Object, new CalctrainerContracts.models.Profile("test"));
            singleProfileEditVM.ProfileName = "test2";
            Assert.True(singleProfileEditVM.SaveModified.CanExecute(null));
        }


    }
}
