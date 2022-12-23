mergeInto(LibraryManager.library, {
  JS_Died: function () {
    var container = document.querySelector(".container");
    container.style.backgroundColor = "red";
  },

  JS_Restart: function () {
    var container = document.querySelector(".container");
    container.style.backgroundColor = "transparent";
  },
});
