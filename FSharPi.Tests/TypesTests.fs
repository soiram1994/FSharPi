module TypesTests

open System
open Xunit
open FSharPi.Core

[<Fact>]
let ``Machine Tests`` () =
    let temp = RaspberryPi.GetTemperature
    Assert.NotNull(temp)
    Assert.NotEmpty(temp)
    Assert.Contains("temp=", temp)
