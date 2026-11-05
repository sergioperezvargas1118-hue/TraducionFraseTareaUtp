// Diccionario de Español a Inglés
let espanolIngles = 
    [
        "AMARILLO", "YELLOW"
        "ROJO", "RED"
        "BLANCA", "WHITE"
        "MESA", "TABLE"
        "AGUA", "WATER"
        "LAPIZ", "PENCIL"
        "ESTA", "IS"
        "SOBRE", "ON"
        "EL", "THE"
    ] |> Map.ofList

let traducirPalabra palabra =
    Map.tryFind palabra espanolIngles
    |> Option.defaultValue palabra

let traducirFrase (frase: string) =
    frase.ToUpper().Split(' ')
    |> Array.map traducirPalabra
    |> String.concat " "

let r = traducirFrase "EL LAPIZ AMARILLO ESTA SOBRE LA MESA BLANCA"

printfn $"Frase traducida: {r}"