using Microsoft.AspNetCore.Components;

namespace Blazor.EndpointHelper.Components.Request.Base
{
    public class BaseRequest : ComponentBase
    {
        [CascadingParameter] public string BaseAddress { get; set; }
        [Parameter] public string RequestName { get; set; }
        [Parameter] public string Endpoint { get; set; }
        [Parameter] public Dictionary<string, Type>? Parameters { get; set; }
        [Parameter] public object? Response200 { get; set; }
        [Parameter] public Type? Response200T { get; set; }
        [Parameter] public object? Response404 { get; set; }
        [Parameter] public object? Response500 { get; set; }
        public RequestMethod Method { get; set; }

    }
    public enum RequestMethod
    {
        GET, POST, DELETE, PUT
    }
}