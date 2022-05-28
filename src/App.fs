module App

open Browser.Dom

// Mutable variable to count the number of times we clicked the button
let mutable count = 0

// Get a reference to our button and cast the Element to an HTMLButtonElement
let myButton = document.querySelector(".my-button") :?> Browser.Types.HTMLButtonElement
let removeButton = document.querySelector(".remove-button") :?> Browser.Types.HTMLButtonElement
let clickLabel = document.querySelector(".click-label") :?> Browser.Types.HTMLParagraphElement

// Register our listener
myButton.onclick <- fun _ ->
    count <- count + 1
    clickLabel.innerText <- sprintf "You clicked: %i time(s)" count

// Register remove listener
removeButton.onclick <- fun _ ->
    
    clickLabel.innerText <- 
        if count = 1 || count = 0 then
            sprintf "No clicks"
        else
            count <- count - 1
            sprintf "You clicked: %i time(s)" count