function customize(box_name) {
    /*
    $("#" + box_name).css({
        "background-image": "url('assets/img/counters-bg.jpg')",      
    });*/

    $("#" + box_name).css({
        "background-image": "url('assets/img/sfondo_blu.jpeg')"
        //"background-color": "Dodgerblue",     
    });
    /*
    $("#" + box_name).css({
        "color": "white" // Set text color to white
    });*/
    $("#" + box_name).find("h2").css("color", "Goldenrod");
    $("#" + box_name).find(".bi").css("color", "red");
    $("#" + box_name).find(".ico-circle").css("background-color", '#f0f0f0');
    $("#" + box_name).find(".s-description").css("color", 'Lightgrey');
} 


$(document).ready(function () {
    // Check if the URL contains '?data'
    if (window.location.href.indexOf('?web') > -1) {
      // Change the background color of the service-box related to Data Analytics
      customize('web_box');
    }

    if (window.location.href.indexOf('?data') > -1) {
        // Change the background color of the service-box related to Data Analytics
        customize('data_box');
    }

    if (window.location.href.indexOf('?ai') > -1) {
        // Change the background color of the service-box related to Data Analytics
        customize('ai_box');
    }

  });