$(function() {
  $('#success').hide();
  $('#startover').addClass('hoverOut');
  var score = 0;

  $('#bobhead').click(function() {
    score++;
    $('#score').text(score);
    $('#success').show('slow').fadeOut(2000);
  });

  // $('#startover').hover(hoverIn, hoverOut);
  //
  // function hoverIn() {
  //   score = 0;
  //   $('#score').text(score);
  //   $('#startover').addClass('hoverIn').remove('hoverOut');
  // }
  //
  // function hoverOut() {
  //   $('#startover').removeClass('hoverIn').addClass('hoverOut');
  // }

  $('#startover').click(function() {
    score = 0;
    $('#score').text(score);
    $('#startover').addClass('hoverIn').remove('hoverOut');
  });
});
