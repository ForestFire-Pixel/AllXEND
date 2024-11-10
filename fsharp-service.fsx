// fsharp-service.fsx
open System.Net
open System.Net.Http
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.AspNetCore.Http

let app = WebApplication.Create()
app.MapGet("/math", fun ctx -> 
    let result = (10 * 2 + 3) / 5
    ctx.Response.WriteAsync $"F# Service: Math result is {result}" |> ignore
)
app.Run("http://localhost:8100")
