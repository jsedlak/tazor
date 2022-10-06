window.setDarkMode = function (darkMode) {
  var htmlElement = document.getElementsByTagName("html")[0];
  var htmlClass = htmlElement.getAttribute("class");

  if (htmlClass) {
    htmlClass = htmlClass.replace("dark", "");
  }

  if (darkMode) {
    htmlElement.setAttribute("class", htmlClass + " dark");
  } else {
    htmlElement.setAttribute("class", htmlClass);
  }
};

window.getDarkMode = function () {
  return (
    document
      .getElementsByTagName("html")[0]
      .getAttribute("class")
      .indexOf("dark") >= 0
  );
};

window.addOnlineStatusListener = function (dotNetRef) {
  function updateDotNet() {
    dotNetRef.invokeMethodAsync("UpdateStatus", navigator.onLine);
  }

  window.addEventListener("online", updateDotNet);
  window.addEventListener("offline", updateDotNet);

  updateDotNet();
};

window.breakpoints = {
  sm: 640,
  md: 768,
  lg: 1024,
  xl: 1280,
  "2xl": 1536,
};

window.getBreakpoint = function () {
  var bp;

  var sortedKeys = Object.keys(window.breakpoints).sort((a, b) => {
    return window.breakpoints[a] - window.breakpoints[b];
  });

  console.log({ sortedKeys });

  for (var index = sortedKeys.length - 1; index >= 0; index--) {
    var key = sortedKeys[index];
    if (window.innerWidth > window.breakpoints[key]) {
      return sortedKeys[Math.min(index + 1, sortedKeys.length - 1)];
    }
  }

  return sortedKeys[0];
};

window.breakpoint = null;

window.addResizeListener = function (dotNetRef) {
  const updateDotNet = () => {
    var newBp = window.getBreakpoint();
    if (!window.breakpoint || newBp != window.breakpoint) {
      window.breakpoint = newBp;
      dotNetRef.invokeMethodAsync("BreakpointReached", {
        width: window.innerWidth,
        height: window.innerHeight,
        breakpoint: newBp,
      });
    }
  };

  window.addEventListener("resize", updateDotNet);

  updateDotNet();
};

window.addClickCheckEvent = function (elementId, dotnetHelper) {
    window.addEventListener("click", (e) => {
        var element = document.getElementById(elementId);

        if (!element || !element.contains(e.target)) {
            dotnetHelper.invokeMethodAsync("InvokeClickOutside");
        }
    });
}
