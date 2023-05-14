"strict";


let previous = document.getElementById("previous");
let next = document.getElementById("next");
let update = document.getElementById("update");
let images = document.querySelectorAll("img");
let jsonObj;
let interval;



previous.addEventListener("mouseover",function(){
    previous.style.backgroundColor="#CB7A12";
});
next.addEventListener("mouseover",function(){
    next.style.backgroundColor="#CB7A12";
});
update.addEventListener("mouseover",function(){
    update.style.backgroundColor="#CB7A12";
});
previous.addEventListener("mouseout",function(){
    previous.style.backgroundColor="";
});
next.addEventListener("mouseout",function(){
    next.style.backgroundColor="";
});
update.addEventListener("mouseout",function(){
    update.style.backgroundColor="";
});

//Function to return the src of the first image displayed in the show
function indexFirstImage (){
    let firstImage = images[0].src.split("/");
    let firstImageIdx = firstImage[firstImage.length-1]
    for(let i=0; i<12;i++){
        if (jsonObj[i].url == firstImageIdx){
            return i;
        }
    }
}

//initiate XMLHttpRequest Object to send http request to photos.txt when the web page loads
window.addEventListener("load",display);
update.addEventListener("click",display);



function display (){
    

    const xhr = new XMLHttpRequest();
    
    xhr.onreadystatechange = function (){
        if(xhr.readyState === 4){
            console.log(xhr.readyState);
            if(xhr.status >=200 && xhr.status<300){
                jsonObj = JSON.parse(xhr.response);
                for(let i=0; i < 4; i++){
                    images[i].src=jsonObj[i].url;                    
                }
                interval = setInterval(nextSlide,jsonObj[0].time);
            }else{
                console.log(xhr.status);
                console.log(xhr.statusText);
            }
        }    
    }    

    //open request and send
    xhr.open("get","photos.txt");
    xhr.send(null);
}

//Move slide show to next image when Next button is clicked
next.addEventListener("click",nextSlide);

function nextSlide(){
    let index = indexFirstImage();
    for(let i=0; i < 4; i++){
        let nextIndex = (index + 1) % 12;
        images[i].src = jsonObj[nextIndex].url;
        index = nextIndex;
    }
}

//Move slide show to previous image when Previous button is clicked
previous.addEventListener("click",function(){
    let index = indexFirstImage();
    index--;
    if(index <0){
        index = 11;
        images[0].src=jsonObj[index].url;
    }else{
        images[0].src=jsonObj[index].url;
    }
    for(let i=1; i < 4; i++){
        let nextIndex = (index + 1) % 12;
        images[i].src = jsonObj[nextIndex].url;
        index = nextIndex;
    }
})