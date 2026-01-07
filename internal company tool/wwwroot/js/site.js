// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Get the modal
var modal = document.getElementById('id01');

// When the user clicks anywhere outside of the modal, close it
window.onclick = function(event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}

// Slideshow functionality
var slideIndex = 1;

// Initialize slideshow when page loads
document.addEventListener('DOMContentLoaded', function() {
    showDivs(slideIndex);
    
    // Auto slideshow - change slide every 5 seconds
    setInterval(function() {
        plusDivs(1);
    }, 8000);
});

function plusDivs(n) {
    showDivs(slideIndex += n);
}

function currentDiv(n) {
    showDivs(slideIndex = n);
}

function showDivs(n) {
    var i;
    var x = document.getElementsByClassName("mySlides");
    var dots = document.getElementsByClassName("dot");
    
    if (x.length === 0) return; // Exit if no slides found
    
    if (n > x.length) { slideIndex = 1 }
    if (n < 1) { slideIndex = x.length }
    
    for (i = 0; i < x.length; i++) {
        x[i].style.display = "none";
    }
    
    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }
    
    x[slideIndex - 1].style.display = "block";
    dots[slideIndex - 1].className += " active";
}
