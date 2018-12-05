//legt liste mit strings an
let fruit = ["apple"; "banana"; "orange"; "plum"; "cherry"]
//erstelle eine neue liste mit zwei weiteren string und der fruit-liste
let fruit2 = "strawberry"::"lemon"::fruit
printfn "%A" fruit2
//neue liste mit einer range von 1 bis 9
let list1 = [0..9]
printfn "%A" list1
//eine neue liste mit strings
let fruit3 = ["ananas"; "apricot"]
//konkatiniere zwei listen
let fruit4 = fruit2@fruit3
printfn "%A" fruit4
//konkatiniere zwei listen, nur andersherum
let fruit5 = fruit3@fruit2
printfn "%A" fruit5

//zeige nur das head-element von fruit5
printfn "fruit5 head:%A" fruit5.Head
//zeige nur das tail-element/die tail-elemente von fruit5 (also die ganze liste nur ohne head)
printfn "fruit5 tail:%A" fruit5.Tail

//benutze die .sum-funktion von listen um die summe einer range von zahlen zu berechnen
let sum1 = List.sum [1 .. 10]
printfn "Summe von 1 bis 10: %i" sum1

//benutze die -average-funktion von listen um den durschnitt der elemente einer liste zu berechnen
let sum2 = List.average [1.0 .. 10.0]
printfn "Durchschnitt von 1 bis 10: %f" sum2

//rekursiver Funktionsaufruf bei der eine Liste von Floats uebergeben werden
let rec recsum (li:list<float>) = 
    //rekursionsaufloesung: gibt es keine Elemente in der Liste wird die Addition mit der 0 als erstem Summanden gestartet.
    if List.isEmpty li then 0.0
    //die köpfe werden addiert mit der rueckgabe der funktion. Die liste wird durch tail immer um 1 element kleiner
    else li.Head + recsum(li.Tail)

let a = recsum [1.0..10.0]
printfn "a=%f" a