namespace CalcTrainer.Core.ViewModels
{
    public class AvaitingViewModel : BaseViewModel
    {
        public string AvaitMessage { get; set; } = "";

        public bool IsIndeterministic { get; set; } = true;

        public int Progress { get; set; }
    }
}
