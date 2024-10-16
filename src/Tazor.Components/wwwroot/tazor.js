window.applyTheme = function () {
    if (localStorage.theme === 'dark' || (!('theme' in localStorage) && window.matchMedia('(prefers-color-scheme: dark)').matches)) {
        document.documentElement.classList.add('dark')
    } else {
        document.documentElement.classList.remove('dark')
    }
}

window.applyCss = function (cssLink) {
    var linkElements = document.head.getElementsByTagName('link');
    
    for (var i = 0; i < linkElements.length; i++) {
        if (linkElements[i].getAttribute("tag") == "tazor-theme") {
            linkElements[i].remove();
        }
    }

    var link = document.createElement('link');
    link.href = cssLink;
    link.rel = 'stylesheet';
    link.setAttribute("tag", "tazor-theme");

    document.head.prepend(link);
}

window.highlight = function (id) {
    const el = document.getElementById(id);
    Prism.highlightElement(el);
}

window.setDarkMode = function (darkMode) {
    localStorage.theme = darkMode ? "dark" : "light";
    applyTheme();
};

window.getDarkMode = function () {
    try {
        return (
            document
                .getElementsByTagName("html")[0]
                .getAttribute("class")
                .indexOf("dark") >= 0
        );
    }
    catch {
        return false;
    }
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
  var sortedKeys = Object.keys(window.breakpoints).sort((a, b) => {
    return window.breakpoints[a] - window.breakpoints[b];
  });

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

window.addClickCheckEvent2 = function (elementId, dotnetHelper) {
    window.addEventListener("click", (e) => {
        // var element = document.getElementById(elementId);
        dotnetHelper.invokeMethodAsync("InvokeClick");
    });
}

window.saveFile = function (file, content) {
    var link = document.createElement('a');
    link.download = file;
    link.href = "data:text/plain;charset=utf-8," + encodeURIComponent(content)

    document.body.appendChild(link);

    link.click();

    document.body.removeChild(link);
} 

window.copyToClipboard = function (text) {
    if (navigator.clipboard) {
        navigator.clipboard.writeText(text);
        return;
    }

    fallbackCopyTextToClipboard(text);
}

function fallbackCopyTextToClipboard(text) {
    var textArea = document.createElement("textarea");
    textArea.value = text;

    // Avoid scrolling to bottom
    textArea.style.top = "0";
    textArea.style.left = "0";
    textArea.style.position = "fixed";

    document.body.appendChild(textArea);
    textArea.focus();
    textArea.select();

    try {
        var successful = document.execCommand('copy');
        var msg = successful ? 'successful' : 'unsuccessful';
        console.log('Fallback: Copying text command was ' + msg);
    } catch (err) {
        console.error('Fallback: Oops, unable to copy', err);
    }

    document.body.removeChild(textArea);
}

window.addEventListener("load", () => {
    window.applyTheme();
})