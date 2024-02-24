const CacheName = "RME-v1";
const SourcesUrl = [
  "/index.html",
  "/Data/Css/styles.css",
  "/Data/Scripts/app.js",
];

// Cache all nessesary resources
self.addEventListener("install", async (event) => {
  const cache = await caches.open(CacheName);
  await cache.addAll(SourcesUrl);
});

// Clear not used cached recources
self.addEventListener("activate", async (event) => {
  const cacheNames = await caches.keys();
  await Promise.all(
    cacheNames
      .filter((name) => name != CacheName)
      .map((name) => caches.delete(name))
  );
});

// Loading a resources from the cache (if they are in cache) or from network
self.addEventListener("fetch", async (event) => {
  const isCached = await caches.match(event.request);
  return isCached ?? (await fetch(event.request));
});
