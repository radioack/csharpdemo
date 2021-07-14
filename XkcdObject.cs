namespace WebAPIClient
{
    interface IXkcdObject
    {
        // string month { get; set; }
        // int num { get; set; }
        // string link { get; set; }
        // int year { get; set; }
        // string news { get; set; }
        // string safe_title { get; set; }
        // string transcript { get; set; }
        // string alt { get; set; }
        string img { get; set; }
        // string title { get; set; }
        // int day { get; set; }

    }

    class XkcdObject : IXkcdObject
    {
        public string img { get; set; }
    }
}