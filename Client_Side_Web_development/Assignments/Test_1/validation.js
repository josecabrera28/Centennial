"use strict";
/*Author: Jose Cabrera
Date: 16/02/2023*/

// testing file
console.log("Javascript working for now...");

// billing placeholders
let billingFirstName = document.getElementById("billingFirstName");
billingFirstName.placeholder="First name";
let billingLastName = document.getElementById("billingLastName");
billingLastName.placeholder="Last name";
let billingStreetAddress = document.getElementById("billingStreetAddress");
billingStreetAddress.placeholder="Street Address";
let billingCity = document.getElementById("billingCity");
billingCity.placeholder="City";
let billingState = document.getElementById("billingState");
billingState.placeholder="XX";
let billingZip = document.getElementById("billingZip");
billingZip.placeholder="Zip";
let billingPhone = document.getElementById("billingPhone");
billingPhone.placeholder="Phone";
// delivery placeholders
let deliveryFirstName = document.getElementById("deliveryFirstName");
deliveryFirstName.placeholder="First name";
let deliveryLastName = document.getElementById("deliveryLastName");
deliveryLastName.placeholder="Last name";
let deliveryStreetAddress = document.getElementById("deliveryStreetAddress");
deliveryStreetAddress.placeholder="Street Address";
let deliveryCity = document.getElementById("deliveryCity");
deliveryCity.placeholder="City";
let deliveryState = document.getElementById("deliveryState");
deliveryState.placeholder="XX";
let deliveryZip = document.getElementById("deliveryZip");
deliveryZip.placeholder="Zip";
let deliveryPhone = document.getElementById("deliveryPhone");
deliveryPhone.placeholder="Phone";

//getting the form
let informationForm = document.forms.informationForm;

//getting selectedIndex = -1
informationForm.billingState.selectedIndex = -1;
informationForm.deliveryState.selectedIndex = -1;

//testing selectedIndex value
console.log("Initial billing state index: "+informationForm.elements.deliveryState.selectedIndex);
console.log("Initial delivery state index: "+informationForm.elements.billingState.selectedIndex);

//adding event listener when checking the checkbox to trigger the function copyInfo
let validationButton = document.getElementById("validationButton");

validationButton.addEventListener("change", copyInfo);

//adding event listener when clicking on submit button to trigger the validate function
let submitButton = document.getElementById("submitButton");
submitButton.addEventListener("click",validateBillingFirstName);
submitButton.addEventListener("click",validateBillingLastName);
submitButton.addEventListener("click",validateBillingStreetAddress);
submitButton.addEventListener("click",validateBillingCity);
submitButton.addEventListener("click",validateBillingState);
submitButton.addEventListener("click",validateBillingZip);
submitButton.addEventListener("click",validateBillingPhone);

submitButton.addEventListener("click",validateDeliveryFirstName);
submitButton.addEventListener("click",validateDeliveryLastName);
submitButton.addEventListener("click",validateDeliveryStreetAddress);
submitButton.addEventListener("click",validateDeliveryCity);
submitButton.addEventListener("click",validateDeliveryState);
submitButton.addEventListener("click",validateDeliveryZip);
submitButton.addEventListener("click",validateDeliveryPhone);

//adding event listeners when the user fix validations issues
informationForm.billingFirstName.addEventListener("change",validateBillingFirstName);
informationForm.billingLastName.addEventListener("change",validateBillingLastName);
informationForm.billingStreetAddress.addEventListener("change",validateBillingStreetAddress);
informationForm.billingCity.addEventListener("change",validateBillingCity);
informationForm.billingState.addEventListener("change",validateBillingState);
informationForm.billingZip.addEventListener("change",validateBillingZip);
informationForm.billingPhone.addEventListener("change",validateBillingPhone);

informationForm.deliveryFirstName.addEventListener("change",validateDeliveryFirstName);
informationForm.deliveryLastName.addEventListener("change",validateDeliveryLastName);
informationForm.deliveryStreetAddress.addEventListener("change",validateDeliveryStreetAddress);
informationForm.deliveryCity.addEventListener("change",validateDeliveryCity);
informationForm.deliveryState.addEventListener("change",validateDeliveryState);
informationForm.deliveryZip.addEventListener("change",validateDeliveryZip);
informationForm.deliveryPhone.addEventListener("change",validateDeliveryPhone);

