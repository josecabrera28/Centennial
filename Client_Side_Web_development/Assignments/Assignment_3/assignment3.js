/*
Author: Jose Cabrera
Student ID: 301212338
student web link: 
*/

"use strict";

let game = document.getElementById("game_section");
var bugsSmached =0;

var label = document.createElement("label");
label.textContent = "Bugs Smashed: ";
label.id="label";
var button = document.createElement("button");
button.type = "text";
button.textContent = bugsSmached;
button.disabled = false;
button.className="buttons";
var reset = document.createElement("button");
reset.type="button";
reset.textContent="Reset game";
reset.className="buttons";

//create bug image
var bug_image = document.createElement("img");
bug_image.src = "bug_image.png";

//create background image 
var background_image = document.createElement("img");
background_image.src="background_image.jpg"

//create canvas node
var canvas = document.createElement("canvas");
canvas.width = 600;
canvas.height = 700;
canvas.style = "border:1px solid #000000;";
canvas.style = "margin:0;";

var ctx = canvas.getContext("2d");

//bug object
let bug = {
    x: 300,
    y: 150,
    width: 50,
    height: 50,
    speed: 7000,  
};

function score(){
    ++bugsSmached;
    button.textContent= bugsSmached;
    if(bug.speed>2000){
        bug.speed -= 1000;
        button.style.backgroundColor="red";
    }else if (bug.speed<=2000){
        bug.speed -= 400;    
        button.style.backgroundColor="yellow";
    } else if (bug.speed<=1000){
        bug.speed -= 100;
        button.style.backgroundColor="green";
    } else if (bug.speed<=500){
    }

    if(bug.speed==6000){
        window.alert("That was easy, right?");
    }else if (bug.speed==2000){
        window.alert("Can you do it better?");
    } else if (bug.speed==1000){
        window.alert("now let´s play");
    } else if (bug.speed==500){
        window.alert("Well done. You win!");
    }
    console.log(bug.speed);
    clearTimer();
    setTimer();
}  

function draw (){
    ctx.drawImage(background_image,0,0);
    ctx.drawImage(bug_image,bug.x,bug.y,bug.width,bug.height);
} 

function jump () {
    console.log("salto");
    bug.x = (Math.abs((Math.random())*canvas.width-50));
    bug.y = (Math.abs((Math.random())*canvas.height-50));

    draw();
}



window.addEventListener("load",function(){

    game.appendChild(canvas);
    game.appendChild(label);
    game.appendChild(button);  
    game.appendChild(reset);  
    draw();
    setTimer();
});

reset.addEventListener("click", function(){
    bugsSmached=0;
    bug.speed=7000;
    button.textContent= bugsSmached;
    console.log(bug.speed);
    clearTimer();
    setTimer();
    button.style.backgroundColor="white";
});
    
canvas.addEventListener("click", function(event){

    var widthP = window.innerWidth;
    var left = ((widthP-canvas.width)/2);    

    var x1 = event.clientX -left;
    var y1 = event.clientY-9;


    console.log("click en x:"+x1);
    console.log("click en y:"+y1);
    console.log("bug en x0:"+bug.x);
    console.log("bug en y0:"+bug.y);
    console.log("bug en x1:"+(bug.x+bug.width));
    console.log("bug en y1:"+(bug.y+bug.height));

    if(x1>=(bug.x) && x1<=(bug.x+bug.width) && y1>=bug.y && y1<=bug.y+bug.height){
        score();
        console.log(bugsSmached); 
        jump();
    }
})

var time;
function setTimer (){
    time = setInterval(jump,bug.speed);
}

function clearTimer(){
    clearInterval(time);
}
