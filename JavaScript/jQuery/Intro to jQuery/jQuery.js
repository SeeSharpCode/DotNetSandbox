$(function() {
  // # selects by ID.
  $("#title").text("Yay, I can now get at the H1 immediately!");

  // $("#first").html("<h2>Great quotes</h2>");

  // Append and prepend work INSIDE the given selection.
  // Before, after, insertBefore, insertAfter work OUTSIDE the given selection.
  $("#first").prepend("<h2>Great quotes</h2>");
  $("#first").append("<h3>... for you to ponder...</h3>");

  $("#myAnchor").attr("href", "http://channel9.msdn.com");

  $("#title").addClass("standout");
});
