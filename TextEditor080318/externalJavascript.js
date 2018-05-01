
function setColor()                                                                 // Repeated code (modular)
{
    var ccc2 = document.querySelector("#TextBox1");
    var ccc3 = document.querySelector("#TextBox2");
    var ccc4 = document.querySelector("#TextBox3");

    ccc2.style.color = sessionStorage['myKey'];                                     // Change colour of input-textbox
    ccc3.style.color = sessionStorage['myKey'];                                     // Change colour of output-textbox
    ccc4.style.color = sessionStorage['myKey'];                                     // Change colour of search-textbox
}

function inputColor()                                                               // Triggered by "ANALYSE TEXT" button
{
    if (document.getElementById('TextBox3').value == "changeColor")                 // If search-string = "changeColor"
    {
        var ccc = document.getElementById('TextBox1').value;                        // Takes string from input-textbox
        sessionStorage['myKey'] = ccc;                                              // Hold in memory (sessionStorage)
        setColor();                                                                 // Sets color
        document.getElementById('TextBox3').value = "";                             // Clears search-textbox 
    }
}

function resetColor()                                                               // Triggered by "RESET" button
{
    sessionStorage['myKey'] = "white";                                              // Set default font color to white
}

setColor();