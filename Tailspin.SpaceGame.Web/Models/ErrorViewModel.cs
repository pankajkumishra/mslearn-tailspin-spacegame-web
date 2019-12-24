namespace TailSpin.SpaceGame.Web.Models
{
    public cclass ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
