namespace FSharPi.Core

open System.Diagnostics

module RaspberryPi =
    let GetTemperature =
        let psi = new ProcessStartInfo("vcgencmd", "measure_temp")
        psi.RedirectStandardOutput <- true
        psi.UseShellExecute <- false
        let tempProcess = Process.Start(psi)
        tempProcess.StandardOutput.ReadToEnd()

    let GetCpuInfo =
        let psi = new ProcessStartInfo("cat", "/proc/cpuinfo")
        psi.RedirectStandardOutput <- true
        psi.UseShellExecute <- false
        let cpuInfoProcess = Process.Start(psi)
        cpuInfoProcess.StandardOutput.ReadToEnd()
