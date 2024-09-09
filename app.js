const fullscreen = document.getElementById("btn");
fullscreen.addEventListener("click", () => {
  if (!document.fullscreenElement) {
    document.documentElement.requestFullscreen();
    fullscreen.textContent = "Exit Fullscreen";
  } else if (document.exitFullscreen) {
    document.exitFullscreen();
    fullscreen.textContent = "Enter Fullscreen";
  }
});
