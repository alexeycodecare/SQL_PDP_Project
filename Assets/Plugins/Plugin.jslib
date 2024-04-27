mergeInto(LibraryManager.library, {
  JS_Died: function () {
    var container = document.querySelector(".container");
    container.style.backgroundColor = "red";
  },

  JS_Restart: function () {
    var container = document.querySelector(".container");
    container.style.backgroundColor = "transparent";
  },

  JS_GetUsers: function () {
    GetUsers();
  },

  JS_SaveUser: function (str, score) {
    SaveUsers(UTF8ToString(str), score);
  },
});
