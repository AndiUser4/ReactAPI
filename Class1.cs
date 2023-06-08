using System;
using System.Web;

public class search : IHttpHandler
{
    public void ProcessRequest(HttpContext context)
    {
        string query = context.Request.QueryString["query"];
        // Perform search operation with the query
        // ...
        // Redirect or display search results
        // ...
    }

    public bool IsReusable
    {
        get { return false; }
    }
}