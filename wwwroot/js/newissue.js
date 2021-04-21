$(document).ready(function () {
  $(".assign_people").hide();
  $(".assignees").click(function () {
    $(".assign_people").toggle();
    $("#assign_search").focus();
    $(".add_labels").hide();
  });

  $(".add_labels").hide();
  $(".labels").click(function () {
    $(".add_labels").toggle();
    $(".search_labels_input").focus();
    $(".assign_people").hide();
  });

  $("#add_file").click(function () {
    $("#attach_file").trigger("click");
  });
});

$(".people_container").on("click", function (event) {

  $.get("assign?id="+$(event.target).attr("identify"), function(data,status){
    // $(".people").append(data);
 
  });
  var colorR = Math.floor((Math.random() * 256));
          var colorG = Math.floor((Math.random() * 256));
          var colorB = Math.floor((Math.random() * 256));
    $("#"+$(event.target).attr("id")).css("border", "2px solid rgb(" + colorR + "," + colorG + "," + colorB + ")");
});
var sign="";
$(".labels_container").on("click", function (event) {

  $.get("assignlabel?id="+$(event.target).attr("identify"), function(data,status){
    $(".labels_container").append(sign+$(event.target).text());
    sign=",";
 
  });
  var colorR = Math.floor((Math.random() * 256));
          var colorG = Math.floor((Math.random() * 256));
          var colorB = Math.floor((Math.random() * 256));
          $("#"+$(event.target).attr("id")).addClass("selected");
    // $("#"+$(event.target).attr("id")).css("color", "2px solid rgb(" + colorR + "," + colorG + "," + colorB + ")");
  });