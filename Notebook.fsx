#r "nuget:Deedle"
#r "nuget:FSharp.Charting"

open System
open Deedle
open FSharp.Charting

let dates = [ 
    DateTime(2013, 1, 1);
    DateTime(2013, 1, 4);
    DateTime(2013, 1, 8); ]

let values = [ 10.0; 20.0; 30.0 ]

let first = Series(dates, values)

Formatter.SetPreferredMimeTypesFor(typeof<obj>, "text/plain")
Formatter.Register(fun (x:obj) (writer: TextWriter) -> fprintfn writer "%120A" x )

first
