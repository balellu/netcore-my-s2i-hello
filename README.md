# Hello-World
A 'Hello World' sample of REST API, created using ASP .NET Core Web API. This app is modified so that it can use OpenShift's S2I build.


## How to run this sample

* Note that there is a folder .s2i/environment added to the root of the project. It will be used by OpenShift S2I builds to build this project
* In OpenShift Images catalog choose .Net Core Image and then in the Git Repo section point to this code repository location
* OpneShift S2I will build the `/bin/Release/netcoreapp1.1/API.dll` and then required .Net Core container image and it will start the POD
* Once POD starts go to http://YourOpenShiftGenerateRouteName/api/hello to invoke the GET method on this API, then you should see `Hello ASP .NET Core - Web API` on the browser. Alternatively `curl -v http://YourOpenShiftGenerateRouteName/api/hello` can also be used from the command line
