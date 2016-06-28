$(document).ready(function(){
  $(".job-title").click(function(){
    var detailsID="details"+$(this).attr("jobIndex");
    console.log(detailsID);
    $("#"+detailsID).toggle();
  });
});
