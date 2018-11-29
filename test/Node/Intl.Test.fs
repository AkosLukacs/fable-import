module Fable.Import.Node.Intl.Test


open Fable.Import.Jest
open Matchers


test "Intl should compile & work" <| fun () ->
    let nf = Fable.Import.Browser.Intl.NumberFormat.Create("en-us")
    let formatted = nf.format(123456789.01)
    formatted == "123,456,789.01"
