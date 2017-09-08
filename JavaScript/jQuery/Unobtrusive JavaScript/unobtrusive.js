$(function() {
  // alert(myApp.version);
  // $('#clickMe').click(function() {
  //   $('#main').append('You should only see this if you click the plus!');
  // });
  $('#main').append("<img src='plus-8.png' alt='Click me to see the paragraph' id='clickMe' />");

  // .toggle has been deprecated
  // $('#clickMe').toggle(function() {
  //   $('#message').show('fast');
  //   $('#clickMe').attr('src', 'minus-8.png');
  // }, function() {
  //   $('#message').hide('slow');
  //   $('#clickMe').attr('src', 'plus-8.png');
  // });

  $('#message').hide();
});

// We don't want this because it pollutes the global namespace.
// var version = "1.2";

var myApp = {};
myApp.version = "1.2";
