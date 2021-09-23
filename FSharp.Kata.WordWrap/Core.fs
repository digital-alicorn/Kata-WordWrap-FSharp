module Core

let rec DoRec (words:list<string>, maxCharPerLine:int, charsOnLine:int, result:string) =
    match words with
    | [] -> result
    | [h] when h.Length > maxCharPerLine -> DoRec ([h.Substring(0, maxCharPerLine);h.Substring(maxCharPerLine)], maxCharPerLine, charsOnLine, result)
    | [h] when h.Length + charsOnLine = maxCharPerLine -> $"{result}{h}\n"
    | [h] when h.Length + charsOnLine < maxCharPerLine -> $"{result}{h}"
    | [h] -> DoRec ([h], maxCharPerLine, 0, $"{result}\n")
    | h::t when h.Length > maxCharPerLine -> DoRec ([h.Substring(0, maxCharPerLine);h.Substring(maxCharPerLine)] @ t, maxCharPerLine, charsOnLine, result)
    | h::t when h.Length + charsOnLine = maxCharPerLine -> DoRec (t, maxCharPerLine, 0, $"{result}{h}\n")
    | h::t when h.Length + charsOnLine + 1 < maxCharPerLine -> DoRec (t, maxCharPerLine, (charsOnLine + h.Length + 1), $"{result}{h} ")
    | h::t -> DoRec (h::t, maxCharPerLine, 0, $"{result}\n")

let Do (text : string, maxCharPerLine : int) = 
    let words = text.Split(' ') |> List.ofSeq
    DoRec (words, maxCharPerLine, 0, "")