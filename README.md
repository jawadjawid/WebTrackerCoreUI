# WebTracker

This repo contains the frontend and the controller of the app

A simple tool to track any website and notify you when that website changes.

[![Video](https://webpagetracker.blob.core.windows.net/pics/demothum.png)](https://youtu.be/uO2EfLAHSeg "Demo")

## Technologies used:
- Node.js/JS: Used with Puppeteer to run the the intial website scrapper (Hosted in Azure).
- C#: Used for the timed azure functuon that runs every minute to detect any changes, and the main contoller in the backend.
- MongoDB: Used tos store all website and email data.
- ASP.Net MVC, HTML, CSS, JS: Used to create the frontend of the website.

### Other related repos (Used the Microservice architecture to improve seperation of concerns)
- [The function that does the intial scraping](https://github.com/jawadjawid/trackerAutomation):
This runs when a track request is submitted, it scrapes the website and stores its data in a MongoDB.
- [The Time triggered fucntion](https://github.com/jawadjawid/webTrackerContinuousAzureFunc):
This function runs every minute, does a another scraping on every website in the db, and send a signal when the website content changes. 

### How to run locally:
Unfortunately I have decided to stop running the azure functions on the cloud for cost purposes, but you can still run it locally.
1. Open a terminal or a cmd on your local machine and type the following command:
> I’ve always been more interested
> in the future than in the past.
2. [The Time triggered fucntion](https://github.com/jawadjawid/webTrackerContinuousAzureFunc):
This function runs every minute, does a another scraping on every website in the db, and send a signal when the website content changes.
