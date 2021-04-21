
$(document).ready(function(){

    $("#add_file").click(function(){
        $("#attach_file").trigger("click");
    });
    
    $('.all_label_names').children('span').each(function () {
        var colorR = Math.floor((Math.random() * 256));
          var colorG = Math.floor((Math.random() * 256));
          var colorB = Math.floor((Math.random() * 256));
          $(this).css("border-color", "rgb(" + colorR + "," + colorG + "," + colorB + ")");
        
    });
   
    $("#Open").on("click", function (event) { 
       console.log($(this).attr("id")); 


      $.get("changestatus?status=Open", 
          function(data,status){
              console.log(data); 
                $(".second_row").html(data); 
  });
  }); 

     
  });

    