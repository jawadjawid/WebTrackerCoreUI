# WebTracker

This repo contains the frontend and the controller of the app

A simple tool to track any website and notify you when that website changes.

[![Video](https://webpagetracker.blob.core.windows.net/pics/demothum.png)](https://youtu.be/uO2EfLAHSeg "Demo")

## Technologies used:
- Node.js/JS: Used with Puppeteer to run the the intial website scrapper (Hosted in Azure).
- C#: Used for the timed azure functuon that runs every minute to detect any changes, and the main contoller in the backend.
- MongoDB: Used tos tore all website and email data.
- ASP.Net MVC, HTML, CSS, JS: Used to create the frontend of the website.

### Other related repos:
- [The function that does the intial scraping](https://github.com/jawadjawid/trackerAutomation)
- [The Time triggered fucntion](Link URL)
