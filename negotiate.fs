module Example.Negotiate
open Microsoft.Azure.WebJobs
open Microsoft.AspNetCore.Http
open Microsoft.Azure.WebJobs.Extensions.Http
open Microsoft.Azure.WebJobs.Extensions.SignalRService

[<FunctionName("negotiate")>]
let negotiate
    ([<HttpTrigger(AuthorizationLevel.Anonymous, "post")>]req: HttpRequest)
    ([<SignalRConnectionInfo(HubName = "resources")>]connectionInfo: SignalRConnectionInfo) =
    connectionInfo