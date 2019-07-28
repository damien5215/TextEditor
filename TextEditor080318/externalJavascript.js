
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

//function demo1()                // DELETE LATER
//{
//    setTimeout(demo1a, 0000);
//    setTimeout(demo1b, 3000);
//    setTimeout(demo1c, 6000);
//    setTimeout(demo1d, 6000);
//    setTimeout(demo1e, 9000);
//    setTimeout(demo1f, 12000);
//}

//function demo1a()                // DELETE LATER
//{
//    var a100 = document.querySelector("#TextBox1");
//    a100.style.opacity = 0.8;
//    document.getElementById('TextBox1').value = "Demo started. This is a demo. It runs for one second.";
//    document.getElementById('TextBox2').value = "";
//}

//function demo1b()                // DELETE LATER
//{
//    var a100 = document.querySelector("#TextBox1");
//    a100.style.opacity = 1;
//    var a100 = document.querySelector("#Button1");
//    a100.style.opacity = 0.3;
//    var a100 = document.querySelector("#TextBox2");
//    a100.style.opacity = 0.8;
//    document.getElementById('TextBox1').value = "Demo started. This is a demo. It runs for one second.";
//    document.getElementById('TextBox2').value = "PARAGRAPH: There are a total of 11 words and there are a total of 3 sentences." + "\n" + "\n" + "Sentence 1 contains 2 words." + "\n" + "Sentence 2 contains 4 words." + "\n" + "Sentence 3 contains 5 words.";
//}

//function demo1c()                // DELETE LATER
//{
//    var a100 = document.querySelector("#Button1");
//    a100.style.opacity = 1;
//    var a100 = document.querySelector("#Button3");
//    a100.style.opacity = 0.3;
//    document.getElementById('TextBox1').value = "Demo started. This is a demo. It runs for one second.";
//    document.getElementById('TextBox2').value = "The word \"demo\" is the most frequently occuring word and it appears 2 times.";
//}

//function demo1d()                // DELETE LATER
//{
//    var a100 = document.querySelector("#Button3");
//    a100.style.opacity = 1;
//    document.getElementById('TextBox1').value = "Demo started. This is a demo. It runs for one second. One one one.";
//    document.getElementById('TextBox2').value = "The word \"demo\" is the most frequently occuring word and it appears 2 times.";
//}

//function demo1e()                // DELETE LATER
//{
//    var a100 = document.querySelector("#Button3");
//    a100.style.opacity = 0.3;
//    document.getElementById('TextBox1').value = "Demo started. This is a demo. It runs for one second. One one one.";
//    document.getElementById('TextBox2').value = "The word \"one\" is the most frequently occuring word and it appears 4 times.";
//}

//function demo1f()                // DELETE LATER
//{
//    var a100 = document.querySelector("#Button3");
//    a100.style.opacity = 1;
//    var a100 = document.querySelector("#Button1");
//    a100.style.opacity = 0.3;
//    document.getElementById('TextBox1').value = "Demo started. This is a demo. It runs for one second. One one one.";
//    document.getElementById('TextBox2').value = "PARAGRAPH: There are a total of 14 words and there are a total of 4 sentences." + "\n" + "\n" + "Sentence 1 contains 2 words." + "\n" + "Sentence 2 contains 4 words." + "\n" + "Sentence 3 contains 5 words." + "\n" + "Sentence 4 contains 3 words.";
//}
setColor();