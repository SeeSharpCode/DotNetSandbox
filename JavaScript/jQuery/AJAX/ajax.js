$(function() {
  $('#clickme').click(function() {
    $.ajax({
      url: 'http://echo.jsontest.com/key1/value1/key2/value2',
      dataType: 'json',
      success: function(data) {
        var items = [];
        $.each(data, function(key, value) {
          items.push('<li id="' + key + '">' + value + '</li>');
        });

        $('<ul/>', {
          'class': 'interest-list',
          html: items.join('')
        }).appendTo('body');
      },
      statusCode: {
        404: function() {
          alert('There was a problem with the server. Try again soon!');
        }
      }
    });
  });
});