//function copyInfo
function copyInfo (){
    
    //copying information from billing section to delivery section
    if (this.checked){
        deliveryFirstName.value = billingFirstName.value;
        deliveryLastName.value = billingLastName.value;
        deliveryStreetAddress.value = billingStreetAddress.value;
        deliveryCity.value = billingCity.value;
        let indexState =  informationForm.elements.billingState.selectedIndex;
        deliveryState.selectedIndex = indexState;
        deliveryZip.value = billingZip.value;
        deliveryPhone.value = billingPhone.value;
    }else{
        deliveryFirstName.value ="";
        deliveryLastName.value = "";
        deliveryStreetAddress.value = "";
        deliveryCity.value = "";
        deliveryState.selectedIndex = -1;
        deliveryZip.value = "";
        deliveryPhone.value = "";
    }
    //testing new indexes
    console.log("billing state index: "+informationForm.elements.deliveryState.selectedIndex);
    console.log("delivery state index: "+informationForm.elements.billingState.selectedIndex);

}
//Validation functions
function validateBillingFirstName(){
    if(billingFirstName.validity.valueMissing){
      billingFirstName.setCustomValidity("Enter your first name");
    }else{
      billingFirstName.setCustomValidity("");
    }
}

function validateBillingLastName (){
    if(billingLastName.validity.valueMissing){
        billingLastName.setCustomValidity("Enter your Last name");
      }else{
        billingLastName.setCustomValidity("");
      }
}

function validateBillingStreetAddress (){
    if(billingStreetAddress.validity.valueMissing){
        billingStreetAddress.setCustomValidity("Enter your address");
      }else{
        billingStreetAddress.setCustomValidity("");
      }
}

function validateBillingCity (){
    if(billingCity.validity.valueMissing){
        billingCity.setCustomValidity("Enter your City");
      }else{
        billingCity.setCustomValidity("");
      }
}

function validateBillingState (){
    if(billingState.validity.valueMissing){
        billingState.setCustomValidity("Select your State");
      }else{
        billingState.setCustomValidity("");
      }
}

function validateBillingZip (){
    if (billingZip.validity.valueMissing){
        billingZip.setCustomValidity("enter a canadian zip code");
     }else if (!(/^(?!.*[DFIOQU])[A-VXY][0-9][A-Z]●?[0-9][A-Z][0-9]$/.test(billingZip.value))){
        billingZip.setCustomValidity("enter a valid canadian zip code");
     }else{
        billingZip.setCustomValidity("");
     }
}

function validateBillingPhone (){
    if (billingPhone.validity.valueMissing){
        billingPhone.setCustomValidity("enter a phone number");
     }else if (!(/^\d{10}$/.test(billingPhone.value))){
        billingPhone.setCustomValidity("enter a valid phone number");
     }else{
        billingPhone.setCustomValidity("");
     }
}
//

function validateDeliveryFirstName (){
    if(deliveryFirstName.validity.valueMissing){
        deliveryFirstName.setCustomValidity("Enter a First Name for delivery");
      }else{
        deliveryFirstName.setCustomValidity("");
      }
}

function validateDeliveryLastName (){
    if(deliveryLastName.validity.valueMissing){
        deliveryLastName.setCustomValidity("Enter a Last Name for delivery");
      }else{
        deliveryLastName.setCustomValidity("");
      }
}

function validateDeliveryStreetAddress (){
    if(deliveryStreetAddress.validity.valueMissing){
        deliveryStreetAddress.setCustomValidity("Enter your delivery Address");
      }else{
        deliveryStreetAddress.setCustomValidity("");
      }
}

function validateDeliveryCity (){
    if(deliveryCity.validity.valueMissing){
        deliveryCity.setCustomValidity("Enter your delivery City");
      }else{
        deliveryCity.setCustomValidity("");
      }
}

function validateDeliveryState (){
    if(deliveryState.validity.valueMissing){
        deliveryState.setCustomValidity("Select your delivery State");
      }else{
        deliveryState.setCustomValidity("");
      }
}

function validateDeliveryZip (){
    if (deliveryZip.validity.valueMissing){
        deliveryZip.setCustomValidity("enter a delivery canadian zip code");
     }else if (!(/^(?!.*[DFIOQU])[A-VXY][0-9][A-Z]●?[0-9][A-Z][0-9]$/.test(deliveryZip.value))){
        deliveryZip.setCustomValidity("enter a valid canadian zip code");
     }else{
        deliveryZip.setCustomValidity("");
     }
}

function validateDeliveryPhone (){
    if (deliveryPhone.validity.valueMissing){
        deliveryPhone.setCustomValidity("enter a delivery phone number");
     }else if (!(/^\d{10}$/.test(deliveryPhone.value))){
        deliveryPhone.setCustomValidity("enter a delivery phone number");
     }else{
        deliveryPhone.setCustomValidity("");
        window.alert("Thank you for filling the form!")
     }
}