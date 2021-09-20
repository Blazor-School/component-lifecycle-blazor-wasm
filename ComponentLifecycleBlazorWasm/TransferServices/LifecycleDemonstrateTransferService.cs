namespace ComponentLifecycleBlazorWasm.TransferServices
{
    public class LifecycleDemonstrateTransferService
    {
        private string _log;
        public event OnLogChangedHandle OnLogChanged;
        public delegate void OnLogChangedHandle(object sender, string log);

        public string Log
        {
            get => _log;
            set
            {
                _log = value;
                OnLogChanged?.Invoke(this, value);
            }
        }
    }
}
