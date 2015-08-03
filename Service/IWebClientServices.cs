namespace Service
{
    public interface IWebClientServices
    {
        string FetchUrl(string url);
        string GetWebPageTitle(string url);
    }
}
