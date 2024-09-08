namespace FSharPi.Core

module Helpers =
    let ToResult func =
        try
            Ok(func ())
        with ex ->
            Error ex.Message
