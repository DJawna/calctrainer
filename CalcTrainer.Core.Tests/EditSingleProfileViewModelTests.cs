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
        public void WhenModifiedCommandShouldBeNotReadyToRun()
        {
            var persistencyService = new Mock<IProfileRepository>();
            var singleProfileEditVM = new EditSingleProfileViewModel(persistencyService.Object, new CalctrainerContracts.models.Profile("test"));
        }
    }
}
