module RaspBerryTests

open Xunit
open FSharPi.Core
open Faqt

[<Fact>]
let ``Temperature Tests`` () =
    let temp = RaspberryPi.GetTemperature
    temp.Should().BeOk()

let ``Cpu Info Tests`` () =
    let cpuInfo = RaspberryPi.GetCpuInfo
    cpuInfo.Should().BeOk()
