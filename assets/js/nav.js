/*
(document).load(function(){
  $("#header").attr("class", "fixed-top header-scrolled");
});*/

$(document).ready(function() {
  // Set a timeout of 3 seconds
  setTimeout(function() {
    // Execute the desired jQuery code after 3 seconds
    $("#header").attr("class", "fixed-top header-scrolled");
  }, 1);
});




/*
$(document).ready(function(){
    $("#nav-placeholder").load("nav.html");
    $.get("nav.html", function(data){
        $("#nav-placeholder").replaceWith(data);
    });
});
$(function(){
  $("#nav-placeholder").load("nav.html");
});
*/
/*
fetch('nav.html')
.then(res => res.text())
.then(text => {
    let oldelem = document.querySelector("script#replace_with_navbar");
    let newelem = document.createElement("div");
    newelem.innerHTML = text;
    oldelem.parentNode.replaceChild(newelem,oldelem);
})*/