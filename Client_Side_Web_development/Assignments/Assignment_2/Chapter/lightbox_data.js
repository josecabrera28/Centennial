"use strict";
/*    JavaScript 7th Edition
      Chapter 5
      Chapter Case

      Image List

      Filename:lightbox_data.js
*/

// Title of the slideshow
let lightboxTitle = "My Western Vacation";

// Names of the image files shown in the slideshow
let imgFiles = ["photo01.jpg", "photo02.jpg", "photo03.jpg", "photo04.jpg",
                "photo05.jpg", "photo06.jpg", "photo07.jpg", "photo08.jpg",
                "photo09.jpg", "photo10.jpg", "photo11.jpg", "photo12.jpg"]

// Captions associated with each image
let imgCaptions = new Array(12);
imgCaptions[0]="Sky Pond (Rocky Mountain National Park)";
imgCaptions[1]="Buffalo on the Plains (South Dakota)"; 
imgCaptions[2]="Garden of the Gods (Colorado Springs)"; 
imgCaptions[3]="Elephant Head Wild Flower (Rocky Mountain National Park)"; 
imgCaptions[4]="Double Rainbow (Colorado National Monument)";
imgCaptions[5]="Moose in the Wild (Grand Lake, Colorado)";
imgCaptions[6]="Camas Wild Flower (Rocky Mountain National Park)";
imgCaptions[7]="Chasm Lake (Rocky Mountain National Park)";
imgCaptions[8]="Teton Crest Trail (Grand Teton National Park)";
imgCaptions[9]="The Notch Trail (Badlands National Park)";
imgCaptions[10]="Sprague Lake (Rocky Mountain National Park)";
imgCaptions[11]="Longs Peak Trail (Rocky Mountain National Park)";

// Count of images in the slideshow
let imgCount = imgFiles.length;

//favorites 

window.addEventListener("load", createLightbox);

function createLightbox(){
           
      //lightbox container
      let lightbox = document.getElementById('lightbox');
      
      //parts of the lightbox
      let lbTitle = document.createElement("h1");
      let lbCounter = document.createElement("div");
      let lbPrev = document.createElement("div");
      let lbNext = document.createElement("div");
      let lbPlay = document.createElement("div");
      let lbImages = document.createElement("div");
      
      //design the lightbox title
      lightbox.appendChild(lbTitle);
      lbTitle.id = "lbTitle";
      lbTitle.textContent = lightboxTitle;

      ////design the slide counter
      lightbox.appendChild(lbCounter);
      lbCounter.id = "lbCounter";
      let currentImg = 1;
      lbCounter.textContent = currentImg +" / "+ imgCount;

      //design the lightbox previous slide button
      lightbox.appendChild(lbPrev);
      lbPrev.id = "lbPrev";
      lbPrev.innerHTML = "&#9664";
      lbPrev.onclick = showPrev;

      //design the lightbox next slide button
      lightbox.appendChild(lbNext);
      lbNext.id = "lbNext";
      lbNext.innerHTML = "&#9654";
      lbNext.onclick = showNext;

      //design the lightbox previous slide button
      lightbox.appendChild(lbPlay);
      lbPlay.id = "lbPlay";
      lbPlay.innerHTML = "&#9199";
      let timeID;
      lbPlay.onclick = function (){
            if(timeID){
                  //stop the slideshow
                  window.clearInterval(timeID);
                  timeID = undefined;
            }else{
                  //start slideshow
                  showNext();
                  timeID = window.setInterval(showNext, 1500);      
            }
      }

      //design the lightbox previous slide button
      lightbox.appendChild(lbImages);
      lbImages.id = "lbImages";

      for (let i=0; i < imgCount;i++){
            let image = document.createElement("img");
            image.src = imgFiles[i];
            image.alt = imgCaptions[i];
            image.onclick = createOverlay;
            lbImages.appendChild(image);
      }

      let favSection = document.createElement("div");
      favSection.id = "favSection";
      //lightbox.appendChild(favSection);
      let fav = document.createElement("h3");
      fav.id = "myFavoritesTitle";
      fav.textContent="My Favorites: ";
      lightbox.appendChild(fav);
      lightbox.appendChild(favSection);

      let firstDiv = document.createElement("div");
      firstDiv.className ="divFavorites";
      
      favSection.appendChild(firstDiv);
      

      //function to move forward thorugh the image list
      function showNext(){
            lbImages.appendChild(lbImages.firstElementChild);
            (currentImg <  imgCount)? currentImg++ : currentImg =1;
            lbCounter.textContent = currentImg + " / " +imgCount;
      }

      //function to move backwards thorugh the image list
      function showPrev(){
            lbImages.insertBefore(lbImages.lastElementChild, lbImages.firstElementChild);
            (currentImg >  1)? currentImg-- : currentImg =imgCount;
            lbCounter.textContent = currentImg + " / " +imgCount;
      }

      // overlayImage variable scope for addFavorite available
      let overlayImage;
      let counter = 0;

      //function to add an image to favorite section
      function addFavorite(){
            
            if (counter > 4){
                  window.alert("Remove one favorite before adding more to your Favorite list");
                  console.log("counter: "+counter);
            }else{
                  
                  let divFavorites = document.createElement("div");
                  divFavorites.className="divFavorites";

                  let favImage = document.createElement("img");
                  favImage.src = overlayImage.src;
                  favImage.className = "favImg";

                  let check=true;

                  let verification = document.getElementsByClassName("divFavorites");
                  console.log(verification.length);
                  if (verification.length<=1){
                        divFavorites.appendChild(favImage);
                        favSection.appendChild(divFavorites);
                        counter++;
                  } else {
                        for (let i=0; i<(verification.length)-1;i++){
                              if(verification[i+1].firstChild.src == favImage.src){
                                    check =false;
                                    window.alert("Image already in your favorites");
                              }
                        }
                        if (check == true){
                              divFavorites.appendChild(favImage);
                              favSection.appendChild(divFavorites);
                              counter++;
                        }
                        
                  }               
 
                  
                  let removeButton = document.createElement("button");
                  removeButton.type="button";
                  removeButton.className="removeButton";
                  removeButton.textContent = "X"; 
                  //function to remove image from favorites
                  removeButton.onclick = function (){
                        removeButton.parentElement.remove();
                        --counter;
                        console.log("counter: "+counter);
                  };
                  divFavorites.appendChild(removeButton);
                  console.log("counter: "+counter);
            }
      }


      function createOverlay (){
            let overlay = document.createElement("div");
            overlay.id = "lbOverlay";

            //add the figure box to the overlay
            let figureBox = document.createElement("figure");
            overlay.appendChild(figureBox);
            
            //add the image to the figure box
            overlayImage = this.cloneNode("true");
            figureBox.appendChild(overlayImage);

            //add the caption to the figure box
            let overlayCaption = document.createElement("figcaption");
            overlayCaption.textContent = this.alt;
            figureBox.appendChild(overlayCaption);

            //add the button to add image to favorites section
            let favButton = document.createElement("button");
            favButton.type = "button";
            favButton.textContent="Add to favorites";
            favButton.onclick = addFavorite;

            //add the close button to the overlay
            let closeBox = document.createElement("div");
            closeBox.id = "lbOverlayClose";
            closeBox.innerHTML = "&times;";
            closeBox.onclick = function () {
                  document.body.removeChild(overlay);
            }
            overlay.appendChild(closeBox);

            figureBox.appendChild(overlayCaption);

            figureBox.appendChild(favButton);

            document.body.appendChild(overlay);


      }
}