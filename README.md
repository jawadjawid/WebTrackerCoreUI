# WebTracker

This repo contains the frontend and the controller of the app

A simple tool to track any website and notify you when that website changes.

[![Video](https://webpagetracker.blob.core.windows.net/pics/demothum.png)](https://youtu.be/uO2EfLAHSeg "Demo")

## Technologies used:
- Node.js/JS: Used with Puppeteer to run the the initial website scrapper (Hosted in Azure).
- C#: Used for the timed azure function that runs every minute to detect any changes, and the main contoller in the backend.
- MongoDB: Used to store all website and email data.
- ASP.Net MVC, HTML, CSS, JS: Used to create the frontend of the website.
- Originally deployed to a Linux virtual machine in the cloud

### Other related repos (Used the Microservice architecture to implement seperation of concerns):
- [The function that does the intial scraping](https://github.com/jawadjawid/trackerAutomation):
This runs when a track request is submitted, it scrapes the website and stores its data in a MongoDB.
- [The Time triggered fucntion](https://github.com/jawadjawid/webTrackerContinuousAzureFunc):
This function runs every minute, does a another scraping on every website in the db, and sends a signal when the website content changes. 

### How to run locally:
Unfortunately I have decided to stop running the azure functions on the cloud for cost purposes, but you can still run it locally.
1. Clone this repo to your local machine and using a terminal, navigate to "WebTrackerCoreUI/WebTrackerCoreUI" then run:
>  dotnet run
2. Open https://localhost:5001 in your browser and ignore safety concerns (trust me)
3. Clone [The function that does the intial scraping](https://github.com/jawadjawid/trackerAutomation)
4. Navigate to trackerAutomation from another terminal and run:
<blockquote>
    <p>npm install</p>
    <p>npm start</p>
</blockquote>

5. You will need the url you get in the terminal later
6. Clone [The Time triggered fucntion](https://github.com/jawadjawid/webTrackerContinuousAzureFunc)
7. Navigate to webTrackerContinuous\webTrackerContinuous from a third terminal
8. Edit webTrackerContinuous\webTrackerContinuous\Function1.cs in your fav text editor and update:
   - The email sender's email and pass
   - the azure func link from step 5
9. After saving, run the following command in webTrackerContinuous\webTrackerContinuous:
> func start
10. Edit WebTrackerCoreUI\QueueApp\Program.cs in your fav text editor and update:
    - the azure func link from step 5
11. Go back to the https://localhost:5001 tab you opened in step 2, and everything should be working as expected





