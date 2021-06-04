namespace PuppeteerSharp.Messaging
{
    internal class TargetCreateTargetRequest
    {
        public string Url { get; set; }
        public bool NewWindow { get; set; }
        public string BrowserContextId { get; set; }
    }
}
