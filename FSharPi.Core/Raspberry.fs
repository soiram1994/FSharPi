namespace FSharPi.Core

open System.Diagnostics
open Helpers

module RaspberryPi =
    let GetTemperature =
        let psi = new ProcessStartInfo("vcgencmd", "measure_temp")
        psi.RedirectStandardOutput <- true
        psi.UseShellExecute <- false
        let tempProcess = Process.Start(psi)
        ToResult(fun () -> tempProcess.StandardOutput.ReadToEnd())

    let GetCpuInfo =
        let psi = new ProcessStartInfo("cat", "/proc/cpuinfo")
        psi.RedirectStandardOutput <- true
        psi.UseShellExecute <- false
        let cpuInfoProcess = Process.Start(psi)
        ToResult(fun () -> cpuInfoProcess.StandardOutput.ReadToEnd())
