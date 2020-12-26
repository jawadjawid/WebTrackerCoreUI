# WebTracker

A simple tool to track any website and notify you when that website changes.

A very quick demo:
[![Video](https://webpagetracker.blob.core.windows.net/pics/demothum.png)](https://youtu.be/uO2EfLAHSeg "Demo")

## Technologies used:
- Node.js: Used with Puppeteer to run the the intial website scrapper (Hosted in Azure).
- C#: Used for the timed azure functuon that runs every minute to detect any changes
- MongoDB: Used tos tore all website and email data.
- ASP.Net MVC: Used to create the frontend of the website.
