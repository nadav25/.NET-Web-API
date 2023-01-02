


namespace Attributes
{
    public class ApiActionFilterAttribute : ActionFilterAttribute
    {
        private static readonly Logger Logger = Logger.Get(LogSource.Api, MethodBase.GetCurrentMethod().DeclaringType);

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            string url = actionContext.Request.RequestUri.ToString();
            string body = actionContext.Request.GetBody();

            Logger.Debug($"start api request, url: [{url}], body: [{body}]");
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            string url = actionExecutedContext.Request.RequestUri.ToString();
            Logger.Debug($"end api request, url: [{url}]");
        }        
    }
}
