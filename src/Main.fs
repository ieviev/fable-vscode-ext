module Main

open Fable.Import.VSCode
open Fable.Import.VSCode.Vscode
open Microsoft.FSharp.Core

// vscode exports
module Vscode = Fable.Import.VSCode.Vscode
    
let helloworld (editor: TextEditor) (currentEdit: TextEditorEdit) (_: ResizeArray<obj option>) =
    promise {
        
        let _ = Vscode.window.showInformationMessage "hello world"
        ()
        
    }
    |> ignore    


let activate (context: ExtensionContext) =
    let allLoadedExtensions = Vscode.extensions.all
    let test = 1
    [
        commands.registerTextEditorCommand ("newext.helloworld", helloworld)
    ]
    |> List.map unbox
    |> List.iter context.subscriptions.Add
