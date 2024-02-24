window.addEventListener("load", async () => {
  if (navigator.serviceWorker) {
    await navigator.serviceWorker.register("/Data/Scripts/sw.js");
  }
});
