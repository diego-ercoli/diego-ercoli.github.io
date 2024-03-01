/*
$(document).ready(function(){
    //$("#nav-placeholder").load("nav.html");
    $.get("nav.html", function(data){
        $("#nav-placeholder").replaceWith(data);
    });
});*/
fetch('nav.html')
.then(res => res.text())
.then(text => {
    let oldelem = document.querySelector("script#replace_with_navbar");
    let newelem = document.createElement("div");
    newelem.innerHTML = text;
    oldelem.parentNode.replaceChild(newelem,oldelem);
})