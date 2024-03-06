import { cssBundleHref } from "@remix-run/css-bundle";
import type { LinksFunction } from "@remix-run/node";
import {
  Links,
  Meta,
  Outlet,
  Scripts,
  ScrollRestoration,
} from "@remix-run/react";
import { useSWEffect, LiveReload } from "@remix-pwa/sw";

import TWStyles from "~/tailwind.css";
import AppStyles from "~/app.css";

export const links: LinksFunction = () => [
  ...(cssBundleHref ? [{ rel: "stylesheet", href: cssBundleHref }] : []),
  { rel: "stylesheet", href: TWStyles },
  { rel: "stylesheet", href: AppStyles },
];

export default function App() {
  useSWEffect();
  return (
    <html lang="en" className="h-100 w-100">
      <head>
        <meta charSet="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <Meta />
        <link rel="manifest" href="/manifest.webmanifest" />
        <Links />
      </head>
      <body className="h-100 w-100">
        <Outlet />
        <ScrollRestoration />
        <Scripts />
        <LiveReload />
      </body>
    </html>
  );
}
